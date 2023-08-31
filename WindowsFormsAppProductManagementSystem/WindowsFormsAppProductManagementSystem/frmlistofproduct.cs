using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppProductManagementSystem.Classes;
namespace WindowsFormsAppProductManagementSystem
{
  
    public partial class frmlistofproduct : Form
    {
        frmproductmanagment frm = null;
        public frmlistofproduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewRepaymentSchedule_Click(object sender, EventArgs e)
        {

        }

        private void frmlistofproduct_Load(object sender, EventArgs e)
        {
            listViewProduct.Columns[0].Width = listViewProduct.Width / 5;
            listViewProduct.Columns[1].Width = listViewProduct.Width / 5;
            listViewProduct.Columns[2].Width = listViewProduct.Width / 5;
            listViewProduct.Columns[3].Width = listViewProduct.Width / 5;
            listViewProduct.Columns[4].Width = listViewProduct.Width / 5;
            frm = (frmproductmanagment)Application.OpenForms["frmproductmanagment"];
            DisplayProduct(frm.ProductMgr.getListOfProduct);
            txtTotalAmount.Text = frm.ProductMgr.getTotalAmount().ToString("C");
        }
        public void DisplayProduct(ProductDetail[] list_exp)
        {
            listViewProduct.Items.Clear();
            if (list_exp == null)
            {
                return;
            }
            ListViewItem item = null;
            foreach (ProductDetail exp in list_exp)
            {
                item = listViewProduct.Items.Add(exp.ProductId);
                item.SubItems.Add(exp.ProductName);
                item.SubItems.Add(exp.ProductPrice.ToString("C"));
                item.SubItems.Add(exp.ProductQuantity.ToString());
                item.SubItems.Add(exp.ProductDeadline.ToString("dd-MMM-yyyy"));
               
            }

        }

        private void listViewProduct_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
              
                ProductDetail._SortProductField = SortProductFeild.ProductID;
                Array.Sort(frm.ProductMgr.getListOfProduct);
            }
            else if (e.Column == 1)
            {
                ProductDetail._SortProductField = SortProductFeild.ProductName;
                Array.Sort(frm.ProductMgr.getListOfProduct);


      
            }
            else if (e.Column == 2)
            {
                ProductDetail._SortProductField = SortProductFeild.ProductPrice;
                Array.Sort(frm.ProductMgr.getListOfProduct);


              
            }
            else if (e.Column == 3)
            {
                ProductDetail._SortProductField = SortProductFeild.ProductQuantity;
                Array.Sort(frm.ProductMgr.getListOfProduct);


            }
            else if (e.Column == 4)
            {
                ProductDetail._SortProductField = SortProductFeild.ProductDate;
                Array.Sort(frm.ProductMgr.getListOfProduct);


               ;
            }

            DisplayProduct(frm.ProductMgr.getListOfProduct);
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
