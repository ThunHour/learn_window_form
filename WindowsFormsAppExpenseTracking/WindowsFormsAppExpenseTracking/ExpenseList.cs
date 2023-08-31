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
    public partial class ExpenseList : Form
    {
        public ExpenseList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ExpenseList_Load(object sender, EventArgs e)
        {
            frmmain frm = null;
            frm = (frmmain)Application.OpenForms["frmmain"];

            txtExpenseList.Text = frm.ExpenseList;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
