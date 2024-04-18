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
    public partial class viewhistorycontrol : UserControl
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        IMongoCollection<logins> g_Collection;
        IMongoCollection<userlogs> l_Collection;
        public viewhistorycontrol()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            m_Collection = m_Database.GetCollection<record>("studentrecord");
            g_Collection = m_Database.GetCollection<logins>("historyrecord");
            l_Collection = m_Database.GetCollection<userlogs>("userloghistory");
            loadAll();
        }
        private void loadAll()
        {
            var filter = Builders<logins>.Filter.Empty;
           
            var show_collection = g_Collection.Find(filter).SortByDescending(a => a.Id).ToList();
            dghistory.DataSource = show_collection;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadAll();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            var filter = Builders<logins>.Filter.Eq(a => a.studentID, searchtxt.Text.ToUpper());
            var search = g_Collection.Find(filter).ToList();
            dghistory.DataSource = search;
        }
    }
}
