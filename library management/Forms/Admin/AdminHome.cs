using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management.Forms.Admin
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnHomeAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent ads= new AddStudent();
            ads.ShowDialog();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            RemoveStudent rs= new RemoveStudent(); 
            rs.ShowDialog();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            Search_Stu_ToUpdate sstu= new Search_Stu_ToUpdate();
            sstu.ShowDialog();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            AddBooks ab = new AddBooks();
            ab.Show();
        }

        private void btnRemoveBooks_Click(object sender, EventArgs e)
        {
            RemoveBooks rb=new RemoveBooks();
            rb.ShowDialog();
        }
    }
}
