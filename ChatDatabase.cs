using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace EuroExplorer.Models
{
    public class ChatDatabase
    {
        private readonly string connectionString;

        // Konstruktor umożliwiający wstrzykiwanie zależności
        public ChatDatabase(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        // Inicjalizacja bazy danych
        public static void InitializeDatabase(string connectionString)
        {
            string createTableQuery = @"
        CREATE TABLE IF NOT EXISTS Messages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Username TEXT NOT NULL,
            AvatarPath TEXT,
            Message TEXT NOT NULL,
            Timestamp DATETIME NOT NULL
        )";

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Baza danych została zainicjowana pomyślnie.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas inicjalizacji bazy danych: {ex.Message}");
            }
        }

        // Sprawdzanie, czy baza danych istnieje
        public void EnsureDatabaseExists()
        {
            string dbPath = @"C:\Users\rafal\source\repos\EuroExplorer\App_Data\chat.db"; // Zaktualizowana ścieżka
            string directoryPath = Path.GetDirectoryName(dbPath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);  // Tworzenie katalogu, jeśli nie istnieje
                Console.WriteLine("Utworzono folder dla bazy danych.");
            }

            if (!File.Exists(dbPath))  // Sprawdzanie, czy plik istnieje
            {
                Console.WriteLine("Baza danych nie istnieje, tworzę nową...");
                InitializeDatabase($"Data Source={dbPath};Version=3;");  // Przekazywanie pełnej ścieżki
            }
            else
            {
                Console.WriteLine("Baza danych istnieje.");
            }
        }

        // Dodanie wiadomości do bazy danych
        public void AddMessage(string username, string avatarPath, string message)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Połączono z bazą danych.");

                    string insertQuery = @"
                        INSERT INTO Messages (Username, AvatarPath, Message, Timestamp)
                        VALUES (@Username, @AvatarPath, @Message, @Timestamp)";
                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@AvatarPath", avatarPath);
                        command.Parameters.AddWithValue("@Message", message);
                        command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Wiadomość została dodana do bazy danych.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas dodawania wiadomości: {ex.Message}");
            }
        }

        // Pobieranie wiadomości z bazy danych
        public List<(string Username, string AvatarPath, string Message, DateTime Timestamp)> GetMessages()
        {
            var messages = new List<(string Username, string AvatarPath, string Message, DateTime Timestamp)>();

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Połączono z bazą danych.");

                    string selectQuery = "SELECT Username, AvatarPath, Message, Timestamp FROM Messages";
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            messages.Add((
                                reader.GetString(0),  // Username
                                reader.GetString(1),  // AvatarPath
                                reader.GetString(2),  // Message
                                reader.GetDateTime(3) // Timestamp
                            ));
                        }
                    }
                    Console.WriteLine("Pobrano wiadomości z bazy danych.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas pobierania wiadomości: {ex.Message}");
            }

            return messages;
        }
    }
}
