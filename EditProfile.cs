// EditProfile.cs - Funkcjonalność zgodnie z wymaganiami
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EuroExplorer.Models;
using Newtonsoft.Json;

namespace EuroExplorer
{
    public partial class EditProfile : Form
    {
        private User currentUser;
        private List<User> users;

        public EditProfile(User loggedInUser)
        {
            InitializeComponent();
            currentUser = loggedInUser;
            users = UserUtils.LoadUsers();
            InitializeFields();
        }

        private void InitializeFields()
        {
            OldName.Text = currentUser.Username;
            ProfilePicture.Image = LoadProfilePicture(currentUser.ProfilePicturePath);
        }

        private Image LoadProfilePicture(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return null;

            return Image.FromFile(filePath);
        }

        private void OldName_TextChanged(object sender, EventArgs e)
        {
            OldName.Text = currentUser.Username;
        }

        private void NewName_TextChanged(object sender, EventArgs e)
        {
            // Użytkownik może wpisać nową nazwę użytkownika
        }

        private void OldPassword_TextChanged(object sender, EventArgs e)
        {
            var users = UserUtils.LoadUsers();
            var currentUser = users.FirstOrDefault(user => user.Username == OldName.Text);

            if (currentUser != null)
            {
                // Symuluje długość hasła przed jego hashowaniem
                OldPassword.Text = new string('*', 12); // Domyślna długość hasła
            }
            else
            {
                OldPassword.Text = ""; // Pole puste, jeśli użytkownik nie istnieje
            }
        }


        private void NewPassword_TextChanged(object sender, EventArgs e)
        {
            // Użytkownik może wpisać nowe hasło
        }

        private void ChangeLogin_Click(object sender, EventArgs e)
        {
            string newUsername = NewName.Text.Trim();
            string newPassword = NewPassword.Text;

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Nazwa użytkownika i hasło nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newUsername == currentUser.Username && UserUtils.VerifyPassword(newPassword, currentUser.Password, currentUser.Salt))
            {
                MessageBox.Show("Brak możliwości zapisu: dane są identyczne.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aktualizacja nazwy użytkownika
            if (newUsername != currentUser.Username)
            {
                if (users.Any(user => user.Username == newUsername && user.Id != currentUser.Id))
                {
                    MessageBox.Show("Nazwa użytkownika jest już zajęta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                currentUser.Username = newUsername;
            }

            // Aktualizacja hasła
            if (!UserUtils.VerifyPassword(newPassword, currentUser.Password, currentUser.Salt))
            {
                currentUser.Password = UserUtils.HashPasswordWithSalt(newPassword, out string newSalt);
                currentUser.Salt = newSalt;
            }

            SaveChanges();
            MessageBox.Show("Dane zostały zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Wylogowanie użytkownika i przejście do okna logowania
            LogOutAndReturnToLogin();
        }

        private void LogOutAndReturnToLogin()
        {
            // Wylogowanie: czyszczenie danych użytkownika
            currentUser = null;

            // Ukrycie bieżącego okna
            this.Hide();

            // Otworzenie okna logowania
            var login = new Login();
            login.Show();

            // Zamknięcie bieżącego okna (jeśli chcesz, aby aplikacja zakończyła działanie po logowaniu)
            this.Close();
        }


        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            if (ProfilePicture.Image != null)
            {
                // Ustawienie rozmiaru obrazu na dopasowanie do rozmiaru PictureBox
                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;

                // Wyświetlenie informacji o zdjęciu profilowym
                MessageBox.Show("Aktualne zdjęcie profilowe wybrane.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Brak zdjęcia profilowego.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Wybierz zdjęcie profilowe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ProfilePicture.Image = Image.FromFile(filePath);
                    currentUser.ProfilePicturePath = SaveProfilePicture(filePath);
                }
            }
        }

        private string SaveProfilePicture(string sourcePath)
        {
            string profilePicturesDir = "C:\\Users\\rafal\\source\\repos\\projektObiektowe13\\ProfilePictures";
            if (!Directory.Exists(profilePicturesDir))
                Directory.CreateDirectory(profilePicturesDir);

            string destPath = Path.Combine(profilePicturesDir, $"user_{currentUser.Id}.jpg");
            File.Copy(sourcePath, destPath, true);

            return destPath;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveChanges();
            MessageBox.Show("Zdjęcie profilowe zostało zapisane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveChanges()
        {
            User userToUpdate = users.FirstOrDefault(user => user.Id == currentUser.Id);
            if (userToUpdate != null)
            {
                userToUpdate.Username = currentUser.Username;
                userToUpdate.Password = currentUser.Password;
                userToUpdate.Salt = currentUser.Salt;
                userToUpdate.ProfilePicturePath = currentUser.ProfilePicturePath;
            }

            UserUtils.SaveUsers(users);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                var menu1Form = new Menu1(currentUser);

                menu1Form.Show();
            }
            else
            {
                MessageBox.Show("Brak zalogowanego użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

    }
}
