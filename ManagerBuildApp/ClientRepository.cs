using System;
using System.Data;
using System.Data.SqlClient;

namespace ManagerBuildApp.DAL
{
    public class ClientRepository
    {
        // Строка подключения (считайте, что она хранится в конфигурационном файле)
        private readonly string connectionString = "Data Source=.;Initial Catalog=ManagerBuildApp;Integrated Security=True;";

        /// <summary>
        /// Чтение всех клиентов из БД.
        /// </summary>
        public DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClientId, Name, Phone, Company FROM Clients";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки или её проброс
                throw new Exception("Ошибка при получении списка клиентов: " + ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Добавление нового клиента в БД.
        /// Возвращает сгенерированный идентификатор нового клиента.
        /// </summary>
        public int InsertClient(string name, string phone, string company)
        {
            int newId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Clients (Name, Phone, Company) 
                                     VALUES (@Name, @Phone, @Company);
                                     SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Company", company);
                        conn.Open();
                        newId = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении клиента: " + ex.Message);
            }
            return newId;
        }

        /// <summary>
        /// Обновление существующего клиента.
        /// Возвращает количество затронутых строк.
        /// </summary>
        public int UpdateClient(int clientId, string name, string phone, string company)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Clients 
                                     SET Name = @Name, Phone = @Phone, Company = @Company 
                                     WHERE ClientId = @ClientId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Company", company);
                        cmd.Parameters.AddWithValue("@ClientId", clientId);
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обновлении клиента: " + ex.Message);
            }
            return rowsAffected;
        }

        /// <summary>
        /// Удаление клиента из БД.
        /// Возвращает количество затронутых строк.
        /// </summary>
        public int DeleteClient(int clientId)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Clients WHERE ClientId = @ClientId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClientId", clientId);
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении клиента: " + ex.Message);
            }
            return rowsAffected;
        }
    }
}
