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
    public enum Operation
    {
        OprNone = 0,
        OptNew = 1,
        OptEdit = 2,
        OptDelete = 3,
        OptSave = 4
    }
    public partial class frmamrtizationcalculator : Form
    {
        public Operation Operation = Operation.OprNone;
        public GenericNavigator<Amortizator> AmortizorMgr = new GenericNavigator<Amortizator>();

        public frmMain frmmain = (frmMain)Application.OpenForms["frmMain"];

        public frmamrtizationcalculator()
        {
            InitializeComponent();
        }

        private void frmamrtizationcalculator_Load(object sender, EventArgs e)
        {
            timer.Start();
            timeOfInteresrBtn.Start();
            AmortizorMgr.ObjectNavigated += AmortizorNavigated;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtinterestrate.Text = "Enter as a Number like 10,20...100";
            txtinterestrate.ForeColor = Color.Silver;
            Operation = Operation.OptNew;
            txtborrowername.Clear();
            txtloanamount.Clear();
            dtpeffectivedate.Value = DateTime.Today;
            txtloantenure.Clear();
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

            errorPro.Clear();
            if (txtloanid.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtloanid, "please click on new button for get id");
                errorPro.SetIconAlignment(txtloanid, ErrorIconAlignment.MiddleLeft);
                errorPro.SetError(btnNew, "click here");
                errorPro.SetIconAlignment(btnNew, ErrorIconAlignment.MiddleLeft);
                return;
            }
            else if (txtborrowername.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtborrowername, "please input all the field..!!");
                errorPro.SetIconAlignment(txtborrowername, ErrorIconAlignment.MiddleLeft);
                txtborrowername.Focus();
                return;
            }
            else if (txtloanamount.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtloanamount, "please input all the field..!!");
                errorPro.SetIconAlignment(txtloanamount, ErrorIconAlignment.MiddleLeft);
                txtloanamount.Focus();
                return;
            }
            else if (txtinterestrate.Text.Trim().Length == 0 || txtinterestrate.Text == "Enter as a Number like 10,20...100")
            {
                errorPro.SetError(txtinterestrate, "please input all the field..!!");
                errorPro.SetIconAlignment(txtinterestrate, ErrorIconAlignment.MiddleLeft);
                txtinterestrate.Focus();
                return;
            }
            else if (txtloantenure.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtloantenure, "please input all the field..!!");
                errorPro.SetIconAlignment(txtloantenure, ErrorIconAlignment.MiddleLeft);
                txtloantenure.Focus();
                return;
            }
            obj = new Amortizator();
            obj.LoanID = txtloanid.Text;
            obj.BrowerName = txtborrowername.Text;
            obj.InterestRate = float.Parse(txtinterestrate.Text) / 100;
            obj.LoanAmount = long.Parse(txtloanamount.Text);
            obj.Loan_tenure_in_year = int.Parse(txtloantenure.Text);
            obj.Effective_Date = dtpeffectivedate.Value;
            obj.Monthly_in_year = 12;
            AmortizorMgr.Add(obj);
            Operation = Operation.OptSave;
            lblposition.Text = AmortizorMgr.Count.ToString() + "/" + AmortizorMgr.Count.ToString();

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

        public void AmortizorNavigated(Amortizator obj) {
            Display(obj);
            lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count.ToString();
        }

        private void btnmovefirst_Click(object sender, EventArgs e)
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

            frmrepayment frmrepay = new frmrepayment();
            frmrepay.RepayAmt = obj;
            frmrepay.MdiParent = this.MdiParent;
            frmrepay.Show();

            //if (frmmain.checkfrmScheduleList == false)
            //{
            //    frmmain.checkfrmScheduleList = true;
            //    frmrepay.Show();
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Amortizator amt = null;
            Amortizator Old_amt = null;
            errorPro.Clear();
            errorPro.Clear();
            if (txtloanid.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtloanid, "please click on new button for get id");
                errorPro.SetIconAlignment(txtloanid, ErrorIconAlignment.MiddleLeft);
                errorPro.SetError(btnNew, "click here");
                errorPro.SetIconAlignment(btnNew, ErrorIconAlignment.MiddleLeft);
                return;
            }
            else if (txtborrowername.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtborrowername, "please input all the field..!!");
                errorPro.SetIconAlignment(txtborrowername, ErrorIconAlignment.MiddleLeft);
                txtborrowername.Focus();
                return;
            }
            else if (txtloanamount.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtloanamount, "please input all the field..!!");
                errorPro.SetIconAlignment(txtloanamount, ErrorIconAlignment.MiddleLeft);
                txtloanamount.Focus();
                return;
            }
            else if (txtinterestrate.Text.Trim().Length == 0 || txtinterestrate.Text == "Enter as a Number like 10,20...100")
            {
                errorPro.SetError(txtinterestrate, "please input all the field..!!");
                errorPro.SetIconAlignment(txtinterestrate, ErrorIconAlignment.MiddleLeft);
                txtinterestrate.Focus();
                return;
            }
            else if (txtloantenure.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtloantenure, "please input all the field..!!");
                errorPro.SetIconAlignment(txtloantenure, ErrorIconAlignment.MiddleLeft);
                txtloantenure.Focus();
                return;
            }


           
            amt = new Amortizator();
            amt = new Amortizator();
            amt.LoanID = txtloanid.Text;
            amt.BrowerName = txtborrowername.Text;
            amt.InterestRate = float.Parse(txtinterestrate.Text) / 100;
            amt.LoanAmount = long.Parse(txtloanamount.Text);
            amt.Loan_tenure_in_year = int.Parse(txtloantenure.Text);
            amt.Effective_Date = dtpeffectivedate.Value;
            amt.Monthly_in_year = 12;



            Old_amt =AmortizorMgr.getListOf()[AmortizorMgr.CurrentPosition - 1];

            AmortizorMgr.Update(Old_amt, amt);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Amortizator currentObj = null;
            currentObj = AmortizorMgr.getListOf()[AmortizorMgr.CurrentPosition - 1];
            if (MessageBox.Show("Are you sure to detele the Loan record ?" + Environment.NewLine + currentObj.ToString(), "Delete ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AmortizorMgr.Delete(currentObj);
                if (AmortizorMgr.Count == 0)
                {
                    errorPro.Clear();
                    txtloanid.Clear();
                    txtborrowername.Clear();
                    txtloanamount.Clear();
                    txtinterestrate.Clear();

                    dtpeffectivedate.Value = DateTime.Today;
                    txtloantenure.Clear();
                    lblposition.Text = "";
                    return;
                }
                Operation = Operation.OptDelete;
                Display(AmortizorMgr.getListOf()[AmortizorMgr.CurrentPosition - 1]);
                lblposition.Text = AmortizorMgr.CurrentPosition.ToString() + "/" + AmortizorMgr.Count;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnviewloanlist_Click(object sender, EventArgs e)
        {
            fromloanlist frmloanlist = new fromloanlist();
            frmloanlist.MdiParent = this.MdiParent;
            frmloanlist.Show();

            //if (frmmain.checkfrmLoanList == false)
            //{
            //    frmmain.checkfrmLoanList = true;
            //    frmloanlist.Show();
            //}
        }

        private void frmamrtizationcalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmmain.checkfrmCalculator = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int AmountRecord = AmortizorMgr.Count;
            int _currentPosition = AmortizorMgr.CurrentPosition;

            btnViewLoanList.Enabled = AmountRecord > 0;
            btnViewRepaymentSchedule.Enabled = AmountRecord > 0;

            btnMoveLast.Enabled = (AmountRecord > 1 && _currentPosition != AmountRecord);
            btnMoveNext.Enabled = (AmountRecord > 1 && _currentPosition != AmountRecord);

            btnMovePrevious.Enabled = (AmountRecord > 1 && _currentPosition > 1);

            btnMoveFirst.Enabled = (AmountRecord > 1 && _currentPosition > 1);

            if (Operation == Operation.OptNew)
            {
                btnNew.Enabled = true;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

            }
            else if (AmountRecord == 0)
            {
                btnNew.Enabled = true;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else if (Operation == Operation.OptEdit || Operation == Operation.OptDelete)
            {

                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else if (Operation == Operation.OptSave)
            {
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtinterestrate_Enter(object sender, EventArgs e)
        {
            if (txtinterestrate.Text == "Enter as a Number like 10,20...100")
            {
                txtinterestrate.Text = "";
                txtinterestrate.ForeColor = Color.Black;
            }
            else if (int.Parse(txtinterestrate.Text) > 101)
            {
                errorPro.SetError(txtinterestrate, "The Interest per annum no bigger then 100");
                errorPro.SetIconAlignment(txtinterestrate, ErrorIconAlignment.MiddleLeft);
                txtinterestrate.Focus();
                return;
            }
            else if (int.Parse(txtinterestrate.Text) <= 100)
            {
                errorPro.Clear();
            }
        }

        private void txtinterestrate_Leave(object sender, EventArgs e)
        {
            if (txtinterestrate.Text == "")
            {
                txtinterestrate.Text = "Enter as a Number like 10,20...100";
                txtinterestrate.ForeColor = Color.Silver;
            }
        }

        private void txtloanamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtinterestrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtloantenure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void timeOfInteresrBtn_Tick(object sender, EventArgs e)
        {
            if (txtinterestrate.Text != "" && txtinterestrate.Text != "Enter as a Number like 10,20...100")
            {
                if (int.Parse(txtinterestrate.Text) > 101)
                {
                    errorPro.SetError(txtinterestrate, "The Interest per annum no bigger then 100");
                    errorPro.SetIconAlignment(txtinterestrate, ErrorIconAlignment.MiddleLeft);
                    txtinterestrate.Focus();
                    return;
                }
                else if (int.Parse(txtinterestrate.Text) <= 100)
                {
                    errorPro.Clear();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
