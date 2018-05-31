namespace PersonnelManagementSystem.ManagementFunction.DepartmentManagement
{
    partial class FrmDepartmentInformation
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStarff = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblStraffName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDepartmentMembers = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSetManager = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStarff);
            this.groupBox2.Controls.Add(this.pbEmployee);
            this.groupBox2.Controls.Add(this.lblLoginName);
            this.groupBox2.Controls.Add(this.lblStraffName);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtLoginName);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(49, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 183);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // lblStarff
            // 
            this.lblStarff.AutoSize = true;
            this.lblStarff.Location = new System.Drawing.Point(12, 0);
            this.lblStarff.Name = "lblStarff";
            this.lblStarff.Size = new System.Drawing.Size(37, 15);
            this.lblStarff.TabIndex = 11;
            this.lblStarff.Text = "员工";
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEmployee.Location = new System.Drawing.Point(28, 24);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(122, 141);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 10;
            this.pbEmployee.TabStop = false;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(260, 85);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(67, 15);
            this.lblLoginName.TabIndex = 7;
            this.lblLoginName.Text = "登录名：";
            // 
            // lblStraffName
            // 
            this.lblStraffName.AutoSize = true;
            this.lblStraffName.Location = new System.Drawing.Point(260, 40);
            this.lblStraffName.Name = "lblStraffName";
            this.lblStraffName.Size = new System.Drawing.Size(52, 15);
            this.lblStraffName.TabIndex = 6;
            this.lblStraffName.Text = "姓名：";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(357, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(207, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(357, 75);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.ReadOnly = true;
            this.txtLoginName.Size = new System.Drawing.Size(207, 25);
            this.txtLoginName.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(260, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "电子邮件：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(357, 30);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(207, 25);
            this.txtName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.lblDepartmentMembers);
            this.groupBox1.Controls.Add(this.lblDepartmentName);
            this.groupBox1.Location = new System.Drawing.Point(49, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(37, 15);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "部门";
            // 
            // lblDepartmentMembers
            // 
            this.lblDepartmentMembers.AutoSize = true;
            this.lblDepartmentMembers.Location = new System.Drawing.Point(119, 46);
            this.lblDepartmentMembers.Name = "lblDepartmentMembers";
            this.lblDepartmentMembers.Size = new System.Drawing.Size(67, 15);
            this.lblDepartmentMembers.TabIndex = 2;
            this.lblDepartmentMembers.Text = "部门编号";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(25, 46);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(52, 15);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "部门名";
            // 
            // grdEmployee
            // 
            this.grdEmployee.AllowUserToAddRows = false;
            this.grdEmployee.AllowUserToDeleteRows = false;
            this.grdEmployee.AllowUserToResizeColumns = false;
            this.grdEmployee.AllowUserToResizeRows = false;
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column12,
            this.Column6,
            this.Column8,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column13,
            this.Column14});
            this.grdEmployee.Location = new System.Drawing.Point(49, 328);
            this.grdEmployee.MultiSelect = false;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.RowTemplate.Height = 27;
            this.grdEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployee.Size = new System.Drawing.Size(685, 126);
            this.grdEmployee.TabIndex = 15;
            this.grdEmployee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdEmployee_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "employeeId";
            this.Column1.HeaderText = "员工编号";
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
            this.Column3.DataPropertyName = "employeeLoginName";
            this.Column3.HeaderText = "员工登录名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employeeEmail";
            this.Column4.HeaderText = "电子邮件";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "employeePosition";
            this.Column5.HeaderText = "职位";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "employeeRank";
            this.Column12.HeaderText = "级别";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "employeePhone";
            this.Column6.HeaderText = "电话号码";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "employeeLoginPwd";
            this.Column8.HeaderText = "员工登录密码";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "employeeBaseSalary";
            this.Column7.HeaderText = "员工基本薪资";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "departmentId";
            this.Column9.HeaderText = "所属部门编号";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "employeeSelfInteroduction";
            this.Column10.HeaderText = "员工自我介绍";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "employeeResidueVacations";
            this.Column11.HeaderText = "员工剩余假期";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "employeeDataOfArrive";
            this.Column13.HeaderText = "报到日期";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "employeePicture";
            this.Column14.HeaderText = "员工照片";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(459, 495);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 37);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSetManager
            // 
            this.btnSetManager.Location = new System.Drawing.Point(171, 495);
            this.btnSetManager.Name = "btnSetManager";
            this.btnSetManager.Size = new System.Drawing.Size(105, 37);
            this.btnSetManager.TabIndex = 13;
            this.btnSetManager.Text = "设为经理";
            this.btnSetManager.UseVisualStyleBackColor = true;
            this.btnSetManager.Click += new System.EventHandler(this.btnSetManager_Click);
            // 
            // FrmDepartmentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdEmployee);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSetManager);
            this.Name = "FrmDepartmentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门信息";
            this.Load += new System.EventHandler(this.FrmDepartmentInformation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStarff;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblStraffName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDepartmentMembers;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.DataGridView grdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSetManager;
    }
}