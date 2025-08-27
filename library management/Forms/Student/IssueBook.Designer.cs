
namespace library_management.Forms.Student
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.dtIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnIssue = new System.Windows.Forms.Button();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBooks
            // 
            this.cmbBooks.DisplayMember = "BookTitle";
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(367, 185);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(200, 24);
            this.cmbBooks.TabIndex = 0;
            this.cmbBooks.ValueMember = "BookID";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 145);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(595, 188);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(69, 17);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Available:";
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(367, 229);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(200, 22);
            this.txtStuEmail.TabIndex = 3;
            // 
            // dtIssueDate
            // 
            this.dtIssueDate.Location = new System.Drawing.Point(367, 279);
            this.dtIssueDate.Name = "dtIssueDate";
            this.dtIssueDate.Size = new System.Drawing.Size(200, 22);
            this.dtIssueDate.TabIndex = 4;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(367, 377);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(68, 26);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // dtDueDate
            // 
            this.dtDueDate.Location = new System.Drawing.Point(367, 326);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(200, 22);
            this.dtDueDate.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(505, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 26);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(279, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(250, 284);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(71, 17);
            this.lblIssueDate.TabIndex = 9;
            this.lblIssueDate.Text = "IssueDate";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(257, 331);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(64, 17);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "DueDate";
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.dtIssueDate);
            this.Controls.Add(this.txtStuEmail);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbBooks);
            this.Name = "IssueBook";
            this.Text = "IssueBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.DateTimePicker dtIssueDate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblDueDate;
    }
}