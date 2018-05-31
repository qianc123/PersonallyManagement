namespace PersonnelManagementSystem.ManagementFunction.SalaryManagement
{
    partial class FrmSalaryHistory
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
            this.grdSalaryHistory = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.salaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdlist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payofDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutOfAbsenteeism = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrantSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSalaryHistory
            // 
            this.grdSalaryHistory.AllowUserToAddRows = false;
            this.grdSalaryHistory.AllowUserToDeleteRows = false;
            this.grdSalaryHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaryHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryId,
            this.employeeIdlist,
            this.employeeName,
            this.payofDate,
            this.overtimeSalary,
            this.cutOfAbsenteeism,
            this.otherSalary,
            this.BaseSalary,
            this.GrantSalary});
            this.grdSalaryHistory.Location = new System.Drawing.Point(16, 14);
            this.grdSalaryHistory.Margin = new System.Windows.Forms.Padding(4);
            this.grdSalaryHistory.Name = "grdSalaryHistory";
            this.grdSalaryHistory.ReadOnly = true;
            this.grdSalaryHistory.RowTemplate.Height = 23;
            this.grdSalaryHistory.Size = new System.Drawing.Size(433, 462);
            this.grdSalaryHistory.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(343, 484);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 44);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // salaryId
            // 
            this.salaryId.DataPropertyName = "salaryId";
            this.salaryId.HeaderText = "薪资编号";
            this.salaryId.Name = "salaryId";
            this.salaryId.ReadOnly = true;
            // 
            // employeeIdlist
            // 
            this.employeeIdlist.DataPropertyName = "employeeId";
            this.employeeIdlist.HeaderText = "员工编号";
            this.employeeIdlist.Name = "employeeIdlist";
            this.employeeIdlist.ReadOnly = true;
            this.employeeIdlist.Visible = false;
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "employeeName";
            this.employeeName.HeaderText = "员工姓名";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            // 
            // payofDate
            // 
            this.payofDate.DataPropertyName = "payofDate";
            this.payofDate.HeaderText = "薪资发放时间";
            this.payofDate.Name = "payofDate";
            this.payofDate.ReadOnly = true;
            // 
            // overtimeSalary
            // 
            this.overtimeSalary.DataPropertyName = "overtimeSalary";
            this.overtimeSalary.HeaderText = "加班薪资";
            this.overtimeSalary.Name = "overtimeSalary";
            this.overtimeSalary.ReadOnly = true;
            this.overtimeSalary.Visible = false;
            // 
            // cutOfAbsenteeism
            // 
            this.cutOfAbsenteeism.DataPropertyName = "cutOfAbsenteeism";
            this.cutOfAbsenteeism.HeaderText = "缺勤扣除";
            this.cutOfAbsenteeism.Name = "cutOfAbsenteeism";
            this.cutOfAbsenteeism.ReadOnly = true;
            this.cutOfAbsenteeism.Visible = false;
            // 
            // otherSalary
            // 
            this.otherSalary.DataPropertyName = "otherSalary";
            this.otherSalary.HeaderText = "其他薪资";
            this.otherSalary.Name = "otherSalary";
            this.otherSalary.ReadOnly = true;
            this.otherSalary.Visible = false;
            // 
            // BaseSalary
            // 
            this.BaseSalary.DataPropertyName = "BaseSalary";
            this.BaseSalary.HeaderText = "基本薪资";
            this.BaseSalary.Name = "BaseSalary";
            this.BaseSalary.ReadOnly = true;
            this.BaseSalary.Visible = false;
            // 
            // GrantSalary
            // 
            this.GrantSalary.DataPropertyName = "GrantSalary";
            this.GrantSalary.HeaderText = "发放薪资";
            this.GrantSalary.Name = "GrantSalary";
            this.GrantSalary.ReadOnly = true;
            // 
            // FrmSalaryHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 543);
            this.Controls.Add(this.grdSalaryHistory);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmSalaryHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工薪资历史记录";
            this.Load += new System.EventHandler(this.FrmSalaryHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSalaryHistory;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn payofDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimeSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutOfAbsenteeism;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrantSalary;
    }
}