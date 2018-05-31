using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace PersonnelManagementSystem.ManagementFunction.AttendanceManagement
{
    public partial class FrmAttendanceManagement : Form
    {
        public FrmAttendanceManagement()
        {
            InitializeComponent();
        }

        private void DataLoad(string sqlSelect)
        {
            //创建数据集对象
            DataSet ds = new DataSet();
            //创建数据适配器
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlSelect, ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            //填充数据ds
            sqlda.Fill(ds);
            //绑定数据集中数据表数据到DataGridView
            grdAttendance.DataSource = ds.Tables[0];
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            //创建考勤历史窗体对象
            FrmAttendanceHistory frmAttendanceHistory = new FrmAttendanceHistory();
            //显示考勤历史窗体
            frmAttendanceHistory.ShowDialog();
            //判断历时查询窗体是否点了确定
            if (frmAttendanceHistory.DialogResult == DialogResult.OK)
            {
                //定义查询语句
                string sqlSelect = string.Format(@"select * from View_ShowAttendanceInformation where dateTimes >= '{0}' and dateTimes <= '{1}'", frmAttendanceHistory.startDate, frmAttendanceHistory.endDate);
                //显示查询到的信息
                DataLoad(sqlSelect);
            }
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            //创建考勤设置窗体对象
            FrmAttendanceSetting frmAttendanceSetting = new FrmAttendanceSetting();
            //显示考勤设置窗体
            frmAttendanceSetting.ShowDialog();
        }

        private void FrmAttendanceManagement_Load(object sender, EventArgs e)
        {
            //定义SQL视图查询语句
            string sqlSelect = "select * from View_ShowAttendanceInformation";
            //载入视图
            DataLoad(sqlSelect);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            //创建弹出删除提示消息框
            DialogResult DR = MessageBox.Show(this, "确定要删除选中的考勤记录码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //判断是否删除语句
            if (DR == DialogResult.Yes)
            {
                //若没选取
                if (grdAttendance.SelectedRows == null)
                {
                    //弹出消息框提示
                    MessageBox.Show("请选择要删除的考勤记录", "考勤管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string attendanceId = grdAttendance.SelectedRows[0].Cells[0].Value.ToString();
                int affectedRow;
                //定义sql查询语句
                string sqlDelete = string.Format(@"delete from tblEmployeeAttendanceRecord where attendanceId = '{0}'", attendanceId);
                affectedRow = SqlHelper.ExecuteNonQuery(sqlDelete);
                if (affectedRow < 0)
                {
                    //弹出消息框
                    MessageBox.Show("删除失败！");
                }
                else
                {
                    //弹出消息框
                    MessageBox.Show("删除成功！");
                }
                //定义查询语句
                string sqlSelect = "select * from View_ShowAttendanceInformation";
                //重新载入表
                DataLoad(sqlSelect);
            }
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            //定义时间格式
            string dts = DateTime.Now.ToString("yyyy-MM-dd");
            //定义查询当日考勤记录的sql语句
            string sqlSelect = string.Format(@"select * from View_ShowAttendanceInformation where attendanceType = '缺勤'and dateTimes = '{0}'", dts);
            //创建数据阅读器
            SqlDataReader dr = SqlHelper.ExecuteDataReader(sqlSelect);
            //判断是否读取到数据
            if (dr.HasRows)
            {
                //载入查询数据
                DataLoad(sqlSelect);
                //关闭数据阅读器
                dr.Close();
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            //创建窗体对象
            FrmAttendanceImport frmAttendanceImport = new FrmAttendanceImport();
            //打开窗体
            frmAttendanceImport.ShowDialog();
            //判断导入窗体是否点击确定按钮
            if (frmAttendanceImport.DialogResult == DialogResult.OK)
            {
                //定义连接字符串
                string strConn = string.Format("Provider = Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR =Yes;'", frmAttendanceImport.ExcelPath);
                //创建并使用连接对象
                using (OleDbConnection conn = new OleDbConnection(strConn))
                {
                    //打开连接
                    conn.Open();
                    //获取Excel表里的表名
                    DataTable table = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                    string sheetName = table.Rows[0]["Table_Name"].ToString();
                    //定义sql查询语句
                    string sqlSelect = string.Format("select * from [{0}]", sheetName);
                    //创建命令对象
                    OleDbCommand comm = new OleDbCommand(sqlSelect, conn);
                    //创建数据适配器
                    OleDbDataAdapter da = new OleDbDataAdapter(sqlSelect, conn);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    //填充数据
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    //绑定数据源
                    grdAttendance.DataSource = dt;
                    //关闭连接
                    conn.Close();
                }
            }
        }
    }
}
