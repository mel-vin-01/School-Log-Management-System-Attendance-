using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoollogmanagementsystem
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recordbtn_Click(object sender, EventArgs e)
        {
            studentrecords1.Visible = true;
            usersbtn.Visible = false;
            usersacc1.Visible = false;
            loghistory1.Visible = false;
            titlelabel.Text = "STUDENT RECORD";
            recordbtn.BackColor = Color.Gray;
            crudbtn.BackColor = Color.RoyalBlue;
            userbtn.BackColor = Color.RoyalBlue;
            logbtn.BackColor = Color.RoyalBlue;

        }

        private void crudbtn_Click(object sender, EventArgs e)
        {
            usersbtn.Visible = true;
            studentrecords1.Visible = false;
            usersacc1.Visible = false;
            loghistory1.Visible = false;
            titlelabel.Text = "ADD, EDIT AND DELETE STUDENT";
            recordbtn.BackColor = Color.RoyalBlue;
            crudbtn.BackColor = Color.Gray;
            userbtn.BackColor = Color.RoyalBlue;
            logbtn.BackColor = Color.RoyalBlue;
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            usersacc1.Visible = true;
            studentrecords1.Visible = false;
            usersbtn.Visible = false;
            loghistory1.Visible = false;
            titlelabel.Text = "USERS ACCOUNT";
            recordbtn.BackColor = Color.RoyalBlue;
            crudbtn.BackColor = Color.RoyalBlue;
            userbtn.BackColor = Color.Gray;
            logbtn.BackColor = Color.RoyalBlue;
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            loghistory1.Visible = true;
            usersacc1.Visible = false;
            studentrecords1.Visible = false;
            usersbtn.Visible = false;
            titlelabel.Text = "LOG HISTORY";
            recordbtn.BackColor = Color.RoyalBlue;
            crudbtn.BackColor = Color.RoyalBlue;
            userbtn.BackColor = Color.RoyalBlue;
            logbtn.BackColor = Color.Gray;
        }

        private void adminform_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
