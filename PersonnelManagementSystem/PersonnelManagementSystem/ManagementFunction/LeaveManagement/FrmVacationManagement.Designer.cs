namespace PersonnelManagementSystem.ManagementFunction.LeaveManagement
{
    partial class FrmVacationManagement
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
            this.lblLeaveList = new System.Windows.Forms.Label();
            this.grdLeaveList = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnVacationSetting = new System.Windows.Forms.Button();
            this.btnQueryEmp = new System.Windows.Forms.Button();
            this.btnQueryDept = new System.Windows.Forms.Button();
            this.btnCancelVacation = new System.Windows.Forms.Button();
            this.btnDeleteVacation = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLeaveList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeaveList
            // 
            this.lblLeaveList.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLeaveList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeaveList.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeaveList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLeaveList.Location = new System.Drawing.Point(49, 77);
            this.lblLeaveList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaveList.Name = "lblLeaveList";
            this.lblLeaveList.Size = new System.Drawing.Size(664, 34);
            this.lblLeaveList.TabIndex = 15;
            this.lblLeaveList.Text = "请假申请列表";
            // 
            // grdLeaveList
            // 
            this.grdLeaveList.AllowUserToAddRows = false;
            this.grdLeaveList.AllowUserToDeleteRows = false;
            this.grdLeaveList.AllowUserToResizeColumns = false;
            this.grdLeaveList.AllowUserToResizeRows = false;
            this.grdLeaveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLeaveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grdLeaveList.Location = new System.Drawing.Point(49, 112);
            this.grdLeaveList.Margin = new System.Windows.Forms.Padding(4);
            this.grdLeaveList.MultiSelect = false;
            this.grdLeaveList.Name = "grdLeaveList";
            this.grdLeaveList.ReadOnly = true;
            this.grdLeaveList.RowTemplate.Height = 23;
            this.grdLeaveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLeaveList.Size = new System.Drawing.Size(664, 321);
            this.grdLeaveList.TabIndex = 14;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(613, 441);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnVacationSetting
            // 
            this.btnVacationSetting.Location = new System.Drawing.Point(613, 22);
            this.btnVacationSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnVacationSetting.Name = "btnVacationSetting";
            this.btnVacationSetting.Size = new System.Drawing.Size(100, 29);
            this.btnVacationSetting.TabIndex = 12;
            this.btnVacationSetting.Text = "假期设置";
            this.btnVacationSetting.UseVisualStyleBackColor = true;
            this.btnVacationSetting.Click += new System.EventHandler(this.btnVacationSetting_Click);
            // 
            // btnQueryEmp
            // 
            this.btnQueryEmp.Location = new System.Drawing.Point(472, 22);
            this.btnQueryEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryEmp.Name = "btnQueryEmp";
            this.btnQueryEmp.Size = new System.Drawing.Size(100, 29);
            this.btnQueryEmp.TabIndex = 11;
            this.btnQueryEmp.Text = "员工汇总";
            this.btnQueryEmp.UseVisualStyleBackColor = true;
            this.btnQueryEmp.Click += new System.EventHandler(this.btnQueryEmp_Click);
            // 
            // btnQueryDept
            // 
            this.btnQueryDept.Location = new System.Drawing.Point(329, 22);
            this.btnQueryDept.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryDept.Name = "btnQueryDept";
            this.btnQueryDept.Size = new System.Drawing.Size(100, 29);
            this.btnQueryDept.TabIndex = 10;
            this.btnQueryDept.Text = "部门汇总";
            this.btnQueryDept.UseVisualStyleBackColor = true;
            this.btnQueryDept.Click += new System.EventHandler(this.btnQueryDept_Click);
            // 
            // btnCancelVacation
            // 
            this.btnCancelVacation.Location = new System.Drawing.Point(185, 22);
            this.btnCancelVacation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelVacation.Name = "btnCancelVacation";
            this.btnCancelVacation.Size = new System.Drawing.Size(100, 29);
            this.btnCancelVacation.TabIndex = 9;
            this.btnCancelVacation.Text = "撤销申请";
            this.btnCancelVacation.UseVisualStyleBackColor = true;
            this.btnCancelVacation.Click += new System.EventHandler(this.btnCancelVacation_Click);
            // 
            // btnDeleteVacation
            // 
            this.btnDeleteVacation.Location = new System.Drawing.Point(49, 22);
            this.btnDeleteVacation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteVacation.Name = "btnDeleteVacation";
            this.btnDeleteVacation.Size = new System.Drawing.Size(100, 29);
            this.btnDeleteVacation.TabIndex = 8;
            this.btnDeleteVacation.Text = "删除记录";
            this.btnDeleteVacation.UseVisualStyleBackColor = true;
            this.btnDeleteVacation.Click += new System.EventHandler(this.btnDeleteVacation_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "leaveId";
            this.Column1.HeaderText = "请假编号";
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
            this.Column3.DataPropertyName = "handTime";
            this.Column3.HeaderText = "提交时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "reason";
            this.Column4.HeaderText = "原因";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "applytStatus";
            this.Column5.HeaderText = "申请状态";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "reasonOfRefuse";
            this.Column6.HeaderText = "撤销原因";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FrmVacationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.lblLeaveList);
            this.Controls.Add(this.grdLeaveList);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnVacationSetting);
            this.Controls.Add(this.btnQueryEmp);
            this.Controls.Add(this.btnQueryDept);
            this.Controls.Add(this.btnCancelVacation);
            this.Controls.Add(this.btnDeleteVacation);
            this.Name = "FrmVacationManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "假期管理";
            this.Load += new System.EventHandler(this.FrmVacationManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLeaveList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLeaveList;
        public System.Windows.Forms.DataGridView grdLeaveList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnVacationSetting;
        private System.Windows.Forms.Button btnQueryEmp;
        private System.Windows.Forms.Button btnQueryDept;
        private System.Windows.Forms.Button btnCancelVacation;
        private System.Windows.Forms.Button btnDeleteVacation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}