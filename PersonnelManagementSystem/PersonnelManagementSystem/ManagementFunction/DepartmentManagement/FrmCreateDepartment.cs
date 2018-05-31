using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PersonnelManagementSystem;

namespace PersonnelManagementSystem.ManagementFunction.DepartmentManagement
{
    public partial class FrmCreateDepartment : Form
    {
        public FrmCreateDepartment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //定义sql查询语句
            string sqlSelect = string.Format("select * from tblDepartment where departmentName = '{0}'", txtDeptName.Text);
            SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
            if (dr.HasRows)
            {
                //弹出消息提示
                MessageBox.Show("该部门已存在！");
                //重置文本输入框
                txtDeptName.Clear();
                txtDeptDescription.Clear();
                txtDeptName.Focus();
                //关闭数据库
                dr.Close();
            }
            else
            {
                //判断文本框是否为空
                if (txtDeptName.Text == "")
                {
                    //弹出消息提示
                    MessageBox.Show("请输入部门名称！");
                    //定位光标
                    txtDeptName.Focus();
                }
                else
                {
                    //定义sql插入语句
                    string sqlInsert = string.Format("Insert into tblDepartment(departmentName,departmentDescribe) values ('{0}','{1}')", txtDeptName.Text, txtDeptDescription.Text);
                    //提交sql语句，根据返回结果显示相应信息
                    int result = SqlHelper.ExecuteNonQuery(sqlInsert);
                    if (result > 0)
                    {
                        //弹出消息提示
                        MessageBox.Show("部门创建成功!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        //弹出消息提示
                        MessageBox.Show("创建失败！");
                        return;
                    }
                }
            }           
        }
    }
}
