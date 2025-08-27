namespace library_management.Forms.Admin
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveBooks = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnHomeAdmin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 131);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemoveBooks);
            this.panel2.Controls.Add(this.btnAddBooks);
            this.panel2.Controls.Add(this.btnUpdateStudent);
            this.panel2.Controls.Add(this.btnRemoveStudent);
            this.panel2.Controls.Add(this.btnAddStudent);
            this.panel2.Location = new System.Drawing.Point(270, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 238);
            this.panel2.TabIndex = 1;
            // 
            // btnRemoveBooks
            // 
            this.btnRemoveBooks.Location = new System.Drawing.Point(51, 194);
            this.btnRemoveBooks.Name = "btnRemoveBooks";
            this.btnRemoveBooks.Size = new System.Drawing.Size(141, 27);
            this.btnRemoveBooks.TabIndex = 4;
            this.btnRemoveBooks.Text = "Remove Books";
            this.btnRemoveBooks.UseVisualStyleBackColor = true;
            this.btnRemoveBooks.Click += new System.EventHandler(this.btnRemoveBooks_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Location = new System.Drawing.Point(51, 151);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(141, 27);
            this.btnAddBooks.TabIndex = 3;
            this.btnAddBooks.Text = "Add Books";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(51, 109);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(141, 27);
            this.btnUpdateStudent.TabIndex = 2;
            this.btnUpdateStudent.Text = "Update Student Info";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(51, 66);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(141, 27);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(51, 23);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(141, 27);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnHomeAdmin
            // 
            this.btnHomeAdmin.Location = new System.Drawing.Point(601, 542);
            this.btnHomeAdmin.Name = "btnHomeAdmin";
            this.btnHomeAdmin.Size = new System.Drawing.Size(187, 59);
            this.btnHomeAdmin.TabIndex = 2;
            this.btnHomeAdmin.Text = "Home";
            this.btnHomeAdmin.UseVisualStyleBackColor = true;
            this.btnHomeAdmin.Click += new System.EventHandler(this.btnHomeAdmin_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btnHomeAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveBooks;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnHomeAdmin;
    }
}