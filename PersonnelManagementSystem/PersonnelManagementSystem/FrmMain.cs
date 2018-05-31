using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PersonnelManagementSystem.ManagementFunction.EmployeeManagement;
using PersonnelManagementSystem.ManagementFunction.DepartmentManagement;
using PersonnelManagementSystem.ManagementFunction.LeaveManagement;
using PersonnelManagementSystem.ManagementFunction.AttendanceManagement;
using PersonnelManagementSystem.ManagementFunction.OvertimeManagement;
using PersonnelManagementSystem.ManagementFunction.SalaryManagement;
using PersonnelManagementSystem.ManagementFunction.SecurityManagement;

namespace PersonnelManagementSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmEmployeeManagement frmEmployeeManagement = new FrmEmployeeManagement();
            //打开窗体
            frmEmployeeManagement.ShowDialog();
        }

        private void btnDepartmentManagement_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmDepartmentManagement frmDeparmentManagement = new FrmDepartmentManagement();
            //打开窗体
            frmDeparmentManagement.ShowDialog();
        }

        private void btnLeaveManagement_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmVacationManagement frmVacationManagement = new FrmVacationManagement();
            //打开窗体
            frmVacationManagement.ShowDialog();
        }

        private void btnAttendanceManagement_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmAttendanceManagement frmAttendanceManagement = new FrmAttendanceManagement();
            //打开窗体
            frmAttendanceManagement.ShowDialog();
        }

        private void btnOvertimeManagement_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmOvertimeManagement frmOvertimeManagement = new FrmOvertimeManagement();
            //打开窗体
            frmOvertimeManagement.ShowDialog();
        }

        private void btnSalaryManagement_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmSalaryManagement frmSalaryManagement = new FrmSalaryManagement();
            //打开窗体
            frmSalaryManagement.ShowDialog();
        }

        private void btnSecurityManagement_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmSystemEvent frmSystemEvent = new FrmSystemEvent();
            //打开窗体
            frmSystemEvent.ShowDialog();
        }
    }
}
