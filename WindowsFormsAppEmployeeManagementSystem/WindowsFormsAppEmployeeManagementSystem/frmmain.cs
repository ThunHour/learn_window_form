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
namespace WindowsFormsAppEmployeeManagementSystem
{
    public partial class frmmain : Form
    {
        public SqlConnection EmployeeDBCon = null;
        public frmmain()
        {
            InitializeComponent();
           

        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddModifyEmployee frm= new frmAddModifyEmployee();
            frm.MdiParent = this;   
            frm.Show();
        }
     
        public void ConnectToDB()
        {
            string constr = "Data Source=localhost;Initial Catalog=EmployeeDB;User ID=SQLDeveloper;Password=123456";
            EmployeeDBCon = new SqlConnection(constr);

            EmployeeDBCon.Open();

            if (EmployeeDBCon.State == ConnectionState.Open)
            {
                lblStatus.Text = "Connected to EmployeeDB";
            }


        }
     

        private void frmmain_Load(object sender, EventArgs e)
        {
            ConnectToDB();
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmemployeelist frm= new frmemployeelist();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
