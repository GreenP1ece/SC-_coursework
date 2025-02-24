namespace ManagerBuildApp
{
    partial class ClientsAndContractorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerBuildAppDataSet = new ManagerBuildApp.ManagerBuildAppDataSet();
            this.dataGridViewContractors = new System.Windows.Forms.DataGridView();
            this.ContractorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractorPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerBuildAppDataSet1 = new ManagerBuildApp.ManagerBuildAppDataSet1();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientCompany = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtContractorPhone = new System.Windows.Forms.TextBox();
            this.txtContractorSpecialty = new System.Windows.Forms.TextBox();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new ManagerBuildApp.ManagerBuildAppDataSetTableAdapters.ClientsTableAdapter();
            this.contractorsTableAdapter = new ManagerBuildApp.ManagerBuildAppDataSet1TableAdapters.ContractorsTableAdapter();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.labelClientCompany = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteContractor = new System.Windows.Forms.Button();
            this.btnUpdateContractor = new System.Windows.Forms.Button();
            this.btnAddContractor = new System.Windows.Forms.Button();
            this.labelContractorSpecialty = new System.Windows.Forms.Label();
            this.labelContractorPhone = new System.Windows.Forms.Label();
            this.labelContactorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AutoGenerateColumns = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientName,
            this.ClientPhone,
            this.Company});
            this.dataGridViewClients.DataSource = this.clientsBindingSource;
            this.dataGridViewClients.Location = new System.Drawing.Point(38, 29);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(446, 289);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            this.dataGridViewClients.SelectionChanged += new System.EventHandler(this.dataGridViewClients_SelectionChanged_1);
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ID клиента";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "Name";
            this.ClientName.HeaderText = "Название";
            this.ClientName.Name = "ClientName";
            // 
            // ClientPhone
            // 
            this.ClientPhone.DataPropertyName = "Phone";
            this.ClientPhone.HeaderText = "Номер телефона";
            this.ClientPhone.Name = "ClientPhone";
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Компания";
            this.Company.Name = "Company";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.managerBuildAppDataSet;
            // 
            // managerBuildAppDataSet
            // 
            this.managerBuildAppDataSet.DataSetName = "ManagerBuildAppDataSet";
            this.managerBuildAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewContractors
            // 
            this.dataGridViewContractors.AutoGenerateColumns = false;
            this.dataGridViewContractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContractors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractorId,
            this.ContractorName,
            this.Specialty,
            this.ContractorPhone});
            this.dataGridViewContractors.DataSource = this.contractorsBindingSource;
            this.dataGridViewContractors.Location = new System.Drawing.Point(527, 29);
            this.dataGridViewContractors.Name = "dataGridViewContractors";
            this.dataGridViewContractors.Size = new System.Drawing.Size(453, 289);
            this.dataGridViewContractors.TabIndex = 1;
            this.dataGridViewContractors.SelectionChanged += new System.EventHandler(this.dataGridViewContractors_SelectionChanged);
            // 
            // ContractorId
            // 
            this.ContractorId.DataPropertyName = "ContractorId";
            this.ContractorId.HeaderText = "ID подрядчика";
            this.ContractorId.Name = "ContractorId";
            this.ContractorId.ReadOnly = true;
            // 
            // ContractorName
            // 
            this.ContractorName.DataPropertyName = "Name";
            this.ContractorName.HeaderText = "Название";
            this.ContractorName.Name = "ContractorName";
            // 
            // Specialty
            // 
            this.Specialty.DataPropertyName = "Specialty";
            this.Specialty.HeaderText = "Специализация";
            this.Specialty.Name = "Specialty";
            // 
            // ContractorPhone
            // 
            this.ContractorPhone.DataPropertyName = "Phone";
            this.ContractorPhone.HeaderText = "Номер телефона";
            this.ContractorPhone.Name = "ContractorPhone";
            // 
            // contractorsBindingSource
            // 
            this.contractorsBindingSource.DataMember = "Contractors";
            this.contractorsBindingSource.DataSource = this.managerBuildAppDataSet1;
            // 
            // managerBuildAppDataSet1
            // 
            this.managerBuildAppDataSet1.DataSetName = "ManagerBuildAppDataSet1";
            this.managerBuildAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(115, 324);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(189, 20);
            this.txtClientName.TabIndex = 2;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(115, 362);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(189, 20);
            this.txtClientPhone.TabIndex = 3;
            // 
            // txtClientCompany
            // 
            this.txtClientCompany.Location = new System.Drawing.Point(115, 402);
            this.txtClientCompany.Name = "txtClientCompany";
            this.txtClientCompany.Size = new System.Drawing.Size(189, 20);
            this.txtClientCompany.TabIndex = 4;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(115, 446);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 35);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtContractorPhone
            // 
            this.txtContractorPhone.Location = new System.Drawing.Point(621, 402);
            this.txtContractorPhone.Name = "txtContractorPhone";
            this.txtContractorPhone.Size = new System.Drawing.Size(189, 20);
            this.txtContractorPhone.TabIndex = 10;
            // 
            // txtContractorSpecialty
            // 
            this.txtContractorSpecialty.Location = new System.Drawing.Point(621, 362);
            this.txtContractorSpecialty.Name = "txtContractorSpecialty";
            this.txtContractorSpecialty.Size = new System.Drawing.Size(189, 20);
            this.txtContractorSpecialty.TabIndex = 9;
            // 
            // txtContractorName
            // 
            this.txtContractorName.Location = new System.Drawing.Point(621, 324);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(189, 20);
            this.txtContractorName.TabIndex = 8;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // contractorsTableAdapter
            // 
            this.contractorsTableAdapter.ClearBeforeFill = true;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(36, 327);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(73, 13);
            this.labelClientName.TabIndex = 11;
            this.labelClientName.Text = "Имя клиента";
            this.labelClientName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.Location = new System.Drawing.Point(36, 369);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(52, 13);
            this.labelClientPhone.TabIndex = 12;
            this.labelClientPhone.Text = "Телефон";
            // 
            // labelClientCompany
            // 
            this.labelClientCompany.AutoSize = true;
            this.labelClientCompany.Location = new System.Drawing.Point(36, 409);
            this.labelClientCompany.Name = "labelClientCompany";
            this.labelClientCompany.Size = new System.Drawing.Size(58, 13);
            this.labelClientCompany.TabIndex = 13;
            this.labelClientCompany.Text = "Компания";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(153, 487);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteClient.TabIndex = 15;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(196, 446);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(108, 35);
            this.btnUpdateClient.TabIndex = 14;
            this.btnUpdateClient.Text = "Изменить данные о клиенте";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteContractor
            // 
            this.btnDeleteContractor.Location = new System.Drawing.Point(659, 480);
            this.btnDeleteContractor.Name = "btnDeleteContractor";
            this.btnDeleteContractor.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteContractor.TabIndex = 18;
            this.btnDeleteContractor.Text = "Удалить подрядчика";
            this.btnDeleteContractor.UseVisualStyleBackColor = true;
            this.btnDeleteContractor.Click += new System.EventHandler(this.btnDeleteContractor_Click);
            // 
            // btnUpdateContractor
            // 
            this.btnUpdateContractor.Location = new System.Drawing.Point(702, 439);
            this.btnUpdateContractor.Name = "btnUpdateContractor";
            this.btnUpdateContractor.Size = new System.Drawing.Size(108, 35);
            this.btnUpdateContractor.TabIndex = 17;
            this.btnUpdateContractor.Text = "Изменить данные о подрядчике";
            this.btnUpdateContractor.UseVisualStyleBackColor = true;
            this.btnUpdateContractor.Click += new System.EventHandler(this.btnUpdateContractor_Click);
            // 
            // btnAddContractor
            // 
            this.btnAddContractor.Location = new System.Drawing.Point(621, 439);
            this.btnAddContractor.Name = "btnAddContractor";
            this.btnAddContractor.Size = new System.Drawing.Size(75, 35);
            this.btnAddContractor.TabIndex = 16;
            this.btnAddContractor.Text = "Добавить подрядчика";
            this.btnAddContractor.UseVisualStyleBackColor = true;
            this.btnAddContractor.Click += new System.EventHandler(this.btnAddContractor_Click);
            // 
            // labelContractorSpecialty
            // 
            this.labelContractorSpecialty.AutoSize = true;
            this.labelContractorSpecialty.Location = new System.Drawing.Point(524, 365);
            this.labelContractorSpecialty.Name = "labelContractorSpecialty";
            this.labelContractorSpecialty.Size = new System.Drawing.Size(86, 13);
            this.labelContractorSpecialty.TabIndex = 21;
            this.labelContractorSpecialty.Text = "Специализация";
            // 
            // labelContractorPhone
            // 
            this.labelContractorPhone.AutoSize = true;
            this.labelContractorPhone.Location = new System.Drawing.Point(524, 405);
            this.labelContractorPhone.Name = "labelContractorPhone";
            this.labelContractorPhone.Size = new System.Drawing.Size(52, 13);
            this.labelContractorPhone.TabIndex = 20;
            this.labelContractorPhone.Text = "Телефон";
            // 
            // labelContactorName
            // 
            this.labelContactorName.AutoSize = true;
            this.labelContactorName.Location = new System.Drawing.Point(524, 324);
            this.labelContactorName.Name = "labelContactorName";
            this.labelContactorName.Size = new System.Drawing.Size(91, 13);
            this.labelContactorName.TabIndex = 19;
            this.labelContactorName.Text = "Имя подрядчика";
            // 
            // ClientsAndContractorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 534);
            this.Controls.Add(this.labelContractorSpecialty);
            this.Controls.Add(this.labelContractorPhone);
            this.Controls.Add(this.labelContactorName);
            this.Controls.Add(this.btnDeleteContractor);
            this.Controls.Add(this.btnUpdateContractor);
            this.Controls.Add(this.btnAddContractor);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.labelClientCompany);
            this.Controls.Add(this.labelClientPhone);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.txtContractorPhone);
            this.Controls.Add(this.txtContractorSpecialty);
            this.Controls.Add(this.txtContractorName);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.txtClientCompany);
            this.Controls.Add(this.txtClientPhone);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.dataGridViewContractors);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "ClientsAndContractorsForm";
            this.Text = "Клиенты и подрядчики";
            this.Load += new System.EventHandler(this.ClientsAndContractorsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewContractors;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientCompany;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtContractorPhone;
        private System.Windows.Forms.TextBox txtContractorSpecialty;
        private System.Windows.Forms.TextBox txtContractorName;
        private ManagerBuildAppDataSet managerBuildAppDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ManagerBuildAppDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private ManagerBuildAppDataSet1 managerBuildAppDataSet1;
        private System.Windows.Forms.BindingSource contractorsBindingSource;
        private ManagerBuildAppDataSet1TableAdapters.ContractorsTableAdapter contractorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelClientPhone;
        private System.Windows.Forms.Label labelClientCompany;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractorPhone;
        private System.Windows.Forms.Button btnDeleteContractor;
        private System.Windows.Forms.Button btnUpdateContractor;
        private System.Windows.Forms.Button btnAddContractor;
        private System.Windows.Forms.Label labelContractorSpecialty;
        private System.Windows.Forms.Label labelContractorPhone;
        private System.Windows.Forms.Label labelContactorName;
    }
}