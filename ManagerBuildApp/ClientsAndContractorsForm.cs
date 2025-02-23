using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ManagerBuildApp;
using ManagerBuildApp.BLL;

namespace ManagerBuildApp
{

    public partial class ClientsAndContractorsForm : Form
    {
        public ClientsAndContractorsForm()
        {
            InitializeComponent();
        }

        private void ClientsAndContractorsForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadContractors();
        }
                
        private void LoadClients()
        {
            string query = "SELECT [ClientId], [Name], [Phone], [Company] FROM [Clients]";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dataGridViewClients.DataSource = dt;
        }

        private void LoadContractors()
        {
            string query = "SELECT [ContractorId], [Name], [Specialty], [Phone] FROM [Contractors]";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dataGridViewContractors.DataSource = dt;
        }

        // Методы для работы с клиентами:


        // Методы для работы с подрядчиками:
        private void btnAddContractor_Click(object sender, EventArgs e)
        {
            string name = txtContractorName.Text.Trim();
            string specialty = txtContractorSpecialty.Text.Trim();
            string phone = txtContractorPhone.Text.Trim();
            if (!InputValidator.ValidatePhone(phone, out string PhoneErr))
            {
                MessageBox.Show(PhoneErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!InputValidator.ValidateName(name, out string NameErr))
            {
                MessageBox.Show(NameErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ClientOrContractorExist.ContractorExists(name, specialty, phone))
            {
                MessageBox.Show("Пользователь уже существует");
                return;
            }

            string query = $"INSERT INTO [Contractors]([Name],[Specialty],[Phone]) VALUES('{name}','{specialty}','{phone}')";
            DatabaseHelper.ExecuteNonQuery(query);
            LoadContractors();
        }

        private void btnUpdateContractor_Click(object sender, EventArgs e)
        {
            if (dataGridViewContractors.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewContractors.SelectedRows[0].Cells["ContractorId"].Value);
                string name = txtContractorName.Text.Trim();
                string specialty = txtContractorSpecialty.Text.Trim();
                string phone = txtContractorPhone.Text.Trim();

                if (!InputValidator.ValidatePhone(txtContractorPhone.Text.Trim(), out string PhoneErr))
                {
                    MessageBox.Show(PhoneErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!InputValidator.ValidateName(txtContractorName.Text.Trim(), out string NameErr))
                {
                    MessageBox.Show(NameErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ClientOrContractorExist.ContractorExists(name, specialty, phone))
                {
                    MessageBox.Show("Пользователь уже существует");
                    return;
                }
                string query = $"UPDATE [Contractors] SET [Name] = '{name}', [Specialty] = '{specialty}', [Phone] = '{phone}' WHERE [ContractorId] = {id}";
                DatabaseHelper.ExecuteNonQuery(query);
                LoadContractors();
            }
        }

        private void btnDeleteContractor_Click(object sender, EventArgs e)
        {
            if (dataGridViewContractors.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewContractors.SelectedRows[0].Cells["ContractorId"].Value);
                string query = $"DELETE FROM [Contractors] WHERE [ContractorId] = {id}";
                DatabaseHelper.ExecuteNonQuery(query);
                LoadContractors();
            }
        }

        private void dataGridViewContractors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewContractors.SelectedRows.Count > 0)
            {
                txtContractorName.Text = dataGridViewContractors.SelectedRows[0].Cells["ContractorName"].Value.ToString();
                txtContractorSpecialty.Text = dataGridViewContractors.SelectedRows[0].Cells["Specialty"].Value.ToString();
                txtContractorPhone.Text = dataGridViewContractors.SelectedRows[0].Cells["ContractorPhone"].Value.ToString();
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = txtClientName.Text.Trim();
            string phone = txtClientPhone.Text.Trim();
            string company = txtClientCompany.Text.Trim();

            if (!InputValidator.ValidatePhone(txtClientPhone.Text.Trim(), out string PhoneErr))
            {
                MessageBox.Show(PhoneErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!InputValidator.ValidateName(txtClientName.Text.Trim(), out string NameErr))
            {
                MessageBox.Show(NameErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ClientOrContractorExist.ClientExists(name, phone, company))
            {
                MessageBox.Show("Пользователь уже существует");
                return;
            }
            // Если все проверки пройдены, выполняем запрос
            string query = $"INSERT INTO [Clients]([Name],[Phone], [Company]) " +
                           $"VALUES('{name}','{phone}','{company}')";
            DatabaseHelper.ExecuteNonQuery(query);
            LoadClients();
        }




        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewClients_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                txtClientName.Text = dataGridViewClients.SelectedRows[0].Cells["ClientName"].Value.ToString();
                txtClientPhone.Text = dataGridViewClients.SelectedRows[0].Cells["ClientPhone"].Value.ToString();
                txtClientCompany.Text = dataGridViewClients.SelectedRows[0].Cells["Company"].Value.ToString();
            }
        }

        private void ClientsAndContractorsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "managerBuildAppDataSet1.Contractors". При необходимости она может быть перемещена или удалена.
            this.contractorsTableAdapter.Fill(this.managerBuildAppDataSet1.Contractors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "managerBuildAppDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.managerBuildAppDataSet.Clients);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["ClientId"].Value);
                string name = txtClientName.Text.Trim();
                string phone = txtClientPhone.Text.Trim();
                string company = txtClientCompany.Text.Trim();

                string query = $"UPDATE [Clients] SET [Name] = '{name}', [Phone] = '{phone}', [Company] = '{company}' WHERE [ClientId] = {id}";
                if (!InputValidator.ValidatePhone(txtClientPhone.Text.Trim(), out string PhoneErr))
                {
                    MessageBox.Show(PhoneErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!InputValidator.ValidateName(txtClientName.Text.Trim(), out string NameErr))
                {
                    MessageBox.Show(NameErr, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Проверяем дубликаты для:\nName={name}\nPhone={phone}\nCompany={company}");

                if (ClientOrContractorExist.ClientExists(name, phone, company))
                {
                    MessageBox.Show("Пользователь уже существует");
                    return;
                }
                DatabaseHelper.ExecuteNonQuery(query);
                LoadClients();
                MessageBox.Show("Selected ClientId: " + id);
            }

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["ClientId"].Value);
                string query = $"DELETE FROM [Clients] WHERE [ClientId] = {id}";
                DatabaseHelper.ExecuteNonQuery(query);
                LoadClients();
            }
        }
    }
}
