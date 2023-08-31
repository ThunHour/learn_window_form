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
    public enum EmployeeActions {
        Edit=1,
        Delete=2,
    }

    public delegate void EmployeeActionHandler(object Sender,EmployeeActions action);

    public partial class EmployeeDisplay : UserControl
    {
        public event EmployeeActionHandler EmployeeAction;
        public EmployeeDisplay()
        {
            InitializeComponent();
        }

        public Image EmployeeImage
        {
            get { return PichPhoto.BackgroundImage; }
            set {
                PichPhoto.BackgroundImage = value;
                PichPhoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        public string EmployeeID {
            get { return lblempid.Text; }
            set { lblempid.Text = value; }
        }

        public string EmployeeName
        {
            get { return lblempname.Text; }
            set { lblempname.Text = value; }
        }

        public string EmployeeDOB
        {
            get { return lbldob.Text; }
            set { lbldob.Text = value; }
        }
        public string EmployeeGender
        {
            get { return lblgender.Text; }
            set { lblgender.Text = value; }
        }

        public string EmployeePassportorNID
        {
            get { return lblNID.Text; }
            set { lblNID.Text = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EmployeeAction != null) {
                EmployeeAction(this, EmployeeActions.Edit);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EmployeeAction != null)
            {
                EmployeeAction(this, EmployeeActions.Delete);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblempid_Click(object sender, EventArgs e)
        {

        }
    }
}
