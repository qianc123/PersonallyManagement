using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction.LeaveManagement
{
    public partial class FrmLeaveEmpSummary : Form
    {
        public FrmLeaveEmpSummary()
        {
            InitializeComponent();
        }

        public string employeeName;

        private void btnOK_Click(object sender, EventArgs e)
        {
            //判断是否选择了员工
            if (lbEmp.SelectedItem == null)
            {
                //弹出消息提示
                MessageBox.Show("请选择员工！");
                return;
            }
            else
            {
                //传值
                employeeName = lbEmp.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                //关闭窗体
                this.Close();
                return;
            }
        }

        private void FrmLeaveEmpSummary_Load(object sender, EventArgs e)
        {
            //清空lbDept的内容
            lbEmp.Items.Clear();
            //定义查询语句
            string sqlSelect = "select employeeName from tblEmployee";
            //提交sql语句，根据返回结果显示相应信息
            SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //添加员工名称进入lbEMmp中
                    lbEmp.Items.Add(dr["employeeName"].ToString());
                }
                //关闭数据阅读  
                dr.Close();
            }
        }
    }
}
