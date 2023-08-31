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
    public partial class frmmain : Form
    {
        public GenericNavigator<Amortizator> AmortizorMgr = new GenericNavigator<Amortizator>();


        public frmmain()
        {
            InitializeComponent();
        }





        private void frmmain_Load(object sender, EventArgs e)
        {
            //Amortizator Am_test = null;

            //Am_test = new Amortizator(100000, 0.1f, 12, 20,DateTime.Today);
            //AmortizorMgr.Add(Am_test);


            //Am_test = new Amortizator(200000, 0.1f, 12, 10, DateTime.Today);
            //AmortizorMgr.Add(Am_test);

            //Am_test = new Amortizator(300000, 0.1f, 12, 15, DateTime.Today;
            //AmortizorMgr.Add(Am_test);



            //MessageBox.Show(Am_test.getMonthlyPaymentAmount().ToString("C"));
            //Am_test.getRepaymentSchedule();

            AmortizorMgr.ObjectNavigated += AmortizorNavigated;
            this.Text = "Loan List of " + AmortizorMgr.FileName;



        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (AmortizorMgr.Count == 0)
            {
                txtloanid.Text = "CFLND0001";
                return;
            }
            txtloanid.Text = "CFLND" + (AmortizorMgr.Count + 1).ToString("D4");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Amortizator obj = null;


            obj = new Amortizator();

            obj.LoanID = txtloanid.Text;
            obj.BrowerName = txtborrowername.Text;
            obj.LoanAmount = float.Parse(txtloanamount.Text);
            obj.InterestRate = float.Parse(txtinterestrate.Text) / 100;
            obj.Loan_tenure_in_year = float.Parse(txtloantenure.Text);
            obj.Effective_Date = dtpeffectivedate.Value.Date;
            obj.Monthly_in_year = 12;


            AmortizorMgr.Add(obj);

        }

        public void Display(Amortizator amt)
        {
            txtloanid.Text = amt.LoanID;
            txtborrowername.Text = amt.BrowerName;
            txtloanamount.Text = amt.LoanAmount.ToString();
            txtinterestrate.Text = (amt.InterestRate * 100).ToString();
            txtloantenure.Text = amt.Loan_tenure_in_year.ToString();
            dtpeffectivedate.Value = amt.Effective_Date;

        }

        public void AmortizorNavigated(Amortizator obj)
        {
            Display(obj);
            lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count.ToString();
        }

        public void btnmovefirst_Click(object sender, EventArgs e)
        {


            AmortizorMgr.MoveFirst();

            //if (tmp == null)
            //{
            //    MessageBox.Show("There is no element in list");
            //    return;
            //}

            //Display(tmp);
            //lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count.ToString();
        }

        private void btnmovenext_Click(object sender, EventArgs e)
        {


            AmortizorMgr.MoveNext();

            //if (tmp == null)
            //{
            //    MessageBox.Show("There is no element in list");
            //    return;
            //}

            //Display(tmp);
            //lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count.ToString();
        }

        private void btnmoveprevious_Click(object sender, EventArgs e)
        {


            AmortizorMgr.MovePrevious();

            //if (tmp == null)
            //{
            //    MessageBox.Show("There is no element in list");
            //    return;
            //}

            //Display(tmp);
            //lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count.ToString();
        }

        private void btnmovelast_Click(object sender, EventArgs e)
        {


            AmortizorMgr.MoveLast();

            //if (tmp == null)
            //{
            //    MessageBox.Show("There is no element in list");
            //    return;
            //}

            //Display(tmp);
            //lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count.ToString();
        }

        private void btnreviewrepaymentschedule_Click(object sender, EventArgs e)
        {
            Amortizator obj = AmortizorMgr.getListOf()[AmortizorMgr.CurrentPosition - 1];
            frmrepayment frmrep = new frmrepayment();
            //frmrep.RepayAmt = obj;
            frmrep.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Amortizator amt = null;
            Amortizator Old_amt = null;

            // validate inputs.......... you should...


            // Create amortizor obj
            amt = new Amortizator();

            amt.LoanID = txtloanid.Text;
            amt.BrowerName = txtborrowername.Text;
            amt.LoanAmount = float.Parse(txtloanamount.Text);
            amt.InterestRate = float.Parse(txtinterestrate.Text) / 100;
            amt.Loan_tenure_in_year = float.Parse(txtloantenure.Text);
            amt.Effective_Date = dtpeffectivedate.Value.Date;
            amt.Monthly_in_year = 12;


            Old_amt = AmortizorMgr.getListOf()[AmortizorMgr.CurrentPosition - 1];

            AmortizorMgr.Update(Old_amt, amt);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Amortizator currentobj = null;

            currentobj = AmortizorMgr.getListOf()[AmortizorMgr.CurrentPosition - 1];

            if (MessageBox.Show("Are you sure to delelete the loan?"
                + Environment.NewLine + currentobj.ToString(), "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                AmortizorMgr.Delete(currentobj);

                if (AmortizorMgr.Count == 0)
                {
                    lblposition.Text = "";
                    return;
                }

                Display(AmortizorMgr.getListOf()[AmortizorMgr.CurrentPosition - 1]);
                lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count.ToString();

            }
        }

        private void frmmain_Activated(object sender, EventArgs e)
        {
            frmmasterform frm = (frmmasterform)this.MdiParent;
            frm.SetStatus(AmortizorMgr.FileName);

        }
    }
}
