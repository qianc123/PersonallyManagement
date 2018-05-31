using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction.DepartmentManagement
{
    public partial class FrmDepartmentInformation : Form
    {
        public FrmDepartmentInformation()
        {
            InitializeComponent();
        }

        public static int i;

        private void grdEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int j = (int)grdEmployee.SelectedRows[0].Cells[0].Value;
                string selectEpeInfo = string.Format("select employeeName,employeeLoginName,employeeEmail,employeePicture from tblEmployee where employeeId = '{0}'", j);
                SqlDataReader ds = SqlHelper.ExecuteDataReader(selectEpeInfo);
                if (ds.HasRows)
                {
                    while (ds.Read())
                    {
                        txtName.Text = ds["employeeName"].ToString();
                        txtLoginName.Text = ds["employeeLoginName"].ToString();
                        txtEmail.Text = ds["employeeEmail"].ToString();
                        try
                        {
                            byte[] images = (byte[])ds["employeePicture"];
                            MemoryStream ms = new MemoryStream(images);
                            Bitmap bmp = new Bitmap(ms);
                            pbEmployee.Image = bmp;
                        }
                        catch
                        {
                            pbEmployee.Image = null;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("该部门无员工！");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void FrmDepartmentInformation_Load(object sender, EventArgs e)
        {
            //加载视图
            ShowFrm();
        }

        int selectDepId;
        //定义通过部门名称获得部门编号的方法
        public int tvDeptIdget()
        {
            try
            {
                string sqlDepId = string.Format("select departmentId from tblDepartment where departmentName = '{0}'", FrmDepartmentManagement.selectDep.ToString());
                selectDepId = (int)SqlHelper.ExecuteScalar(sqlDepId);
            }
            catch
            {
            }
            return selectDepId;
        }

        //定义加载窗体内容的方法
        public void ShowFrm()
        {
            i = tvDeptIdget();//获取当前选定部门的部门编号View_ShowEmployeeInformation
            lblDepartmentName.Text = FrmDepartmentManagement.selectDep.ToString();//显示当前查看部门名称
            string selectView = string.Format("select * from tblEmployee where employeeName in (select employeeName from tblEmployee where departmentId = '{0}')", i);
            DataTable dt = SqlHelper.getDataTable(selectView);
            grdEmployee.DataSource = dt;
            //统计当前以显示员工人数
            int members = grdEmployee.RowCount;
            lblDepartmentMembers.Text = string.Format(" 员工统计： " + members.ToString());

        }

        private void btnSetManager_Click(object sender, EventArgs e)
        {
            //定义整型EmpId为员工Id
            int EmpId = (int)grdEmployee.SelectedRows[0].Cells[0].Value;
            string dragement = string.Format("select employeeName from tblEmployee where employeePosition = '经理'and employeeId = '{0}'", EmpId);
            SqlDataReader ds = SqlHelper.ExecuteDataReader(dragement);
            if (ds.HasRows)
            {
                MessageBox.Show("该人员已是经理！");
                return;
            }
            else
            {
                string drage = string.Format("select employeePosition from tblEmployee where employeePosition = '经理' and departmentId = '{0}' ", tvDeptIdget());
                SqlDataReader drg = SqlHelper.ExecuteDataReader(drage);
                if (drg.HasRows)
                {
                    if (MessageBox.Show("该部门存在经理，是否撤除？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string cutPosition = string.Format("update tblDepartment set employeeId = null where departmentId = '{0}'", tvDeptIdget());
                        string changePosition = string.Format("update tblEmployee set employeePosition = '员工',employeeRank = 1 where departmentId = '{0}' and employeePosition = '经理' ", tvDeptIdget());
                        int r = SqlHelper.ExecuteNonQuery(cutPosition);
                        int t = SqlHelper.ExecuteNonQuery(changePosition);
                        if (r > 0 && t > 0)
                        {
                            MessageBox.Show("撤除成功！");
                            string setManager1 = string.Format("update tblDepartment set  employeeId = '{0}' where departmentId = '{1}'", EmpId, tvDeptIdget());
                            string changePosition1 = string.Format("update tblEmployee set employeePosition = '经理',employeeRank = '3' where employeeId = '{0}'", EmpId);
                            int result = SqlHelper.ExecuteNonQuery(setManager1);
                            int change = SqlHelper.ExecuteNonQuery(changePosition1);
                            if (result > 0 && change > 0)
                            {
                                MessageBox.Show("设置成功！");
                            }
                            else
                            {
                                MessageBox.Show("设置失败！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("撤除失败！");
                        }
                        ShowFrm();
                    }
                }
                else
                {
                    string setManager1 = string.Format("update tblDepartment set employeeId = '{0}' where departmentId = '{1}'", EmpId, tvDeptIdget());
                    string changePosition2 = string.Format("update tblEmployee set employeePosition = '经理',employeeRank = '3' where employeeId = '{0}'", EmpId);
                    int result = SqlHelper.ExecuteNonQuery(setManager1);
                    int change = SqlHelper.ExecuteNonQuery(changePosition2);
                    if (result > 0 && change > 0)
                    {
                        MessageBox.Show("设置成功！");
                    }
                    else
                    {
                        MessageBox.Show("设置失败！");
                    }
                    ShowFrm();
                }
            }                 
        }
    }
}
