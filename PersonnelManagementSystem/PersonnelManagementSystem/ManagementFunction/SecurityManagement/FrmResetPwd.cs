using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction.SecurityManagement
{
    public partial class FrmResetPwd : Form
    {
        public FrmResetPwd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmLogin frmLogin = new FrmLogin();
            //限制新密码长度大于6位
            if (txtNewPwd.TextLength > 6)
            {
                int result;
                if (txtNewPwd.Text.Trim() == txtCheckNewPwd.Text.Trim())
                {
                    //定义sql修改语句
                    string sqlUpdate = string.Format("update tblEmployee set employeeLoginPwd ='{0}' where employeeLoginName ='{1}' and employeeLoginPwd = '{2}'", txtNewPwd.Text, FrmLogin.loginName, txtOldPwd.Text);
                    //提交sql修改语句，根据返回结果显示相应信息
                     result = SqlHelper.ExecuteNonQuery(sqlUpdate);
                    if (result > 0)
                    {
                        //定义sql插入语句
                        string sqlInsert = string.Format("insert into tblsystemEvent(eventDescribe,eventTime) values ( '用户 {0} 修改密码" + "', '{1}')", FrmLogin.loginName, frmLogin.datetime);
                        result = SqlHelper.ExecuteNonQuery(sqlInsert);
                        if (result > 0)
                        {
                            //关闭窗体
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("系统发生错误！");
                            Application.Exit();
                        }
                    }
                    else
                    {
                        //弹出消息提示
                        MessageBox.Show("旧密码错误！");
                        //清空文本输入框
                        txtOldPwd.Clear();
                        //重新定位光标
                        txtOldPwd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("新密码确认有误！");
                }
            }
            else
            {
                //弹出消息提示
                MessageBox.Show("新密码长度要大于6位！");
                //清空文本输入框
                txtNewPwd.Clear();
                txtCheckNewPwd.Clear();
                //重新定位光标
                txtNewPwd.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
    }
}
