using EuroExplorer;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

public static class ChatDatabase
{
    private static string connectionString = "Data Source=chat.db;Version=3;";

    // Inicjalizacja bazy danych i tworzenie tabeli, jeśli nie istnieje
    public static void InitializeDatabase()
    {
        string createTableQuery = @"
    CREATE TABLE IF NOT EXISTS Messages (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Username TEXT NOT NULL,
        AvatarPath TEXT,
        Message TEXT NOT NULL,
        Timestamp DATETIME NOT NULL
    )";

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                Console.WriteLine("Sprawdzanie istnienia tabeli Messages...");
                command.ExecuteNonQuery();
                Console.WriteLine("Tabela Messages została utworzona lub już istnieje.");
            }
        }
    }


    public static void EnsureDatabaseExists()
    {
        string dbPath = "chat.db";
        Console.WriteLine($"Sprawdzam istnienie bazy danych: {dbPath}");
        if (!File.Exists(dbPath))
        {
            Console.WriteLine("Baza danych nie istnieje. Tworzenie nowej bazy...");
            InitializeDatabase();
        }
        else
        {
            Console.WriteLine("Baza danych istnieje.");
        }
    }

    // Metoda do dodawania wiadomości do bazy danych
    public static void AddMessage(string username, string avatarPath, string message)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertQuery = @"
            INSERT INTO Messages (Username, AvatarPath, Message)
            VALUES (@Username, @AvatarPath, @Message)";
            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@AvatarPath", avatarPath);
                command.Parameters.AddWithValue("@Message", message);
                command.ExecuteNonQuery();
            }
        }
    }


    // Metoda do pobierania wiadomości z bazy danych
    public static List<(string Username, string AvatarPath, string Message, DateTime Timestamp)> GetMessages()
    {
        var messages = new List<(string Username, string AvatarPath, string Message, DateTime Timestamp)>();
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT Username, AvatarPath, Message, Timestamp FROM Messages";
            using (var command = new SQLiteCommand(selectQuery, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    messages.Add((
                        reader.GetString(0),      // Username
                        reader.GetString(1),      // AvatarPath
                        reader.GetString(2),      // Message
                        reader.GetDateTime(3)     // Timestamp
                    ));
                }
            }
        }
        return messages;
    }


    // Nowa metoda do zapisania wiadomości
}
