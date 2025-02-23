using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerBuildApp
{
    internal class ContractorRepository
    {
        // Строка подключения (считайте, что она хранится в конфигурационном файле)
        private readonly string connectionString = "Data Source=.;Initial Catalog=ManagerBuildApp;Integrated Security=True;";

        /// <summary>
        /// Чтение всех клиентов из БД.
        /// </summary>
        public DataTable GetAllContractors()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT ContractorId, Name, Specialty, Phone FROM Contractors";
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
                throw new Exception("Ошибка при получении списка подрядчиков: " + ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Добавление нового клиента в БД.
        /// Возвращает сгенерированный идентификатор нового клиента.
        /// </summary>
        public int InsertContractor(string name, string specialty, string phone)
        {
            int newId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Contractors (Name, Specialty, Phone) 
                                     VALUES (@Name, @Specialty, @Phone);
                                     SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Specialty", specialty);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        conn.Open();
                        newId = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении подрядчика: " + ex.Message);
            }
            return newId;
        }

        /// <summary>
        /// Обновление существующего клиента.
        /// Возвращает количество затронутых строк.
        /// </summary>
        public int UpdateContractor(int contractorId, string name, string specialty, string phone)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Contractors 
                                     SET Name = @Name, Specialty = @Specialty, Phone = @Phone
                                     WHERE ContractorId = @ContractorId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", specialty);
                        cmd.Parameters.AddWithValue("@Company", phone);
                        cmd.Parameters.AddWithValue("@ContractorId", contractorId);
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обновлении подрядчика: " + ex.Message);
            }
            return rowsAffected;
        }

        /// <summary>
        /// Удаление клиента из БД.
        /// Возвращает количество затронутых строк.
        /// </summary>
        public int DeleteClient(int ContractorId)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Clients WHERE ContractorId = @ContractorId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ContractorId", ContractorId);
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении подрядчика: " + ex.Message);
            }
            return rowsAffected;
        }
    }
}
