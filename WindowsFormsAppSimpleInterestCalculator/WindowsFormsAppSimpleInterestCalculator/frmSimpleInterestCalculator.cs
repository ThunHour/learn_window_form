using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSimpleInterestCalculator
{
    public partial class frmSimpleInterestCalculator : Form
    {
        public frmSimpleInterestCalculator()
        {
            InitializeComponent();
        }

        private void FormSimpleInterestCalculator_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
         int Principle;
         float InterestRatePerYear = 0.0f;
         float TimesYear = 0.00f;
         float InterestEarned = 0.0f;
         float TotalAmountPaid = 0.0f;
        //To validate the input
             int temp = 0;
            float tempFloat = 0.0f;
            errorPro.Clear();
            
            //check principle
            if(int.TryParse(txtPriciple.Text, out temp)==false)
            {
                //Messagebox.show("please input principle correctly", "principle error");
                errorPro.SetIconAlignment(txtPriciple, ErrorIconAlignment.TopLeft);
                errorPro.SetError(txtPriciple, "please input correctly ");
                txtPriciple.Focus();
                txtPriciple.SelectAll();
                return;
            }
            Principle = temp;

            //check Interest Rate Per Year

            if(!float.TryParse(txtInterestPerAnnum.Text,out tempFloat)){
                //MessageBox.Show("Please input Interest per Annum correctly", "Interest per Annum Error");
                errorPro.SetError(txtInterestPerAnnum, "please input correctly");
                txtInterestPerAnnum.Focus();
                txtInterestPerAnnum.SelectAll();
                return;
            }else if (int.Parse(txtInterestPerAnnum.Text) > 100)
            {
                errorPro.SetError(txtInterestPerAnnum, "input must be no bigger then 100");
                txtInterestPerAnnum.Focus();
                txtInterestPerAnnum.SelectAll();
                return;
            }
            InterestRatePerYear = tempFloat;


            //check time yearly

            if (!float.TryParse(txtTimeAsYearly.Text, out tempFloat))
            {
                // MessageBox.Show("Please input Time as Yearly correctly", "Time as Yearly Error");
                errorPro.SetError(txtTimeAsYearly, "please input correctly");
                txtTimeAsYearly.Focus();
                txtTimeAsYearly.SelectAll();
                return;
            }
            TimesYear = tempFloat;

            //create object
            InterestCalculator _simpleInterestCalculator = new InterestCalculator(Principle, InterestRatePerYear, TimesYear);


            txtInterestEarned.Text = _simpleInterestCalculator.getInterestEarned().ToString("C");
            txtTotalAmoundPaid.Text = _simpleInterestCalculator.getTotalPaid().ToString("C");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
   
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPriciple.Clear();
            txtInterestPerAnnum.Clear();
            txtTimeAsYearly.Clear();
            txtTotalAmoundPaid.Clear();
            txtInterestEarned.Clear();

            //to send cursor too principle textbox
            txtPriciple.Focus();
        }

        private void btnPaymentSchedule_Click(object sender, EventArgs e)
        {
            frmPaymentSchedule frm = new frmPaymentSchedule();
            frm.ShowDialog();
           

        }
        private void txtPriciple_KeyPress(object sender, KeyPressEventArgs e)
        {
            //when user pressing keyborad , the block of codes here will be executed

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back)&& e.KeyChar.ToString()!=".")
            {
                e.Handled = true;
            }
          
        }

        private void txtInterestPerAnnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
            }
        }

        private void txtTimeAsYearly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
            }
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }
        public class InterestCalculator
        {
            //declear variable
            private int _Principle=0;
            private float _InterestRatePerYear = 0.0f;
            private  float _TimesYear = 0.00f;

            //create constructor
            public InterestCalculator(int principle = 0, float interestRate = 0, float timeYearly = 0)
            {
                _InterestRatePerYear = interestRate;
                _TimesYear = timeYearly;
                _Principle = principle;
                
            }
            public float getInterestEarned()
            {
                this.getInterestEarnAndTotalAmount(out float _InterestEarned, out float _TotalAmountPaid);
                return _InterestEarned;
            }
            public float getTotalPaid()
            {
                this.getInterestEarnAndTotalAmount(out float _InterestEarned, out float _TotalAmountPaid);
                return _TotalAmountPaid;
            }
            // To calculate Interestearned and Total amount to be paid
            public void getInterestEarnAndTotalAmount(out float _InterestEarned, out float _TotalAmountPaid)
            {
                _InterestEarned = _Principle * (_InterestRatePerYear / 100) * _TimesYear;
                _TotalAmountPaid = _Principle + _InterestEarned;
            }


        }
    }

}
