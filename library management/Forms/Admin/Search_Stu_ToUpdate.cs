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
    public partial class Search_Stu_ToUpdate : Form
    {
        public Search_Stu_ToUpdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            Update_Info ui = new Update_Info(email);
            ui.ShowDialog();

        }
    }
}
