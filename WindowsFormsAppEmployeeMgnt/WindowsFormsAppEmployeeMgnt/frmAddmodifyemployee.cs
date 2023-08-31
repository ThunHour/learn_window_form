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
using System.IO;

namespace WindowsFormsAppEmployeeMgnt
{
    public partial class frmAddmodifyemployee : Form
    {
        public string EmpID_To_Modified = "";

        public frmAddmodifyemployee()
        {
            InitializeComponent();
        }

        private void frmAddmodifyemployee_Load(object sender, EventArgs e)
        {
            if (EmpID_To_Modified != "")
            {
                txtemployeeid.ReadOnly = true;
                LoadEmployeeByID(EmpID_To_Modified);
            }
            else {
                txtemployeeid.ReadOnly = true;
                txtemployeeid.Text = getNewEmployeeID();
            }
        }

       

        public void LoadEmployeeByID(string empid) {
            string sql = "Select * from tblemployee where EmployeeID='" + empid + "'";
            SqlDataReader Reader = null;
            SqlCommand com = new SqlCommand(sql);
            byte[] ImageByte = null;
            Image empPhoto = null;
            MemoryStream Mem = null;


            com.Connection = ((frmmain)Application.OpenForms["frmmain"]).EmployeeDBCon;
            Reader = com.ExecuteReader();
            Reader.Read();

            txtemployeeid.Text = empid;
            txtemployeename.Text = Reader["EmployeeName"].ToString();
            cbogender.Text = Reader["Gender"].ToString();
            dtpdob.Value = DateTime.Parse(Reader["EmployeeDOB"].ToString());
            txtNIDpassport.Text = Reader["NID_Passport"].ToString();

            // to evaluate that the photo field has value
            if (!Reader.IsDBNull(Reader.GetOrdinal("photo")))
            {

                ImageByte = (byte[])Reader["Photo"];
                Mem = new MemoryStream();
                Mem.Write(ImageByte, 0, ImageByte.Length);
                empPhoto = Image.FromStream(Mem);
                picphoto.BackgroundImage = empPhoto;
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else {
                picphoto.BackgroundImage = null;
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;
            }



            Reader.Close();
        }

        public string getNewEmployeeID() {
            string sql = "select Max(Right(EmployeeID,3)) as 'Last_Emp_ID' from tblemployee";
            int lastID = 0;

            SqlCommand com = new SqlCommand(sql);
            IDataReader Reader = null;


            com.Connection= ((frmmain)Application.OpenForms["frmmain"]).EmployeeDBCon;

            try
            {
                Reader = com.ExecuteReader();
                Reader.Read();
                lastID = int.Parse(Reader["Last_Emp_ID"].ToString());
            }
            catch (Exception ex) { 
            
            }

            Reader.Close();

            return "EMP" + (lastID + 1).ToString("D3");
           

     
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string DOB = dtpdob.Value.Month.ToString("D2") + "/" + dtpdob.Value.Day.ToString("D2") + "/" +
                    dtpdob.Value.Year.ToString();
            int count = 0;
            SqlParameter param;
            SqlCommand Com = null;
            MemoryStream Mem= null;




            if (EmpID_To_Modified == "")
            {
                sql = "Insert into tblemployee values('" +
                            txtemployeeid.Text + "',N'" + txtemployeename.Text + "','"
                            + cbogender.Text + "','" + DOB
                            + "',@NID,@img)";

                Com = new SqlCommand(sql);
                
                param = new SqlParameter("img", SqlDbType.Image);
                Mem = new MemoryStream();
                picphoto.BackgroundImage.Save(Mem, System.Drawing.Imaging.ImageFormat.Png);
                param.Value = Mem.ToArray();
                Com.Parameters.Add(param);

                param = new SqlParameter("NID", SqlDbType.NVarChar);
                param.Value = txtNIDpassport.Text.Trim();
                Com.Parameters.Add(param);


            }
            else
            {

                sql = "update tblemployee set EmployeeName=N'" +
                        txtemployeename.Text + "',Gender='"
                        + cbogender.Text + "',EmployeeDOB='" + DOB
                        + "',NID_Passport='" + txtNIDpassport.Text + "',photo=@img where EmployeeID='" + EmpID_To_Modified + "'";

                // MessageBox.Show(sql);
                Com = new SqlCommand(sql);

                param = new SqlParameter("img", SqlDbType.Image);
                Mem = new MemoryStream();
                picphoto.BackgroundImage.Save(Mem, System.Drawing.Imaging.ImageFormat.Png);
                param.Value = Mem.ToArray();
                Com.Parameters.Add(param);
            }


            Com.Connection = ((frmmain)Application.OpenForms["frmmain"]).EmployeeDBCon;

            try
            {
                // Insert ,Delete, Update

                count = Com.ExecuteNonQuery();
                //MessageBox.Show(count.ToString());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            this.Close();
            //MessageBox.Show(sql);

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            Image img = null;

            OpenFileDialog OpenPhoto = new OpenFileDialog();

            OpenPhoto.Filter = "Png file(*.png)|*.png|Jpg(*.jpg)|*.jpg";
            OpenPhoto.FilterIndex = 0;
            OpenPhoto.Multiselect = false;
            OpenPhoto.DefaultExt = "png";
            OpenPhoto.CheckFileExists = true;

            if (OpenPhoto.ShowDialog() == DialogResult.OK) { 
                img = Image.FromFile(OpenPhoto.FileName);
                picphoto.BackgroundImage = img;
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
            

        }
    }   
}
