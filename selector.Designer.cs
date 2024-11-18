
namespace SF10_Generation_Systems
{
    partial class Selector
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
            this.cbxStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnFileGenerate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbxStudent
            // 
            this.cbxStudent.Enabled = false;
            this.cbxStudent.FormattingEnabled = true;
            this.cbxStudent.Location = new System.Drawing.Point(12, 25);
            this.cbxStudent.Name = "cbxStudent";
            this.cbxStudent.Size = new System.Drawing.Size(134, 21);
            this.cbxStudent.TabIndex = 0;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(12, 9);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(44, 13);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student";
            // 
            // btnFileGenerate
            // 
            this.btnFileGenerate.Location = new System.Drawing.Point(12, 62);
            this.btnFileGenerate.Name = "btnFileGenerate";
            this.btnFileGenerate.Size = new System.Drawing.Size(134, 23);
            this.btnFileGenerate.TabIndex = 2;
            this.btnFileGenerate.Text = "Generate Documents";
            this.btnFileGenerate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print Documents";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(164, 27);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(71, 17);
            this.chkAll.TabIndex = 5;
            this.chkAll.Text = "Everyone";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 98);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFileGenerate);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.cbxStudent);
            this.Name = "Selector";
            this.Text = "Select Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnFileGenerate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkAll;
    }
}