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

namespace PersonnelManagementSystem.ManagementFunction.AttendanceManagement
{
    public partial class FrmAttendanceSetting : Form
    {
        public FrmAttendanceSetting()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //定义sql查询语句
            string sqlInsert = string.Format("insert into tblSystemLayout (layoutType,layoutName,layoutValue) values ('{0}','{1}','{2}')", lblConfigType.Text, lblConfigName.Text, TxtConfigVal.Text);
            //提sql语句，根据返回结果显示相应信息
            int result = SqlHelper.ExecuteNonQuery(sqlInsert);
            if (result > 0)
            {
                //弹出消息框提示
                MessageBox.Show("考勤设置成功！");
                //关闭窗体
                this.Close();
            }
            else
            {
                //弹出消息框提示
                MessageBox.Show("考勤设置失败！");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
    }
}
