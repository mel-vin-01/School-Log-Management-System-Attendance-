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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Excel = Microsoft.Office.Interop.Excel;

namespace Schoollogmanagementsystem
{
    public partial class studentrecords : UserControl
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        public studentrecords()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            m_Collection = m_Database.GetCollection<record>("studentrecord");
            loadAll();
        }
        private void loadAll()
        {
            var filter = Builders<record>.Filter.Empty;
            var show_collection = m_Collection.Find(filter)
                .SortBy(a => a.studentID)
                .ToList();
            var size = show_collection.Count();
            label6.Text = size.ToString() + " Records";

            dgrecord.DataSource = show_collection;

           
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            var filter = Builders<record>.Filter.Eq(a => a.studentID, searchtxt.Text) |  Builders<record>.Filter.Eq(a => a.lastname, searchtxt.Text.ToUpper()) | Builders<record>.Filter.Eq(a => a.firstname, searchtxt.Text.ToUpper());
            var search = m_Collection.Find(filter).ToList();
            dgrecord.DataSource = search;
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void dgrecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                studidtxt.Text = dgrecord.Rows[e.RowIndex].Cells[1].Value.ToString();
                fnametxt.Text = dgrecord.Rows[e.RowIndex].Cells[2].Value.ToString();
                mnametxt.Text = dgrecord.Rows[e.RowIndex].Cells[3].Value.ToString();
                lnametxt.Text = dgrecord.Rows[e.RowIndex].Cells[4].Value.ToString();
                gendertxt.Text = dgrecord.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtcontact.Text = dgrecord.Rows[e.RowIndex].Cells[6].Value.ToString();
                studagetxt.Text = dgrecord.Rows[e.RowIndex].Cells[7].Value.ToString();
                gradelvltxt.Text = dgrecord.Rows[e.RowIndex].Cells[8].Value.ToString();
                studguardtxt.Text = dgrecord.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch
            {

            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update data?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var filter = Builders<record>.Filter.Eq(a => a.studentID, studidtxt.Text);
                var update = Builders<record>.Update.Set(a => a.firstname, fnametxt.Text.ToUpper())
                    .Set(a => a.middlename, mnametxt.Text.ToUpper())
                    .Set(a => a.lastname, lnametxt.Text.ToUpper())
                    .Set(a => a.gender, gendertxt.Text.ToUpper())
                    .Set(a => a.contactno, decimal.Parse(txtcontact.Text))
                    .Set(a => a.age, Convert.ToInt32(studagetxt.Text))
                    .Set(a => a.gradelvl, Convert.ToInt32(gradelvltxt.Text))
                    .Set(a => a.guardianname, studguardtxt.Text.ToUpper());
                m_Collection.UpdateOne(filter, update);
                loadAll();
                Clear();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {     
            DialogResult result = MessageBox.Show("Are you sure you want to delete data?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var filter = Builders<record>.Filter.Eq(a => a.studentID, studidtxt.Text);
                m_Collection.DeleteOne(filter);
                MessageBox.Show("Delete Successfully!");
                Clear();
                loadAll(); 
            }                               
        }

        private void toexcelbtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application apps = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = apps.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            //apps.Visible = true;
            worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            worksheet.Name = "Export To Excel";

            for (int i = 1; i < dgrecord.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgrecord.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgrecord.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgrecord.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgrecord.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ouput";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            apps.Quit();
        }

        private void dgrecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Clear()
        {   
            Panel panel = panel7;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
            foreach (Control c in panel.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.SelectedIndex = -1;
                }
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

                if (count > 0)
                {
                    throw new Exception("A document with same value for 'Student Id'is already exists");
                }
                m_Collection.InsertOne(add);
                MessageBox.Show("New Data Saved!");
                Clear();
                loadAll();
                refreshbtn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
