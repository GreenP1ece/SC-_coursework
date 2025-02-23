namespace ManagerBuildApp
{
    partial class MainForm
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
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnClientsContractors = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(12, 12);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(75, 23);
            this.btnProjects.TabIndex = 0;
            this.btnProjects.Text = "Проекты";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click_1);
            // 
            // btnClientsContractors
            // 
            this.btnClientsContractors.Location = new System.Drawing.Point(104, 12);
            this.btnClientsContractors.Name = "btnClientsContractors";
            this.btnClientsContractors.Size = new System.Drawing.Size(145, 23);
            this.btnClientsContractors.TabIndex = 1;
            this.btnClientsContractors.Text = "Клиенты и подрядчики";
            this.btnClientsContractors.UseVisualStyleBackColor = true;
            this.btnClientsContractors.Click += new System.EventHandler(this.btnClientsContractors_Click_1);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(273, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Отчеты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnClientsContractors);
            this.Controls.Add(this.btnProjects);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnClientsContractors;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
    }
}