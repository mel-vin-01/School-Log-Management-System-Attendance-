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
    public partial class logmanagement : Form
    {
        public logmanagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log login = new log();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logOut lo = new logOut();
            lo.ShowDialog();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            admnlog view = new admnlog();
            view.ShowDialog();
        }

        private void viewbtn_Click_1(object sender, EventArgs e)
        {
            viewhistory view = new viewhistory();
            view.Show();
        }

        private void logmanagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                adminform forms = new adminform();
                forms.Show();
            }
        }
    }
}
