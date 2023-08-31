using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEmployeeMgnt
{
    public partial class frmtestusercontrol : Form
    {

        public void EmployeeAction(Object Sender, EmployeeActions action) {
            if (action == EmployeeActions.Edit) {
                MessageBox.Show("Edit Clicked");
            }

            if (action == EmployeeActions.Delete)
            {
                MessageBox.Show("Delete Clicked");
            }
        }

        public frmtestusercontrol()
        {
            InitializeComponent();
        }

        private void frmtestusercontrol_Load(object sender, EventArgs e)
        {
            EmployeeDisplay employeedsp = null;

            for (int i = 1; i <= 20;i++) { 
              employeedsp = new EmployeeDisplay();
              employeedsp.Name = "emp" + i.ToString();
              employeedsp.EmployeeAction += EmployeeAction;
              flowLayoutPanel1.Controls.Add(employeedsp);

            }

 
        }
    }
}
