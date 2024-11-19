namespace SF10_Generation_Systems
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlButtonPanel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.fpnlFileMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlButtonPanel2 = new System.Windows.Forms.Panel();
            this.btnFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.fpnlOpenMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpenData = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fpnlMenu.SuspendLayout();
            this.pnlButtonPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.fpnlFileMenu.SuspendLayout();
            this.pnlButtonPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fpnlOpenMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 1;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Excel Spreadsheet (*.xlsx)|*.xlsx|All files (*.*)|*.*\"";
            this.openFileDialog1.Title = "Browse for Student Data";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(60, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 450);
            this.panel4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 51);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(740, 399);
            this.panel8.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 51);
            this.panel5.TabIndex = 1;
            // 
            // fpnlMenu
            // 
            this.fpnlMenu.BackColor = System.Drawing.Color.White;
            this.fpnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlMenu.Controls.Add(this.pnlButtonPanel1);
            this.fpnlMenu.Controls.Add(this.panel7);
            this.fpnlMenu.Controls.Add(this.fpnlFileMenu);
            this.fpnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpnlMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlMenu.Location = new System.Drawing.Point(0, 0);
            this.fpnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlMenu.Name = "fpnlMenu";
            this.fpnlMenu.Size = new System.Drawing.Size(60, 450);
            this.fpnlMenu.TabIndex = 6;
            this.fpnlMenu.WrapContents = false;
            // 
            // pnlButtonPanel1
            // 
            this.pnlButtonPanel1.Controls.Add(this.btnMenu);
            this.pnlButtonPanel1.Location = new System.Drawing.Point(3, 3);
            this.pnlButtonPanel1.Name = "pnlButtonPanel1";
            this.pnlButtonPanel1.Size = new System.Drawing.Size(170, 43);
            this.pnlButtonPanel1.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(170, 43);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "           Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(3, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(170, 43);
            this.panel7.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(170, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "           Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fpnlFileMenu
            // 
            this.fpnlFileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.fpnlFileMenu.Controls.Add(this.pnlButtonPanel2);
            this.fpnlFileMenu.Controls.Add(this.panel2);
            this.fpnlFileMenu.Controls.Add(this.fpnlOpenMenu);
            this.fpnlFileMenu.Location = new System.Drawing.Point(0, 98);
            this.fpnlFileMenu.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlFileMenu.Name = "fpnlFileMenu";
            this.fpnlFileMenu.Size = new System.Drawing.Size(175, 50);
            this.fpnlFileMenu.TabIndex = 6;
            // 
            // pnlButtonPanel2
            // 
            this.pnlButtonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtonPanel2.Controls.Add(this.btnFile);
            this.pnlButtonPanel2.Location = new System.Drawing.Point(3, 3);
            this.pnlButtonPanel2.Name = "pnlButtonPanel2";
            this.pnlButtonPanel2.Size = new System.Drawing.Size(170, 43);
            this.pnlButtonPanel2.TabIndex = 4;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.Location = new System.Drawing.Point(0, 0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFile.Size = new System.Drawing.Size(170, 43);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "           File";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewProject);
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 43);
            this.panel2.TabIndex = 5;
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProject.Image")));
            this.btnNewProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.Location = new System.Drawing.Point(0, 0);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNewProject.Size = new System.Drawing.Size(170, 43);
            this.btnNewProject.TabIndex = 2;
            this.btnNewProject.Text = "           New Project";
            this.btnNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.UseVisualStyleBackColor = false;
            // 
            // fpnlOpenMenu
            // 
            this.fpnlOpenMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.fpnlOpenMenu.Controls.Add(this.panel1);
            this.fpnlOpenMenu.Controls.Add(this.panel3);
            this.fpnlOpenMenu.Controls.Add(this.panel6);
            this.fpnlOpenMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlOpenMenu.Location = new System.Drawing.Point(0, 98);
            this.fpnlOpenMenu.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlOpenMenu.Name = "fpnlOpenMenu";
            this.fpnlOpenMenu.Size = new System.Drawing.Size(175, 50);
            this.fpnlOpenMenu.TabIndex = 6;
            this.fpnlOpenMenu.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 43);
            this.panel1.TabIndex = 5;
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenMenu.FlatAppearance.BorderSize = 0;
            this.btnOpenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenMenu.Image")));
            this.btnOpenMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenMenu.Location = new System.Drawing.Point(0, 0);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOpenMenu.Size = new System.Drawing.Size(170, 43);
            this.btnOpenMenu.TabIndex = 2;
            this.btnOpenMenu.Text = "           Open...";
            this.btnOpenMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenMenu.UseVisualStyleBackColor = false;
            this.btnOpenMenu.Click += new System.EventHandler(this.btnOpenMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOpenData);
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 43);
            this.panel3.TabIndex = 4;
            // 
            // btnOpenData
            // 
            this.btnOpenData.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenData.FlatAppearance.BorderSize = 0;
            this.btnOpenData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenData.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenData.Image")));
            this.btnOpenData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenData.Location = new System.Drawing.Point(0, 0);
            this.btnOpenData.Name = "btnOpenData";
            this.btnOpenData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOpenData.Size = new System.Drawing.Size(170, 43);
            this.btnOpenData.TabIndex = 2;
            this.btnOpenData.Text = "           Open Data";
            this.btnOpenData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenData.UseVisualStyleBackColor = false;
            this.btnOpenData.Click += new System.EventHandler(this.btnOpenData_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnOpenProject);
            this.panel6.Location = new System.Drawing.Point(3, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 43);
            this.panel6.TabIndex = 6;
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenProject.FlatAppearance.BorderSize = 0;
            this.btnOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProject.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenProject.Image")));
            this.btnOpenProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenProject.Location = new System.Drawing.Point(0, 0);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOpenProject.Size = new System.Drawing.Size(170, 43);
            this.btnOpenProject.TabIndex = 2;
            this.btnOpenProject.Text = "           Open Project";
            this.btnOpenProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenProject.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.fpnlMenu);
            this.Name = "frmMain";
            this.Text = "SF10 Generation System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fpnlMenu.ResumeLayout(false);
            this.pnlButtonPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.fpnlFileMenu.ResumeLayout(false);
            this.pnlButtonPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.fpnlOpenMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel fpnlMenu;
        private System.Windows.Forms.Panel pnlButtonPanel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.FlowLayoutPanel fpnlFileMenu;
        private System.Windows.Forms.Panel pnlButtonPanel2;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.FlowLayoutPanel fpnlOpenMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpenData;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnOpenProject;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
    }
}