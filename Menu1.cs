using System;
using System.Windows.Forms;

namespace EuroExplorer
{
    public partial class Menu1 : Form
    {
        private Models.User loggedInUser;

        public Menu1(Models.User loggedInUser)
        {
            if (loggedInUser == null)
                throw new ArgumentNullException(nameof(loggedInUser), "Zalogowany użytkownik nie może być null");

            InitializeComponent();
            this.loggedInUser = loggedInUser;

            // Powiąż metodę Send_Click z wydarzeniem kliknięcia przycisku "Wyślij"
            Send.Click += new EventHandler(Send_Click);

            // Powiąż metodę MessageTextBox_KeyDown z wydarzeniem KeyDown pola tekstowego
            Message.KeyDown += new KeyEventHandler(MessageTextBox_KeyDown);
        }

        private void ListaPanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Możesz dodać rysowanie na panelu, jeśli jest potrzebne
        }

        private void ListaPanstw_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na przycisk Lista Państw
        }

        private void Map_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na przycisk Mapa
        }

        private void Czat_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na przycisk Czat
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na webView21, jeśli to potrzebne
        }

        private void Chat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obsługa zmiany wybranego elementu w Chat
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (loggedInUser == null)
            {
                MessageBox.Show("Błąd: użytkownik nie jest zalogowany.");
                return;
            }

            string message = Message.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                string formattedMessage = $"{loggedInUser.Username}: {message}";
                Chat.Items.Add(formattedMessage);
                Message.Clear();
            }
        }

        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_Click(sender, e);
                e.SuppressKeyPress = true; // Zapobiega dodaniu nowej linii w TextBox po naciśnięciu Enter
            }
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            // Obsługa zmiany tekstu w Message, jeśli to potrzebne
        }
    }
}
