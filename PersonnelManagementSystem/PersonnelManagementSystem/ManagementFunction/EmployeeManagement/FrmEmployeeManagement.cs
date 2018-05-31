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
using PersonnelManagementSystem.ManagementFunction;

namespace PersonnelManagementSystem.ManagementFunction.EmployeeManagement
{
    public partial class FrmEmployeeManagement : Form
    {
        public FrmEmployeeManagement()
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
            grdEmployee.DataSource = ds.Tables[0];
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            FrmEmployeeAdd frmEmployeeAdd = new FrmEmployeeAdd();
            frmEmployeeAdd.ShowDialog();
            //定义SQL的查询语句
            string sqlSelect = "select * from tblEmployee";
            //载入数据
            DataLoad(sqlSelect);
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            //弹出删除提示消息框
            DialogResult DRS = MessageBox.Show("确定要删除选中行数据码？", "提示", MessageBoxButtons.YesNo);
            if (DRS == DialogResult.Yes)
            {
                int result;
                string employeeId = grdEmployee.SelectedRows[0].Cells["employeeId"].Value.ToString();//选择的当前行employeeId列的值，员工编号
                string departmentId = grdEmployee.SelectedRows[0].Cells["departmentId"].Value.ToString();//选择的当前行departmentId列的值，部门编号
                string sqlSelect = string.Format("select employeePosition from tblEmployee where employeePosition = '经理' and departmentId = '{0}' ",departmentId);
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    //定义sql修改语句
                    string sqlUpdate = string.Format("Update tblDepartment set employeeId = @employeeId where employeeId ='{0}'", employeeId);
                    SqlParameter prmEmployee = new SqlParameter("@employeeId", SqlDbType.Int);
                    prmEmployee.Value = DBNull.Value;//sql修改语句，若删除的人是经理时，需要修改表tblDepartment中的employeeId(部门经理编号)值为空，平时无用
                    //定义sql删除语句
                    string sqlDelete = string.Format("Delete tblEmployee where employeeId ='{0}'", employeeId);
                    //提交sql语句，根据返回结果显示相应信息
                    SqlHelper.ExecuteNonQuery(sqlUpdate, prmEmployee);
                    result = SqlHelper.ExecuteNonQuery(sqlDelete);
                    if (result > 0)
                    {
                        MessageBox.Show("删除成功！");
                        //定义SQL的查询语句
                        string strSelect = "select * from tblEmployee";
                        //载入数据
                        DataLoad(strSelect);
                    }
                    else
                        MessageBox.Show("删除失败！");
                }
                else
                {
                    //定义sql删除语句
                    string sqlDelete = string.Format("Delete tblEmployee where employeeId ='{0}'", employeeId);
                    //提交sql语句，根据返回结果显示相应信息
                    result = SqlHelper.ExecuteNonQuery(sqlDelete);
                    if (result > 0)
                    {
                        MessageBox.Show("删除成功！");
                        //定义SQL的查询语句
                        string strSelect = "select * from tblEmployee";
                        //载入数据
                        DataLoad(strSelect);
                    }
                    else
                        MessageBox.Show("删除失败！");
                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmUpdateEmployee frmUpdateEmployee = new FrmUpdateEmployee();
            //选择的当前行employeeId列的值，员工编号
            string EmployeeId = grdEmployee.SelectedRows[0].Cells["employeeId"].Value.ToString();
            frmUpdateEmployee.employeeid = EmployeeId;
            frmUpdateEmployee.ShowDialog();
            //定义SQL的查询语句
            string sqlSelect = "select * from tblEmployee";
            //载入数据
            DataLoad(sqlSelect);
        }

        private void btnQueryEmployee_Click(object sender, EventArgs e)
        {
            //创建窗口对象
            FrmQuerybyEmp employeequery = new FrmQuerybyEmp();
            employeequery.ShowDialog();
            //判断员工查询窗体是否按了确定按钮
            if (employeequery.DialogResult == DialogResult.OK)
            {
                //定义查询语句
                string sqlSelect = "select * from tblEmployee where 1=1";
                if (employeequery.EmpName != "")
                {
                    sqlSelect += string.Format("and employeeName like '%" + employeequery.EmpName + "%'");
                }
                if (employeequery.EmpEmail != "")
                {
                    sqlSelect += string.Format("and employeeEmail like '%" + employeequery.EmpEmail + "%'");
                }
                if (employeequery.DeptName != "")
                {
                    string DepartmentIdlookup = @"select departmentId from tblDepartment where departmentName ='" + employeequery.DeptName + "'";
                    int departmentid = (Int32)SqlHelper.ExecuteScalar(DepartmentIdlookup);//将employeequery.DeptName部门名称转化为部门编号
                    sqlSelect += string.Format("and departmentId = '" + departmentid + "'");
                }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void FrmEmployeeManagement_Load(object sender, EventArgs e)
        {
            //定义SQL的查询语句
            string sqlSelect = "select * from tblEmployee";
            //载入数据
            DataLoad(sqlSelect);
        }
    }
}
