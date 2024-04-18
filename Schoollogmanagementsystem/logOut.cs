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
    public partial class logOut : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        IMongoCollection<logins> g_Collection;
        public logOut()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            m_Collection = m_Database.GetCollection<record>("studentrecord");
            g_Collection = m_Database.GetCollection<logins>("historyrecord");
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOut_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            try
            {

                var filter = Builders<record>.Filter.Eq(a => a.studentID, txtlogout.Text);
                var search = m_Collection.Find(filter).ToList();

                if (search.Count == 1)
                {
                    if (txtlogout.Text == search[0].studentID)
                    {
                        MessageBox.Show("See you student!! " + search[0].firstname);
                        var flter = Builders<logins>.Filter.Eq(a => a.date, label3.Text.ToString()) & Builders<logins>.Filter.Eq(a => a.studentID, txtlogout.Text);
                        var logout = Builders<logins>.Update.Set(a => a.timeout, label2.Text.ToString()).Set(a => a.HasLoggedOut, true);
                        var sarch = g_Collection.FindOneAndUpdate(flter, logout).ToString();
                        txtlogout.Clear();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
