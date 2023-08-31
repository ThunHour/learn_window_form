using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace WindowsFormExpenseManagement.Classses
{
    [Serializable]
    public class Expense:IComparable
    {
        public static SortExpenseFeild _SortField = SortExpenseFeild.ExpsenseID;
        public void SetSortField(SortExpenseFeild sortExpenseFeild)
        {
            _SortField = sortExpenseFeild;
        }
        private string _expenseID;
        private string _expenseON;
        private float _expenseAmount;
        private string _expenseDecription;
        private DateTime _expenseDate;
        public Expense() { }
        public Expense(string expenseid,string expenseon, float expenseamount, DateTime expensedate, string expensedecription)
        {
            this._expenseID = expenseid;
            this._expenseON = expenseon;
            this._expenseDecription = expensedecription;
            this._expenseDate = expensedate;
            this._expenseAmount = expenseamount;
        }

        public string ExpenseID { get => _expenseID; set => _expenseID = value; }
        public string ExpenseON { get => _expenseON; set => _expenseON = value; }
        public float ExpenseAmount { get => _expenseAmount; set => _expenseAmount = value; }
        public string ExpenseDecription { get => _expenseDecription; set => _expenseDecription = value; }
        public DateTime ExpenseDate { get => _expenseDate; set => _expenseDate = value; }

        public override string ToString()
        {
            return String.Format("Expense ID :{0}   ,   ExpenseOn :{1}",_expenseID,_expenseON);
        }

        public int  CompareTo(object obj)
        {
            Expense temp = (Expense)obj;
            if (_SortField == SortExpenseFeild.ExpsenseID)
            {
                return this.ExpenseID.CompareTo(temp.ExpenseID);
            }else if(_SortField == SortExpenseFeild.ExpenseOn)
            {
                return this.ExpenseON.CompareTo(temp.ExpenseON);
            }
            else if (_SortField == SortExpenseFeild.ExpenseAmount)
            {
                return this.ExpenseAmount.CompareTo(temp.ExpenseAmount);
            }
            else if (_SortField == SortExpenseFeild.ExpenseDate)
            {
                return this.ExpenseDate.CompareTo(temp.ExpenseDate);
            }
            else if (_SortField == SortExpenseFeild.ExpenseDesc)
            {
                return this.ExpenseDecription.CompareTo(temp.ExpenseDecription);
            }
            return 0;
            
        }
    }

    //using icomparer method
    public class ExpsenseIDComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Expense exp1 = (Expense)x;
            Expense exp2 = (Expense)y;
            return exp1.ExpenseID.CompareTo(exp2.ExpenseID);
        }
    }
    public class ExpsenseAmountComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Expense exp1 = (Expense)x;
            Expense exp2 = (Expense)y;
            return exp1.ExpenseAmount.CompareTo(exp2.ExpenseAmount);
        }
    }
    public class ExpsenseOnComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Expense exp1 = (Expense)x;
            Expense exp2 = (Expense)y;
            return exp1.ExpenseON.CompareTo(exp2.ExpenseON);
        }
    }
    public class ExpsenseDateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Expense exp1 = (Expense)x;
            Expense exp2 = (Expense)y;
            return exp1.ExpenseDate.CompareTo(exp2.ExpenseDate);
        }
    }
    public class ExpsenseDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Expense exp1 = (Expense)x;
            Expense exp2 = (Expense)y;
            return exp1.ExpenseDecription.CompareTo(exp2.ExpenseDecription);
        }
    }
}
