namespace PersonnelManagementSystem.ManagementFunction.OvertimeManagement
{
    partial class FrmOvertimeManagement
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.GrdOT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnQuerybyEmp = new System.Windows.Forms.Button();
            this.BtnQuerybyDept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "加班列表";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(613, 412);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 29);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // GrdOT
            // 
            this.GrdOT.AllowUserToAddRows = false;
            this.GrdOT.AllowUserToDeleteRows = false;
            this.GrdOT.AllowUserToResizeColumns = false;
            this.GrdOT.AllowUserToResizeRows = false;
            this.GrdOT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrdOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdOT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.GrdOT.Location = new System.Drawing.Point(45, 93);
            this.GrdOT.MultiSelect = false;
            this.GrdOT.Name = "GrdOT";
            this.GrdOT.RowTemplate.Height = 27;
            this.GrdOT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdOT.Size = new System.Drawing.Size(643, 310);
            this.GrdOT.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "applyId";
            this.Column1.HeaderText = "申请编号";
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
            this.Column3.DataPropertyName = "submitTime";
            this.Column3.HeaderText = "提交时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "overtimeReason";
            this.Column4.HeaderText = "加班原因";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "applyConditions";
            this.Column5.HeaderText = "状态";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "overtimeName";
            this.Column6.HeaderText = "描述";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // BtnQuerybyEmp
            // 
            this.BtnQuerybyEmp.Location = new System.Drawing.Point(161, 18);
            this.BtnQuerybyEmp.Name = "BtnQuerybyEmp";
            this.BtnQuerybyEmp.Size = new System.Drawing.Size(75, 29);
            this.BtnQuerybyEmp.TabIndex = 6;
            this.BtnQuerybyEmp.Text = "员工查询";
            this.BtnQuerybyEmp.UseVisualStyleBackColor = true;
            this.BtnQuerybyEmp.Click += new System.EventHandler(this.BtnQuerybyEmp_Click);
            // 
            // BtnQuerybyDept
            // 
            this.BtnQuerybyDept.Location = new System.Drawing.Point(45, 18);
            this.BtnQuerybyDept.Name = "BtnQuerybyDept";
            this.BtnQuerybyDept.Size = new System.Drawing.Size(75, 29);
            this.BtnQuerybyDept.TabIndex = 5;
            this.BtnQuerybyDept.Text = "部门汇总";
            this.BtnQuerybyDept.UseVisualStyleBackColor = true;
            this.BtnQuerybyDept.Click += new System.EventHandler(this.BtnQuerybyDept_Click);
            // 
            // FrmOvertimeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrdOT);
            this.Controls.Add(this.BtnQuerybyEmp);
            this.Controls.Add(this.BtnQuerybyDept);
            this.Name = "FrmOvertimeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加班管理";
            this.Load += new System.EventHandler(this.FrmOvertimeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdOT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.DataGridView GrdOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button BtnQuerybyEmp;
        private System.Windows.Forms.Button BtnQuerybyDept;
    }
}