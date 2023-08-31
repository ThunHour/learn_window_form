using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQuadraticCalculator
{
    public partial class frmQuadraticCalculator : Form
    {
        public frmQuadraticCalculator()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCoefficientOfXSquare_A_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // declear variable 
            int CoefficientOfXSquare_A = 0;
            int CoefficientOfX_B = 0;
            int Constant_C = 0;
          

            //To validate the input
            errorPro.Clear();
            int temp = 0;

            //check Coefficient Of X Square
            if(int.TryParse(txtCoefficientOfXSquare_A.Text, out temp) == false)
            {
                errorPro.SetError(txtCoefficientOfXSquare_A, "Please input correctly");
                errorPro.SetIconAlignment(txtCoefficientOfXSquare_A, ErrorIconAlignment.MiddleRight);
                txtCoefficientOfXSquare_A.Focus();
                txtCoefficientOfXSquare_A.SelectAll();
                return;
            }
            CoefficientOfXSquare_A = temp;


            //check Coefficient Of X
            if (int.TryParse(txtCoefficientOfX_B.Text, out temp) == false)
            {
                errorPro.SetError(txtCoefficientOfX_B, "Please input correctly");
                errorPro.SetIconAlignment(txtCoefficientOfX_B, ErrorIconAlignment.MiddleRight);
                txtCoefficientOfX_B.Focus();
                txtCoefficientOfX_B.SelectAll();
                return;
            }
            CoefficientOfX_B = temp;

            //Check Constant
            if (int.TryParse(txtConstant_C.Text, out temp) == false)
            {
                errorPro.SetError(txtConstant_C, "Please input correctly");
                errorPro.SetIconAlignment(txtConstant_C, ErrorIconAlignment.MiddleRight);
                txtConstant_C.Focus();
                txtConstant_C.SelectAll();
                return;
            }
            Constant_C = temp;

            //create object 
            Quadratic q = new Quadratic(CoefficientOfXSquare_A, CoefficientOfX_B, Constant_C);
            if(q.getfirstRoot()== 2147483647 && q.getsecondRoot()== 2147483647)
            {
                errorPro.SetError(txtX1, "Delta is less then zero");
                errorPro.SetIconAlignment(txtX1, ErrorIconAlignment.MiddleRight);
                btnClear_Click(sender, e);
                errorPro.SetError(txtX2, "Delta is less then zero");
                errorPro.SetIconAlignment(txtX2, ErrorIconAlignment.MiddleRight);
                btnClear_Click(sender, e);
                return;
            }
            else
            {
                txtX1.Text = q.getfirstRoot().ToString();
                txtX2.Text = q.getsecondRoot().ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCoefficientOfXSquare_A.Clear();
            txtCoefficientOfX_B.Clear();
            txtConstant_C.Clear();
            
            txtX1.Clear();
            txtX2.Clear();
            txtCoefficientOfXSquare_A.Focus();
        }
        public class Quadratic {
            private int _a;
            private int _b;
            private int _c;
            private float x1;
            private float x2;
            private int deltaValue=0;
            public Quadratic(int a,int b,int c)
            {
                this._a = a;
                this._b = b;
                this._c = c;
            }
            public float getfirstRoot()
            {
                this.getDeltaAndRoot(out  x1, out  x2);
                return x1;
            }
            public float getsecondRoot()
            {
                this.getDeltaAndRoot(out  x1, out  x2 );
                return x2;
            }

            public void getDeltaAndRoot(out float x1,out float x2)
            {

                deltaValue=(int)(Math.Pow(_b,2)-(4*_a* _c));
                if (deltaValue < 0)
                {
                    x1 = int.MaxValue;
                    x2 = int.MaxValue;
                    return;


                }
                else
                {
                    x1 = (float)(-_b - Math.Sqrt(deltaValue)) / (2 * _a);
                    x2 = (float)(-_b + Math.Sqrt(deltaValue)) / (2 * _a);
                }
              
                
            }
        }

    }
}
