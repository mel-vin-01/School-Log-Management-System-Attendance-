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
    public partial class usersacc : UserControl
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        IMongoCollection<Userrecord> u_Collection;
        public usersacc()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            m_Collection = m_Database.GetCollection<record>("studentrecord");
            u_Collection = m_Database.GetCollection<Userrecord>("users");
            loadAll();
        }
        private void loadAll()
        {
            var filter = Builders<Userrecord>.Filter.Empty;
            var show_collection = u_Collection.Find(filter).ToList();
            dguser.DataSource = show_collection;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usersacc_Load(object sender, EventArgs e)
        {

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filter = Builders<Userrecord>.Filter.Eq(a => a.username, searchtxt.Text.ToUpper());
            var search = u_Collection.Find(filter).ToList();
            dguser.DataSource = search;
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
         MessageBox.Show("Delete Record?");
        try
         {
           var filter = Builders<Userrecord>.Filter.Eq(a => a.username, searchtxt.Text.ToUpper());
           u_Collection.DeleteOne(filter);

           MessageBox.Show("Delete Successfully!");              
         }
        catch
         {
            MessageBox.Show("Cant's Delete Data something's error!");
         }
            loadAll();
        }
    }
}
