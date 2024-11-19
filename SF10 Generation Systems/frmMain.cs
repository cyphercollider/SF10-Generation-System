using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using System.IO;

namespace SF10_Generation_Systems
{
    public partial class frmMain : Form
    {
        public void openFile()
        {


        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        public bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                if (fpnlMenu.Width == 180)
                {
                    menuTransition.Enabled = false;
                }
                else
                {
                    fpnlMenu.Width += 10 ;
                }
            }
            else
            {
                if (fpnlMenu.Width == 60)
                {
                    menuTransition.Enabled = false;
                }
                else
                {
                    fpnlMenu.Width -= 10;
                }
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuExpand = !menuExpand;
            menuTransition.Enabled = true;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (fpnlFileMenu.Height == 150)
            {
                fpnlFileMenu.Height = 50;
                fpnlOpenMenu.Height = 50;
            }
            else
            {
                fpnlFileMenu.Height = 150;
            }
        }

        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            if(fpnlOpenMenu.Height == 150)
            {
                fpnlFileMenu.Height = 150;
                fpnlOpenMenu.Height = 50;
            }
            else
            {
                fpnlFileMenu.Height = 250;
                fpnlOpenMenu.Height = 150;
            }
        }

        private void btnOpenData_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Console.WriteLine();
                    String filepath = openFileDialog1.FileName;
                    Stream File = openFileDialog1.OpenFile();

                    SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

                    ExcelFile excel = ExcelFile.Load(filepath);


                    DataTable dataTable = new DataTable();


                    // Select the first worksheet from the file.
                    ExcelWorksheet worksheet = excel.Worksheets[0];

                    for (int x = 0; x < worksheet.Rows[1].AllocatedCells.Count; x++)
                    {
                        dataTable.Columns.Add(worksheet.Cells[0, x].Value.ToString(), typeof(string));
                    }

                    // Extract the data from an Excel worksheet to the DataTable.
                    worksheet.ExtractToDataTable(dataTable, new ExtractToDataTableOptions(1, 0, 20));


                    dataGridView1.DataSource = dataTable;

                    // Focus tab control to view spreadsheet

                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show("Error", ex.StackTrace);
                }
            }
        }
    }
}
