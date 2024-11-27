using GemBox.Spreadsheet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SF10_Generation_Systems
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnOpenData_Click(object sender, EventArgs e) {
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

                    LinkLabel link = new LinkLabel();
                    link.Text = filepath;
                    link.Tag = filepath;
                    flowLayoutPanel1.Controls.Add(link);
                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show("Error", ex.StackTrace);
                }
            }
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            pageHandler.UpdatePage(pnlMain);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlSideBar.Width==160)
            {
                pnlSideBar.Width=43;
            }
            else
            {
                pnlSideBar.Width=160;
            }
            pageHandler.UpdatePage(pnlMain);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control control in pnlMain.Controls)
            {
                pageHandler.AddPage(control);
            }
            pageHandler.ChangePage(pnlHomePage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageHandler.PageFeedback(btnHome);
            pageHandler.ChangePage(pnlHomePage);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            pageHandler.PageFeedback(btnFile);
            pageHandler.ChangePage(pnlFilePage);
        }

        private void btnSpreadsheet_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageHandler.PageFeedback(btnAccount);
            pageHandler.ChangePage(pnlAccountPage);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pageHandler.PageFeedback(btnSettings);
            pageHandler.ChangePage(pnlSettingsPage);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pageHandler.ChangePage(pnlDataViewerPage);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pnlNoDataWindow.Visible = false;
            pnlDataWindow.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pageHandler.ChangePage(pnlDataViewerPage);
            pnlNoDataWindow.Visible = false;
            pnlDataWindow.Visible = true;
        }
    }
    public static class pageHandler
    {
        public static List<Control> LastButton = new List<Control>();
        public static List<Control> Pages = new List<Control>();
        public static List<String> PageNames = new List<String>();
        public static void AddPage(Control control)
        {
            Pages.Add(control);
            PageNames.Add(control.Name);
        }
        public static void ChangePage(String pageName)
        {
            for (int x = 0; x < Pages.Count; x++)
            {
                if (PageNames[x]!=pageName)
                {
                    Pages[x].Visible = false;
                }
                else
                {
                    Pages[x].Visible = true;
                }
            }
        }
        public static void ChangePage(Control control)
        {
            for (int x = 0; x < Pages.Count; x++)
            {
                if (Pages[x]!=control)
                {
                    Pages[x].Visible = false;
                }
                else
                {
                    Pages[x].Visible = true;
                }
            }
            pageHandler.UpdatePage(control.Parent);
        }
        public static void UpdatePage(Control pnlMain)
        {
            foreach (Control cnt in pnlMain.Controls)
            {
                foreach (Control c in cnt.Controls)
                {
                    c.Left = (pnlMain.Width - c.Width) / 2;
                    c.Top = (pnlMain.Height - c.Height) / 2;
                }
            }
        }
        public static void PageFeedback(Control control)
        {
            if(LastButton.Count < 1)
            {
                LastButton.Add(new Control());
            }
            LastButton.Add(control);
            LastButton[0].BackColor = System.Drawing.Color.FromArgb(158, 223, 156);
            LastButton[1].BackColor = System.Drawing.Color.FromArgb(98, 130, 93);
            LastButton.RemoveAt(0);
        }
    }
}
