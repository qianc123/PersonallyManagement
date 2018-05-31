using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelManagementSystem.ManagementFunction.AttendanceManagement
{
    public partial class FrmAttendanceHistory : Form
    {
        public FrmAttendanceHistory()
        {
            InitializeComponent();
        }

        public string startDate, endDate;

        private bool CheckDate()
        {
            //判断起始时间是否大于截止时间
            if (DtpStart.Value >= DtpEnd.Value)
            {
                //弹出消息框提示
                MessageBox.Show("起始时间应早于截止时间！");
                return false;
            }
            return true;
        }

        private void BthCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!CheckDate()) return;
            else
            {
                //定义查询历史记录的sql语句
                string sqlSelect = string.Format(@"select * from View_ShowAttendanceInformation where dateTimes >= '{0}' and dateTimes <= '{1}'", DtpStart.Value.ToString("yyyy-MM-dd"), DtpEnd.Value.ToString("yyyy-MM-dd"));
                //提交Sql语句，根据返回结果显示相应信息
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    //传值
                    startDate = DtpStart.Value.ToString("yyyy-MM-dd");
                    endDate = DtpEnd.Value.ToString("yyyy-MM-dd");
                    //关闭数据阅读器
                    dr.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    //弹出消息框提示
                    MessageBox.Show("没有符合条件的考勤记录！", "提示");
                }
                //关闭窗体
                this.Close();
            }
        }
    }
}
