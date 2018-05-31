using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction.LeaveManagement
{
    public partial class FrmRefuseApplication : Form
    {
        public FrmRefuseApplication()
        {
            InitializeComponent();
        }

        public string employeeName;

        private void btnOK_Click(object sender, EventArgs e)
        {
            //定义sql修改语句
            string sqlUpdate = string.Format("update tblEmployeeLeave set reasonOfRefuse = '{0}' and applyStatus = '已否决' where employeeId = (select employeeId from tblEmployee where employeeName = '{1}') ", txtReason.Text, employeeName);
            //提交sql修改语句，根据返回信息显示相应结果
            int result = SqlHelper.ExecuteNonQuery(sqlUpdate);
            if (result > 0)
            {
                //弹出消息提示
                MessageBox.Show("撤销申请已提交！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //弹出消息提示
                MessageBox.Show("撤销申请提交失败！");
            }
            //关闭窗体
            this.Close();
        }
    }
}
