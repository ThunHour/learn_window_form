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
    public partial class fromloanlist : Form
    {
        private int indexOfRecordChecked;
        public frmamrtizationcalculator frm = null;
        public frmMain mainfrm = (frmMain)Application.OpenForms["frmMain"];
        public fromloanlist()
        {
            InitializeComponent();
        }

        private void fromloanlist_Load(object sender, EventArgs e)
        {
            timerInListBorrower.Start();

            frm = (frmamrtizationcalculator)Application.OpenForms["frmamrtizationcalculator"];
            DisplayBorrowerDetail(frm.AmortizorMgr.getListOf());
            txtTotalAmount.Text = getTotalAmountLoaner(frm.AmortizorMgr.getListOf()).ToString("C");

        }
        private float getTotalAmountLoaner(List<Amortizator> obj)
        {
            float temp = 0;
            if (obj == null || obj.Count == 0)
            {
                return temp;
            }
            foreach (Amortizator amt in obj)
            {
                temp += amt.LoanAmount;
            }
            return temp;

        }
        public void DisplayBorrowerDetail(List<Amortizator> obj)
        {
            lvwBorrowerList.Items.Clear();
            if (obj == null)
            {
                return;
            }
            ListViewItem item = null;
            foreach (Amortizator amt in obj)
            {
                item = lvwBorrowerList.Items.Add(amt.LoanID);
                item.SubItems.Add(amt.BrowerName);
                item.SubItems.Add(amt.LoanAmount.ToString("C"));
                item.SubItems.Add(amt.Loan_tenure_in_year.ToString());
                item.SubItems.Add(amt.Effective_Date.ToString("dd-MMM-yyyy"));

            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Amortizator obj = frm.AmortizorMgr.getListOf()[indexOfRecordChecked];
            frmrepayment frmSche = new frmrepayment();

            frmSche.MdiParent = this.MdiParent;
            frmSche.RepayAmt = obj;
            frmSche.Show();

            //if (mainfrm.checkfrmScheduleList == false)
            //{
            //    frmSche.MdiParent = this.MdiParent;
            //    frmSche.RepayAmt = obj;
            //    frmSche.Show();
            //    mainfrm.checkfrmScheduleList = true;
            //}
        }

        private void fromloanlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainfrm.checkfrmLoanList = false;
        }

        private void timerInListBorrower_Tick(object sender, EventArgs e)
        {
            if (lvwBorrowerList.CheckedItems.Count == 1)
            {
                indexOfRecordChecked = getIndexOfrecord();
                btnViewRepaymentSchedule.Enabled = true;
            }
            else
            {
                btnViewRepaymentSchedule.Enabled = false;
            }
        }

        private void lvwBorrowerList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {

                Amortizator._SortLoanDetail = SortLoanDetail.LoanID;
                frm.AmortizorMgr.getListOf();
            }
            else if (e.Column == 1)
            {
                Amortizator._SortLoanDetail = SortLoanDetail.LoanName;
                frm.AmortizorMgr.getListOf();



            }
            else if (e.Column == 2)
            {
                Amortizator._SortLoanDetail = SortLoanDetail.LoanAmount;
                frm.AmortizorMgr.getListOf();
                    

            }
            else if (e.Column == 3)
            {
                Amortizator._SortLoanDetail = SortLoanDetail.LoanRatePerYear;
                frm.AmortizorMgr.getListOf();

            }
            else if (e.Column == 4)
            {
                Amortizator._SortLoanDetail = SortLoanDetail.LoanDate;
                frm.AmortizorMgr.getListOf();
                  
            }
            else if (e.Column == 5)
            {
                Amortizator._SortLoanDetail = SortLoanDetail.Loantenure;
                frm.AmortizorMgr.getListOf();

            }

            DisplayBorrowerDetail(frm.AmortizorMgr.getListOf());
        }
        public int getIndexOfrecord()
        {
            int temp = 0;
            for (int i = 0; i < lvwBorrowerList.Items.Count; i++)
            {
                if (lvwBorrowerList.Items[i].Equals(lvwBorrowerList.CheckedItems[0]))
                {
                    temp = i;

                }
            }
            return temp;
        }

        private void lvwBorrowerList_Resize(object sender, EventArgs e)
        {
            lvwBorrowerList.Columns[0].Width = lvwBorrowerList.Width / 5;
            lvwBorrowerList.Columns[1].Width = lvwBorrowerList.Width / 5;
            lvwBorrowerList.Columns[2].Width = lvwBorrowerList.Width / 5;
            lvwBorrowerList.Columns[3].Width = lvwBorrowerList.Width / 5;
            lvwBorrowerList.Columns[4].Width = lvwBorrowerList.Width / 5;
        }
    }
}
