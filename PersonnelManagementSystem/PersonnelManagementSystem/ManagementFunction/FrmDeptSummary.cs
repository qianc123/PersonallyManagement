using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelManagementSystem.ManagementFunction
{
    public partial class FrmDeptSummary : Form
    {
        public FrmDeptSummary()
        {
            InitializeComponent();
        }

        public string DeptName;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //判断部门名称是否为空
            if (txtDept.Text.Trim() != "")
            {
                //定义查询语句
                string sqlSelect = string.Format("select departmentName from tblDepartment where departmentName like '%{0}%'", txtDept.Text.Trim());
                //提交sql语句，根据返回结果显示相应信息
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    DeptName = txtDept.Text.Trim();
                    //关闭数据阅读器
                    dr.Close();
                    this.DialogResult = DialogResult.OK;
                    //关闭窗体
                    this.Close();
                    return;
                }
                else
                {
                    //弹出消息框提示
                    MessageBox.Show("该部门不存在！请重新输入！");
                    //重置输入
                    txtDept.Text = "";
                    txtDept.Focus();
                }
            }
            else
            {
                //弹出消息框提示
                MessageBox.Show("部门名称不得为空！");
                //定位光标
                txtDept.Focus();
            }
        }
    }
}
