namespace PersonnelManagementSystem.ManagementFunction.LeaveManagement
{
    partial class FrmVacationSetting
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.clbVacation = new System.Windows.Forms.CheckedListBox();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.dtpVacation = new System.Windows.Forms.DateTimePicker();
            this.lblVacationName = new System.Windows.Forms.Label();
            this.txtVacationName = new System.Windows.Forms.TextBox();
            this.cbNationalVacation = new System.Windows.Forms.CheckBox();
            this.btnAddVaction = new System.Windows.Forms.Button();
            this.btnDelVaction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAllVacationDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pbSetting);
            this.groupBox.Controls.Add(this.clbVacation);
            this.groupBox.Controls.Add(this.pbTime);
            this.groupBox.Controls.Add(this.dtpVacation);
            this.groupBox.Controls.Add(this.lblVacationName);
            this.groupBox.Controls.Add(this.txtVacationName);
            this.groupBox.Controls.Add(this.cbNationalVacation);
            this.groupBox.Controls.Add(this.btnAddVaction);
            this.groupBox.Controls.Add(this.btnDelVaction);
            this.groupBox.Location = new System.Drawing.Point(19, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(615, 320);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // pbSetting
            // 
            this.pbSetting.Image = global::PersonnelManagementSystem.Properties.Resources.setting_48px_26276_easyicon_net;
            this.pbSetting.Location = new System.Drawing.Point(10, 25);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(48, 48);
            this.pbSetting.TabIndex = 12;
            this.pbSetting.TabStop = false;
            // 
            // clbVacation
            // 
            this.clbVacation.FormattingEnabled = true;
            this.clbVacation.Location = new System.Drawing.Point(65, 25);
            this.clbVacation.Margin = new System.Windows.Forms.Padding(4);
            this.clbVacation.Name = "clbVacation";
            this.clbVacation.Size = new System.Drawing.Size(265, 264);
            this.clbVacation.TabIndex = 0;
            // 
            // pbTime
            // 
            this.pbTime.Image = global::PersonnelManagementSystem.Properties.Resources.goog_event_calendar_lb_32px_524502_easyicon_net;
            this.pbTime.Location = new System.Drawing.Point(337, 25);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(32, 32);
            this.pbTime.TabIndex = 11;
            this.pbTime.TabStop = false;
            // 
            // dtpVacation
            // 
            this.dtpVacation.Location = new System.Drawing.Point(376, 25);
            this.dtpVacation.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVacation.Name = "dtpVacation";
            this.dtpVacation.Size = new System.Drawing.Size(221, 25);
            this.dtpVacation.TabIndex = 1;
            // 
            // lblVacationName
            // 
            this.lblVacationName.AutoSize = true;
            this.lblVacationName.Location = new System.Drawing.Point(373, 81);
            this.lblVacationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVacationName.Name = "lblVacationName";
            this.lblVacationName.Size = new System.Drawing.Size(67, 15);
            this.lblVacationName.TabIndex = 2;
            this.lblVacationName.Text = "假期名称";
            // 
            // txtVacationName
            // 
            this.txtVacationName.Location = new System.Drawing.Point(376, 116);
            this.txtVacationName.Margin = new System.Windows.Forms.Padding(4);
            this.txtVacationName.Name = "txtVacationName";
            this.txtVacationName.Size = new System.Drawing.Size(221, 25);
            this.txtVacationName.TabIndex = 3;
            // 
            // cbNationalVacation
            // 
            this.cbNationalVacation.AutoSize = true;
            this.cbNationalVacation.Location = new System.Drawing.Point(376, 180);
            this.cbNationalVacation.Margin = new System.Windows.Forms.Padding(4);
            this.cbNationalVacation.Name = "cbNationalVacation";
            this.cbNationalVacation.Size = new System.Drawing.Size(89, 19);
            this.cbNationalVacation.TabIndex = 4;
            this.cbNationalVacation.Text = "国定假日";
            this.cbNationalVacation.UseVisualStyleBackColor = true;
            // 
            // btnAddVaction
            // 
            this.btnAddVaction.Location = new System.Drawing.Point(376, 234);
            this.btnAddVaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVaction.Name = "btnAddVaction";
            this.btnAddVaction.Size = new System.Drawing.Size(100, 29);
            this.btnAddVaction.TabIndex = 5;
            this.btnAddVaction.Text = "增加假日";
            this.btnAddVaction.UseVisualStyleBackColor = true;
            this.btnAddVaction.Click += new System.EventHandler(this.btnAddVaction_Click);
            // 
            // btnDelVaction
            // 
            this.btnDelVaction.Location = new System.Drawing.Point(498, 234);
            this.btnDelVaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelVaction.Name = "btnDelVaction";
            this.btnDelVaction.Size = new System.Drawing.Size(100, 29);
            this.btnDelVaction.TabIndex = 6;
            this.btnDelVaction.Text = "删除假日";
            this.btnDelVaction.UseVisualStyleBackColor = true;
            this.btnDelVaction.Click += new System.EventHandler(this.btnDelVaction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(510, 420);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(364, 420);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 40);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAllVacationDays
            // 
            this.lblAllVacationDays.AutoSize = true;
            this.lblAllVacationDays.Location = new System.Drawing.Point(399, 356);
            this.lblAllVacationDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllVacationDays.Name = "lblAllVacationDays";
            this.lblAllVacationDays.Size = new System.Drawing.Size(82, 15);
            this.lblAllVacationDays.TabIndex = 14;
            this.lblAllVacationDays.Text = "年假天数：";
            // 
            // numDays
            // 
            this.numDays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numDays.Location = new System.Drawing.Point(511, 350);
            this.numDays.Margin = new System.Windows.Forms.Padding(4);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(123, 25);
            this.numDays.TabIndex = 13;
            this.numDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(652, 473);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 630;
            this.lineShape1.Y1 = 400;
            this.lineShape1.Y2 = 400;
            // 
            // FrmVacationSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 473);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAllVacationDays);
            this.Controls.Add(this.numDays);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmVacationSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "假期设置";
            this.Load += new System.EventHandler(this.FrmVacationSetting_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.CheckedListBox clbVacation;
        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.DateTimePicker dtpVacation;
        private System.Windows.Forms.Label lblVacationName;
        private System.Windows.Forms.TextBox txtVacationName;
        private System.Windows.Forms.CheckBox cbNationalVacation;
        private System.Windows.Forms.Button btnAddVaction;
        private System.Windows.Forms.Button btnDelVaction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAllVacationDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}