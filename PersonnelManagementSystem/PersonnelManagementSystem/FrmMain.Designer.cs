namespace PersonnelManagementSystem
{
    partial class FrmMain
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
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnDepartmentManagement = new System.Windows.Forms.Button();
            this.btnLeaveManagement = new System.Windows.Forms.Button();
            this.btnAttendanceManagement = new System.Windows.Forms.Button();
            this.btnOvertimeManagement = new System.Windows.Forms.Button();
            this.btnSalaryManagement = new System.Windows.Forms.Button();
            this.btnSecurityManagement = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSecurityManagement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecurityManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.AutoSize = true;
            this.btnEmployeeManagement.Location = new System.Drawing.Point(100, 60);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(107, 36);
            this.btnEmployeeManagement.TabIndex = 0;
            this.btnEmployeeManagement.Text = "员工资料管理";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnDepartmentManagement
            // 
            this.btnDepartmentManagement.Location = new System.Drawing.Point(101, 135);
            this.btnDepartmentManagement.Name = "btnDepartmentManagement";
            this.btnDepartmentManagement.Size = new System.Drawing.Size(107, 36);
            this.btnDepartmentManagement.TabIndex = 1;
            this.btnDepartmentManagement.Text = "部门管理";
            this.btnDepartmentManagement.UseVisualStyleBackColor = true;
            this.btnDepartmentManagement.Click += new System.EventHandler(this.btnDepartmentManagement_Click);
            // 
            // btnLeaveManagement
            // 
            this.btnLeaveManagement.Location = new System.Drawing.Point(101, 205);
            this.btnLeaveManagement.Name = "btnLeaveManagement";
            this.btnLeaveManagement.Size = new System.Drawing.Size(107, 36);
            this.btnLeaveManagement.TabIndex = 2;
            this.btnLeaveManagement.Text = "请假管理";
            this.btnLeaveManagement.UseVisualStyleBackColor = true;
            this.btnLeaveManagement.Click += new System.EventHandler(this.btnLeaveManagement_Click);
            // 
            // btnAttendanceManagement
            // 
            this.btnAttendanceManagement.Location = new System.Drawing.Point(101, 275);
            this.btnAttendanceManagement.Name = "btnAttendanceManagement";
            this.btnAttendanceManagement.Size = new System.Drawing.Size(107, 36);
            this.btnAttendanceManagement.TabIndex = 3;
            this.btnAttendanceManagement.Text = "考勤管理";
            this.btnAttendanceManagement.UseVisualStyleBackColor = true;
            this.btnAttendanceManagement.Click += new System.EventHandler(this.btnAttendanceManagement_Click);
            // 
            // btnOvertimeManagement
            // 
            this.btnOvertimeManagement.Location = new System.Drawing.Point(300, 60);
            this.btnOvertimeManagement.Name = "btnOvertimeManagement";
            this.btnOvertimeManagement.Size = new System.Drawing.Size(75, 36);
            this.btnOvertimeManagement.TabIndex = 4;
            this.btnOvertimeManagement.Text = "加班管理";
            this.btnOvertimeManagement.UseVisualStyleBackColor = true;
            this.btnOvertimeManagement.Click += new System.EventHandler(this.btnOvertimeManagement_Click);
            // 
            // btnSalaryManagement
            // 
            this.btnSalaryManagement.Location = new System.Drawing.Point(300, 135);
            this.btnSalaryManagement.Name = "btnSalaryManagement";
            this.btnSalaryManagement.Size = new System.Drawing.Size(75, 36);
            this.btnSalaryManagement.TabIndex = 5;
            this.btnSalaryManagement.Text = "薪资管理";
            this.btnSalaryManagement.UseVisualStyleBackColor = true;
            this.btnSalaryManagement.Click += new System.EventHandler(this.btnSalaryManagement_Click);
            // 
            // btnSecurityManagement
            // 
            this.btnSecurityManagement.Location = new System.Drawing.Point(300, 205);
            this.btnSecurityManagement.Name = "btnSecurityManagement";
            this.btnSecurityManagement.Size = new System.Drawing.Size(75, 36);
            this.btnSecurityManagement.TabIndex = 6;
            this.btnSecurityManagement.Text = "安全管理";
            this.btnSecurityManagement.UseVisualStyleBackColor = true;
            this.btnSecurityManagement.Click += new System.EventHandler(this.btnSecurityManagement_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(300, 275);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 36);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PersonnelManagementSystem.Properties.Resources.id_card_48px_1202415_easyicon_net;
            this.pictureBox7.Location = new System.Drawing.Point(46, 48);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 48);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PersonnelManagementSystem.Properties.Resources.box_closed_48px_534956_easyicon_net;
            this.pictureBox6.Location = new System.Drawing.Point(246, 263);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PersonnelManagementSystem.Properties.Resources.tables_48px_1082322_easyicon_net;
            this.pictureBox5.Location = new System.Drawing.Point(46, 263);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PersonnelManagementSystem.Properties.Resources.Groups_Folder_48px_1173172_easyicon_net;
            this.pictureBox4.Location = new System.Drawing.Point(46, 123);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PersonnelManagementSystem.Properties.Resources.clock_file_temporary_time_48px_1902_easyicon_net;
            this.pictureBox3.Location = new System.Drawing.Point(246, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PersonnelManagementSystem.Properties.Resources.sign_up_48px_12013_easyicon_net;
            this.pictureBox2.Location = new System.Drawing.Point(46, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonnelManagementSystem.Properties.Resources.Coin_money_gold_48px_510549_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(246, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbSecurityManagement
            // 
            this.pbSecurityManagement.Image = global::PersonnelManagementSystem.Properties.Resources.safe_Shield_48px_556119_easyicon_net;
            this.pbSecurityManagement.Location = new System.Drawing.Point(246, 193);
            this.pbSecurityManagement.Name = "pbSecurityManagement";
            this.pbSecurityManagement.Size = new System.Drawing.Size(48, 48);
            this.pbSecurityManagement.TabIndex = 8;
            this.pbSecurityManagement.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 373);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbSecurityManagement);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSecurityManagement);
            this.Controls.Add(this.btnSalaryManagement);
            this.Controls.Add(this.btnOvertimeManagement);
            this.Controls.Add(this.btnAttendanceManagement);
            this.Controls.Add(this.btnLeaveManagement);
            this.Controls.Add(this.btnDepartmentManagement);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  人事管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecurityManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnDepartmentManagement;
        private System.Windows.Forms.Button btnLeaveManagement;
        private System.Windows.Forms.Button btnAttendanceManagement;
        private System.Windows.Forms.Button btnOvertimeManagement;
        private System.Windows.Forms.Button btnSalaryManagement;
        private System.Windows.Forms.Button btnSecurityManagement;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pbSecurityManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}