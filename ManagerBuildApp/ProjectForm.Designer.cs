namespace ManagerBuildApp
{
    partial class ProjectForm
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
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerBuildAppDataSet2 = new ManagerBuildApp.ManagerBuildAppDataSet2();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.projectsTableAdapter = new ManagerBuildApp.ManagerBuildAppDataSet2TableAdapters.ProjectsTableAdapter();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelProjectStatus = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelContractor = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbContractor = new System.Windows.Forms.ComboBox();
            this.managerBuildAppDataSet = new ManagerBuildApp.ManagerBuildAppDataSet();
            this.managerBuildAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerBuildAppDataSet1 = new ManagerBuildApp.ManagerBuildAppDataSet1();
            this.contractorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorsTableAdapter = new ManagerBuildApp.ManagerBuildAppDataSet1TableAdapters.ContractorsTableAdapter();
            this.managerBuildAppDataSet3 = new ManagerBuildApp.ManagerBuildAppDataSet3();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new ManagerBuildApp.ManagerBuildAppDataSet3TableAdapters.ClientsTableAdapter();
            this.managerBuildAppDataSet4 = new ManagerBuildApp.ManagerBuildAppDataSet4();
            this.contractorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contractorsTableAdapter1 = new ManagerBuildApp.ManagerBuildAppDataSet4TableAdapters.ContractorsTableAdapter();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter1 = new ManagerBuildApp.ManagerBuildAppDataSetTableAdapters.ClientsTableAdapter();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AutoGenerateColumns = false;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.contractorIdDataGridViewTextBoxColumn,
            this.managerIdDataGridViewTextBoxColumn});
            this.dataGridViewProjects.DataSource = this.projectsBindingSource;
            this.dataGridViewProjects.Location = new System.Drawing.Point(46, 24);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(1034, 299);
            this.dataGridViewProjects.TabIndex = 0;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.managerBuildAppDataSet2;
            // 
            // managerBuildAppDataSet2
            // 
            this.managerBuildAppDataSet2.DataSetName = "ManagerBuildAppDataSet2";
            this.managerBuildAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(107, 330);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(154, 20);
            this.txtProjectName.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(107, 366);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(154, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(754, 329);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeadline.TabIndex = 4;
            this.dateTimePickerDeadline.ValueChanged += new System.EventHandler(this.dateTimePickerDeadline_ValueChanged);
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(43, 336);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(57, 13);
            this.labelProjectName.TabIndex = 5;
            this.labelProjectName.Text = "Название";
            // 
            // labelProjectStatus
            // 
            this.labelProjectStatus.AutoSize = true;
            this.labelProjectStatus.Location = new System.Drawing.Point(43, 366);
            this.labelProjectStatus.Name = "labelProjectStatus";
            this.labelProjectStatus.Size = new System.Drawing.Size(41, 13);
            this.labelProjectStatus.TabIndex = 6;
            this.labelProjectStatus.Text = "Статус";
            this.labelProjectStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(127, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelContractor
            // 
            this.labelContractor.AutoSize = true;
            this.labelContractor.Location = new System.Drawing.Point(359, 363);
            this.labelContractor.Name = "labelContractor";
            this.labelContractor.Size = new System.Drawing.Size(62, 13);
            this.labelContractor.TabIndex = 12;
            this.labelContractor.Text = "Подрядчик";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(358, 333);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 11;
            this.labelClient.Text = "Клиент";
            // 
            // cmbClient
            // 
            this.cmbClient.DataSource = this.clientsBindingSource1;
            this.cmbClient.DisplayMember = "Name";
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(421, 328);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(154, 21);
            this.cmbClient.TabIndex = 13;
            this.cmbClient.ValueMember = "ClientId";
            // 
            // cmbContractor
            // 
            this.cmbContractor.DataSource = this.contractorsBindingSource;
            this.cmbContractor.DisplayMember = "Name";
            this.cmbContractor.FormattingEnabled = true;
            this.cmbContractor.Location = new System.Drawing.Point(421, 360);
            this.cmbContractor.Name = "cmbContractor";
            this.cmbContractor.Size = new System.Drawing.Size(154, 21);
            this.cmbContractor.TabIndex = 14;
            this.cmbContractor.ValueMember = "ContractorId";
            // 
            // managerBuildAppDataSet
            // 
            this.managerBuildAppDataSet.DataSetName = "ManagerBuildAppDataSet";
            this.managerBuildAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBuildAppDataSetBindingSource
            // 
            this.managerBuildAppDataSetBindingSource.DataSource = this.managerBuildAppDataSet;
            this.managerBuildAppDataSetBindingSource.Position = 0;
            // 
            // managerBuildAppDataSet1
            // 
            this.managerBuildAppDataSet1.DataSetName = "ManagerBuildAppDataSet1";
            this.managerBuildAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractorsBindingSource
            // 
            this.contractorsBindingSource.DataMember = "Contractors";
            this.contractorsBindingSource.DataSource = this.managerBuildAppDataSet1;
            // 
            // contractorsTableAdapter
            // 
            this.contractorsTableAdapter.ClearBeforeFill = true;
            // 
            // managerBuildAppDataSet3
            // 
            this.managerBuildAppDataSet3.DataSetName = "ManagerBuildAppDataSet3";
            this.managerBuildAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.managerBuildAppDataSet3;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // managerBuildAppDataSet4
            // 
            this.managerBuildAppDataSet4.DataSetName = "ManagerBuildAppDataSet4";
            this.managerBuildAppDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractorsBindingSource1
            // 
            this.contractorsBindingSource1.DataMember = "Contractors";
            this.contractorsBindingSource1.DataSource = this.managerBuildAppDataSet4;
            // 
            // contractorsTableAdapter1
            // 
            this.contractorsTableAdapter1.ClearBeforeFill = true;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.managerBuildAppDataSetBindingSource;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.Name = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "Name";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "Status";
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.Name = "Deadline";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "ClientId";
            // 
            // contractorIdDataGridViewTextBoxColumn
            // 
            this.contractorIdDataGridViewTextBoxColumn.DataPropertyName = "ContractorId";
            this.contractorIdDataGridViewTextBoxColumn.HeaderText = "ContractorId";
            this.contractorIdDataGridViewTextBoxColumn.Name = "ContractorId";
            // 
            // managerIdDataGridViewTextBoxColumn
            // 
            this.managerIdDataGridViewTextBoxColumn.DataPropertyName = "ManagerId";
            this.managerIdDataGridViewTextBoxColumn.HeaderText = "ManagerId";
            this.managerIdDataGridViewTextBoxColumn.Name = "ManagerId";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.cmbContractor);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.labelContractor);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelProjectStatus);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewProjects);
            this.Name = "ProjectForm";
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBuildAppDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private ManagerBuildAppDataSet2 managerBuildAppDataSet2;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ManagerBuildAppDataSet2TableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelProjectStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelContractor;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbContractor;
        private System.Windows.Forms.BindingSource managerBuildAppDataSetBindingSource;
        private ManagerBuildAppDataSet managerBuildAppDataSet;
        private ManagerBuildAppDataSet1 managerBuildAppDataSet1;
        private System.Windows.Forms.BindingSource contractorsBindingSource;
        private ManagerBuildAppDataSet1TableAdapters.ContractorsTableAdapter contractorsTableAdapter;
        private ManagerBuildAppDataSet3 managerBuildAppDataSet3;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ManagerBuildAppDataSet3TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private ManagerBuildAppDataSet4 managerBuildAppDataSet4;
        private System.Windows.Forms.BindingSource contractorsBindingSource1;
        private ManagerBuildAppDataSet4TableAdapters.ContractorsTableAdapter contractorsTableAdapter1;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private ManagerBuildAppDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIdDataGridViewTextBoxColumn;
    }
}