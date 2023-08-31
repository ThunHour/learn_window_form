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
    public partial class frmmasterform : Form
    {
        public frmmasterform()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain frm = (frmmain)this.ActiveMdiChild;
            SaveFileDialog sdf = null;

            if (frm.AmortizorMgr.FileName != "Untitled")
            {
                sdf = new SaveFileDialog();
                sdf.Title = "Save Loan List";
                sdf.Filter = "Loan File(*.lnf)|*.lnf|All File(*.*)|*.*";
                sdf.DefaultExt = "lnf";
                sdf.FilterIndex = 0;

                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    this.lblstatus.Text = frm.AmortizorMgr.SaveToFile(sdf.FileName);
                    frm.AmortizorMgr.FileName = sdf.FileName;
                    frm.Text = "Loan List of " + frm.AmortizorMgr.FileName;
                }
            }
            else
            {
                saveToolStripMenuItem_Click(null, null);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            frm.MdiParent = this;
            frm.Show();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain frm = (frmmain)this.ActiveMdiChild;
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
                    this.lblstatus.Text = frm.AmortizorMgr.SaveToFile(sdf.FileName);
                    frm.AmortizorMgr.FileName = sdf.FileName;
                }
            }
            else {
                this.lblstatus.Text = frm.AmortizorMgr.Save();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            frmmain frm = null;
           
            ofd.Title = "Open Loan List";
            ofd.Filter = "Loan File(*.lnf)|*.lnf|All File(*.*)|*.*";
            ofd.DefaultExt = "lnf";
            ofd.FilterIndex = 0;

            if (ofd.ShowDialog() == DialogResult.OK) {
                frm = new frmmain();
                frm.MdiParent = this;
                lblstatus.Text = frm.AmortizorMgr.ReadFromFile(ofd.FileName);
                frm.AmortizorMgr.FileName = ofd.FileName;
                frm.Show();
                frm.btnmovefirst_Click(null, null);
            }



        }

        private void frmmasterform_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
        }

        public void SetStatus(string status) {
            this.lblstatus.Text = status;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmmain frm = (frmmain)this.ActiveMdiChild;
            SaveFileDialog sdf = null;
            sdf = new SaveFileDialog();
            sdf.Title = "Export to SCV";
            sdf.Filter = "CSV File(*.csv)|*.csv|All File(*.*)|*.*";
            sdf.DefaultExt = "csv";
            sdf.FilterIndex = 0;

            if (sdf.ShowDialog() == DialogResult.OK) {
                lblstatus.Text= frm.AmortizorMgr.ExportToCSV(sdf.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmmain frm = (frmmain)this.ActiveMdiChild;

            if (frm == null)
            {
                saveAsToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                exptoolStripMenuItem2.Enabled = false;
            }
            else {
                saveAsToolStripMenuItem.Enabled = frm.AmortizorMgr.Count>0;
                saveToolStripMenuItem.Enabled = frm.AmortizorMgr.Count > 0;
                exptoolStripMenuItem2.Enabled = frm.AmortizorMgr.Count > 0;
            }
           
        }
    }
}
