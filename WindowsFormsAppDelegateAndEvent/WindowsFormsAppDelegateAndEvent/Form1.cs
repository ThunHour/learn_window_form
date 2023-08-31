using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDelegateAndEvent
{
    public partial class Form1 : Form
    {
        public Expense obj=new Expense("001","study",120.00f);
        public void AmountChnaged(float exp_old,float exp_new)
        {
            MessageBox.Show(String.Format("Old Amount :{0} but New Amount :{1}",exp_old.ToString("C"),exp_new.ToString("C")),"AmountChnage Event Occur");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj.AmountChanged += AmountChnaged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.Exp_Amount = 15.00f;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            obj.AmountChanged -= AmountChnaged;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            obj.AmountChanged += AmountChnaged;
        }
    }
}
