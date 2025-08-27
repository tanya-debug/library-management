using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_management.Forms.Student
{
    public partial class AvailableBooks : Form
    {
        public AvailableBooks()
        {
            InitializeComponent();
        }

       

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
            

        }

        private void LoadBooks(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT BookID, BookTitle, Author, Category, Publisher, Quantity, AddedDate FROM tbl_BookDetails WHERE Quantity > 0";

                if (!string.IsNullOrEmpty(search))
                {
                    query += " AND BookTitle LIKE @Search";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            LoadBooks(searchText);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
