using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PersonnelManagementSystem.ManagementFunction.AttendanceManagement
{
    public partial class FrmAttendanceImport : Form
    {
        public FrmAttendanceImport()
        {
            InitializeComponent();
            btnOK.Enabled = false;
            this.DialogResult = DialogResult.None;
        }

        public string ExcelPath;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ofdExcel.InitialDirectory = Application.StartupPath;
            //限制只可选择Excel文件
            ofdExcel.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx";
            ofdExcel.FilterIndex = 2;
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                //txtExcelPath显示文件路径
                txtExcelPath.Text = ofdExcel.FileName.ToString();
                btnOK.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtExcelPath.Text.Trim() == "")
            {
                //弹出消息提示
                MessageBox.Show("请选择Excel文件！");
                btnOK.Enabled = false;
            }
            else
            {
                //传值
                ExcelPath = txtExcelPath.Text;
                this.DialogResult = DialogResult.OK;
                //关闭窗体
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
    }
}
