namespace DVLD.Presentation_Layer
{
    partial class ctrlDrivingLicenseApplicationInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.gbDrivingLicenseApplicationInfo = new System.Windows.Forms.GroupBox();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblPassedTestsValue = new System.Windows.Forms.Label();
            this.lblAppliedForLicenseValue = new System.Windows.Forms.Label();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.lblAppliedForLicense = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.gbDrivingLicenseApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDrivingLicenseApplicationInfo
            // 
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.llShowLicenseInfo);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblPassedTestsValue);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblAppliedForLicenseValue);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblDLAppIDValue);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblPassedTests);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblAppliedForLicense);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblDLAppID);
            this.gbDrivingLicenseApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDrivingLicenseApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrivingLicenseApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.gbDrivingLicenseApplicationInfo.Name = "gbDrivingLicenseApplicationInfo";
            this.gbDrivingLicenseApplicationInfo.Size = new System.Drawing.Size(950, 256);
            this.gbDrivingLicenseApplicationInfo.TabIndex = 0;
            this.gbDrivingLicenseApplicationInfo.TabStop = false;
            this.gbDrivingLicenseApplicationInfo.Text = "Driving License Application Info";
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(20, 75);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(118, 19);
            this.llShowLicenseInfo.TabIndex = 6;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // lblPassedTestsValue
            // 
            this.lblPassedTestsValue.AutoSize = true;
            this.lblPassedTestsValue.Location = new System.Drawing.Point(721, 40);
            this.lblPassedTestsValue.Name = "lblPassedTestsValue";
            this.lblPassedTestsValue.Size = new System.Drawing.Size(35, 19);
            this.lblPassedTestsValue.TabIndex = 5;
            this.lblPassedTestsValue.Text = "[???]";
            // 
            // lblAppliedForLicenseValue
            // 
            this.lblAppliedForLicenseValue.AutoSize = true;
            this.lblAppliedForLicenseValue.Location = new System.Drawing.Point(448, 40);
            this.lblAppliedForLicenseValue.Name = "lblAppliedForLicenseValue";
            this.lblAppliedForLicenseValue.Size = new System.Drawing.Size(35, 19);
            this.lblAppliedForLicenseValue.TabIndex = 4;
            this.lblAppliedForLicenseValue.Text = "[???]";
            // 
            // lblDLAppIDValue
            // 
            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Location = new System.Drawing.Point(109, 40);
            this.lblDLAppIDValue.Name = "lblDLAppIDValue";
            this.lblDLAppIDValue.Size = new System.Drawing.Size(35, 19);
            this.lblDLAppIDValue.TabIndex = 3;
            this.lblDLAppIDValue.Text = "[???]";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPassedTests.Location = new System.Drawing.Point(620, 40);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(95, 19);
            this.lblPassedTests.TabIndex = 2;
            this.lblPassedTests.Text = "Passed Tests:";
            // 
            // lblAppliedForLicense
            // 
            this.lblAppliedForLicense.AutoSize = true;
            this.lblAppliedForLicense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedForLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAppliedForLicense.Location = new System.Drawing.Point(300, 40);
            this.lblAppliedForLicense.Name = "lblAppliedForLicense";
            this.lblAppliedForLicense.Size = new System.Drawing.Size(144, 19);
            this.lblAppliedForLicense.TabIndex = 1;
            this.lblAppliedForLicense.Text = "Applied For License:";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDLAppID.Location = new System.Drawing.Point(20, 40);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(83, 19);
            this.lblDLAppID.TabIndex = 0;
            this.lblDLAppID.Text = "D.L.App ID:";
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.gbDrivingLicenseApplicationInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(950, 110);
            this.gbDrivingLicenseApplicationInfo.ResumeLayout(false);
            this.gbDrivingLicenseApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDrivingLicenseApplicationInfo;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label lblAppliedForLicense;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.Label lblAppliedForLicenseValue;
        private System.Windows.Forms.Label lblPassedTestsValue;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
    }
}
