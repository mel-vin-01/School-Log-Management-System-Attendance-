using Microsoft.Office.Interop.Excel;
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
using System.Xml.Linq;

namespace Schoollogmanagementsystem
{
    public partial class crudform : UserControl
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        IMongoCollection<Userrecord> u_Collection;
        public crudform()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            m_Collection = m_Database.GetCollection<record>("studentrecord");
            u_Collection = m_Database.GetCollection<Userrecord>("users");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                fnametxt.Focus();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                record add = new record();
                add.studentID = studidtxt.Text;
                add.firstname = fnametxt.Text.ToUpper();
                add.middlename = mnametxt.Text.ToUpper();
                add.lastname = lnametxt.Text.ToUpper();
                add.gender = gendertxt.Text.ToUpper();
                add.contactno = decimal.Parse(txtcontact.Text);
                add.age = Convert.ToInt32(studagetxt.Text);
                add.gradelvl = Convert.ToInt32(gradelvltxt.Text.ToUpper());
                add.guardianname = studguardtxt.Text.ToUpper();

                var filter = Builders<record>.Filter.Eq(a => a.studentID, studidtxt.Text);
                var count = m_Collection.CountDocuments(filter);

                if(count > 0)
                {
                    throw new Exception("A document with same value for 'Student Id'is already exists");
                }
                m_Collection.InsertOne(add);
                MessageBox.Show("New Data Saved!");
                //Clear
               studidtxt.Clear();
                fnametxt.Clear();
                mnametxt.Clear();
                lnametxt.Clear();
                gendertxt.SelectedIndex = -1;
                txtcontact.Clear();
                studagetxt.Clear();
                gradelvltxt.SelectedIndex = -1;
                studguardtxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = Builders<record>.Filter.Eq(a => a.studentID, studidtxt.Text);
                var update = Builders<record>.Update.Set(a => a.firstname, fnametxt.Text)
                    .Set(a => a.middlename, mnametxt.Text)
                    .Set(a => a.lastname, lnametxt.Text)
                    .Set(a => a.gender, gendertxt.Text)
                    .Set(a => a.contactno, decimal.Parse(txtcontact.Text))
                    .Set(a => a.age, Convert.ToInt32(studagetxt.Text))
                    .Set(a => a.gradelvl, Convert.ToInt32(gradelvltxt.Text))
                    .Set(a => a.guardianname, studguardtxt.Text);
                m_Collection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = Builders<record>.Filter.Eq(a => a.studentID, studidtxt.Text);
                m_Collection.DeleteOne(filter);

                MessageBox.Show("Delete Successfully!");

                //Clear
                studidtxt.Clear();
                fnametxt.Clear();
                mnametxt.Clear();
                lnametxt.Clear();
                gendertxt.SelectedIndex = -1;
                txtcontact.Clear();
                studagetxt.Clear();
                gradelvltxt.SelectedIndex = -1;
                studguardtxt.Clear();
            }
            catch
            {
                MessageBox.Show("Cant's Delete Data something's error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Userrecord addnew = new Userrecord();
                addnew.firstname = userfnametxt.Text.ToUpper();
                addnew.middlename = usermnametxt.Text.ToUpper();
                addnew.lastname = userlnametxt.Text.ToUpper();
                addnew.username = usernametxt.Text;
                addnew.role = userroletxt.Text.ToUpper();
                addnew.password = userpasswordtxt.Text;
                addnew.date = label16.Text;

                u_Collection.InsertOne(addnew);
                MessageBox.Show("New Data Saved!");
                
                //Clear
                userfnametxt.Clear();
                usermnametxt.Clear();
                userlnametxt.Clear();
                usernametxt.Clear();
                userroletxt.SelectedIndex = -1;
                userpasswordtxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crudform_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label16.Text = DateTime.Now.ToShortDateString();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void crudform_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
