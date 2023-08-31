using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsAppEmployeeMgnt
{
    public partial class frmmain : Form
    {
        public SqlConnection EmployeeDBCon = null;

        public frmmain()
        {
            InitializeComponent();
        }

        private void manageEmplyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddmodifyemployee frm = new frmAddmodifyemployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            ConnectToDB();
        }


        public void ConnectToDB()
        {
            string constr = "Data Source=localhost;Initial Catalog=EmployeeDB;User ID=SQLDeveloper;Password=123456";
            EmployeeDBCon = new SqlConnection(constr);

            EmployeeDBCon.Open();

            if (EmployeeDBCon.State == ConnectionState.Open) {
                lblstatus.Text = "Connected to EmployeeDB";
            }


        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmemployeelist frm = new frmemployeelist();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void displayUserControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtestusercontrol frm = new frmtestusercontrol();
            frm.MdiParent = this;
            frm.WindowState=FormWindowState.Maximized;
            frm.Show();
        }
    }
}
