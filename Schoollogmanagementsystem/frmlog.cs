using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoollogmanagementsystem
{
    public partial class frmlog : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        IMongoCollection<logins> g_Collection;
        public frmlog()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            m_Collection = m_Database.GetCollection<record>("studentrecord");
            g_Collection = m_Database.GetCollection<logins>("historyrecord");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            viewhistory view = new viewhistory();
            view.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = Builders<record>.Filter.Eq(a => a.studentID, txtlog.Text);
                var search = m_Collection.Find(filter).ToList();

                if (search.Count == 1)
                {
                    if (txtlog.Text == search[0].studentID)
                    {
                        MessageBox.Show("See you student!! " + search[0].firstname);
                        var flter = Builders<logins>.Filter.Eq(a => a.date, label3.Text.ToString()) & Builders<logins>.Filter.Eq(a => a.studentID, txtlog.Text);
                        var logout = Builders<logins>.Update.Set(a => a.timeout, label2.Text.ToString()).Set(a => a.HasLoggedOut, true);
                        var sarch = g_Collection.FindOneAndUpdate(flter, logout).ToString();
                        txtlog.Clear();
                        MessageBox.Show("Logout successful.");
                    }
                }
                else
                {
                    MessageBox.Show("No Account Found!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = Builders<record>.Filter.Eq(a => a.studentID, txtlog.Text);
                var search = m_Collection.Find(filter).ToList();
                if (search.Count == 1)
                {
                    if (txtlog.Text == search[0].studentID)
                    {
                        MessageBox.Show("Welcome Student " + search[0].firstname);
                        txtlog.Clear();

                        logins log = new logins();
                        log.studentID = search[0].studentID;
                        log.name = search[0].firstname;
                        log.lastname = search[0].lastname;
                        log.date = label3.Text.ToString();
                        log.timein = label2.Text.ToString();
                        log.timeout = label4.Text.ToString();
                        log.HasLoggedIn = true;
                        log.HasLoggedOut = false;
                        g_Collection.InsertOne(log);
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmlog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                adminform forms = new adminform();
                forms.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void frmlog_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
