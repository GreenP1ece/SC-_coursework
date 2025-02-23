using System;
using System.Data;
using System.Data.SqlClient;

namespace ManagerBuildApp
{
    public class ProjectRepository
    {
        private readonly string connectionString = @"Data Source=.;Initial Catalog=ManagerBuildApp;Integrated Security=True;";

        /// <summary>
        /// Создание (INSERT) нового проекта.
        /// </summary>
        public void InsertProject(string name, string status, DateTime deadline, int managerId, int clientId, int contractorId)
        {
            string query = @"
                INSERT INTO [Projects] ([Name], [Status], [Deadline], [ManagerId], [ClientId], [ContractorId])
                VALUES (@Name, @Status, @Deadline, @ManagerId, @ClientId, @ContractorId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Deadline", deadline);
                    cmd.Parameters.AddWithValue("@ManagerId", managerId);
                    cmd.Parameters.AddWithValue("@ClientId", clientId);
                    cmd.Parameters.AddWithValue("@ContractorId", contractorId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Чтение (SELECT) всех проектов - возвращает DataTable.
        /// </summary>
        public DataTable GetAllProjects()
        {
            DataTable dt = new DataTable();
            string query = "SELECT [ProjectId], [Name], [Status], [Deadline], [ClientId], [ContractorId], [ManagerId] FROM [Projects]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Обновление (UPDATE) проекта.
        /// </summary>
        public void UpdateProject(int projectId, string name, string status, DateTime deadline, int managerId, int clientId, int contractorId)
        {
            string query = @"
                UPDATE [Projects]
                SET [Name] = @Name,
                    [Status] = @Status,
                    [Deadline] = @Deadline,
                    [ManagerId] = @ManagerId,
                    [ClientId] = @ClientId,
                    [ContractorId] = @ContractorId
                WHERE [ProjectId] = @ProjectId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Deadline", deadline);
                    cmd.Parameters.AddWithValue("@ManagerId", managerId);
                    cmd.Parameters.AddWithValue("@ClientId", clientId);
                    cmd.Parameters.AddWithValue("@ContractorId", contractorId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Удаление (DELETE) проекта.
        /// </summary>
        public void DeleteProject(int projectId)
        {
            string query = "DELETE FROM [Projects] WHERE [ProjectId] = @ProjectId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
