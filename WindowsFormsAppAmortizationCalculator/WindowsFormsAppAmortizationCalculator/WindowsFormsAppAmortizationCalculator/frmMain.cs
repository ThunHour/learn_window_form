using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAmortizationCalculator
{
    public partial class frmMain : Form
    {

        ////check form for preven duplicate form openning 
        //public bool checkfrmLoanList = false;
        //public bool checkfrmScheduleList = false;
        //public bool checkfrmCalculator = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmamrtizationcalculator frm = new frmamrtizationcalculator();
            //frm.MdiParent = this;
            //frm.Show();
            //if (checkfrmCalculator == false)
            //{
            //    checkfrmCalculator = true;
            //    frm.Show();
            //}
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmamrtizationcalculator frm = (frmamrtizationcalculator)this.ActiveMdiChild;
            SaveFileDialog sdf = null;
            if (frm.AmortizorMgr.FileName == "Untitled")
            {
                sdf = new SaveFileDialog();
                sdf.Title = "Save Loan List";
                sdf.Filter = "Loan File(*.lnf)|*.lnf|All File(*.*)|*.*";
                sdf.DefaultExt = "lnf";
                sdf.FilterIndex = 0;

                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    this.lblStatus.Text = frm.AmortizorMgr.SaveTofile(sdf.FileName);
                    frm.AmortizorMgr.FileName = sdf.FileName;
                }
            }
            else
            {
                this.lblStatus.Text = frm.AmortizorMgr.Save();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmamrtizationcalculator frm =new frmamrtizationcalculator();
            frm.MdiParent=this; 
            frm.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
