namespace ManagerBuildApp
{
    partial class ReportsForm
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(13, 415);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "button1";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(106, 23);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(660, 382);
            this.txtReport.TabIndex = 2;
            this.txtReport.Text = "";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "ReportsForm";
            this.Text = "Отчеты";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.RichTextBox txtReport;
    }
}