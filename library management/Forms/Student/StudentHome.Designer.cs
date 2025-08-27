namespace library_management.Forms.Student
{
    partial class StudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAvailableBooks = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnIssuedBooks = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 144);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChangePassword);
            this.panel2.Controls.Add(this.btnUpdateProfile);
            this.panel2.Controls.Add(this.btnReturnBook);
            this.panel2.Controls.Add(this.btnIssuedBooks);
            this.panel2.Controls.Add(this.btnIssueBook);
            this.panel2.Controls.Add(this.btnAvailableBooks);
            this.panel2.Location = new System.Drawing.Point(351, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 233);
            this.panel2.TabIndex = 1;
            // 
            // btnAvailableBooks
            // 
            this.btnAvailableBooks.Location = new System.Drawing.Point(20, 18);
            this.btnAvailableBooks.Name = "btnAvailableBooks";
            this.btnAvailableBooks.Size = new System.Drawing.Size(148, 28);
            this.btnAvailableBooks.TabIndex = 0;
            this.btnAvailableBooks.Text = "Available Books";
            this.btnAvailableBooks.UseVisualStyleBackColor = true;
            this.btnAvailableBooks.Click += new System.EventHandler(this.btnAvailableBooks_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(20, 52);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(148, 28);
            this.btnIssueBook.TabIndex = 1;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnIssuedBooks
            // 
            this.btnIssuedBooks.Location = new System.Drawing.Point(20, 86);
            this.btnIssuedBooks.Name = "btnIssuedBooks";
            this.btnIssuedBooks.Size = new System.Drawing.Size(148, 28);
            this.btnIssuedBooks.TabIndex = 2;
            this.btnIssuedBooks.Text = "Issued Books";
            this.btnIssuedBooks.UseVisualStyleBackColor = true;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(20, 120);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(148, 28);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(20, 154);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(148, 28);
            this.btnUpdateProfile.TabIndex = 4;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(20, 188);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(148, 28);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(667, 403);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 35);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnIssuedBooks;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnAvailableBooks;
        private System.Windows.Forms.Button btnHome;
    }
}