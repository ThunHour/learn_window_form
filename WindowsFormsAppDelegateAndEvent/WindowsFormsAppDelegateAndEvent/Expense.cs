using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDelegateAndEvent
{
    public delegate void AmountChangeHandler(float oldAmount,float newAmount);
    public class Expense
    {
        private string exp_id;
        private string exp_on;
        private float exp_amount;
        public event AmountChangeHandler AmountChanged;
        public Expense() { } 
        public Expense(string expid,string expon,float expamount) {
            this.exp_id = expid;
            this.exp_on = expon;
            this.exp_amount = expamount;
        }
        public string Exp_Id { get => exp_id; set => exp_id = value; }
        public string Exp_On { get => exp_on; set => exp_on = value; }
        public float Exp_Amount
        {
            get => exp_amount;
            set
            {
                if (exp_amount != value)
                {
                    if (AmountChanged != null)
                    {
                        AmountChanged(exp_amount,value);
                    }
                }
            }
        }
    }
}
