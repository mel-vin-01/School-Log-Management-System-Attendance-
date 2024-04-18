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
using Excel = Microsoft.Office.Interop.Excel;

namespace Schoollogmanagementsystem
{
    public partial class loghistory : UserControl
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<record> m_Collection;
        IMongoCollection<logins> g_Collection;
        IMongoCollection<userlogs> l_Collection;
        public loghistory()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb://localhost:27017");
            m_Database = m_Client.GetDatabase("AttendanceManagement");
            m_Collection = m_Database.GetCollection<record>("studentrecord");
            g_Collection = m_Database.GetCollection<logins>("historyrecord");
            l_Collection = m_Database.GetCollection<userlogs>("userloghistory");
        loadAll();
            clearColumns();
            loadAll2();
        }
        private void loadAll()
        {
            var filter = Builders<logins>.Filter.Empty;
            var show_collection = g_Collection.Find(filter).ToList();
            var size = show_collection.Count();
            label3.Text = size.ToString() + " Records";
            dghistory.DataSource = show_collection;
        }

        private void loadAll2()
        {
            var filter = Builders<userlogs>.Filter.Empty;
            var show_collection = l_Collection.Find(filter).ToList();
            dguserhistory.DataSource = show_collection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filter = Builders<logins>.Filter.Eq(a => a.studentID, searchtxt.Text) & Builders<logins>.Filter.Gte(a => a.date, datefrom.Value.ToShortDateString()) & Builders<logins>.Filter.Lte(a => a.date, dateto.Value.ToShortDateString());
            var search = g_Collection.Find(filter).ToList();
            dghistory.DataSource = search;
            clearColumns();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadAll();
            loadAll2();
            clearColumns();
        }

        private void toexcelbtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application apps = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = apps.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
           
            worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Excel.Worksheet)workbook.ActiveSheet;


            worksheet.Name = "Export To Excel";

            for (int i = 1; i < dghistory.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dghistory.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dghistory.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dghistory.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dghistory.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ouput";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            apps.Quit();
        }

        private void datefrom_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void loghistory_Load(object sender, EventArgs e)
        {
            clearColumns();
        }
        private void clearColumns()
        {
            dghistory.Columns.Remove("id");
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            var filter = Builders<logins>.Filter.Eq(a => a.studentID, searchtxt.Text) & Builders<logins>.Filter.Gte(a => a.date, datefrom.Value.ToShortDateString()) & Builders<logins>.Filter.Lte(a => a.date, dateto.Value.ToShortDateString());
            var search = g_Collection.Find(filter).ToList();
            dghistory.DataSource = search;
            clearColumns();
        }
    }
}
