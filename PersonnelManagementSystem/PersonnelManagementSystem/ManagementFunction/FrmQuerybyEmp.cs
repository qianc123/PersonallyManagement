using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction
{
    public partial class FrmQuerybyEmp : Form
    {
        public FrmQuerybyEmp()
        {
            InitializeComponent();
        }

        public string EmpName, EmpEmail, DeptName;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //判断三个查询条件是否都为空
            if (txtEmail.Text.Trim() == "" && txtName.Text.Trim() == "" && cbDepartment.Text.Trim() == "")
            {
                //弹出提示信息框
                MessageBox.Show("请输入查询条件！");
                //重置员工查询窗口
                txtEmail.Text = "";
                txtName.Text = "";
                cbDepartment.Text = "";
                txtName.Focus();
            }
            else
            {
                //传值
                EmpName = txtName.Text.Trim();
                EmpEmail = txtEmail.Text.Trim();
                DeptName = cbDepartment.Text.Trim();
                this.DialogResult = DialogResult.OK;
                //关闭窗口
                this.Close();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //直接从部门表中获取部门名称添加进comboBox中
            //清空cbDepartment的内容
            cbDepartment.Items.Clear();
            //定义查询语句
            string sqlSelect = "select departmentName from tblDepartment";
            //提交sql语句，根据返回结果显示相应信息
            SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //添加部门名称进入comboBox中
                    cbDepartment.Items.Add(dr["departmentName"].ToString());
                }
                //关闭数据阅读  
                dr.Close();
            }
        }
    }
}
