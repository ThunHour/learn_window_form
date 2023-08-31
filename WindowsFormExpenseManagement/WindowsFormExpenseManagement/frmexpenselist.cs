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
   
    public partial class frmexpenselist : Form
    {
        frmExpense frm = null;
        public frmexpenselist()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        private void frmexpenselist_Load(object sender, EventArgs e)
        {
            lvwExpense.Columns[0].Width = lvwExpense.Width / 5;
            lvwExpense.Columns[1].Width = lvwExpense.Width / 5;
            lvwExpense.Columns[2].Width = lvwExpense.Width / 5;
            lvwExpense.Columns[3].Width = lvwExpense.Width / 5;
            lvwExpense.Columns[4].Width = lvwExpense.Width / 5;
            frm= (frmExpense)Application.OpenForms["frmExpense"];
            DisplayExpense(frm.ExpenseMgr.getListOfExpense());
            txtTotalExpsense.Text = frm.ExpenseMgr.getTotalExpense().ToString("C");
        }
        public void DisplayExpense(Expense[] list_exp)
        {
            lvwExpense.Items.Clear();
            if (list_exp == null)
            {
                return;
            }
            ListViewItem item = null;
            foreach(Expense exp in list_exp)
            {
                item = lvwExpense.Items.Add(exp.ExpenseID);
                item.SubItems.Add(exp.ExpenseON);
                item.SubItems.Add(exp.ExpenseAmount.ToString("C"));
                item.SubItems.Add(exp.ExpenseDate.ToString("dd-MMM-yyyy"));
                item.SubItems.Add(exp.ExpenseDecription);
            }
          
        }

        private void lvwExpense_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                //using icomparable to sort
                Expense._SortField = SortExpenseFeild.ExpsenseID;
                Array.Sort(frm.ExpenseMgr.getListOfExpense());

                ////using icomparer to sort
                //Array.Sort(frm.ExpenseMgr.getListOfExpense(),new ExpsenseIDComparer());


            }else if (e.Column==1)
            {
                Expense._SortField = SortExpenseFeild.ExpenseOn;
                Array.Sort(frm.ExpenseMgr.getListOfExpense());


                ////using icomparer to sort
                //Array.Sort(frm.ExpenseMgr.getListOfExpense(), new ExpsenseOnComparer());
            }
            else if (e.Column == 2)
            {
                Expense._SortField = SortExpenseFeild.ExpenseAmount;
                Array.Sort(frm.ExpenseMgr.getListOfExpense());


                ////using icomparer to sort
                //Array.Sort(frm.ExpenseMgr.getListOfExpense(), new ExpsenseAmountComparer());
            }
            else if (e.Column == 3)
            {
                Expense._SortField = SortExpenseFeild.ExpenseDate;
                Array.Sort(frm.ExpenseMgr.getListOfExpense());


                ////using icomparer to sort
                //Array.Sort(frm.ExpenseMgr.getListOfExpense(), new ExpsenseDateComparer());
            }
            else if (e.Column == 4)
            {
                Expense._SortField = SortExpenseFeild.ExpenseDesc;
                Array.Sort(frm.ExpenseMgr.getListOfExpense());


                ////using icomparer to sort
                //Array.Sort(frm.ExpenseMgr.getListOfExpense(), new ExpsenseDescComparer());
            }
           
            DisplayExpense(frm.ExpenseMgr.getListOfExpense());

        }
    }
}
