using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management.Forms.Admin
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                string query = "INSERT INTO tbl_StudentDetails (StudentName, StudentEmail, StudentMobile, StudentPassword) " +
                       "VALUES (@Name, @Email, @Mobile, @Password)";
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@Name", txtStuName.Text);
            cmd.Parameters.AddWithValue("@Email", txtStuEmail.Text);
            cmd.Parameters.AddWithValue("@Mobile", txtStuMobile.Text);
            cmd.Parameters.AddWithValue("@Password", txtStuPassword.Text);

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Student added successfully." : "Insert failed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        }
    

