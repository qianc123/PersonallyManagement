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

namespace PersonnelManagementSystem.ManagementFunction.SecurityManagement
{
    public partial class FrmSystemEvent : Form
    {
        public FrmSystemEvent()
        {
            InitializeComponent();
        }

        private void btnQueryEvent_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmSystemEventQuery frmSystemEventQuery = new FrmSystemEventQuery();
            //打开窗体
            frmSystemEventQuery.ShowDialog();
            //判断历史查询窗体是否点击了确定按钮
            if (frmSystemEventQuery.DialogResult == DialogResult.OK)
            {
                //定义SQL的查询语句
                string sqlSelect = string.Format("select * from tblsystemEvent  where eventTime between '{0}' and '{1}'", frmSystemEventQuery.startDate, frmSystemEventQuery.endDate);
                //提交sql查询语句，根据返回结果显示相应信息
                SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
                if (dr.HasRows)
                {
                    //载入数据
                    DataLoad(sqlSelect);
                    //关闭数据阅读器
                    dr.Close();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void DataLoad(string sqlSelect)
        {
            //创建数据集对象
            DataSet ds = new DataSet();
            //创建数据适配器
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlSelect, ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            //填充数据
            sqlda.Fill(ds);
            //绑定数据集中数据表数据到DataGridView
            grdEvent.DataSource = ds.Tables[0];
        }

        private void FrmSystemEvent_Load(object sender, EventArgs e)
        {
            //定义SQL的查询语句
            string sqlSelect="select * from tblsystemEvent";
            //载入数据
            DataLoad(sqlSelect);
        }
    }
}
