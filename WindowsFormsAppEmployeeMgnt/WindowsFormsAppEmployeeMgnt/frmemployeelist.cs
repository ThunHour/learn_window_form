﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsAppEmployeeMgnt
{
    public partial class frmemployeelist : Form
    {
        string ID_to_delete_Or_modify = "";
        public frmemployeelist()
        {
            InitializeComponent();
        }

        private void frmemployeelist_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            LoadEmployeeWithPhoto();
        }

        public void LoadEmployee(string Searchstr="") {


            string sql = "SELECT [EmployeeID] as 'អត្ថលេខបុគ្កលិក',[EmployeeName] as 'ឈ្មោះ',[Gender] as 'ភេទ',[EmployeeDOB]​ as 'ថ្ងៃខែឆ្នាំកំណើត' ,[NID_Passport]​ as ​'លេខអត្តសញ្ញាណប័ន'​ FROM tblemployee";


            SqlCommand com = null;
            SqlDataAdapter da = null;
            DataSet Ds = null;


            if (Searchstr != "") {
                sql = sql + " where " + Searchstr;
            }

            com = new SqlCommand(sql);


            com.Connection = ((frmmain)this.MdiParent).EmployeeDBCon;
            da = new SqlDataAdapter(com);
            Ds = new DataSet();
            da.Fill(Ds, "Employee");

            dgdemployeelist.DataSource = Ds.Tables["Employee"];

        }

        public void LoadEmployeeWithPhoto(string Searchstr = "")
        {

            byte[] ImageByte = null;
            Image empPhoto = null;
            MemoryStream Mem = null;

            string sql = "SELECT * FROM tblemployee";
            EmployeeDisplay employeeds = null;



            SqlCommand com = null;
            SqlDataAdapter da = null;
            DataSet Ds = null;


            if (Searchstr != "")
            {
                sql = sql + " where " + Searchstr;
            }

            com = new SqlCommand(sql);


            com.Connection = ((frmmain)this.MdiParent).EmployeeDBCon;
            da = new SqlDataAdapter(com);
            Ds = new DataSet();
            da.Fill(Ds, "Employee");
            fltale.Controls.Clear();

            foreach (DataRow item in Ds.Tables["Employee"].Rows)
            {
                employeeds = new EmployeeDisplay();
                ImageByte = (byte[])item["Photo"];
                Mem = new MemoryStream();
                Mem.Write(ImageByte, 0, ImageByte.Length);
                empPhoto = Image.FromStream(Mem);

                employeeds.EmployeeImage = empPhoto;
                employeeds.EmployeeID = item["EmployeeID"].ToString();
                employeeds.EmployeeName = item["EmployeeName"].ToString();
                employeeds.EmployeeGender = item["Gender"].ToString();
                employeeds.EmployeeDOB = ((DateTime)item["EmployeeDOB"]).ToString("dd-MMM-yyyy");
                employeeds.EmployeePassportorNID = item["NID_Passport"].ToString();
                employeeds.EmployeeAction += EmployeeAction;
                fltale.Controls.Add(employeeds);

            }
            


            

        }

        public void EmployeeAction(Object Sender, EmployeeActions action)
        {
            if (action == EmployeeActions.Edit)
            {
                ID_to_delete_Or_modify = ((EmployeeDisplay)Sender).EmployeeID;
                btnedit_Click(null, null);
            }

            if (action == EmployeeActions.Delete)
            {
                ID_to_delete_Or_modify = ((EmployeeDisplay)Sender).EmployeeID;
                btndelete_Click(null, null);
                btnsearch_Click(null,null);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string Searchst = "";



            if (txtsearchname.Text.Trim() != "") {
                Searchst = "EmployeeName like N'%" + txtsearchname.Text.Trim() + "%'";  
            }

            if (txtsearchpassport.Text.Trim() != "") {
                if (Searchst == "")
                {
                    Searchst = "NID_Passport = '" + txtsearchpassport.Text.Trim() + "'";
                }
                else {
                    Searchst = Searchst + "  Or " + "NID_Passport = '" + txtsearchpassport.Text.Trim() + "'";
                }
            }
            LoadEmployee(Searchst);
            LoadEmployeeWithPhoto(Searchst);

        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            frmAddmodifyemployee frm = new frmAddmodifyemployee();
            frm.ShowDialog();
            LoadEmployee("");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sql = "";
           
            SqlCommand com = null;
            int count = 0;


            //ID_to_delete = dgdemployeelist.Rows[dgdemployeelist.SelectedRows[0].Index].Cells[0].Value.ToString();
            sql = "Delete from tblemployee where EmployeeID='" + ID_to_delete_Or_modify + "'";

            if (MessageBox.Show("Are you sure to delete employee ID:" + ID_to_delete_Or_modify, "Delete Employee"
                , MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {

                com = new SqlCommand(sql);
                com.Connection = ((frmmain)Application.OpenForms["frmmain"]).EmployeeDBCon;
                try
                {

                    count = com.ExecuteNonQuery();
                    if (count > 0) {
                        LoadEmployee("");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }



            //MessageBox.Show(ID_to_delete);




        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string ID_to_modify = "";
            // ID_to_modify = dgdemployeelist.Rows[dgdemployeelist.SelectedRows[0].Index].Cells[0].Value.ToString();

            frmAddmodifyemployee frm = new frmAddmodifyemployee();
            frm.EmpID_To_Modified = ID_to_delete_Or_modify;
            frm.ShowDialog();
            LoadEmployee("");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btndelete_Click(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnedit_Click(null,null);
        }

        private void dgdemployeelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fltale_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
