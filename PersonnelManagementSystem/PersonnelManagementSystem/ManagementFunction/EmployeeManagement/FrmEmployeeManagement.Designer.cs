namespace PersonnelManagementSystem.ManagementFunction.EmployeeManagement
{
    partial class FrmEmployeeManagement
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
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataOfArrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSelfInteroduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeResidueVacations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQueryEmployee = new System.Windows.Forms.Button();
            this.btnDelEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmployee
            // 
            this.grdEmployee.AllowUserToAddRows = false;
            this.grdEmployee.AllowUserToDeleteRows = false;
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeId,
            this.employeeName,
            this.employeeLoginName,
            this.employeeLoginPwd,
            this.employeeEmail,
            this.departmentId,
            this.employeeBaseSalary,
            this.employeePosition,
            this.employeePhone,
            this.employeeDataOfArrive,
            this.employeeSelfInteroduction,
            this.employeeResidueVacations,
            this.employeeRank,
            this.employeePicture});
            this.grdEmployee.Location = new System.Drawing.Point(3, 59);
            this.grdEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.grdEmployee.MultiSelect = false;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.ReadOnly = true;
            this.grdEmployee.RowTemplate.Height = 23;
            this.grdEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployee.Size = new System.Drawing.Size(967, 474);
            this.grdEmployee.TabIndex = 23;
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "employeeId";
            this.employeeId.HeaderText = "员工编号";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            this.employeeId.Width = 80;
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "employeeName";
            this.employeeName.HeaderText = "员工姓名";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            this.employeeName.Width = 90;
            // 
            // employeeLoginName
            // 
            this.employeeLoginName.DataPropertyName = "employeeLoginName";
            this.employeeLoginName.HeaderText = "员工登录名";
            this.employeeLoginName.Name = "employeeLoginName";
            this.employeeLoginName.ReadOnly = true;
            this.employeeLoginName.Width = 90;
            // 
            // employeeLoginPwd
            // 
            this.employeeLoginPwd.DataPropertyName = "employeeLoginPwd";
            this.employeeLoginPwd.HeaderText = "员工登录密码";
            this.employeeLoginPwd.Name = "employeeLoginPwd";
            this.employeeLoginPwd.ReadOnly = true;
            this.employeeLoginPwd.Width = 110;
            // 
            // employeeEmail
            // 
            this.employeeEmail.DataPropertyName = "employeeEmail";
            this.employeeEmail.HeaderText = "员工电子邮件";
            this.employeeEmail.Name = "employeeEmail";
            this.employeeEmail.ReadOnly = true;
            this.employeeEmail.Width = 110;
            // 
            // departmentId
            // 
            this.departmentId.DataPropertyName = "departmentId";
            this.departmentId.HeaderText = "员工所属部门编号";
            this.departmentId.Name = "departmentId";
            this.departmentId.ReadOnly = true;
            this.departmentId.Width = 80;
            // 
            // employeeBaseSalary
            // 
            this.employeeBaseSalary.DataPropertyName = "employeeBaseSalary";
            this.employeeBaseSalary.HeaderText = "员工基本薪资";
            this.employeeBaseSalary.Name = "employeeBaseSalary";
            this.employeeBaseSalary.ReadOnly = true;
            this.employeeBaseSalary.Width = 110;
            // 
            // employeePosition
            // 
            this.employeePosition.DataPropertyName = "employeePosition";
            this.employeePosition.HeaderText = "员工职位";
            this.employeePosition.Name = "employeePosition";
            this.employeePosition.ReadOnly = true;
            this.employeePosition.Width = 90;
            // 
            // employeePhone
            // 
            this.employeePhone.DataPropertyName = "employeePhone";
            this.employeePhone.HeaderText = "员工电话";
            this.employeePhone.Name = "employeePhone";
            this.employeePhone.ReadOnly = true;
            this.employeePhone.Width = 90;
            // 
            // employeeDataOfArrive
            // 
            this.employeeDataOfArrive.DataPropertyName = "employeeDataOfArrive";
            this.employeeDataOfArrive.HeaderText = "员工报道日期";
            this.employeeDataOfArrive.Name = "employeeDataOfArrive";
            this.employeeDataOfArrive.ReadOnly = true;
            this.employeeDataOfArrive.Width = 110;
            // 
            // employeeSelfInteroduction
            // 
            this.employeeSelfInteroduction.DataPropertyName = "employeeSelfInteroduction";
            this.employeeSelfInteroduction.HeaderText = "员工自我介绍";
            this.employeeSelfInteroduction.Name = "employeeSelfInteroduction";
            this.employeeSelfInteroduction.ReadOnly = true;
            this.employeeSelfInteroduction.Width = 110;
            // 
            // employeeResidueVacations
            // 
            this.employeeResidueVacations.DataPropertyName = "employeeResidueVacations";
            this.employeeResidueVacations.HeaderText = "员工剩余假期";
            this.employeeResidueVacations.Name = "employeeResidueVacations";
            this.employeeResidueVacations.ReadOnly = true;
            this.employeeResidueVacations.Width = 110;
            // 
            // employeeRank
            // 
            this.employeeRank.DataPropertyName = "employeeRank";
            this.employeeRank.HeaderText = "员工的级别";
            this.employeeRank.Name = "employeeRank";
            this.employeeRank.ReadOnly = true;
            this.employeeRank.Width = 90;
            // 
            // employeePicture
            // 
            this.employeePicture.DataPropertyName = "employeePicture";
            this.employeePicture.HeaderText = "员工照片";
            this.employeePicture.Name = "employeePicture";
            this.employeePicture.ReadOnly = true;
            this.employeePicture.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(687, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQueryEmployee
            // 
            this.btnQueryEmployee.Location = new System.Drawing.Point(518, 9);
            this.btnQueryEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryEmployee.Name = "btnQueryEmployee";
            this.btnQueryEmployee.Size = new System.Drawing.Size(100, 36);
            this.btnQueryEmployee.TabIndex = 21;
            this.btnQueryEmployee.Text = "查询员工";
            this.btnQueryEmployee.UseVisualStyleBackColor = true;
            this.btnQueryEmployee.Click += new System.EventHandler(this.btnQueryEmployee_Click);
            // 
            // btnDelEmployee
            // 
            this.btnDelEmployee.Location = new System.Drawing.Point(194, 9);
            this.btnDelEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelEmployee.Name = "btnDelEmployee";
            this.btnDelEmployee.Size = new System.Drawing.Size(100, 36);
            this.btnDelEmployee.TabIndex = 20;
            this.btnDelEmployee.Text = "删除员工";
            this.btnDelEmployee.UseVisualStyleBackColor = true;
            this.btnDelEmployee.Click += new System.EventHandler(this.btnDelEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(353, 9);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(100, 36);
            this.btnEditEmployee.TabIndex = 19;
            this.btnEditEmployee.Text = "修改员工";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(30, 9);
            this.btnEmployeeAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(100, 36);
            this.btnEmployeeAdd.TabIndex = 18;
            this.btnEmployeeAdd.Text = "添加员工";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // FrmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 543);
            this.Controls.Add(this.grdEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnQueryEmployee);
            this.Controls.Add(this.btnDelEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Name = "FrmEmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.FrmEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataOfArrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSelfInteroduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeResidueVacations;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePicture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQueryEmployee;
        private System.Windows.Forms.Button btnDelEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnEmployeeAdd;
    }
}