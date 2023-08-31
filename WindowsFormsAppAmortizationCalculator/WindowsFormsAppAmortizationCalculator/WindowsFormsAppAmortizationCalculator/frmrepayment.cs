using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAmortizationCalculator.Classes;

namespace WindowsFormsAppAmortizationCalculator
{
    public partial class frmrepayment : Form
    {
        public Amortizator RepayAmt;


        public frmrepayment()
        {
            InitializeComponent();
        }

        private void frmrepayment_Load(object sender, EventArgs e)
        {
            DislayRepaymentList();
            this.Text = "Loan Repayment Schedule of [" + RepayAmt.LoanID + ":" + RepayAmt.BrowerName + "]";

            lvwrepaymentlist.Columns[0].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[1].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[2].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[3].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[4].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;


        }

        public void DislayRepaymentList() {
            ListViewItem itm = null;

            lvwrepaymentlist.Items.Clear(); 


            if (RepayAmt == null) {
                return;
            }

            foreach (RepaymentSchedule rs in RepayAmt.getRepaymentSchedule()) {
                itm = lvwrepaymentlist.Items.Add(rs.RepaymentDate.ToString("dd-MMM-yyyy"));
                itm.SubItems.Add(rs.Monthly_Install_Amount.ToString("C"));
                itm.SubItems.Add(rs.PaidPrinciple.ToString("C"));
                itm.SubItems.Add(rs.PaidInterest.ToString("C"));
                itm.SubItems.Add(rs.RemainingBalance.ToString("C"));
            }        
        }

        private void frmrepayment_ResizeEnd(object sender, EventArgs e)
        {
         
        }

        private void frmrepayment_MaximumSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void frmrepayment_Resize(object sender, EventArgs e)
        {
            lvwrepaymentlist.Columns[0].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[1].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[2].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[3].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
            lvwrepaymentlist.Columns[4].Width = lvwrepaymentlist.Width / lvwrepaymentlist.Columns.Count;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void frmrepayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmmain = (frmMain)Application.OpenForms["frmMain"];
            //frmmain.checkfrmScheduleList = false;
        }
    }
}
