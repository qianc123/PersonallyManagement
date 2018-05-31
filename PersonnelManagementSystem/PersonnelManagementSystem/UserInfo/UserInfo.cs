using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelManagementSystem.UserInfo
{
    class UserInfo
    {
        private string userId;
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string userPwd;
        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }

        //定义登录的方法
        public int Login()
        {
            int result = 0;
            try
            {
                //定义sql查询语句
                string sqlSelect = string.Format("select * from tblEmployee where employeeLoginName = '{0}' and employeeLoginPwd = '{1}'and departmentId = (select departmentId from tblDepartment where departmentName = '人事部')", userId, userPwd);
                //提交sql查询语句，根据返回结果显示相应
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                //判断dr是否有行数据 确定登录是否有误
                if (dr.HasRows)
                {
                    result = 1;
                    //关闭数据阅读器
                    dr.Close();
                    //返回结果 
                    return result;
                }
                else
                {
                    //返回结果
                    return result;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return result;
            }
        }
    }
}
