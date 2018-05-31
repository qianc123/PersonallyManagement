using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction.SalaryManagement
{
    public partial class FrmBaseSalary : Form
    {
        public FrmBaseSalary()
        {
            InitializeComponent();
        }

        public string employeeId;

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            flag = int.TryParse(txtBaseSalary.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("输入的不是一个数字");
            }
            else
            {
                if (int.Parse(txtBaseSalary.Text.ToString()) >= 0)
                {
                    //sql修改语句
                    string basesalarysetting = string.Format("Update tblEmployee set employeeBaseSalary ='{0}' where employeeId ='{1}'",txtBaseSalary.Text,employeeId);
                    int result = SqlHelper.ExecuteNonQuery(basesalarysetting);
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        //关闭窗体
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("基本薪资设定失败！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("基本薪资不能小于0");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
    }
}
