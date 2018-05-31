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
    public partial class FrmVacationSetting : Form
    {
        public FrmVacationSetting()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        public int nationalVacation;
        public string dateTime;

        private void btnAddVaction_Click(object sender, EventArgs e)
        {
            //datetime等于假期日期
            dateTime = dtpVacation.Value.ToString("yyyy-MM-dd");
            if (cbNationalVacation.Checked == true)
            {
                nationalVacation = 1;
            }
            else
            {
                nationalVacation = 0;
            }
            //定义sql插入语句
            string sqlInsert = string.Format("insert into tblVacation ( vacationTime,vacationName,ifNationalVacation ) values ('{0}','{1}','{2}')", dateTime, txtVacationName.Text, nationalVacation);
            //提交sql插入语句，根据返回结果显示相应信息
            int result = SqlHelper.ExecuteNonQuery(sqlInsert);
            if (result > 0)
            {
                MessageBox.Show("假期加入成功！");
            }
            //刷新假期选择表
            VacationLoad();
        }

        private void btnDelVaction_Click(object sender, EventArgs e)
        {
            if (clbVacation.SelectedItems.Count <= 0)
            {
                //弹出消息提示
                MessageBox.Show("请选择假期", "提示");
                return;
            }
            string sqlDelete = string.Format("delete tblVacation where vacationName='{0}'",clbVacation.SelectedItem);
            int result = SqlHelper.ExecuteNonQuery(sqlDelete);
            if (result > 0)
            {
                //弹出消息提示
                MessageBox.Show("删除成功", "提示");
                //刷新假期选择表
                VacationLoad();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        public void VacationLoad()
        {
            //清空假期选择表
            clbVacation.Items.Clear();
            //定义sql查询语句
            string sqlSelect = "select vacationName from tblVacation";
            //提交sql查询语句，根据返回结果显示相应信息
            SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string da = dr["vacationName"].ToString();
                    clbVacation.Items.Add(da);
                }
            }
        }

        private void FrmVacationSetting_Load(object sender, EventArgs e)
        {
            //加载假期选择表
            VacationLoad();
        }
    }
}
