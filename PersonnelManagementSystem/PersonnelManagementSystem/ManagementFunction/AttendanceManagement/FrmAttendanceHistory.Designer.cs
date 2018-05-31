namespace PersonnelManagementSystem.ManagementFunction.AttendanceManagement
{
    partial class FrmAttendanceHistory
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
            this.BthCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BthCancel
            // 
            this.BthCancel.Location = new System.Drawing.Point(261, 183);
            this.BthCancel.Name = "BthCancel";
            this.BthCancel.Size = new System.Drawing.Size(75, 23);
            this.BthCancel.TabIndex = 9;
            this.BthCancel.Text = "取消";
            this.BthCancel.UseVisualStyleBackColor = true;
            this.BthCancel.Click += new System.EventHandler(this.BthCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(95, 183);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DtpStart);
            this.panel1.Controls.Add(this.lblEnd);
            this.panel1.Controls.Add(this.DtpEnd);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Location = new System.Drawing.Point(37, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 110);
            this.panel1.TabIndex = 7;
            // 
            // DtpStart
            // 
            this.DtpStart.Location = new System.Drawing.Point(173, 24);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(156, 25);
            this.DtpStart.TabIndex = 0;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(85, 63);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(82, 15);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "截止时间：";
            // 
            // DtpEnd
            // 
            this.DtpEnd.Location = new System.Drawing.Point(173, 56);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(156, 25);
            this.DtpEnd.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(85, 31);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(82, 15);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "起始时间：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonnelManagementSystem.Properties.Resources.goog_event_calendar_lb_32px_524502_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(29, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAttendanceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.BthCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAttendanceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设定查询范围";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BthCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}