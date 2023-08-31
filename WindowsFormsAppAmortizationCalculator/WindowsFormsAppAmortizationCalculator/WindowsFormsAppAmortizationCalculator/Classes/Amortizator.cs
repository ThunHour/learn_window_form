using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsAppAmortizationCalculator.Classes
{
    [Serializable]
    public class Amortizator: IComparable,ISaveable
    {
        public static SortLoanDetail _SortLoanDetail = SortLoanDetail.LoanID;
        public void SetProductFeild(SortLoanDetail sortLoanDetail)
        {
            _SortLoanDetail = sortLoanDetail;
        }
        private float Am_interestrate;
        private float Am_principle;
        private int Am_monthly_in_year;
        private float Am_loan_tenure_in_year;
        private DateTime Am_eff_date;
        private string Am_loanid;
        private string Am_borrowerName;

        public Amortizator() { 
        
        }
        public int CompareTo(object obj)
        {
            Amortizator temp = (Amortizator)obj;
            if (_SortLoanDetail == SortLoanDetail.LoanID)
            {
                return this.LoanID.CompareTo(temp.LoanID);
            }
            else if (_SortLoanDetail == SortLoanDetail.LoanName)
            {
                return this.BrowerName.CompareTo(temp.BrowerName);
            }
            else if (_SortLoanDetail == SortLoanDetail.LoanAmount)
            {
                return this.LoanAmount.CompareTo(temp.LoanAmount);
            }
            else if (_SortLoanDetail == SortLoanDetail.LoanDate)
            {
                return this.Effective_Date.CompareTo(temp.Effective_Date);
            }
            else if (_SortLoanDetail == SortLoanDetail.LoanRatePerYear)
            {
                return this.InterestRate.CompareTo(temp.InterestRate);
            }
            else if (_SortLoanDetail == SortLoanDetail.Loantenure)
            {
                return this.Loan_tenure_in_year.CompareTo(temp.Loan_tenure_in_year);
            }
            return 0;

        }

        public Amortizator(float loanamount, float interestrate, 
            int monthly_in_year, float loan_tenure,DateTime effDate,string LoanID,string BorrowerName) {

            Am_interestrate = interestrate;
            Am_principle = loanamount;
            Am_monthly_in_year = monthly_in_year;
            Am_loan_tenure_in_year = loan_tenure;
            Am_eff_date = effDate;
            Am_loanid = LoanID;
            Am_borrowerName = BorrowerName;
        }

        public float InterestRate { get => Am_interestrate; set => Am_interestrate = value; }
        public float LoanAmount { get => Am_principle; set => Am_principle = value; }
        public int Monthly_in_year { get => Am_monthly_in_year; set => Am_monthly_in_year = value; }
        public float Loan_tenure_in_year { get => Am_loan_tenure_in_year; set => Am_loan_tenure_in_year = value; }
        public DateTime Effective_Date { get => Am_eff_date; set => Am_eff_date = value; }
        public string LoanID { get => Am_loanid; set => Am_loanid = value; }
        public string BrowerName { get => Am_borrowerName; set => Am_borrowerName = value; }

        public float getMonthlyPaymentAmount() {

            double tmp_formul1 = Math.Pow((1 + (Am_interestrate / Am_monthly_in_year))
                                            , (-1) * Am_monthly_in_year * Am_loan_tenure_in_year);

            double tmp_emi;

            tmp_emi = Math.Round((Am_interestrate * Am_principle) / (Am_monthly_in_year * (1 - tmp_formul1)), 2);
            return (float)tmp_emi;       
    
        }

        public List<RepaymentSchedule> getRepaymentSchedule() {
            List<RepaymentSchedule> repaymentSchedule = new List<RepaymentSchedule>();
            float tmp_EMI;
            float tmp_paid_interest;
            float tmp_paid_Principle;
            float tmp_Remainning_Balance = 00f;
            DateTime Last_repaymentDate = DateTime.Now;

            RepaymentSchedule tmp_repay;


            tmp_EMI = this.getMonthlyPaymentAmount();

            for (int i = 1; i <= Am_loan_tenure_in_year * Am_monthly_in_year; i++) {
                tmp_repay = new RepaymentSchedule();

                if (i == 1)
                {
                    tmp_repay.RepaymentDate = Effective_Date.AddMonths(1);
                    tmp_repay.Monthly_Install_Amount = tmp_EMI;
                    tmp_repay.PaidInterest = (float)Math.Round(Am_principle * (Am_interestrate / Am_monthly_in_year), 10);
                    tmp_repay.PaidPrinciple = tmp_repay.Monthly_Install_Amount - tmp_repay.PaidInterest;
                    tmp_repay.RemainingBalance = Am_principle - tmp_repay.PaidPrinciple;
                }
                else {
                    tmp_repay.RepaymentDate = Last_repaymentDate.AddMonths(1);
                    tmp_repay.Monthly_Install_Amount = tmp_EMI;
                    tmp_repay.PaidInterest = (float)Math.Round(tmp_Remainning_Balance * (Am_interestrate / Am_monthly_in_year), 10);
                    tmp_repay.PaidPrinciple = tmp_repay.Monthly_Install_Amount - tmp_repay.PaidInterest;
                    tmp_repay.RemainingBalance = tmp_Remainning_Balance - tmp_repay.PaidPrinciple;
                }
                if (i == Am_loan_tenure_in_year * Am_monthly_in_year && tmp_repay.RemainingBalance > 0) {
                    tmp_repay.PaidInterest = tmp_repay.PaidInterest- tmp_repay.RemainingBalance;
                    tmp_repay.RemainingBalance = 0.0f;
                }



                tmp_Remainning_Balance = tmp_repay.RemainingBalance;
                Last_repaymentDate = tmp_repay.RepaymentDate;
                repaymentSchedule.Add(tmp_repay);
            }

            return repaymentSchedule;
        }
        public override bool Equals(object obj)
        {
            Amortizator am = (Amortizator)obj;

            return this.LoanID.Equals(am.LoanID);
        }

        public override string ToString()
        {
            return "Loan ID:" + Am_loanid +
                ";Borrower Name:" + Am_borrowerName + ";Loan Amount:" + Am_principle.ToString("C");
        }

        void ISaveable.WriteObject(FileStream Fs)
        {
            BinaryFormatter Bwriter = new BinaryFormatter();

            Bwriter.Serialize(Fs, this);    

        }

        object ISaveable.ReadObject(FileStream Fs)
        {
            throw new NotImplementedException();
        }
    }
    
    public class RepaymentSchedule {
        private DateTime Am_repaymentdate;
        private float Am_Monthly_install_amount;
        private float Am_PaidInterest;
        private float Am_PaidPrinciple;
        private float Am_RemainingBalance;

        public RepaymentSchedule() { }
        public RepaymentSchedule(DateTime RepaymentDate, float Monthly_inst_amt, float PaidInterest, float PaidPrinciple, float RemainingBalance) { 
           Am_Monthly_install_amount = Monthly_inst_amt; 
           Am_PaidInterest = PaidInterest;
           Am_repaymentdate = RepaymentDate;
           Am_PaidPrinciple = PaidPrinciple;
           Am_RemainingBalance = RemainingBalance;
        }

        public DateTime RepaymentDate { get => Am_repaymentdate; set => Am_repaymentdate = value; }
        public float Monthly_Install_Amount { get => Am_Monthly_install_amount; set => Am_Monthly_install_amount = value; }
        public float PaidInterest { get => Am_PaidInterest; set => Am_PaidInterest = value; }
        public float PaidPrinciple { get => Am_PaidPrinciple; set => Am_PaidPrinciple = value; }
        public float RemainingBalance { get => Am_RemainingBalance; set => Am_RemainingBalance = value; }
    }

}
