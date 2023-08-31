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
    public enum Operation
    {
        OprNone = 0,
        OptNew = 1,
        OptEdit = 2,
        OptDelete = 3,
        OptSave = 4
    }
    public partial class frmproductmanagment : Form
    {
        public Operation Operation = Operation.OprNone;
        public ProductManagement ProductMgr = new ProductManagement();
        public frmproductmanagment()
        {
            InitializeComponent();
        }

        private void btnViewLoanList_Click(object sender, EventArgs e)
        {
            frmlistofproduct frm = new frmlistofproduct();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Operation = Operation.OptNew;
            txtProductId.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            dtpDeadlineProduct.Value = DateTime.Today;
            txtProductQuantity.Clear();
            if (ProductMgr.Count == 0)
            {
                txtProductId.Text = "EXP0001";
                return;
            }
            txtProductId.Text = "EXP" + (ProductMgr.Count + 1).ToString("D4");
        }

        private void txtProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
    (!char.IsDigit(e.KeyChar)) &&
    e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
(!char.IsDigit(e.KeyChar)) &&
e.KeyChar != ((char)Keys.Back) &&
e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operation = Operation.OptSave;
            ProductDetail exp = null;
            errorPro.Clear();
            if (txtProductId.Text.Trim().Length==0)
            {
                errorPro.SetError(txtProductId, "please click on new button for get id");
                errorPro.SetIconAlignment(txtProductId, ErrorIconAlignment.MiddleLeft);
                errorPro.SetError(btnNew, "click here");
                errorPro.SetIconAlignment(btnNew, ErrorIconAlignment.MiddleLeft);
                txtProductId.Focus();
                return;
            }
            else
            if (txtProductName.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtProductName, "please input all the field..!!");
                errorPro.SetIconAlignment(txtProductName, ErrorIconAlignment.MiddleLeft);
                txtProductName.Focus();
                return;
            }
            else if (txtProductPrice.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtProductPrice, "please input all the field..!!");
                errorPro.SetIconAlignment(txtProductPrice, ErrorIconAlignment.MiddleLeft);
                txtProductPrice.Focus();
                return;
            }
            else if (txtProductQuantity.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtProductQuantity, "please input all the field..!!");
                errorPro.SetIconAlignment(txtProductQuantity, ErrorIconAlignment.MiddleLeft);
                txtProductQuantity.Focus();
                return;
            }
            exp = new ProductDetail();
            exp.ProductId = txtProductId.Text;
            exp.ProductName = txtProductName.Text;
            exp.ProductPrice = float.Parse(txtProductPrice.Text);
            exp.ProductDeadline = dtpDeadlineProduct.Value;
            exp.ProductQuantity = int.Parse(txtProductQuantity.Text);
            ProductMgr.add(exp);
            txtTotalPriceOfAllProduct.Text = ProductMgr.getTotalAmount().ToString("C");
            lblPosition.Text = ProductMgr.Count.ToString() + "/" + ProductMgr.Count.ToString();

        }

        private void frmproductmanagment_Load(object sender, EventArgs e)
        {
            btnNew_Click(null, null);
            timer.Start();  
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            ProductDetail temp = null;
            temp = ProductMgr.MoveFirst();
            if (temp == null)
            {
                MessageBox.Show("There are no element in expense list.");
                return;
            }
            Display(temp);
            lblPosition.Text = ProductMgr.CurrentPosition.ToString() + "/" + ProductMgr.Count.ToString();

        }
        public void Display(ProductDetail exp)
        {
            txtProductId.Text = exp.ProductId;
            txtProductName.Text = exp.ProductName;
            txtProductPrice.Text = exp.ProductPrice.ToString();
            dtpDeadlineProduct.Value = exp.ProductDeadline;
            txtProductQuantity.Text = exp.ProductQuantity.ToString();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            ProductDetail temp = null;
            temp = ProductMgr.MovePrevious();
            if (temp == null)
            {
                MessageBox.Show("There are no element in expense list.");
                return;
            }
            Display(temp);
            lblPosition.Text = ProductMgr.CurrentPosition.ToString() + "/" + ProductMgr.Count.ToString();

        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            ProductDetail temp = null;
            temp = ProductMgr.MoveNext();
            if (temp == null)
            {
                MessageBox.Show("There are no element in expense list.");
                return;
            }
            Display(temp);
            lblPosition.Text = ProductMgr.CurrentPosition.ToString() + "/" + ProductMgr.Count.ToString();

        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            ProductDetail temp = null;
            temp = ProductMgr.MoveLast();
            if (temp == null)
            {
                MessageBox.Show("There are no element in expense list.");
                return;
            }
            Display(temp);
            lblPosition.Text = ProductMgr.CurrentPosition.ToString() + "/" + ProductMgr.Count.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDetail currentObj = null;
            currentObj = ProductMgr.getListOfProduct[ProductMgr.CurrentPosition - 1];
            if (MessageBox.Show("Are you sure to detele the expense." + Environment.NewLine + currentObj.ToString(), "Delete ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProductMgr.Delete(currentObj);
                if (ProductMgr.Count == 0)
                {
                    txtProductId.Clear();
                    txtProductName.Clear();
                    txtProductPrice.Clear();
                    errorPro.Clear();
                    txtProductQuantity.Clear();
                    dtpDeadlineProduct.Value = DateTime.Today;
                    txtTotalPriceOfAllProduct.Clear();
                    lblPosition.Text = "";
                    return;
                }
                Operation = Operation.OptDelete;
                Display(ProductMgr.getListOfProduct[ProductMgr.CurrentPosition - 1]);
                lblPosition.Text = lblPosition.Text = ProductMgr.CurrentPosition.ToString() + "/" + ProductMgr.Count;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductDetail exp = null;
            ProductDetail Old_exp = null;
            errorPro.Clear();
            Operation = Operation.OptEdit; 
           
            errorPro.Clear();
            if (txtProductId.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtProductId, "please click on new button for get id");
                errorPro.SetIconAlignment(txtProductId, ErrorIconAlignment.MiddleLeft);
                errorPro.SetError(btnNew, "click here");
                errorPro.SetIconAlignment(btnNew, ErrorIconAlignment.MiddleLeft);
                txtProductId.Focus();
                return;
            }
            else
            if (txtProductName.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtProductName, "please input all the field..!!");
                errorPro.SetIconAlignment(txtProductName, ErrorIconAlignment.MiddleLeft);
                txtProductName.Focus();
                return;
            }
            else if (txtProductPrice.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtProductPrice, "please input all the field..!!");
                errorPro.SetIconAlignment(txtProductPrice, ErrorIconAlignment.MiddleLeft);
                txtProductPrice.Focus();
                return;
            }
            else if (txtProductQuantity.Text.Trim().Length == 0)
            {
                errorPro.SetError(txtProductQuantity, "please input all the field..!!");
                errorPro.SetIconAlignment(txtProductQuantity, ErrorIconAlignment.MiddleLeft);
                txtProductQuantity.Focus();
                return;
            }
            Operation = Operation.OptEdit;
            exp = new ProductDetail();
           
            Old_exp = ProductMgr.getListOfProduct[ProductMgr.CurrentPosition - 1];
            exp.ProductId = txtProductId.Text;
            exp.ProductName = txtProductName.Text;
            exp.ProductPrice = float.Parse(txtProductPrice.Text.Trim());
            exp.ProductDeadline = dtpDeadlineProduct.Value.Date;
            exp.ProductQuantity = int.Parse(txtProductQuantity.Text.Trim());
            ProductMgr.Update(Old_exp, exp);
            txtTotalPriceOfAllProduct.Text = ProductMgr.getTotalAmount().ToString("C");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnViewProductList.Enabled = ProductMgr.Count > 0;
            btnMoveFirst.Enabled = ProductMgr.Count > 0;
            btnMoveLast.Enabled = ProductMgr.Count > 0;
            btnMoveNext.Enabled = ProductMgr.Count > 0;
            btnMovePrevious.Enabled = ProductMgr.Count > 0;
            if (Operation == Operation.OptNew || ProductMgr.Count == 0)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

            }
            else if (Operation == Operation.OptEdit || Operation == Operation.OptDelete)
            {
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else if (Operation == Operation.OptSave)
            {
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
