using System;
using System.Data;
using System.Windows.Forms;
using ManagerBuildApp;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;
using ManagerBuildApp.BLL;
using ManagerBuildApp.DAL;

namespace ManagerBuildApp
{
    public partial class ProjectForm : Form
    {
        private ProjectRepository projectRepository = new ProjectRepository();
        private ClientRepository clientRepository = new ClientRepository();
        private ContractorRepository contractorRepository = new ContractorRepository();
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadProjects();
            LoadContractors();

        }

        private void LoadProjects()
        {
            DataTable dt = projectRepository.GetAllProjects();
            dataGridViewProjects.DataSource = dt;
        }
        private void LoadClients()
        {
            DataTable dtClients = clientRepository.GetAllClients();

            cmbClient.DataSource = dtClients;
            cmbClient.DisplayMember = "Name";       // то, что будет отображаться пользователю
            cmbClient.ValueMember = "ClientId";     // то, что будет храниться в SelectedValue
            cmbClient.SelectedIndex = -1;           // при желании сбрасываем выбор
        }
        private void LoadContractors()
        {
            DataTable dtContractors = contractorRepository.GetAllContractors();
            cmbContractor.DataSource = dtContractors;
            cmbContractor.DisplayMember = "Name";       // то, что будет отображаться пользователю
            cmbContractor.ValueMember = "ContractorId";     // то, что будет храниться в SelectedValue
            cmbContractor.SelectedIndex = -1;           // при желании сбрасываем выбор
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text.Trim();
            string status = txtStatus.Text.Trim();
            DateTime deadline = dateTimePickerDeadline.Value;

            // Предположим, ManagerId берем из текущего пользователя
            int managerId = SessionManager.CurrentUserId;

            // Теперь самое главное:
            //   cmbClient.SelectedValue   -> должен вернуть ClientId (int)
            //   cmbContractor.SelectedValue -> вернет ContractorId (int)
            // Но они типа object, так что делаем Convert.ToInt32:
            int clientId = Convert.ToInt32(cmbClient.SelectedValue);
            int contractorId = Convert.ToInt32(cmbContractor.SelectedValue);
            MessageBox.Show("ManagerId = " + managerId);
            // Проверки (не пустые поля, выбранные comboBox, etc.)
            if (string.IsNullOrEmpty(projectName) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Введите название и статус проекта!", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Вызов репозитория для добавления
                projectRepository.InsertProject(projectName, status, deadline, managerId, clientId, contractorId);
                MessageBox.Show("Проект добавлен!");
                LoadProjects(); // Перезагрузить список проектов, если нужно
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении проекта: " + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells["ProjectId"].Value);

                string projectName = txtProjectName.Text.Trim();
                string status = txtStatus.Text.Trim();
                DateTime deadline = dateTimePickerDeadline.Value;

                // Берём новые значения ManagerId, ClientId, ContractorId
                int managerId = SessionManager.CurrentUserId; // или cmbManager.SelectedValue
                int clientId = Convert.ToInt32(cmbClient.SelectedValue);
                int contractorId = Convert.ToInt32(cmbContractor.SelectedValue);

                try
                {
                    projectRepository.UpdateProject(projectId, projectName, status, deadline, managerId, clientId, contractorId);
                    MessageBox.Show("Проект обновлён!");
                    LoadProjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении проекта: " + ex.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите проект для обновления!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells["ProjectId"].Value);

                DialogResult dr = MessageBox.Show("Удалить выбранный проект?",
                                                  "Подтверждение",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        projectRepository.DeleteProject(projectId);
                        MessageBox.Show("Проект удалён!");
                        LoadProjects();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении проекта: " + ex.Message,
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите проект для удаления!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void dataGridViewProjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewProjects.SelectedRows[0];
                txtProjectName.Text = row.Cells["Name"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
                dateTimePickerDeadline.Value = Convert.ToDateTime(row.Cells["Deadline"].Value);

                // ManagerId, ClientId, ContractorId
                // Можно либо заполнить ComboBox, либо просто хранить их где-то
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDeadline_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
