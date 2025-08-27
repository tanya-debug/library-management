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
using library_management.Forms.Admin;

namespace library_management.Forms.Student
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("StudentLogin", conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                // Fill DataSet
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                conn.Open();
                da.Fill(ds);  // Executes and fills dataset
                conn.Close();

                // Get the return value
                bool returnValue = Convert.ToBoolean(returnParameter.Value);

                // If you want to get the SELECTed value (same as returnValue)
                if (returnValue == true)
                {
                    StudentHome stuHome = new StudentHome();
                    stuHome.ShowDialog();
                }
                else
                    MessageBox.Show("Incorrect UserName Or Password !!!", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
