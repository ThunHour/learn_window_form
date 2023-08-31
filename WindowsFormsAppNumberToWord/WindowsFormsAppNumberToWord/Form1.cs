using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNumberToWord
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long Number = long.Parse(txtNumber.Text);
            ConvertNumberToWord cnt = new ConvertNumberToWord(Number);
            string resultInKhmerWord = cnt.getResultKhmerWord();
            string resultInEnglishWord = cnt.getResultEnglishWord();
          
            if (resultInKhmerWord == "The number is no more then 1,000,000,000,000")
            {
                txtNumber.Clear();
                txtNumber.Focus();
            }
                txtKhmerWordOfNumber.Text = resultInKhmerWord;
                txtEnglishWordOfNumber.Text = resultInEnglishWord;
        }
        


        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }
    }
    public class ConvertNumberToWord
    {
        long _number;
        string _Khmerword = "";
        string _Englishword = "";

        public ConvertNumberToWord(long number)
        {
            this._number = number;
        }
        //method get data out of class for english word result
        public string getResultEnglishWord()
        {
            this.ConvertTool(out _Khmerword, out _Englishword);
            return _Englishword;
        }
        //method get data out of class for khmer word result
        public string getResultKhmerWord()
        {
            this.ConvertTool(out _Khmerword, out _Englishword);
            return _Khmerword;
        }
        //method for convert from numbver to khmer and english word
        private void ConvertTool(out string _khmerword, out string _englishWord)
        {
            _englishWord = NumberToEnglishWord(_number);
            _khmerword = NumberToKhmerhWord(_number);
        }
        private string NumberToEnglishWord(long _Number)
        {
            //create list of number as english word
            string[] uniqueNumberEnglishWord= { "", "One", "Two", "Three",
                                    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
                                    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
                                    "Eighteen", "Nineteen" };

            string[] tensAdEnglishWord = { "", "", "Twenty", "Thirty", "Forty",
                                    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (_Number < 20)
            {
                return uniqueNumberEnglishWord[_Number];
            }
            else if (_Number >= 20 && _Number < 100)
            {
                return _Number == 20 ? tensAdEnglishWord[2] : tensAdEnglishWord[(int)(_Number / 10)] + "-" + NumberToEnglishWord(_Number % 10);
                { }
            }
            else if (_Number >= 100 && _Number < 1000)
            {
                return _Number == 100 ? uniqueNumberEnglishWord[1] + " hundred" : NumberToEnglishWord((int)(_Number / 100)) + " hundred " + NumberToEnglishWord(_Number % 100);
            }
            else if (_Number >= 1000 && _Number < 100000)
            {
                return (_Number == 1000 || _Number == 10000) ? uniqueNumberEnglishWord[_Number / 1000] + " thousand" : NumberToEnglishWord((int)(_Number / 1000)) + " Thousand " + NumberToEnglishWord(_Number % 1000);
            }
            else if (_Number >= 100000 && _Number < 1000000)
            {
                return _Number == 100000 ? uniqueNumberEnglishWord[1] + " hundred" + " thousand" : NumberToEnglishWord((int)(_Number / 1000)) + " Thousand " + NumberToEnglishWord(_Number % 1000);
            }
            else if (_Number >= 1000000 && _Number < 1000000000)
            {
                return (_Number == 10000000 || _Number == 1000000 || _Number == 100000000 || _Number == 10000000) ? NumberToEnglishWord(_Number / 1000000) + " Million" :
                    NumberToEnglishWord((int)(_Number / 1000000)) + " Million " + NumberToEnglishWord(_Number % 1000000);
            }
            else if (_Number >= 1000000000 && _Number < 1000000000000)
            {
                return (_Number == 1000000000 || _Number == 10000000000 || _Number == 100000000000) ? NumberToEnglishWord(_Number / 1000000000) + " Billion" :
                    NumberToEnglishWord((int)(_Number / 1000000000)) + " Billion " + NumberToEnglishWord(_Number % 1000000000);
            }
            return "The number is no more then 1,000,000,000,000";
        }
        private string NumberToKhmerhWord(long _Number)
        {
            //create list of number as khmer word
            string[] uniqueNumberKhmerWord = { "", "មួយ", "ពីរ", "បី", "បួន", "ប្រាំ", "ប្រាំមួយ", "ប្រាំពីរ", "ប្រាំបី", "ប្រាំបួន" };
            string[] tensKhmerWord = { "", "ដប់", "ម្ភៃ", "សាមសិប", "សែសិប", "ហាសិប", "ហុកសិប", "ចិតសិប", "ប៉ែតសិប", "កៅសិប" };
            if (_Number < 10)
            {
                return uniqueNumberKhmerWord[_Number];
            }
           
            else

            if (_Number < 100)
            {
                return _Number % 10 == 0 ? tensKhmerWord[_Number / 10] : tensKhmerWord[(int)(_Number / 10)] + uniqueNumberKhmerWord[_Number % 10];
            }
            else if (_Number >= 100 && _Number < 1000)
            {
                return _Number % 100 == 0 ? uniqueNumberKhmerWord[_Number / 100] + "រយ" : NumberToKhmerhWord((int)(_Number / 100)) + "រយ" + NumberToKhmerhWord(_Number % 100);
            }
            else if (_Number >= 1000 && _Number < 10000)
            {
                return _Number % 1000 == 0 ? uniqueNumberKhmerWord[_Number / 1000] +"ពាន់": NumberToKhmerhWord(_Number / 1000) + "ពាន់" + NumberToKhmerhWord(_Number % 1000);
            }
            else if (_Number >= 10000 && _Number < 100000)
            {
                return _Number % 10000 == 0 ? uniqueNumberKhmerWord[_Number / 10000] + "ម៉ឺន": NumberToKhmerhWord((int)(_Number / 10000)) + "ម៉ឺន" + NumberToKhmerhWord(_Number % 10000);
            }
            else if (_Number >= 100000 && _Number < 1000000)
            {
                return _Number % 100000 == 0 ? uniqueNumberKhmerWord[_Number / 100000] + "សែន" : NumberToKhmerhWord((int)(_Number / 100000)) + "សែន" + NumberToKhmerhWord(_Number % 100000);
            }
            else if (_Number >= 1000000 && _Number < 1000000000000)
            {
                return NumberToKhmerhWord(_Number / 1000000) + "លាន " + NumberToKhmerhWord(_Number % 1000000);
            }
            return "The number is no more then 1,000,000,000,000";
        }
    }
}
