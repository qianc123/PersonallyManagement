using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonnelManagementSystem;

namespace PersonnelManagementSystem.ManagementFunction.DepartmentManagement
{
    public partial class FrmMoveEmployee : Form
    {
        public FrmMoveEmployee()
        {
            InitializeComponent();
        }

        private void FrmMoveEmployee_Load(object sender, EventArgs e)
        {
            //清空cbDeptName内容
            cbDeptName.Items.Clear();
            //获取当前表中存在部门并显示名称
            string strSelect = "select departmentName from tblDepartment ";
            DataTable dt = SqlHelper.getDataTable(strSelect);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //将数据添加至cbDeptName控件中
                cbDeptName.Items.Add(dt.Rows[i]["departmentName"].ToString());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //判断是否选择了部门或选择部门为待删除部门
            if (cbDeptName.Text == "" || cbDeptName.Text == FrmDepartmentManagement.selectDep.ToString())
            {
                //弹出消息提示
                MessageBox.Show("请选择其他部门！");
                return;
            }
            else if (cbDeptName.Text != "" || cbDeptName.Text != FrmDepartmentManagement.selectDep.ToString())
            {
                //定义sql修改语句
                string sqlUpdate = string.Format("update tblEmployee set departmentId = (select departmentId from tblDepartment where departmentName= '{0}') where departmentId=(select departmentId from tblDepartment where departmentName= '{1}')", cbDeptName.Text, FrmDepartmentManagement.selectDep.ToString());
                //提交sql修改语句，根据返回结果显示相应信息
                int i = SqlHelper.ExecuteNonQuery(sqlUpdate);
                if (i > 0)
                {
                    //弹出消息提示
                    MessageBox.Show("转移成功！");
                    //关闭窗体
                    this.Close();
                }
                else
                {
                    //弹出消息提示
                    MessageBox.Show("转移失败！");
                    //关闭窗体
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
    }
}
