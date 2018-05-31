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
    public partial class FrmSalaryHistory : Form
    {
        public FrmSalaryHistory()
        {
            InitializeComponent();
        }

        //定义操作模式属性
        public bool EmployeeSH
        {
            set;
            get;
        }

        public string employeeId,departmentId;

        private void btnOK_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void FrmSalaryHistory_Load(object sender, EventArgs e)
        {
            if (EmployeeSH)
            {
                this.Text = "员工薪资历史记录";
                //定义员工薪资表的查询语句
                string sqlSelect = string.Format("select * from tblEmployeeSalary where employeeId='{0}'",employeeId);
                DataLoad(sqlSelect);
            }
            else
            {
                this.Text = "部门薪资历史记录";
                //定义员工薪资表的查询语句
                string sqlSelect = string.Format("select * from tblEmployeeSalary where employeeId in (select employeeId from tblEmployee where departmentId = '{0}')", departmentId);
                DataLoad(sqlSelect);
            }
            //当dataGridView内没有数据时，消息框提示
            if ((grdSalaryHistory.DataSource as DataTable).Rows.Count == 0)
            {
                MessageBox.Show("未查询到记录");
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
            //直接为表创建一新列employeeName来显示员工姓名
            ds.Tables[0].Columns.Add("employeeName", System.Type.GetType("System.String"));
            //添加每一行的员工姓名
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //定义员工姓名的查询语句
                string NameSelect = string.Format("select employeeName from tblEmployee where employeeId = '{0}'",ds.Tables[0].Rows[i]["employeeId"]);
                //查询每一列的ID并给姓名赋值
                ds.Tables[0].Rows[i]["employeeName"] = SqlHelper.ExecuteScalar(NameSelect);
            }
            //直接为表创建一新列GrantSalary来显示发放薪资
            ds.Tables[0].Columns.Add("GrantSalary", System.Type.GetType("System.String"));
            //计算发放薪资并添加
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["GrantSalary"] = (int.Parse(ds.Tables[0].Rows[i]["overtimeSalary"].ToString()) + int.Parse(ds.Tables[0].Rows[i]["cutOfAbsenteeism"].ToString()) + int.Parse(ds.Tables[0].Rows[i]["otherSalary"].ToString()) + int.Parse(ds.Tables[0].Rows[i]["baseSalary"].ToString())).ToString();
            }
            //绑定数据集中数据表数据到DataGridView
            grdSalaryHistory.DataSource = ds.Tables[0];
        }

    }
}
