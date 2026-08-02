namespace PresentationLayer
{
    partial class frmTakeAppointment
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbScheduleTest = new System.Windows.Forms.GroupBox();
            this.pbTestIcon = new System.Windows.Forms.PictureBox();
            this.lblLocalDrivingLicenseApplicationIDTitle = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicenseApplicationIDValue = new System.Windows.Forms.Label();
            this.lblDrivingClassTitle = new System.Windows.Forms.Label();
            this.lblDrivingClassValue = new System.Windows.Forms.Label();
            this.lblApplicantNameTitle = new System.Windows.Forms.Label();
            this.lblApplicantNameValue = new System.Windows.Forms.Label();
            this.lblTrialTitle = new System.Windows.Forms.Label();
            this.lblTrialValue = new System.Windows.Forms.Label();
            this.lblAppointmentDateTitle = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblFeesTitle = new System.Windows.Forms.Label();
            this.lblFeesValue = new System.Windows.Forms.Label();
            this.gbRetakeTestInformation = new System.Windows.Forms.GroupBox();
            this.lblRetakeApplicationFeesTitle = new System.Windows.Forms.Label();
            this.lblRetakeApplicationFeesValue = new System.Windows.Forms.Label();
            this.lblRetakeTestApplicationIDTitle = new System.Windows.Forms.Label();
            this.lblRetakeTestApplicationIDValue = new System.Windows.Forms.Label();
            this.lblTotalFeesTitle = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbScheduleTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestIcon)).BeginInit();
            this.gbRetakeTestInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Schedule Test";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbScheduleTest
            // 
            this.gbScheduleTest.BackColor = System.Drawing.Color.White;
            this.gbScheduleTest.Controls.Add(this.pbTestIcon);
            this.gbScheduleTest.Controls.Add(this.lblLocalDrivingLicenseApplicationIDTitle);
            this.gbScheduleTest.Controls.Add(this.lblLocalDrivingLicenseApplicationIDValue);
            this.gbScheduleTest.Controls.Add(this.lblDrivingClassTitle);
            this.gbScheduleTest.Controls.Add(this.lblDrivingClassValue);
            this.gbScheduleTest.Controls.Add(this.lblApplicantNameTitle);
            this.gbScheduleTest.Controls.Add(this.lblApplicantNameValue);
            this.gbScheduleTest.Controls.Add(this.lblTrialTitle);
            this.gbScheduleTest.Controls.Add(this.lblTrialValue);
            this.gbScheduleTest.Controls.Add(this.lblAppointmentDateTitle);
            this.gbScheduleTest.Controls.Add(this.dtpAppointmentDate);
            this.gbScheduleTest.Controls.Add(this.lblFeesTitle);
            this.gbScheduleTest.Controls.Add(this.lblFeesValue);
            this.gbScheduleTest.Controls.Add(this.gbRetakeTestInformation);
            this.gbScheduleTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScheduleTest.Location = new System.Drawing.Point(30, 95);
            this.gbScheduleTest.Name = "gbScheduleTest";
            this.gbScheduleTest.Size = new System.Drawing.Size(540, 560);
            this.gbScheduleTest.TabIndex = 1;
            this.gbScheduleTest.TabStop = false;
            this.gbScheduleTest.Text = "Vision Test";
            this.gbScheduleTest.Enter += new System.EventHandler(this.gbScheduleTest_Enter);
            // 
            // pbTestIcon
            // 
            this.pbTestIcon.Location = new System.Drawing.Point(220, 30);
            this.pbTestIcon.Name = "pbTestIcon";
            this.pbTestIcon.Size = new System.Drawing.Size(100, 100);
            this.pbTestIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestIcon.TabIndex = 0;
            this.pbTestIcon.TabStop = false;
            // 
            // lblLocalDrivingLicenseApplicationIDTitle
            // 
            this.lblLocalDrivingLicenseApplicationIDTitle.AutoSize = true;
            this.lblLocalDrivingLicenseApplicationIDTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingLicenseApplicationIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLocalDrivingLicenseApplicationIDTitle.Location = new System.Drawing.Point(30, 150);
            this.lblLocalDrivingLicenseApplicationIDTitle.Name = "lblLocalDrivingLicenseApplicationIDTitle";
            this.lblLocalDrivingLicenseApplicationIDTitle.Size = new System.Drawing.Size(97, 21);
            this.lblLocalDrivingLicenseApplicationIDTitle.TabIndex = 1;
            this.lblLocalDrivingLicenseApplicationIDTitle.Text = "D.L. App ID:";
            // 
            // lblLocalDrivingLicenseApplicationIDValue
            // 
            this.lblLocalDrivingLicenseApplicationIDValue.AutoSize = true;
            this.lblLocalDrivingLicenseApplicationIDValue.Location = new System.Drawing.Point(180, 150);
            this.lblLocalDrivingLicenseApplicationIDValue.Name = "lblLocalDrivingLicenseApplicationIDValue";
            this.lblLocalDrivingLicenseApplicationIDValue.Size = new System.Drawing.Size(38, 21);
            this.lblLocalDrivingLicenseApplicationIDValue.TabIndex = 2;
            this.lblLocalDrivingLicenseApplicationIDValue.Text = "N/A";
            // 
            // lblDrivingClassTitle
            // 
            this.lblDrivingClassTitle.AutoSize = true;
            this.lblDrivingClassTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDrivingClassTitle.Location = new System.Drawing.Point(30, 190);
            this.lblDrivingClassTitle.Name = "lblDrivingClassTitle";
            this.lblDrivingClassTitle.Size = new System.Drawing.Size(71, 21);
            this.lblDrivingClassTitle.TabIndex = 3;
            this.lblDrivingClassTitle.Text = "D. Class:";
            // 
            // lblDrivingClassValue
            // 
            this.lblDrivingClassValue.AutoSize = true;
            this.lblDrivingClassValue.Location = new System.Drawing.Point(180, 190);
            this.lblDrivingClassValue.Name = "lblDrivingClassValue";
            this.lblDrivingClassValue.Size = new System.Drawing.Size(38, 21);
            this.lblDrivingClassValue.TabIndex = 4;
            this.lblDrivingClassValue.Text = "N/A";
            // 
            // lblApplicantNameTitle
            // 
            this.lblApplicantNameTitle.AutoSize = true;
            this.lblApplicantNameTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblApplicantNameTitle.Location = new System.Drawing.Point(30, 230);
            this.lblApplicantNameTitle.Name = "lblApplicantNameTitle";
            this.lblApplicantNameTitle.Size = new System.Drawing.Size(60, 21);
            this.lblApplicantNameTitle.TabIndex = 5;
            this.lblApplicantNameTitle.Text = "Name:";
            // 
            // lblApplicantNameValue
            // 
            this.lblApplicantNameValue.AutoSize = true;
            this.lblApplicantNameValue.Location = new System.Drawing.Point(180, 230);
            this.lblApplicantNameValue.Name = "lblApplicantNameValue";
            this.lblApplicantNameValue.Size = new System.Drawing.Size(38, 21);
            this.lblApplicantNameValue.TabIndex = 6;
            this.lblApplicantNameValue.Text = "N/A";
            // 
            // lblTrialTitle
            // 
            this.lblTrialTitle.AutoSize = true;
            this.lblTrialTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrialTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTrialTitle.Location = new System.Drawing.Point(30, 270);
            this.lblTrialTitle.Name = "lblTrialTitle";
            this.lblTrialTitle.Size = new System.Drawing.Size(47, 21);
            this.lblTrialTitle.TabIndex = 7;
            this.lblTrialTitle.Text = "Trial:";
            // 
            // lblTrialValue
            // 
            this.lblTrialValue.AutoSize = true;
            this.lblTrialValue.Location = new System.Drawing.Point(180, 270);
            this.lblTrialValue.Name = "lblTrialValue";
            this.lblTrialValue.Size = new System.Drawing.Size(19, 21);
            this.lblTrialValue.TabIndex = 8;
            this.lblTrialValue.Text = "0";
            // 
            // lblAppointmentDateTitle
            // 
            this.lblAppointmentDateTitle.AutoSize = true;
            this.lblAppointmentDateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAppointmentDateTitle.Location = new System.Drawing.Point(30, 310);
            this.lblAppointmentDateTitle.Name = "lblAppointmentDateTitle";
            this.lblAppointmentDateTitle.Size = new System.Drawing.Size(50, 21);
            this.lblAppointmentDateTitle.TabIndex = 9;
            this.lblAppointmentDateTitle.Text = "Date:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(180, 310);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(150, 29);
            this.dtpAppointmentDate.TabIndex = 10;
            this.dtpAppointmentDate.ValueChanged += new System.EventHandler(this.dtpAppointmentDate_ValueChanged);
            // 
            // lblFeesTitle
            // 
            this.lblFeesTitle.AutoSize = true;
            this.lblFeesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblFeesTitle.Location = new System.Drawing.Point(30, 350);
            this.lblFeesTitle.Name = "lblFeesTitle";
            this.lblFeesTitle.Size = new System.Drawing.Size(47, 21);
            this.lblFeesTitle.TabIndex = 11;
            this.lblFeesTitle.Text = "Fees:";
            // 
            // lblFeesValue
            // 
            this.lblFeesValue.AutoSize = true;
            this.lblFeesValue.Location = new System.Drawing.Point(180, 350);
            this.lblFeesValue.Name = "lblFeesValue";
            this.lblFeesValue.Size = new System.Drawing.Size(19, 21);
            this.lblFeesValue.TabIndex = 12;
            this.lblFeesValue.Text = "0";
            // 
            // gbRetakeTestInformation
            // 
            this.gbRetakeTestInformation.Controls.Add(this.lblRetakeApplicationFeesTitle);
            this.gbRetakeTestInformation.Controls.Add(this.lblRetakeApplicationFeesValue);
            this.gbRetakeTestInformation.Controls.Add(this.lblRetakeTestApplicationIDTitle);
            this.gbRetakeTestInformation.Controls.Add(this.lblRetakeTestApplicationIDValue);
            this.gbRetakeTestInformation.Controls.Add(this.lblTotalFeesTitle);
            this.gbRetakeTestInformation.Controls.Add(this.lblTotalFeesValue);
            this.gbRetakeTestInformation.Location = new System.Drawing.Point(20, 390);
            this.gbRetakeTestInformation.Name = "gbRetakeTestInformation";
            this.gbRetakeTestInformation.Size = new System.Drawing.Size(500, 150);
            this.gbRetakeTestInformation.TabIndex = 13;
            this.gbRetakeTestInformation.TabStop = false;
            this.gbRetakeTestInformation.Text = "Retake Test Information";
            // 
            // lblRetakeApplicationFeesTitle
            // 
            this.lblRetakeApplicationFeesTitle.AutoSize = true;
            this.lblRetakeApplicationFeesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetakeApplicationFeesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRetakeApplicationFeesTitle.Location = new System.Drawing.Point(20, 40);
            this.lblRetakeApplicationFeesTitle.Name = "lblRetakeApplicationFeesTitle";
            this.lblRetakeApplicationFeesTitle.Size = new System.Drawing.Size(104, 21);
            this.lblRetakeApplicationFeesTitle.TabIndex = 14;
            this.lblRetakeApplicationFeesTitle.Text = "R. App. Fees:";
            // 
            // lblRetakeApplicationFeesValue
            // 
            this.lblRetakeApplicationFeesValue.AutoSize = true;
            this.lblRetakeApplicationFeesValue.Location = new System.Drawing.Point(150, 40);
            this.lblRetakeApplicationFeesValue.Name = "lblRetakeApplicationFeesValue";
            this.lblRetakeApplicationFeesValue.Size = new System.Drawing.Size(19, 21);
            this.lblRetakeApplicationFeesValue.TabIndex = 15;
            this.lblRetakeApplicationFeesValue.Text = "0";
            // 
            // lblRetakeTestApplicationIDTitle
            // 
            this.lblRetakeTestApplicationIDTitle.AutoSize = true;
            this.lblRetakeTestApplicationIDTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetakeTestApplicationIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRetakeTestApplicationIDTitle.Location = new System.Drawing.Point(20, 80);
            this.lblRetakeTestApplicationIDTitle.Name = "lblRetakeTestApplicationIDTitle";
            this.lblRetakeTestApplicationIDTitle.Size = new System.Drawing.Size(118, 21);
            this.lblRetakeTestApplicationIDTitle.TabIndex = 16;
            this.lblRetakeTestApplicationIDTitle.Text = "R.Test App. ID:";
            // 
            // lblRetakeTestApplicationIDValue
            // 
            this.lblRetakeTestApplicationIDValue.AutoSize = true;
            this.lblRetakeTestApplicationIDValue.Location = new System.Drawing.Point(150, 80);
            this.lblRetakeTestApplicationIDValue.Name = "lblRetakeTestApplicationIDValue";
            this.lblRetakeTestApplicationIDValue.Size = new System.Drawing.Size(38, 21);
            this.lblRetakeTestApplicationIDValue.TabIndex = 17;
            this.lblRetakeTestApplicationIDValue.Text = "N/A";
            // 
            // lblTotalFeesTitle
            // 
            this.lblTotalFeesTitle.AutoSize = true;
            this.lblTotalFeesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTotalFeesTitle.Location = new System.Drawing.Point(260, 40);
            this.lblTotalFeesTitle.Name = "lblTotalFeesTitle";
            this.lblTotalFeesTitle.Size = new System.Drawing.Size(89, 21);
            this.lblTotalFeesTitle.TabIndex = 18;
            this.lblTotalFeesTitle.Text = "Total Fees:";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Location = new System.Drawing.Point(360, 40);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(19, 21);
            this.lblTotalFeesValue.TabIndex = 19;
            this.lblTotalFeesValue.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(450, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(30, 675);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(600, 740);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbScheduleTest);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmTakeAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Test";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbScheduleTest.ResumeLayout(false);
            this.gbScheduleTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestIcon)).EndInit();
            this.gbRetakeTestInformation.ResumeLayout(false);
            this.gbRetakeTestInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbScheduleTest;
        private System.Windows.Forms.PictureBox pbTestIcon;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationIDTitle;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationIDValue;
        private System.Windows.Forms.Label lblDrivingClassTitle;
        private System.Windows.Forms.Label lblDrivingClassValue;
        private System.Windows.Forms.Label lblApplicantNameTitle;
        private System.Windows.Forms.Label lblApplicantNameValue;
        private System.Windows.Forms.Label lblTrialTitle;
        private System.Windows.Forms.Label lblTrialValue;
        private System.Windows.Forms.Label lblAppointmentDateTitle;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblFeesTitle;
        private System.Windows.Forms.Label lblFeesValue;

        private System.Windows.Forms.GroupBox gbRetakeTestInformation;
        private System.Windows.Forms.Label lblRetakeApplicationFeesTitle;
        private System.Windows.Forms.Label lblRetakeApplicationFeesValue;
        private System.Windows.Forms.Label lblRetakeTestApplicationIDTitle;
        private System.Windows.Forms.Label lblRetakeTestApplicationIDValue;
        private System.Windows.Forms.Label lblTotalFeesTitle;
        private System.Windows.Forms.Label lblTotalFeesValue;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
