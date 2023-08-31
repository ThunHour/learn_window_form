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
namespace WindowsFormsAppEmployeeManagementSystem
{
    public partial class frmAddModifyEmployee : Form
    {
        public string EmpId_to_Modified = "";
        public frmAddModifyEmployee()
        {
            InitializeComponent();
        }
        
        public void LoadEmpByID(string empId)
        {
            string sql = "Select * from tblemployee where EmployeeID='" + empId + "'";
            SqlDataReader reader = null;
            byte[] imgbyte = null;
            Image empPhoto = null;
            MemoryStream Mem = null;
            SqlCommand cmd = new SqlCommand(sql);  
            cmd.Connection= ((frmmain)Application.OpenForms["frmmain"]).EmployeeDBCon;
            reader= cmd.ExecuteReader();
            reader.Read();

            txtemployeeid.Text = empId;
            txtemployeename.Text = reader["EmployeeName"].ToString();
            cbogender.Text = reader["Gender"].ToString();
            dtpdob.Value = DateTime.Parse(reader["EmployeeDOB"].ToString());
            txtNIDpassport.Text = reader["NID_Passport"].ToString();

            if (!reader.IsDBNull(reader.GetOrdinal("photo")))
            {
                imgbyte = (byte[])reader["photo"];
                Mem=new MemoryStream();
                Mem.Write(imgbyte,0,imgbyte.Length);
                empPhoto=Image.FromStream(Mem);
                picphoto.BackgroundImage=empPhoto;
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;


            }
            else
            {
                picphoto.BackgroundImage = null;
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
            reader.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            SqlParameter sqlpara = null;
            MemoryStream ms = null;
            SqlCommand Com = null;
            string DOB = dtpdob.Value.Month.ToString("D2") + "/" + dtpdob.Value.Day.ToString("D2") + "/" +
              dtpdob.Value.Year.ToString();
            if (EmpId_to_Modified == "")
            {
                sql = "Insert into tblemployee values('" +
                   txtemployeeid.Text + "',N'" + txtemployeename.Text + "','"
                   + cbogender.Text + "','" + DOB
                   + "','" + txtNIDpassport.Text + "',@img)";
                Com = new SqlCommand(sql);
                ms = new MemoryStream();
                picphoto.BackgroundImage.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                sqlpara = new SqlParameter("img", SqlDbType.Image);
                sqlpara.Value = ms.ToArray();
                Com.Parameters.Add(sqlpara);
               
            }
            else
            {
                sql= "Update tblemployee set EmployeeName=N'"+txtemployeename.Text+"' ,Gender='"+ cbogender.Text + "',EmployeeDOB='" + DOB
                   + "',NID_Passport='" + txtNIDpassport.Text + "',photo=@img where EmployeeID='"+EmpId_to_Modified+"'";
                Com = new SqlCommand(sql);
                ms = new MemoryStream();
                picphoto.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                sqlpara = new SqlParameter("img", SqlDbType.Image);
                sqlpara.Value = ms.ToArray();
                Com.Parameters.Add(sqlpara);

            }
           
            Com.Connection = ((frmmain)Application.OpenForms["frmmain"]).EmployeeDBCon;
            try
            {
                Com.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
          
            txtemployeeid.Clear();
            txtemployeename.Clear();   
            txtNIDpassport.Clear();
            cbogender.Items.Clear();
            dtpdob.Value= DateTime.Now; 

        }
        public string getNewEmployeeID()
        {
            string sql = "SELECT COUNT(EmployeeID) as 'Last_Emp_ID'FROM tblemployee; ";
            int lastID = 0;

            SqlCommand com = new SqlCommand(sql);
            IDataReader Reader = null;


            com.Connection = ((frmmain)Application.OpenForms["frmmain"]).EmployeeDBCon;

            try
            {
                Reader = com.ExecuteReader();
                Reader.Read();
                lastID = int.Parse(Reader["Last_Emp_ID"].ToString());
            }
            catch (Exception ex)
            {

            }

            Reader.Close();

            return "EMP" + (lastID + 1).ToString("D3");



        }
        private void frmAddModifyEmployee_Load(object sender, EventArgs e)
        {
            if (EmpId_to_Modified != "")
            {
                txtemployeeid.ReadOnly = true;
                LoadEmpByID(EmpId_to_Modified);
            }
            else
            {
                txtemployeeid.ReadOnly = true;
                txtemployeeid.Text = getNewEmployeeID();
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            Image img = null;
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter = "Png file(*.png)|*.png|Jpng(*.jpg|*.jpg)";
            ofd.FilterIndex = 0;
            ofd.Multiselect = false;
            ofd.DefaultExt = "png";
            ofd.CheckFileExists = true; 
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                img=Image.FromFile(ofd.FileName);
                picphoto.BackgroundImage = img;
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
