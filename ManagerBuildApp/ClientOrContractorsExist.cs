using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ManagerBuildApp.BLL
{
    /// <summary>
    /// Класс для проверки наличия дублирующих записей клиентов и подрядчиков в базе данных.
    /// </summary>
    public static class ClientOrContractorExist
    {
        /// <summary>
        /// Проверяет, существует ли клиент с заданными параметрами.
        /// </summary>
        /// <param name="name">Имя клиента.</param>
        /// <param name="phone">Телефон клиента.</param>
        /// <param name="company">Название компании клиента.</param>
        /// <param name="excludeId">Опционально: идентификатор клиента, который нужно исключить из проверки (например, при обновлении записи).</param>
        /// <returns>Возвращает true, если клиент с такими данными уже существует, иначе false.</returns>
        public static bool ClientExists(string name, string phone, string company, int? excludeId = null)
        {
            // Формируем запрос с использованием параметров
            string query = "SELECT COUNT(*) FROM [Clients] WHERE [Name] = @Name AND [Phone] = @Phone AND [Company] = @Company";
            if (excludeId.HasValue)
            {
                query += " AND [ClientId] <> @ClientId";
            }

            int count = 0;
            // Получаем строку подключения из файла конфигурации
            string connectionString = ConfigurationManager.ConnectionStrings["ManagerBuildApp"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Добавляем параметры
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Company", company);
                    if (excludeId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ClientId", excludeId.Value);
                    }
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count > 0;
        }

        /// <summary>
        /// Проверяет, существует ли подрядчик с заданными параметрами.
        /// </summary>
        /// <param name="name">Имя подрядчика.</param>
        /// <param name="specialty">Специализация подрядчика.</param>
        /// <param name="phone">Телефон подрядчика.</param>
        /// <param name="excludeId">Опционально: идентификатор подрядчика, который нужно исключить из проверки (например, при обновлении записи).</param>
        /// <returns>Возвращает true, если подрядчик с такими данными уже существует, иначе false.</returns>
        public static bool ContractorExists(string name, string specialty, string phone, int? excludeId = null)
        {
            string query = "SELECT COUNT(*) FROM [Contractors] WHERE [Name] = @Name AND [Specialty] = @Specialty AND [Phone] = @Phone";
            if (excludeId.HasValue)
            {
                query += " AND [ContractorId] <> @ContractorId";
            }

            int count = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["ManagerBuildApp"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Specialty", specialty);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    if (excludeId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ContractorId", excludeId.Value);
                    }
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count > 0;
        }
    }
}
