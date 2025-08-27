using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management.Forms.Student
{
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void btnAvailableBooks_Click(object sender, EventArgs e)
        {
            AvailableBooks avb = new AvailableBooks();
            avb.ShowDialog();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            IssueBook ib = new IssueBook();
            ib.ShowDialog();
        }
    }
}
