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

namespace PersonnelManagementSystem.ManagementFunction.LeaveManagement
{
    public partial class FrmVacationManagement : Form
    {
        public FrmVacationManagement()
        {
            InitializeComponent();
        }

        public string employeeName;

        private void btnDeleteVacation_Click(object sender, EventArgs e)
        {
            //判断是否选择了假期记录
            if (grdLeaveList.SelectedRows.Count <= 0)
            {
                //弹出消息提示
                MessageBox.Show("请选择请假记录!", "提示");
                return;
            }
            //定义sql查询语句
            string sqlDelete = string.Format("delete tblEmployeeLeave where leaveId={0}", grdLeaveList.SelectedRows[0].Cells[0].Value);
            //提交sql查询语句，根据返回结果显示相应信息
            int result = SqlHelper.ExecuteNonQuery(sqlDelete);
            if (result > 0)
            {
                //弹出消息提示
                MessageBox.Show("删除成功！", "提示");
                //定义sql查询语句
                string sqlSelect = "select * from View_ShowLeaveInformation";
                //刷新请假信息视图
                DataLoad(sqlSelect);
            }
        }

        private void btnCancelVacation_Click(object sender, EventArgs e)
        {
            //判断是否选择了请假记录
            if (grdLeaveList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("未选择请假记录！");
                return;
            }
            else
            {
                //创建窗体对象
                FrmRefuseApplication frmRefuseApplication = new FrmRefuseApplication();
                //赋值
                frmRefuseApplication.employeeName = grdLeaveList.SelectedRows[0].Cells[1].Value.ToString();
                //打开窗体
                frmRefuseApplication.ShowDialog();
                if (frmRefuseApplication.DialogResult == DialogResult.OK)
                {
                    //定义sql查询语句
                    string sqlSelect = "select * from View_ShowLeaveInformation";
                    //刷新请假信息视图
                    DataLoad(sqlSelect);
                }
            }
        }

        private void btnQueryDept_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmLeaveDeptSummary frmLeaveDeptSummary = new FrmLeaveDeptSummary();
            //打开窗体
            frmLeaveDeptSummary.ShowDialog();
            if (frmLeaveDeptSummary.DialogResult == DialogResult.OK)
            {
                //定义SQL的查询语句
                string sqlSelect = string.Format("select * from View_ShowLeaveInformation where employeeName in (select employeeName from tblEmployee where departmentId = (select departmentId from tblDepartment where departmentName ='{0}'))", frmLeaveDeptSummary.departmentName);
                //提交sql查询语句，根据返回结果显示相应信息
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    //载入数据
                    DataLoad(sqlSelect);
                    //关闭数据阅读器
                    dr.Close();
                }
                else
                {
                    //弹出消息框提示
                    MessageBox.Show("本部门没有任何请假记录！");
                }
            }
        }

        private void btnQueryEmp_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmLeaveEmpSummary frmLeaveEmpSummary = new FrmLeaveEmpSummary();
            //打开窗体
            frmLeaveEmpSummary.ShowDialog();
            //判断员工汇总窗体是否点击了确定按钮
            if (frmLeaveEmpSummary.DialogResult == DialogResult.OK)
            {
                //定义SQL的查询语句
                string sqlSelect = string.Format("select * from View_ShowLeaveInformation where employeeName in (select employeeName from tblEmployee where employeeName = '{0}' )", frmLeaveEmpSummary.employeeName);
                //提交sql查询语句，根据返回结果显示相应信息
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    //载入数据
                    DataLoad(sqlSelect);
                    //关闭数据阅读器
                    dr.Close();
                }
                else
                {
                    //弹出消息框提示
                    MessageBox.Show("该员工没有请假记录！");
                }
            }
        }

        private void btnVacationSetting_Click(object sender, EventArgs e)
        {
            //创建对象
            FrmVacationSetting frmVacationSetting = new FrmVacationSetting();
            //打开窗体
            frmVacationSetting.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void DataLoad(string sqlSelect)
        {
            //创建数据集对象
            DataSet ds = new DataSet();
            //创建数据适配器
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlSelect, ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            //填充数据
            sqlda.Fill(ds);
            //绑定数据集中数据表数据到DataGridView
            grdLeaveList.DataSource = ds.Tables[0];
        }

        private void FrmVacationManagement_Load(object sender, EventArgs e)
        {
            //定义sql查询语句
            string sqlSelect = "select * from View_ShowLeaveInformation";
            //刷新请假信息视图
            DataLoad(sqlSelect);
        }
    }
}
