using System;
using System.Data;
using System.Windows.Forms;
using ManagerBuildApp;

namespace ManagerBuildApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Пример простого формирования отчёта
            string reportText = "Отчёт о текущем состоянии:\r\n\r\n";

            // Проекты
            DataTable dtProjects = DatabaseHelper.ExecuteQuery("SELECT [Name], [Status], [Deadline] FROM [Projects]");
            reportText += "Проекты:\r\n";
            foreach (DataRow row in dtProjects.Rows)
            {
                reportText += $"Название: {row["Name"]}, Статус: {row["Status"]}, Срок: {row["Deadline"]}\r\n";
            }
            reportText += "\r\n";

            // Клиенты
            DataTable dtClients = DatabaseHelper.ExecuteQuery("SELECT [Name], [Phone], [Company] FROM [Clients]");
            reportText += "Клиенты:\r\n";
            foreach (DataRow row in dtClients.Rows)
            {
                reportText += $"Имя: {row["Name"]}, Телефон: {row["Phone"]}, Компания: {row["Company"]}\r\n";
            }
            reportText += "\r\n";

            // Подрядчики
            DataTable dtContractors = DatabaseHelper.ExecuteQuery("SELECT [Name], [Specialty], [Phone] FROM [Contractors]");
            reportText += "Подрядчики:\r\n";
            foreach (DataRow row in dtContractors.Rows)
            {
                reportText += $"Имя: {row["Name"]}, Специализация: {row["Specialty"]}, Телефон: {row["Phone"]}\r\n";
            }

            txtReport.Text = reportText;
        }
    }
}
