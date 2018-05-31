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

namespace PersonnelManagementSystem.ManagementFunction.OvertimeManagement
{
    public partial class FrmOvertimeManagement : Form
    {
        public FrmOvertimeManagement()
        {
            InitializeComponent();
        }

        private void BtnQuerybyDept_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmDeptSummary frmDeptSummary = new FrmDeptSummary();
            //打开窗体
            frmDeptSummary.ShowDialog();
            //判断部门查询窗体是否按了确定按钮
            if (frmDeptSummary.DialogResult == DialogResult.OK)
            {
                //定义SQL的查询语句
                string sqlSelect = string.Format("select * from View_ShowOvertimeInformation where employeeName in (select employeeName from tblEmployee where departmentId = (select departmentId from tblDepartment where departmentName like '%{0}%'  ))", frmDeptSummary.DeptName);
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
                    MessageBox.Show("未查询到记录！");
                }
            }
        }

        private void FrmOvertimeManagement_Load(object sender, EventArgs e)
        {
            //定义SQL的查询语句
            string sqlSelect = "select * from View_ShowOvertimeInformation";
            //载入数据
            DataLoad(sqlSelect);
        }

        private void BtnQuerybyEmp_Click(object sender, EventArgs e)
        {
            //创建窗口对象
            FrmQuerybyEmp frmQuerybyEmp = new FrmQuerybyEmp();
            //打开窗口
            frmQuerybyEmp.ShowDialog();
            //判断员工查询窗体是否按了确定按钮
            if (frmQuerybyEmp.DialogResult == DialogResult.OK)
            {
                //定义查询语句
                string sqlSelect = string.Format("select applyId,employeeName,submitTime,overtimeReason,applyConditions,overtimeName from tblOvertime inner join tblEmployee on tblOvertime.employeeId=tblEmployee.employeeId inner join tblOvertimeType on tblOvertime.overtimeType=tblOvertimeType.overtimeType inner join tblDepartment on tblDepartment.departmentId = tblEmployee.departmentId WHERE employeeName like '%{0}%' and employeeEmail like '%{1}%' and departmentName like '%{2}%'", frmQuerybyEmp.EmpName, frmQuerybyEmp.EmpEmail, frmQuerybyEmp.DeptName);
                //提交sql语句，根据返回结果显示相应信息
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    //载入查询结果
                    DataLoad(sqlSelect);
                    //关闭数据阅读器
                    dr.Close();
                }
                else
                {
                    //弹出消息框提示
                    MessageBox.Show("未查到符合条件的员工！");
                }
            }
        }

        //定义数据加载到datagridview的方法
        private void DataLoad(string sqlSelect)
        {
            //创建数据集对象
            DataSet ds = new DataSet();
            //创建数据适配器
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlSelect, ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            //填充数据
            sqlda.Fill(ds);
            //绑定数据集中数据表数据到DataGridView
            GrdOT.DataSource = ds.Tables[0];
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }
    }
}
