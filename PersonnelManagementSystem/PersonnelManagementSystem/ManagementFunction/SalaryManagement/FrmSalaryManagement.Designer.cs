namespace PersonnelManagementSystem.ManagementFunction.SalaryManagement
{
    partial class FrmSalaryManagement
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
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHistoryQuery = new System.Windows.Forms.Button();
            this.grdSalaryList = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnGroupbyDept = new System.Windows.Forms.Button();
            this.btnQueryEmp = new System.Windows.Forms.Button();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(51, 574);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(100, 42);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "设定薪资";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHistoryQuery
            // 
            this.btnHistoryQuery.Location = new System.Drawing.Point(212, 23);
            this.btnHistoryQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistoryQuery.Name = "btnHistoryQuery";
            this.btnHistoryQuery.Size = new System.Drawing.Size(100, 42);
            this.btnHistoryQuery.TabIndex = 10;
            this.btnHistoryQuery.Text = "历史查询";
            this.btnHistoryQuery.UseVisualStyleBackColor = true;
            this.btnHistoryQuery.Click += new System.EventHandler(this.btnHistoryQuery_Click);
            // 
            // grdSalaryList
            // 
            this.grdSalaryList.AllowUserToAddRows = false;
            this.grdSalaryList.AllowUserToDeleteRows = false;
            this.grdSalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeId,
            this.employeeName,
            this.employeeBaseSalary});
            this.grdSalaryList.Location = new System.Drawing.Point(51, 84);
            this.grdSalaryList.Margin = new System.Windows.Forms.Padding(4);
            this.grdSalaryList.MultiSelect = false;
            this.grdSalaryList.Name = "grdSalaryList";
            this.grdSalaryList.ReadOnly = true;
            this.grdSalaryList.RowTemplate.Height = 23;
            this.grdSalaryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSalaryList.Size = new System.Drawing.Size(424, 469);
            this.grdSalaryList.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(375, 574);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 42);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnGroupbyDept
            // 
            this.btnGroupbyDept.Location = new System.Drawing.Point(375, 23);
            this.btnGroupbyDept.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupbyDept.Name = "btnGroupbyDept";
            this.btnGroupbyDept.Size = new System.Drawing.Size(100, 42);
            this.btnGroupbyDept.TabIndex = 7;
            this.btnGroupbyDept.Text = "部门汇总";
            this.btnGroupbyDept.UseVisualStyleBackColor = true;
            this.btnGroupbyDept.Click += new System.EventHandler(this.btnGroupbyDept_Click);
            // 
            // btnQueryEmp
            // 
            this.btnQueryEmp.Location = new System.Drawing.Point(51, 23);
            this.btnQueryEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryEmp.Name = "btnQueryEmp";
            this.btnQueryEmp.Size = new System.Drawing.Size(100, 42);
            this.btnQueryEmp.TabIndex = 6;
            this.btnQueryEmp.Text = "员工查询";
            this.btnQueryEmp.UseVisualStyleBackColor = true;
            this.btnQueryEmp.Click += new System.EventHandler(this.btnQueryEmp_Click);
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "employeeId";
            this.employeeId.HeaderText = "员工编号";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "employeeName";
            this.employeeName.HeaderText = "员工姓名";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            // 
            // employeeBaseSalary
            // 
            this.employeeBaseSalary.DataPropertyName = "employeeBaseSalary";
            this.employeeBaseSalary.HeaderText = "员工基本薪资";
            this.employeeBaseSalary.Name = "employeeBaseSalary";
            this.employeeBaseSalary.ReadOnly = true;
            this.employeeBaseSalary.Width = 140;
            // 
            // FrmSalaryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 638);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnHistoryQuery);
            this.Controls.Add(this.grdSalaryList);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGroupbyDept);
            this.Controls.Add(this.btnQueryEmp);
            this.Name = "FrmSalaryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "薪资管理";
            this.Load += new System.EventHandler(this.FrmSalaryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHistoryQuery;
        private System.Windows.Forms.DataGridView grdSalaryList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnGroupbyDept;
        private System.Windows.Forms.Button btnQueryEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBaseSalary;
    }
}