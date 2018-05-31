namespace PersonnelManagementSystem.ManagementFunction.AttendanceManagement
{
    partial class FrmAttendanceManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.grdAttendance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnToday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "考勤记录";
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(8, 424);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 14;
            this.BtnDel.Text = "删除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(383, 424);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 13;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // grdAttendance
            // 
            this.grdAttendance.AllowUserToAddRows = false;
            this.grdAttendance.AllowUserToDeleteRows = false;
            this.grdAttendance.AllowUserToResizeColumns = false;
            this.grdAttendance.AllowUserToResizeRows = false;
            this.grdAttendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grdAttendance.Location = new System.Drawing.Point(8, 96);
            this.grdAttendance.MultiSelect = false;
            this.grdAttendance.Name = "grdAttendance";
            this.grdAttendance.ReadOnly = true;
            this.grdAttendance.RowTemplate.Height = 27;
            this.grdAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAttendance.Size = new System.Drawing.Size(445, 310);
            this.grdAttendance.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "attendanceId";
            this.Column1.HeaderText = "考勤编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "employeeName";
            this.Column2.HeaderText = "员工姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dateTimes";
            this.Column3.HeaderText = "时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "attendanceType";
            this.Column4.HeaderText = "考勤类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(383, 21);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnImportExcel.TabIndex = 11;
            this.btnImportExcel.Text = "导入";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // BtnSetting
            // 
            this.BtnSetting.Location = new System.Drawing.Point(258, 21);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(75, 23);
            this.BtnSetting.TabIndex = 10;
            this.BtnSetting.Text = "考勤设置";
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Location = new System.Drawing.Point(133, 21);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(75, 23);
            this.BtnHistory.TabIndex = 9;
            this.BtnHistory.Text = "历史查询";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnToday
            // 
            this.BtnToday.Location = new System.Drawing.Point(8, 21);
            this.BtnToday.Name = "BtnToday";
            this.BtnToday.Size = new System.Drawing.Size(75, 23);
            this.BtnToday.TabIndex = 8;
            this.BtnToday.Text = "本日情况";
            this.BtnToday.UseVisualStyleBackColor = true;
            this.BtnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // FrmAttendanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.grdAttendance);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.BtnSetting);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnToday);
            this.Name = "FrmAttendanceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤管理";
            this.Load += new System.EventHandler(this.FrmAttendanceManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnOK;
        public System.Windows.Forms.DataGridView grdAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnToday;
    }
}