using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot.WinForms;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using System.IO;
using System.Configuration;

namespace SF10_Generation_Systems
{
    public partial class frmMain : Form
    {
        public void openFile()
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
                    tbcOperationPanel.SelectTab(1);
                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show("Error", ex.StackTrace);
                }
            }
        }
        public frmMain()
        {
            InitializeComponent();
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selector seletor = new Selector();
            seletor.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            this.panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
