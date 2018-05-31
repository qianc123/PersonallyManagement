using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonnelManagementSystem.ManagementFunction.EmployeeManagement
{
    public partial class FrmUploadPhoto : Form
    {
        public FrmUploadPhoto()
        {
            InitializeComponent();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != "")
            {
                picPhoto.ImageLocation = ofd.FileName;
                TxtPhotoPath.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (TxtPhotoPath.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("请指定正确的照片文件路径");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }
    }
}
