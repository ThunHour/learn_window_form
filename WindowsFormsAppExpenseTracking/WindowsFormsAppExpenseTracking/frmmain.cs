using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppExpenseTracking
{
    public partial class frmmain : Form
    {
        public int ExpenseCount = 1;
        public float TotalExpense = 0;
        public string ExpenseList = "";
        public frmmain()
        {
            InitializeComponent();
            txtExpenNumber.Text = ExpenseCount.ToString("D3");
        }

        private void btnTrackExpense_Click(object sender, EventArgs e)
        {
            float ExpenseAmount = 0;


            txtTotalAmount.Text = TotalExpense.ToString();
            if (
                txtExpenseType.Text == "")
            {
                errorPro.SetError(txtExpenseType, "input can not be null");
                errorPro.SetIconAlignment(txtExpenseType, ErrorIconAlignment.MiddleLeft);

                txtExpenseType.SelectAll();
                txtExpenseType.Focus();
                return;
            }
            try
            {
                ExpenseAmount = float.Parse(txtExpenseAmount.Text);
            }
            catch (ArgumentNullException ArguEx)
            {
                errorPro.SetError(txtExpenseAmount, "input can not be null");
                errorPro.SetIconAlignment(txtExpenseAmount, ErrorIconAlignment.MiddleLeft);
                txtExpenseAmount.SelectAll();
                txtExpenseAmount.Focus();
                return;
            }
            catch (FormatException fEx)
            {
                errorPro.SetError(txtExpenseAmount, "Please input correctly.");
                errorPro.SetIconAlignment(txtExpenseAmount, ErrorIconAlignment.MiddleLeft);
                txtExpenseAmount.SelectAll();
                txtExpenseAmount.Focus();
                return;
            }
            catch (OverflowException oEx)
            {
                errorPro.SetError(txtExpenseAmount, "");
                errorPro.SetIconAlignment(txtExpenseAmount, ErrorIconAlignment.MiddleLeft);
                txtExpenseAmount.SelectAll();
                txtExpenseAmount.Focus();
                return;
            }
            TotalExpense += ExpenseAmount;
            ExpenseList=ExpenseList +"Type: "+ txtExpenseType.Text +", Amount : " +txtExpenseAmount.Text +", Total: "+TotalExpense+ Environment.NewLine;
            txtTotalAmount.Text = TotalExpense.ToString("C");

        }



        private void txtExpenNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCleanExpense_Click(object sender, EventArgs e)
        {
            txtExpenseType.Clear();
            txtExpenseAmount.Clear();
            txtExpenseType.SelectAll();
            txtExpenseType.Focus();
            ExpenseCount++;
            txtExpenNumber.Text = ExpenseCount.ToString("D3");
        }

        private void txtExpenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
            }
        }

        private void txtExpenseAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestartExpense_Click(object sender, EventArgs e)
        {
            ExpenseCount = 1;
            ExpenseList = "";
            TotalExpense = 0;
            
            txtExpenNumber.Text = ExpenseCount.ToString("D3");
            txtExpenseAmount.Clear();
            txtTotalAmount.Clear();
            txtExpenseType.Clear();

        }

        private void btnViewExpense_Click(object sender, EventArgs e)
        {
            ExpenseList frmEx = new ExpenseList();
            frmEx.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

