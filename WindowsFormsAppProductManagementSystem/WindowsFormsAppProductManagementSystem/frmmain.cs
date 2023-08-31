using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProductManagementSystem
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
         
        }

        private void openProductionManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproductmanagment frm = new frmproductmanagment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
