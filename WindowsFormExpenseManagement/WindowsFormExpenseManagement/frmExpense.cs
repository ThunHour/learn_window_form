using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormExpenseManagement.Classses;

namespace WindowsFormExpenseManagement
{
    public enum Operation{
        OprNone=0,
        OptNew=1,
        OptEdit=2,
        OptDelete=3,
            OptSave=4
    }
    public partial class frmExpense : Form
    {
        public Operation Operation = Operation.OprNone;
        public ExpsenseManagement ExpenseMgr = new ExpsenseManagement();
        public frmExpense()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSaveStream_Click_1(object sender, EventArgs e)
        {


        }


        private void btnNextAll_Click(object sender, EventArgs e)
        {
            Expense temp = null;
            temp = ExpenseMgr.MoveLast();
            if (temp == null)
            {
               
                return;
            }
            Operation = Operation.OptEdit;
            Display(temp);
            lblPosition.Text = ExpenseMgr.CurrentPosition.ToString() + "/" + ExpenseMgr.Count.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Expense temp = null;
            temp = ExpenseMgr.MoveNext();
            if (temp == null)
            {
              
                return;
            }
            Operation = Operation.OptEdit;
            Display(temp);
            lblPosition.Text = ExpenseMgr.CurrentPosition.ToString() + "/" + ExpenseMgr.Count.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Expense temp = null;
            temp = ExpenseMgr.MovePrevious();
            if (temp == null)
            {
                return;
            }
            Operation = Operation.OptEdit;
            Display(temp);
            lblPosition.Text = ExpenseMgr.CurrentPosition.ToString() + "/" + ExpenseMgr.Count.ToString();

        }

