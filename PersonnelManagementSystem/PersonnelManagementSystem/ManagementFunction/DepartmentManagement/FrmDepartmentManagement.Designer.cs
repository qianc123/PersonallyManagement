namespace PersonnelManagementSystem.ManagementFunction.DepartmentManagement
{
    partial class FrmDepartmentManagement
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDeptDetail = new System.Windows.Forms.Button();
            this.btnDeleteDept = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.tvDept = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(330, 387);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(103, 36);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDeptDetail
            // 
            this.btnDeptDetail.Location = new System.Drawing.Point(330, 334);
            this.btnDeptDetail.Name = "btnDeptDetail";
            this.btnDeptDetail.Size = new System.Drawing.Size(103, 36);
            this.btnDeptDetail.TabIndex = 8;
            this.btnDeptDetail.Text = "部门明细";
            this.btnDeptDetail.UseVisualStyleBackColor = true;
            this.btnDeptDetail.Click += new System.EventHandler(this.btnDeptDetail_Click);
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.Location = new System.Drawing.Point(330, 282);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Size = new System.Drawing.Size(103, 36);
            this.btnDeleteDept.TabIndex = 7;
            this.btnDeleteDept.Text = "删除部门";
            this.btnDeleteDept.UseVisualStyleBackColor = true;
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(330, 231);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(103, 36);
            this.btnAddDept.TabIndex = 6;
            this.btnAddDept.Text = "增加部门";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // tvDept
            // 
            this.tvDept.Location = new System.Drawing.Point(50, 19);
            this.tvDept.Name = "tvDept";
            this.tvDept.Size = new System.Drawing.Size(212, 441);
            this.tvDept.TabIndex = 5;
            this.tvDept.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvDept_AfterExpand);
            this.tvDept.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvDept_ItemDrag);
            this.tvDept.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDept_AfterSelect);
            this.tvDept.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvDept_DragDrop);
            this.tvDept.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvDept_DragEnter);
            // 
            // FrmDepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 478);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDeptDetail);
            this.Controls.Add(this.btnDeleteDept);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.tvDept);
            this.Name = "FrmDepartmentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.FrmDepartmentManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDeptDetail;
        private System.Windows.Forms.Button btnDeleteDept;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.TreeView tvDept;
    }
}