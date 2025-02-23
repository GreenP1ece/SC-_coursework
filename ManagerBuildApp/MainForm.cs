using System;
using System.Windows.Forms;

namespace ManagerBuildApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProjects_Click_1(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm();
            form.ShowDialog();
        }

        private void btnClientsContractors_Click_1(object sender, EventArgs e)
        {
            ClientsAndContractorsForm form = new ClientsAndContractorsForm();
            form.ShowDialog();
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
