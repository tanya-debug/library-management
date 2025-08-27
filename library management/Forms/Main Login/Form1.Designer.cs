namespace library_management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundPannel1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.logoPannel = new System.Windows.Forms.Panel();
            this.backgroundPannel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPannel1
            // 
            this.backgroundPannel1.Controls.Add(this.panel1);
            this.backgroundPannel1.Controls.Add(this.logoPannel);
            this.backgroundPannel1.Location = new System.Drawing.Point(12, 13);
            this.backgroundPannel1.Name = "backgroundPannel1";
            this.backgroundPannel1.Padding = new System.Windows.Forms.Padding(10);
            this.backgroundPannel1.Size = new System.Drawing.Size(860, 566);
            this.backgroundPannel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdminLogin);
            this.panel1.Controls.Add(this.btnStudentLogin);
            this.panel1.Location = new System.Drawing.Point(336, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 160);
            this.panel1.TabIndex = 1;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(25, 85);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(136, 32);
            this.btnAdminLogin.TabIndex = 1;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Location = new System.Drawing.Point(25, 32);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(135, 32);
            this.btnStudentLogin.TabIndex = 0;
            this.btnStudentLogin.Text = "Student Login";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // logoPannel
            // 
            this.logoPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPannel.BackgroundImage")));
            this.logoPannel.Location = new System.Drawing.Point(3, 3);
            this.logoPannel.Name = "logoPannel";
            this.logoPannel.Size = new System.Drawing.Size(277, 137);
            this.logoPannel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.backgroundPannel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.backgroundPannel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPannel1;
        private System.Windows.Forms.Panel logoPannel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnStudentLogin;
    }
}

