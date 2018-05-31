namespace PersonnelManagementSystem.ManagementFunction.DepartmentManagement
{
    partial class FrmMoveEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMoveQuit = new System.Windows.Forms.Button();
            this.btnMovOk = new System.Windows.Forms.Button();
            this.lblInfor = new System.Windows.Forms.Label();
            this.cbDeptName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMoveQuit
            // 
            this.btnMoveQuit.Location = new System.Drawing.Point(280, 140);
            this.btnMoveQuit.Name = "btnMoveQuit";
            this.btnMoveQuit.Size = new System.Drawing.Size(75, 31);
            this.btnMoveQuit.TabIndex = 7;
            this.btnMoveQuit.Text = "取消";
            this.btnMoveQuit.UseVisualStyleBackColor = true;
            this.btnMoveQuit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMovOk
            // 
            this.btnMovOk.Location = new System.Drawing.Point(105, 140);
            this.btnMovOk.Name = "btnMovOk";
            this.btnMovOk.Size = new System.Drawing.Size(88, 31);
            this.btnMovOk.TabIndex = 6;
            this.btnMovOk.Text = "确定";
            this.btnMovOk.UseVisualStyleBackColor = true;
            this.btnMovOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Location = new System.Drawing.Point(85, 60);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(142, 15);
            this.lblInfor.TabIndex = 5;
            this.lblInfor.Text = "选择移动到的部门：";
            // 
            // cbDeptName
            // 
            this.cbDeptName.FormattingEnabled = true;
            this.cbDeptName.Location = new System.Drawing.Point(260, 57);
            this.cbDeptName.Name = "cbDeptName";
            this.cbDeptName.Size = new System.Drawing.Size(121, 23);
            this.cbDeptName.TabIndex = 4;
            // 
            // FrmMoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 218);
            this.Controls.Add(this.btnMoveQuit);
            this.Controls.Add(this.btnMovOk);
            this.Controls.Add(this.lblInfor);
            this.Controls.Add(this.cbDeptName);
            this.Name = "FrmMoveEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "移动员工";
            this.Load += new System.EventHandler(this.FrmMoveEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveQuit;
        private System.Windows.Forms.Button btnMovOk;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.ComboBox cbDeptName;
    }
}