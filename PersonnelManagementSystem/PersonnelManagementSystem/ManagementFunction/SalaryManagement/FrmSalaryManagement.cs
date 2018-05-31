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

namespace PersonnelManagementSystem.ManagementFunction.SalaryManagement
{
    public partial class FrmSalaryManagement : Form
    {
        public FrmSalaryManagement()
        {
            InitializeComponent();
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
            grdSalaryList.DataSource = ds.Tables[0];
        }

        private void btnQueryEmp_Click(object sender, EventArgs e)
        {
            //创建窗口对象
            FrmQuerybyEmp frmQuerybyEmp = new FrmQuerybyEmp();
            frmQuerybyEmp.ShowDialog();//判断员工查询窗体是否按了确定按钮
            if (frmQuerybyEmp.DialogResult == DialogResult.OK)
            {
                //定义查询语句
                string sqlSelect = "select employeeId,employeeName,employeeBaseSalary from tblEmployee where 1=1";
                if (frmQuerybyEmp.EmpName != "")
                {
                    sqlSelect += string.Format("and employeeName like '%{0}%'",frmQuerybyEmp.EmpName);
                }
                if (frmQuerybyEmp.EmpEmail != "")
                {
                    sqlSelect += string.Format("and employeeEmail like '%{0}%'",frmQuerybyEmp.EmpEmail);
                }
                if (frmQuerybyEmp.DeptName != "")
                {
                    string DepartmentIdlookup = string.Format("select departmentId from tblDepartment where departmentName ='{0}'",frmQuerybyEmp.DeptName);
                    int departmentid = (Int32)SqlHelper.ExecuteScalar(DepartmentIdlookup);//根据employeequery.DeptName部门名称查询部门编号
                    sqlSelect += string.Format("and departmentId = '{0}'",departmentid);
                }//提交sql语句，根据返回结果显示相应信息
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

        private void btnHistoryQuery_Click(object sender, EventArgs e)
        {
            FrmSalaryHistory frmEmployeeSalaryHistory = new FrmSalaryHistory();
            string EmployeeId = grdSalaryList.SelectedRows[0].Cells["employeeId"].Value.ToString();//选择的当前行employeeId列的值，员工编号
            frmEmployeeSalaryHistory.employeeId = EmployeeId;
            frmEmployeeSalaryHistory.EmployeeSH = true;
            frmEmployeeSalaryHistory.ShowDialog();
        }

        private void btnGroupbyDept_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmDeptSummary frmDeptSummary = new FrmDeptSummary();
            //打开窗体
            frmDeptSummary.ShowDialog();
            //判断员工查询窗体是否按了确定按钮
            if (frmDeptSummary.DialogResult == DialogResult.OK)
            {
                try
                {
                    string DepartmentIdlookup = string.Format("select departmentId from tblDepartment where departmentName like '{0}'", frmDeptSummary.DeptName);
                    string DepartmentId = SqlHelper.ExecuteScalar(DepartmentIdlookup).ToString();//根据employeequery.DeptName部门名称查询部门编号
                    FrmSalaryHistory frmDepartmentSalaryHistory = new FrmSalaryHistory();
                    frmDepartmentSalaryHistory.departmentId = DepartmentId;
                    frmDepartmentSalaryHistory.EmployeeSH = false;
                    frmDepartmentSalaryHistory.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("不存在该部门！");
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmBaseSalary frmbasesalary = new FrmBaseSalary();
            string EmployeeId = grdSalaryList.SelectedRows[0].Cells["employeeId"].Value.ToString();//选择的当前行employeeId列的值，员工编号
            frmbasesalary.employeeId = EmployeeId;
            frmbasesalary.ShowDialog();
            if(frmbasesalary.DialogResult==DialogResult.OK)
            {
                 //定义SQL的查询语句
                 string sqlSelect = "select * from View_ShowBaseSalaryInformation";
                 //载入数据
                 DataLoad(sqlSelect);
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void FrmSalaryManagement_Load(object sender, EventArgs e)
        {
            //定义SQL的查询语句
            string sqlSelect = "select * from View_ShowBaseSalaryInformation";
            //载入数据
            DataLoad(sqlSelect);
            //判断登录人职位并赋予相应权限
            string drgPower = string.Format("select * from tblEmployee where employeePosition = '经理' and employeeLoginName = '{0}'", FrmLogin.EmpName.ToString());
            SqlDataReader ds = SqlHelper.ExecuteDataReader(drgPower);
            if (ds.HasRows)
            {
                btnSetting.Enabled = true;
            }
            else
            {
                btnSetting.Enabled = false;
            }
        }
    }
}
