using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Windows.Forms;
using ManagerBuildApp.BLL;

namespace ManagerBuildApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Пример параметризованного запроса для проверки
            string checkQuery = "SELECT COUNT(*) FROM [Users] WHERE [Username] = @Username AND [Password] = @Password";

            try
            {
                // Проверяем, существует ли пользователь
                int userCount = ExecuteScalarQuery(checkQuery, username, password);

                if (userCount == 1)
                {

                    (int userId, string currentUser, string userRole) = GetUserData(username, password);

                     SessionManager.CurrentUserId = userId;
                     SessionManager.CurrentUserName = currentUser;
                     SessionManager.CurrentUserRole = userRole;

                    // Или передать в главную форму
                    MainForm mainForm = new MainForm();
                    // mainForm.SetUserData(userId, currentUser); // если нужно

                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    // Авторизация не удалась
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при авторизации: " + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Выполняет параметризованный запрос с логином и паролем и возвращает количество строк (int).
        /// </summary>
        private int ExecuteScalarQuery(string query, string username, string password)
        {
            int result = 0;
            // Подставь свою строку подключения
            string connectionString = ConfigurationManager.ConnectionStrings["ManagerBuildApp"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Добавляем параметры
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    // ExecuteScalar возвращает object, но мы знаем, что в запросе SELECT COUNT(*),
                    // поэтому результат будет числом
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        result = Convert.ToInt32(obj);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Получает UserId и Username из таблицы [Users] для указанного логина/пароля.
        /// </summary>
        private (int userId, string currentUser, string userRole) GetUserData(string username, string password)
        {
            int userId = 0;
            string currentUser = string.Empty;
            string userRole = string.Empty;

            // Запрос для получения ID и имени пользователя
            string query = @"
                SELECT [UserId], [Username], [Role]
                FROM [Users] 
                WHERE [Username] = @Username AND [Password] = @Password";

            string connectionString = ConfigurationManager.ConnectionStrings["ManagerBuildApp"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = reader.GetInt32(0);
                            currentUser = reader.GetString(1);
                            userRole = reader.GetString(2);
                        }
                    }
                }
            }
            return (userId, currentUser, userRole);
        }
    }
}
