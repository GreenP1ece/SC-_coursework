using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ManagerBuildApp.DAL
{
    public static class DatabaseInitializer
    {
        // Путь к файлу базы данных
        private static readonly string DbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ManagerBuildApp.sqlite");

        // Строка подключения для SQLite (используем System.Data.SQLite)
        private static readonly string connectionString = $"Data Source={DbFilePath};Version=3;";

        /// <summary>
        /// Проверяет, существует ли файл базы данных. Если нет, создаёт базу, таблицы и вставляет стартовые записи.
        /// </summary>
        public static void InitializeDatabase()
        {
            if (!File.Exists(DbFilePath))
            {
                MessageBox.Show("Создаем базу данных");
                // Создаем файл базы данных
                SQLiteConnection.CreateFile(DbFilePath);
                Console.WriteLine("Файл базы данных создан.");

                // Выполняем скрипт создания таблиц и вставки данных
                CreateTablesAndInsertData();
            }
            else
            {
                Console.WriteLine("Файл базы данных уже существует.");
            }
        }

        /// <summary>
        /// Выполняет SQL-скрипт для создания таблиц и вставки стартовых записей.
        /// </summary>
        private static void CreateTablesAndInsertData()
        {
            // Скрипт создания таблиц и вставки стартовых данных.
            // Обратите внимание, что для телефонных номеров используется формат 10 цифр (XXXXXXXXXX).
            string script = @"
                -- Создание таблицы Users
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );

                -- Создание таблицы Clients
                CREATE TABLE IF NOT EXISTS Clients (
                    ClientId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Phone TEXT,
                    Company TEXT
                );

                -- Создание таблицы Contractors
                CREATE TABLE IF NOT EXISTS Contractors (
                    ContractorId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Specialty TEXT,
                    Phone TEXT
                );

                -- Создание таблицы Projects
                CREATE TABLE IF NOT EXISTS Projects (
                    ProjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    Deadline DATETIME NOT NULL,
                    ManagerId INTEGER NOT NULL,
                    ClientId INTEGER NOT NULL,
                    ContractorId INTEGER NOT NULL,
                    FOREIGN KEY (ManagerId) REFERENCES Users(UserId),
                    FOREIGN KEY (ClientId) REFERENCES Clients(ClientId),
                    FOREIGN KEY (ContractorId) REFERENCES Contractors(ContractorId)
                );

                -- Вставка стартовых записей в Users
                INSERT INTO Users (Username, Password, Role) VALUES 
                    ('admin', 'admin123', 'Administrator'),
                    ('manager1', 'manager123', 'Manager'),
                    ('manager2', 'manager123', 'Manager');

                -- Вставка стартовых записей в Clients
                INSERT INTO Clients (Name, Phone, Company) VALUES 
                    ('ООО СтройИнвест', '4951112233', 'СтройИнвест'),
                    ('ИП Петров', '9262223344', 'Петров ИП'),
                    ('ЗАО ГородСтрой', '4953334455', 'ГородСтрой');

                -- Вставка стартовых записей в Contractors
                INSERT INTO Contractors (Name, Specialty, Phone) VALUES 
                    ('ООО СтройМонтаж', 'Монтаж', '4951110011'),
                    ('ООО ИнжПроект', 'Инженерные сети', '4952220022'),
                    ('ИП Тарасов', 'Отделка', '9263330033');

                -- Вставка стартовой записи в Projects (например, связываем с первым менеджером, клиентом и подрядчиком)
                INSERT INTO Projects (Name, Status, Deadline, ManagerId, ClientId, ContractorId)
                VALUES ('Жилой комплекс Солнечный', 'Active', '2025-12-31', 2, 1, 1);
            ";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(script, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Таблицы созданы, а стартовые записи вставлены.");
        }
    }
}
