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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace library_management.Forms.Admin
{
    public partial class Update_Info : Form
    {
        private string _email;
        public Update_Info(string email)
        {
            InitializeComponent();
            _email = email;
            LoadStudentData();
        }

        public Update_Info()
        {
            InitializeComponent();
        }

        private void LoadStudentData()
        {


            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                string query = "SELECT StudentName, StudentEmail, StudentMobile, StudentPassword FROM tbl_StudentDetails WHERE StudentEmail = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", _email);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtStuName.Text = reader["StudentName"].ToString();
                        txtStuEmail.Text = reader["StudentEmail"].ToString();
                        txtStuMobile.Text = reader["StudentMobile"].ToString();
                        txtStuPassword.Text = reader["StudentPassword"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No student found with this email.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

  


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                string query = "UPDATE tbl_StudentDetails SET StudentName = @Name,StudentEmail=@Email, StudentMobile = @Mobile, StudentPassword = @Password WHERE StudentEmail = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", txtStuName.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtStuMobile.Text);
                cmd.Parameters.AddWithValue("@Password", txtStuPassword.Text);
                cmd.Parameters.AddWithValue("@Email", _email);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Student record updated successfully." : "Update failed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }

            }



        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
