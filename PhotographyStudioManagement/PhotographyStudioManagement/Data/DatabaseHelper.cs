using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.Sqlite;

namespace PhotographyStudioManagement.Data
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            "Data Source=photography.db";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using SqliteConnection connection = GetConnection();

            connection.Open();

            string createClientTable = @"
                CREATE TABLE IF NOT EXISTS Clients
                (
                    ClientID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Phone TEXT NOT NULL,
                    Email TEXT
                );";

            using SqliteCommand command =
                new SqliteCommand(createClientTable, connection);

            command.ExecuteNonQuery();
        }
    }
}