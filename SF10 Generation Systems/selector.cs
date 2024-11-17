using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF10_Generation_Systems
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            cbxStudent.Enabled = !chkAll.Checked;
        }
    }
}
