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
    public partial class admnlog : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Userrecord> u_Collection;
        IMongoCollection<userlogs> l_Collection;
        public admnlog()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            u_Collection = m_Database.GetCollection<Userrecord>("users");
            l_Collection = m_Database.GetCollection<userlogs>("userloghistory");
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            try
            {

                var filter = Builders<Userrecord>.Filter.Eq(a => a.username, usernametxt.Text) & Builders<Userrecord>.Filter.Eq(a => a.password, passwordtxt.Text);
                var search = u_Collection.Find(filter).ToList();


                if (search.Count == 1)
                {
                    if (usernametxt.Text == search[0].username & passwordtxt.Text == search[0].password)
                    {  

                        adminform adform = new adminform();
                        adform.Show();
                        
                        MessageBox.Show("Welcome! " + search[0].username);
                       usernametxt.Clear();
                        passwordtxt.Clear();

                        userlogs add = new userlogs();
                        add.username = search[0].username;
                        add.firstname = search[0].firstname;
                        add.lastname = search[0].lastname;
                        add.role = search[0].role;
                        add.date = label3.Text.ToString();
                        l_Collection.InsertOne(add);                      
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

        private void txtlogout_TextChanged(object sender, EventArgs e)
        {

        }

        private void admnlog_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
