using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace PersonnelManagementSystem.ManagementFunction.EmployeeManagement
{
    public partial class FrmUpdateEmployee : Form
    {
        public FrmUpdateEmployee()
        {
            InitializeComponent();
        }

        //各种数据输入格式是否正确
        private void CheckDataErrorLoad()
        {
            int val;
            bool SalaryIntJudge = int.TryParse(txtSalary.Text, out val);
            if (txtName.Text == "")
            {
                lblNameError.Text = "*必填";
            }
            else if (txtLoginName.Text == "")
            {
                lblLoginNameError.Text = "*必填";
            }
            else if (txtLoginPwd.Text == "")
            {
                lblLoginPwdError.Text = "*必填";
            }
            else if (txtEmail.Text == "")
            {
                lblEmailError.Text = "*必填";
            }
            else if (SalaryIntJudge == false)
            {
                lblSalaryError.Text = "请输入数字";
                if (int.Parse(txtSalary.Text) < 0)
                {
                    lblSalaryError.Text = "不能小于0";
                }
            }
            else
            {
                //数据输入格式全部正确
                DataFormatError = false;
            }
        }

        //定义一个根据员工ID获得员工表指定数据的方法
        private string ObtainEmployeeData(string employeeData)
        {
            string obtainemployeedata = @"select " + employeeData + " from tblEmployee where employeeId ='" + employeeid + "'";
            string employeedata = SqlHelper.ExecuteScalar(obtainemployeedata).ToString();
            return employeedata;
        }

        //定义员工ID
        public string employeeid;

        //定义一个布尔变量，用来防止数据输入格式错误
        public bool DataFormatError = true;

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            FrmUploadPhoto uploadphoto = new FrmUploadPhoto();
            uploadphoto.ShowDialog();
            //判断员工查询窗体是否按了确定按钮
            if (uploadphoto.DialogResult == DialogResult.OK)
            {
                picPhoto.ImageLocation = uploadphoto.TxtPhotoPath.Text;
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            DataFormatError = true;
            CheckDataErrorLoad();
            if (DataFormatError == false)
            {
                //根据cbDepartment内的部门名称查询部门编号，定义departmentid保存它
                string DepartmentIdlookup = "select departmentId from tblDepartment where departmentName ='" + cbDepartment.Text + "'";
                string departmentid = SqlHelper.ExecuteScalar(DepartmentIdlookup).ToString();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                conn.Open();

                string sqlUpdate = "Update tblEmployee set employeeName=@employeeName,employeeLoginName=@employeeLoginName,employeeLoginPwd=@employeeLoginPwd,employeeEmail=@employeeEmail,employeeBaseSalary=@employeeBaseSalary,employeeRank=@employeeRank,employeePhone=@employeePhone,departmentId=@departmentId,employeePosition=@employeePosition,employeePicture=@employeePicture where [employeeId] ='" + employeeid + "'";
                SqlParameter prmemployeeName = new SqlParameter("@employeeName", SqlDbType.VarChar, 50);
                SqlParameter prmemployeeLoginName = new SqlParameter("@employeeLoginName", SqlDbType.VarChar, 20);
                SqlParameter prmemployeeLoginPwd = new SqlParameter("@employeeLoginPwd", SqlDbType.VarChar, 20);
                SqlParameter prmemployeeEmail = new SqlParameter("@employeeEmail", SqlDbType.VarChar, 50);
                SqlParameter prmemployeeBaseSalary = new SqlParameter("@employeeBaseSalary", SqlDbType.Int);
                SqlParameter prmemployeeRank = new SqlParameter("@employeeRank", SqlDbType.Int);
                SqlParameter prmemployeePhone = new SqlParameter("@employeePhone", SqlDbType.VarChar, 50);
                SqlParameter prmdepartmentId = new SqlParameter("@departmentId", SqlDbType.Int);
                SqlParameter prmemployeePosition = new SqlParameter("@employeePosition", SqlDbType.VarChar, 50);
                SqlParameter prmemployeePicture = new SqlParameter("@employeePicture", SqlDbType.Image);
                prmemployeeName.Value = txtName.Text.Trim();
                prmemployeeLoginName.Value = txtLoginName.Text.Trim();
                prmemployeeLoginPwd.Value = txtLoginPwd.Text.Trim();
                prmemployeeEmail.Value = txtEmail.Text.Trim();
                prmemployeeBaseSalary.Value = txtSalary.Text.Trim();
                prmemployeeRank.Value = numLevel.Value;
                prmemployeePhone.Value = txtPhone.Text.Trim();
                prmdepartmentId.Value = departmentid;
                prmemployeePosition.Value = txtPosition.Text.Trim();
                if (picPhoto.ImageLocation != null)
                {
                    //将图片转为二进制
                    FileStream fs = File.OpenRead(picPhoto.ImageLocation);
                    byte[] imagebytes = new byte[fs.Length];
                    fs.Read(imagebytes, 0, imagebytes.Length);
                    fs.Close();
                    prmemployeePicture.Value = imagebytes;
                }
                else
                {
                    prmemployeePicture.Value = DBNull.Value;
                }
                int result = SqlHelper.ExecuteNonQuery(sqlUpdate, prmemployeeName, prmemployeeLoginName, prmemployeeLoginPwd, prmemployeeEmail, prmemployeeBaseSalary, prmemployeeRank, prmemployeePhone, prmdepartmentId, prmemployeePosition, prmemployeePicture);
                if (result > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("部分数据格式有误，请订正");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void FrmUpdateEmployee_Load(object sender, EventArgs e)
        {
            //直接从部门表中获取部门名称添加进comboBox中

            //定义查询语句
            string sqlSelect = "select departmentName from tblDepartment";
            //提交sql语句，根据返回结果显示相应信息
            SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbDepartment.Items.Add(dr["departmentName"].ToString());
                }
                dr.Close();
            }
            //获得员工数据并赋给各个控件
            txtName.Text = ObtainEmployeeData("employeeName");
            txtLoginName.Text = ObtainEmployeeData("employeeLoginName");
            txtLoginPwd.Text = ObtainEmployeeData("employeeLoginPwd");
            txtEmail.Text = ObtainEmployeeData("employeeEmail");
            txtSalary.Text = ObtainEmployeeData("employeeBaseSalary");
            numLevel.Value = decimal.Parse(ObtainEmployeeData("employeeRank"));
            txtPhone.Text = ObtainEmployeeData("employeePhone");
            txtPosition.Text = ObtainEmployeeData("employeePosition");
            string departmentid = ObtainEmployeeData("departmentId");
            //根据部门编号获得部门名称并赋给控件cbDepartment
            string DepartmentNamelookup = "select departmentName from tblDepartment where departmentId ='" + departmentid + "'";
            cbDepartment.Text = SqlHelper.ExecuteScalar(DepartmentNamelookup).ToString();
            //显示图片
            string sql = "select employeePicture from tblEmployee where employeeId ='" + employeeid + "'";
            DataTable dt = SqlHelper.getDataTable(sql);
            if (dt.Rows[0]["employeePicture"] != DBNull.Value)
            {
                byte[] Mybyte = (Byte[])(dt.Rows[0]["employeePicture"]);
                MemoryStream ms = new MemoryStream(Mybyte);
                picPhoto.Image = Image.FromStream(ms);
            }
        }
    }
}
