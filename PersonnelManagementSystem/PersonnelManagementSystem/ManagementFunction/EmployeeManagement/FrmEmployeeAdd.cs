using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PersonnelManagementSystem.ManagementFunction.EmployeeManagement
{
    public partial class FrmEmployeeAdd : Form
    {
        public FrmEmployeeAdd()
        {
            InitializeComponent();
        }

        bool DataFormatError = true;//定义一个布尔变量，用来防止数据输入格式错误

        //判断各种数据输入格式是否正确
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
            else if (txtDataOfArrive.Text == "")
            {
                lblDataOfArriveError.Text = "*必填";
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

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmUploadPhoto frmUploadPhoto = new FrmUploadPhoto();
            //打开窗体
            frmUploadPhoto.ShowDialog();
            //判断员工查询窗体是否按了确定按钮
            if (frmUploadPhoto.DialogResult == DialogResult.OK)
            {
                picPhoto.ImageLocation = frmUploadPhoto.TxtPhotoPath.Text;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            CheckDataErrorLoad();
            if (DataFormatError == false)
            {
                //将cbDepartment内的部门名称转换为部门编号
                string DepartmentIdlookup = "select departmentId from tblDepartment where departmentName ='" + cbDepartment.Text + "'";
                int departmentid = (Int32)SqlHelper.ExecuteScalar(DepartmentIdlookup);

                string sqlinsept = "Insert into [tblEmployee]([employeeName],[employeeLoginName],[employeeLoginPwd],[employeeDataOfArrive],[employeeEmail],[departmentId],[employeeBaseSalary],[employeeRank],[employeePosition],[employeePhone],[employeePicture])";
                string insept = sqlinsept + "values('" + txtName.Text + "','" + txtLoginName.Text + "','" + txtLoginPwd.Text + "','" + txtDataOfArrive.Text + "','" + txtEmail.Text + "'," + departmentid + "," + int.Parse(txtSalary.Text.ToString()) + "," + int.Parse(numLevel.Value.ToString()) + ",'" + txtPosition.Text + "','" + txtPhone.Text + "',@employeePicture)";
                SqlParameter employeePicture = new SqlParameter("@employeePicture", SqlDbType.Image);
                if (picPhoto.ImageLocation != null)
                {
                    //将图片转为二进制
                    FileStream fs = File.OpenRead(picPhoto.ImageLocation);
                    byte[] imagebytes = new byte[fs.Length];
                    fs.Read(imagebytes, 0, imagebytes.Length);
                    fs.Close();
                    employeePicture.Value = imagebytes;
                }
                else
                {
                    employeePicture.Value = DBNull.Value;
                }
                SqlHelper.ExecuteNonQuery(insept, employeePicture);
                this.Close();
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

        private void FrmEmployeeAdd_Load(object sender, EventArgs e)
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
        }
    }
}
