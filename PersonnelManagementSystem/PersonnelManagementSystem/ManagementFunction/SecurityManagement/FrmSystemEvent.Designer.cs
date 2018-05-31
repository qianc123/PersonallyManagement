namespace PersonnelManagementSystem.ManagementFunction.SecurityManagement
{
    partial class FrmSystemEvent
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
            this.lblSystemEventList = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnQueryEvent = new System.Windows.Forms.Button();
            this.grdEvent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSystemEventList
            // 
            this.lblSystemEventList.BackColor = System.Drawing.Color.Red;
            this.lblSystemEventList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSystemEventList.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.lblSystemEventList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSystemEventList.Location = new System.Drawing.Point(36, 22);
            this.lblSystemEventList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemEventList.Name = "lblSystemEventList";
            this.lblSystemEventList.Size = new System.Drawing.Size(412, 32);
            this.lblSystemEventList.TabIndex = 7;
            this.lblSystemEventList.Text = "系统事件列表";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(496, 381);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 36);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnQueryEvent
            // 
            this.btnQueryEvent.Location = new System.Drawing.Point(496, 321);
            this.btnQueryEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryEvent.Name = "btnQueryEvent";
            this.btnQueryEvent.Size = new System.Drawing.Size(100, 36);
            this.btnQueryEvent.TabIndex = 5;
            this.btnQueryEvent.Text = "查询";
            this.btnQueryEvent.UseVisualStyleBackColor = true;
            this.btnQueryEvent.Click += new System.EventHandler(this.btnQueryEvent_Click);
            // 
            // grdEvent
            // 
            this.grdEvent.AllowUserToAddRows = false;
            this.grdEvent.AllowUserToDeleteRows = false;
            this.grdEvent.AllowUserToResizeColumns = false;
            this.grdEvent.AllowUserToResizeRows = false;
            this.grdEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdEvent.Location = new System.Drawing.Point(36, 55);
            this.grdEvent.Margin = new System.Windows.Forms.Padding(4);
            this.grdEvent.MultiSelect = false;
            this.grdEvent.Name = "grdEvent";
            this.grdEvent.ReadOnly = true;
            this.grdEvent.RowTemplate.Height = 23;
            this.grdEvent.Size = new System.Drawing.Size(412, 375);
            this.grdEvent.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "eventId";
            this.Column1.HeaderText = "事件编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "eventDescribe";
            this.Column2.HeaderText = "事件描述";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "eventTime";
            this.Column3.HeaderText = "事件时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmSystemEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.lblSystemEventList);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnQueryEvent);
            this.Controls.Add(this.grdEvent);
            this.Name = "FrmSystemEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统事件";
            this.Load += new System.EventHandler(this.FrmSystemEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSystemEventList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnQueryEvent;
        private System.Windows.Forms.DataGridView grdEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}