using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library_management.Forms.Admin;
using library_management.Forms.Student;

namespace library_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
             
            StudentLogin sl = new StudentLogin();
            sl.ShowDialog();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            ad.ShowDialog();
        }
    }
}
