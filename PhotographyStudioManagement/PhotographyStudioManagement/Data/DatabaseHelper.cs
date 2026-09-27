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

            string createServiceTable = @"
                CREATE TABLE IF NOT EXISTS Services
                (
                    ServiceID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ServiceName TEXT NOT NULL UNIQUE,
                    ServiceType TEXT NOT NULL,
                    BasePrice REAL NOT NULL,
                    EditingFee REAL DEFAULT 0
                );";

            string createBookingTable = @"
                CREATE TABLE IF NOT EXISTS Bookings
                (
                    BookingID INTEGER PRIMARY KEY AUTOINCREMENT,

                    ClientID INTEGER NOT NULL,
                    ServiceID INTEGER NOT NULL,

                    BookingDate TEXT NOT NULL,
                    Location TEXT NOT NULL,

                    Hours INTEGER NOT NULL,
                    Price REAL NOT NULL,

                    BookingStatus TEXT NOT NULL,
                    PaymentStatus TEXT NOT NULL,

                    AmountPaid REAL NOT NULL DEFAULT 0,
                    Notes TEXT,

                    FOREIGN KEY(ClientID)
                        REFERENCES Clients(ClientID),

                    FOREIGN KEY(ServiceID)
                        REFERENCES Services(ServiceID)
                );";

            using SqliteCommand clientCommand =
                new SqliteCommand(createClientTable, connection);

            clientCommand.ExecuteNonQuery();

            using SqliteCommand serviceCommand =
                new SqliteCommand(createServiceTable, connection);

            serviceCommand.ExecuteNonQuery();

            using SqliteCommand bookingCommand =
                new SqliteCommand(createBookingTable, connection);

            bookingCommand.ExecuteNonQuery();

            SeedServices(connection);
        }

        private static void SeedServices(SqliteConnection connection)
        {
            string sql = @"
                INSERT OR IGNORE INTO Services
                (ServiceName, ServiceType, BasePrice, EditingFee)
                VALUES
                ('Portrait Photography', 'Photography', 150, 0),

                ('Event Photography', 'Photography', 200, 0),

                ('Wedding Photography', 'Photography', 250, 0),

                ('Event Videography', 'Videography', 220, 100),

                ('Wedding Videography', 'Videography', 300, 150);";

            using SqliteCommand command =
                new SqliteCommand(sql, connection);

            command.ExecuteNonQuery();
        }
    }
}