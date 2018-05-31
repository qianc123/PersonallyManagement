using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonnelManagementSystem.UserInfo;
using PersonnelManagementSystem.ManagementFunction.SecurityManagement;

namespace PersonnelManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static string loginName;
        //定义静态全局变量用于判断登录人权限
        public static string EmpName;

        //定义dateTime等于当前系统时间
        public string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        //创建新的用户信息类对象
        UserInfo.UserInfo userInfo = new UserInfo.UserInfo();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmpName = txtUserName.Text;
            int i = 0;
            if (txtUserName.Text.Trim() == "" || txtUserPwd.Text.Trim() == "")
            {
                //弹出消息提示登录失败
                MessageBox.Show("登录名或密码不能为空！");
                //清空文本输入框
                txtUserName.Clear();
                txtUserPwd.Clear();
                //定位光标
                txtUserName.Focus();
            }
            else
            {
                userInfo.UserId = txtUserName.Text;
                userInfo.UserPwd = txtUserPwd.Text;
                //调用登陆的方法
                userInfo.Login();
                if (i < 3)
                {
                    i++;
                    if (userInfo.Login() == 1)
                    {
                        //定义datetime为系统当前时间
                        //定义sql插入语句
                        string sqlInsert = string.Format("insert into tblsystemEvent(eventDescribe,eventTime) values ( '用户 {0} 登录" + "', '{1}')", txtUserName.Text.Trim(), datetime);
                        //提交sql插入语句，根据返回结果显示相应信息
                        int result = SqlHelper.ExecuteNonQuery(sqlInsert);
                        if (result > 0)
                        {
                            //创建窗体对象
                            FrmMain frmMain = new FrmMain();
                            //隐藏窗体
                            this.Hide();
                            //打开窗体
                            frmMain.ShowDialog();
                            //关闭窗体
                            this.Close();
                        }
                    }
                    else
                    {
                        //弹出消息提示
                        MessageBox.Show("登录名或密码有误！");
                        //重置文本输入框
                        txtUserName.Clear();
                        txtUserPwd.Clear();
                        //定位光标
                        txtUserName.Focus();
                    }
                    return;
                }
                else
                {
                    //弹出消息提示登录失败
                    MessageBox.Show("登录名或密码错误三次");
                    //关闭窗体
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            //判断登录名及密码是否为空
            if (txtUserName.Text.Trim() == "" || txtUserPwd.Text.Trim() == "")
            {
                //弹出消息提示
                MessageBox.Show("登录名或密码不能为空！");
                //重置文本输入框
                txtUserName.Clear();
                txtUserPwd.Clear();
                //定位光标
                txtUserName.Focus();
            }
            else
            {
                //传值
                loginName = txtUserName.Text;
                userInfo.UserId = txtUserName.Text;
                userInfo.UserPwd = txtUserPwd.Text;
                //调用用户类的登录方法
                userInfo.Login();
                //判断是否登陆成功
                if (userInfo.Login() == 1)
                {
                    //创建窗体类对象
                    FrmResetPwd frmResetPwd = new FrmResetPwd();
                    //打开窗体
                    frmResetPwd.ShowDialog();
                    //定义sql插入语句
                    string sqlInsert = string.Format("insert into tblSystemEvent(eventDescribe,eventTime) values ( '用户 {0} 修改了密码', '{1}')", loginName, datetime);
                    //提交sql插入语句
                    int result = SqlHelper.ExecuteNonQuery(sqlInsert);
                }
                else
                {
                    //弹出消息提示
                    MessageBox.Show("登录名或密码有误！");
                    //重置文本输入框
                    txtUserName.Clear();
                    txtUserPwd.Clear();
                    //定位光标
                    txtUserName.Focus();
                }
            }
        }
    }
}