        private void btnBackAll_Click(object sender, EventArgs e)
        {
            Expense temp = null;
            temp = ExpenseMgr.MoveFirst();
            if (temp == null)
            {
               
                return;
            }
            Operation = Operation.OptEdit;
            Display(temp);
            lblPosition.Text = ExpenseMgr.CurrentPosition.ToString() + "/"+ExpenseMgr.Count.ToString()  ;

        }
        public void Display(Expense exp)
        {
            txtExpenseID.Text = exp.ExpenseID;
            txtAmountExpense.Text = exp.ExpenseAmount.ToString();
            txtTypeExpense.Text = exp.ExpenseON;
            txtDecriptionExpense.Text = exp.ExpenseDecription;
            dtpDate.Value = exp.ExpenseDate;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnViewExpense_Click(object sender, EventArgs e)
        {
            frmexpenselist frm = new frmexpenselist();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            btnNew_Click(null, null);
            timer.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Operation = Operation.OptSave;
            Expense exp = null;
            errorPro.Clear();
            if (txtExpenseID.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtExpenseID, "please click on new button for get id");
                errorPro.SetIconAlignment(txtExpenseID, ErrorIconAlignment.MiddleLeft);
                errorPro.SetError(btnNew, "click here");
                errorPro.SetIconAlignment(btnNew, ErrorIconAlignment.MiddleLeft);
                txtAmountExpense.Focus();
                return;
            }
            else if (txtTypeExpense.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtTypeExpense, "please input all the field..!!");
                errorPro.SetIconAlignment(txtTypeExpense, ErrorIconAlignment.MiddleLeft);
                txtAmountExpense.Focus();
                return;
            }
            else if (txtAmountExpense.Text.Trim().Length==0)
            {
                errorPro.SetError(txtAmountExpense, "please input all the field..!!");
                errorPro.SetIconAlignment(txtAmountExpense, ErrorIconAlignment.MiddleLeft);
                txtAmountExpense.Focus();
                return;
            }
            else if (txtDecriptionExpense.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtDecriptionExpense, "please input all the field..!!");
                errorPro.SetIconAlignment(txtDecriptionExpense, ErrorIconAlignment.MiddleLeft);
                txtAmountExpense.Focus();
                return;
            }
            exp = new Expense();
            exp.ExpenseID = txtExpenseID.Text;
            exp.ExpenseON = txtTypeExpense.Text;
            exp.ExpenseAmount = float.Parse(txtAmountExpense.Text.Trim());
            exp.ExpenseDate = dtpDate.Value.Date;
            exp.ExpenseDecription = txtDecriptionExpense.Text;
            ExpenseMgr.add(exp);
            txtTotalAmount.Text = ExpenseMgr.getTotalExpense().ToString("C");
            lblPosition.Text = ExpenseMgr.Count.ToString() + "/" + ExpenseMgr.Count.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAmountExpense.Clear();
            txtExpenseID.Clear();
            txtTypeExpense.Clear();
            errorPro.Clear();
            txtDecriptionExpense.Clear();
            dtpDate.Value = DateTime.Today;
            Operation = Operation.OptNew;
            if (ExpenseMgr.Count == 0)
            {
                txtExpenseID.Text = "EXP0001";
                return;
            }
            txtExpenseID.Text = "EXP" + (ExpenseMgr.Count+1).ToString("D4");

            
        }

        private void txtAmuntExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(
                (!char.IsDigit(e.KeyChar)) && 
                e.KeyChar !=((char)Keys.Back)  && 
                e.KeyChar.ToString()!=".")
            {
                e.Handled = true;
            }
        }

        private void txtTypeExpense_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmuntExpense_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Expense exp = null;
            Expense Old_exp = null;
            errorPro.Clear();
            if (txtTypeExpense.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtTypeExpense, "please input all the field..!!");
                errorPro.SetIconAlignment(txtTypeExpense, ErrorIconAlignment.MiddleLeft);
                txtAmountExpense.Focus();
                return;
            }
            else if (txtAmountExpense.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtAmountExpense, "please input all the field..!!");
                errorPro.SetIconAlignment(txtAmountExpense, ErrorIconAlignment.MiddleLeft);
                txtAmountExpense.Focus();
                return;
            }
            else if (txtDecriptionExpense.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtDecriptionExpense, "please input all the field..!!");
                errorPro.SetIconAlignment(txtDecriptionExpense, ErrorIconAlignment.MiddleLeft);
                txtAmountExpense.Focus();
                return;
            }
            Operation = Operation.OptEdit;
            exp = new Expense();
            //reget old object
            Old_exp = ExpenseMgr.getListOfExpense()[ExpenseMgr.CurrentPosition-1];
            exp.ExpenseID = txtExpenseID.Text;
            exp.ExpenseON = txtTypeExpense.Text;
            exp.ExpenseAmount = float.Parse(txtAmountExpense.Text.Trim());
            exp.ExpenseDate = dtpDate.Value.Date;
            exp.ExpenseDecription = txtDecriptionExpense.Text;
            ExpenseMgr.Update(Old_exp,exp);
            txtTotalAmount.Text = ExpenseMgr.getTotalExpense().ToString("C");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Expense currentObj = null;
            currentObj = ExpenseMgr.getListOfExpense()[ExpenseMgr.CurrentPosition - 1];
            if (MessageBox.Show("Are you sure to detele the expense." + Environment.NewLine + currentObj.ToString(),"Delete ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExpenseMgr.Delete(currentObj);
                if (ExpenseMgr.Count == 0)
                {
                    txtAmountExpense.Clear();
                    txtExpenseID.Clear();
                    txtTypeExpense.Clear();
                    errorPro.Clear();
                    txtDecriptionExpense.Clear();
                    dtpDate.Value = DateTime.Today;
                    txtTotalAmount.Clear();
                    lblPosition.Text = "";
                    return;
                }
                Operation = Operation.OptDelete;
                Display(ExpenseMgr.getListOfExpense()[ExpenseMgr.CurrentPosition - 1]);
                lblPosition.Text = lblPosition.Text = ExpenseMgr.CurrentPosition.ToString() + "/" + ExpenseMgr.Count;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
            btnViewExpense.Enabled = ExpenseMgr.Count > 0;
            btnMoveFirst.Enabled = ExpenseMgr.Count > 0;
            btnMoveLast.Enabled = ExpenseMgr.Count > 0;
            btnMoveNext.Enabled = ExpenseMgr.Count > 0;
            btnMovePrevious.Enabled = ExpenseMgr.Count > 0;
            if (Operation== Operation.OptNew|| ExpenseMgr.Count == 0)
            {
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

            }
            else if (Operation == Operation.OptEdit|| Operation == Operation.OptDelete)
            {
                btnNew.Enabled = true;               
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }else if(Operation == Operation.OptSave)
            {
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
           
        }





        private void btnSaveStream_Click_2(object sender, EventArgs e)
        {
            SaveFileDialog Sfd = new SaveFileDialog();
            Sfd.Title = "save Expense to File";
            Sfd.Filter = "Expense File(*.epx)|*exp|All File(*.*)|*.*";
            Sfd.DefaultExt = "exp";
            Sfd.FilterIndex = 0;
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                ExpenseMgr.SaveToFile(Sfd.FileName, SaveFileOption.SaveFileOptStream);
            }
        }

        private void btnReadStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog Sfd = new OpenFileDialog();
            Sfd.Title = "Read Expense From File";
            Sfd.Filter = "Expense File(*.epx)|*exp|All File(*.*)|*.*";
            Sfd.DefaultExt = "exp";
            Sfd.FilterIndex = 0;
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                ExpenseMgr.ReadFromFile(Sfd.FileName, SaveFileOption.SaveFileOptStream);
                btnBackAll_Click(null,null);
            }
        }

        private void btnSaveBin_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog Sfd = new SaveFileDialog();

            Sfd.Title = "Save Expense to File";
            Sfd.Filter = "Expense File(*.exp)|*.exp|All Files(*.*)|*.*";
            Sfd.DefaultExt = "exp";
            Sfd.FilterIndex = 0;
            Sfd.FileName = "Test.exp";

            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                ExpenseMgr.SaveToFile(Sfd.FileName, SaveFileOption.SaveFileOptBinary);
            }
        }

        private void btnReadBin_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Sfd = new OpenFileDialog();

            Sfd.Title = "Select Expense File";
            Sfd.Filter = "Expense File(*.exp)|*.exp|All Files(*.*)|*.*";
            Sfd.DefaultExt = "exp";
            Sfd.FilterIndex = 0;

            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                ExpenseMgr.ReadFromFile(Sfd.FileName, SaveFileOption.SaveFileOptBinary);
                btnBackAll_Click(null, null);
            }
        }

        private void btnSerialization_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog Sfd = new SaveFileDialog();

            Sfd.Title = "Save Expense to File";
            Sfd.Filter = "Expense File(*.exp)|*.exp|All Files(*.*)|*.*";
            Sfd.DefaultExt = "exp";
            Sfd.FilterIndex = 0;
            Sfd.FileName = "Test.exp";

            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                ExpenseMgr.SaveToFile(Sfd.FileName, SaveFileOption.SaveFileOptSerialization);
            }
        }

        private void btnDeserialization_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Sfd = new OpenFileDialog();

            Sfd.Title = "Select Expense File";
            Sfd.Filter = "Expense File(*.exp)|*.exp|All Files(*.*)|*.*";
            Sfd.DefaultExt = "exp";
            Sfd.FilterIndex = 0;

            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                ExpenseMgr.ReadFromFile(Sfd.FileName, SaveFileOption.SaveFileOptSerialization);
                btnBackAll_Click(null, null);
            }
        }
    }
}
