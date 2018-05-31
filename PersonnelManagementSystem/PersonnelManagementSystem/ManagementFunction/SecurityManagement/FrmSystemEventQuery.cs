using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction.SecurityManagement
{
    public partial class FrmSystemEventQuery : Form
    {
        public FrmSystemEventQuery()
        {
            InitializeComponent();
        }

        public string startDate, endDate;

        private void btnOK_Click(object sender, EventArgs e)
        {
            //限定开始时间不得晚于结束时间
            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("结束时间不能比开始时间早");
                return;
            }
            else
            {
                //定义sql查询语句
                string sqlSelect = string.Format("select eventTime from tblsystemEvent  where eventTime between '{0}' and '{1}'", dtpStart.Value.ToString(), dtpEnd.Value.ToString());
                //提交sql查询语句，根据返回结果显示相应信息
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    //传值
                    startDate = dtpStart.Value.ToString();
                    endDate = dtpEnd.Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    //关闭数据阅读器
                    dr.Close();
                }
                else
                {
                    //弹出消息提示
                    MessageBox.Show("没有符合条件的系统记录");
                }
                //关闭窗口
                this.Close();
            }
        }
    }
}
