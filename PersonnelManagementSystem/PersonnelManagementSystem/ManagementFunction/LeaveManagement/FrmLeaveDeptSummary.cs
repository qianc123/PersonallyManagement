using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelManagementSystem.ManagementFunction.LeaveManagement
{
    public partial class FrmLeaveDeptSummary : Form
    {
        public FrmLeaveDeptSummary()
        {
            InitializeComponent();
        }

        private void FrmLeaveDeptSummary_Load(object sender, EventArgs e)
        {
            //清空lbDept的内容
            lbDept.Items.Clear();
            //定义查询语句
            string sqlSelect = "select departmentName from tblDepartment";
            //提交sql语句，根据返回结果显示相应信息
            SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //添加部门名称进入lbDept中
                    lbDept.Items.Add(dr["departmentName"].ToString());
                }
                //关闭数据阅读  
                dr.Close();
            }
        }

        public string departmentName;

        private void btnOK_Click(object sender, EventArgs e)
        {
            //判断是否选择了部门
            if (lbDept.SelectedItem == null)
            {
                //弹出消息提示
                MessageBox.Show("请选择部门！");
                return;
            }
            else
            {
                //传值
                departmentName = lbDept.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                //关闭窗体
                this.Close();
                return;
            }
        }
    }
}
