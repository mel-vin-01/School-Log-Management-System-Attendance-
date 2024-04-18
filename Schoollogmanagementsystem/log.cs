using MongoDB.Driver;
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
    public partial class log : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        IMongoCollection<logins> g_Collection;
        public log()
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

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {

                var filter = Builders<record>.Filter.Eq(a => a.studentID, txtlogin.Text);
                var search = m_Collection.Find(filter).ToList();
                

                if (search.Count == 1)
                {
                    if (txtlogin.Text == search[0].studentID)
                    {
                        MessageBox.Show("Welcome Student " + search[0].firstname);
                        txtlogin.Clear();

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
                    else
                    {
                        
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void log_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
