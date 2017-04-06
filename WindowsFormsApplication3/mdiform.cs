using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmmdi : Form
    {
        public frmmdi()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmemployee frm = new frmemployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmmdi_Load(object sender, EventArgs e)
        {

        }
    }
}
