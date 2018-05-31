namespace PersonnelManagementSystem.ManagementFunction.LeaveManagement
{
    partial class FrmRefuseApplication
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
            this.lblRefuseReason = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRefuseReason
            // 
            this.lblRefuseReason.AutoSize = true;
            this.lblRefuseReason.Location = new System.Drawing.Point(19, 29);
            this.lblRefuseReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefuseReason.Name = "lblRefuseReason";
            this.lblRefuseReason.Size = new System.Drawing.Size(82, 15);
            this.lblRefuseReason.TabIndex = 5;
            this.lblRefuseReason.Text = "撤销理由：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(398, 187);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 36);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(18, 63);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(480, 96);
            this.txtReason.TabIndex = 3;
            // 
            // FrmRefuseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 253);
            this.Controls.Add(this.lblRefuseReason);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtReason);
            this.Name = "FrmRefuseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "撤销申请";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRefuseReason;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtReason;

    }
}