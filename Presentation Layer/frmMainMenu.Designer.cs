namespace Presentation_Layer
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.plUserChange = new System.Windows.Forms.Panel();
            this.plUserDetails = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDrivingLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miReplacementForLostOrDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.miLocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.miInternationalLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.miManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.miManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.miSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopNav.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.cmsAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlTopNav.Controls.Add(this.btnAccountSettings);
            this.pnlTopNav.Controls.Add(this.btnUsers);
            this.pnlTopNav.Controls.Add(this.btnDrivers);
            this.pnlTopNav.Controls.Add(this.btnPeople);
            this.pnlTopNav.Controls.Add(this.btnApplications);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1904, 68);
            this.pnlTopNav.TabIndex = 0;
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccountSettings.FlatAppearance.BorderSize = 0;
            this.btnAccountSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.btnAccountSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSettings.ForeColor = System.Drawing.Color.White;
            this.btnAccountSettings.Location = new System.Drawing.Point(600, 0);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(150, 68);
            this.btnAccountSettings.TabIndex = 4;
            this.btnAccountSettings.Text = "Account Settings";
            this.btnAccountSettings.UseVisualStyleBackColor = false;
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(450, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(150, 68);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.Transparent;
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.btnDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Location = new System.Drawing.Point(300, 0);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(150, 68);
            this.btnDrivers.TabIndex = 2;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.btnPeople.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.White;
            this.btnPeople.Location = new System.Drawing.Point(150, 0);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(150, 68);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnApplications.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.btnApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.Location = new System.Drawing.Point(0, 0);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(150, 68);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.Text = "Applications";
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlDashboard.Controls.Add(this.plUserChange);
            this.pnlDashboard.Controls.Add(this.plUserDetails);
            this.pnlDashboard.Controls.Add(this.pbLogo);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 68);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1904, 973);
            this.pnlDashboard.TabIndex = 1;
            // 
            // plUserChange
            // 
            this.plUserChange.Location = new System.Drawing.Point(300, 0);
            this.plUserChange.Name = "plUserChange";
            this.plUserChange.Size = new System.Drawing.Size(891, 813);
            this.plUserChange.TabIndex = 6;
            this.plUserChange.Visible = false;
            // 
            // plUserDetails
            // 
            this.plUserDetails.Location = new System.Drawing.Point(300, 43);
            this.plUserDetails.Name = "plUserDetails";
            this.plUserDetails.Size = new System.Drawing.Size(844, 600);
            this.plUserDetails.TabIndex = 6;
            this.plUserDetails.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Image = global::Presentation_Layer.Properties.Resources.cb769a8dc2abddb43fa73dc746c71cbd;
            this.pbLogo.Location = new System.Drawing.Point(-10, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1922, 957);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDrivingLicenseServices,
            this.miManageApplications,
            this.miDetainLicenses,
            this.miManageApplicationTypes,
            this.miManageTestTypes});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(255, 146);
            // 
            // miDrivingLicenseServices
            // 
            this.miDrivingLicenseServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewDrivingLicense,
            this.miRenewDrivingLicense,
            this.miReplacementForLostOrDamagedLicense,
            this.miReleaseDetainedDrivingLicense,
            this.miRetakeTest});
            this.miDrivingLicenseServices.Name = "miDrivingLicenseServices";
            this.miDrivingLicenseServices.Size = new System.Drawing.Size(254, 24);
            this.miDrivingLicenseServices.Text = "Driving Licenses Services";
            // 
            // miNewDrivingLicense
            // 
            this.miNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLocalLicense,
            this.miInternationalLicense});
            this.miNewDrivingLicense.Name = "miNewDrivingLicense";
            this.miNewDrivingLicense.Size = new System.Drawing.Size(359, 24);
            this.miNewDrivingLicense.Text = "New Driving License";
            this.miNewDrivingLicense.Click += new System.EventHandler(this.miNewDrivingLicense_Click);
            // 
            // miLocalLicense
            // 
            this.miLocalLicense.Name = "miLocalLicense";
            this.miLocalLicense.Size = new System.Drawing.Size(214, 24);
            this.miLocalLicense.Text = "Local License";
            this.miLocalLicense.Click += new System.EventHandler(this.miLocalLicense_Click);
            // 
            // miInternationalLicense
            // 
            this.miInternationalLicense.Name = "miInternationalLicense";
            this.miInternationalLicense.Size = new System.Drawing.Size(214, 24);
            this.miInternationalLicense.Text = "International License";
            this.miInternationalLicense.Click += new System.EventHandler(this.miInternationalLicense_Click);
            // 
            // miRenewDrivingLicense
            // 
            this.miRenewDrivingLicense.Name = "miRenewDrivingLicense";
            this.miRenewDrivingLicense.Size = new System.Drawing.Size(359, 24);
            this.miRenewDrivingLicense.Text = "Renew Driving License";
            this.miRenewDrivingLicense.Click += new System.EventHandler(this.miRenewDrivingLicense_Click);
            // 
            // miReplacementForLostOrDamagedLicense
            // 
            this.miReplacementForLostOrDamagedLicense.Name = "miReplacementForLostOrDamagedLicense";
            this.miReplacementForLostOrDamagedLicense.Size = new System.Drawing.Size(359, 24);
            this.miReplacementForLostOrDamagedLicense.Text = "Replacement for Lost or Damaged License";
            this.miReplacementForLostOrDamagedLicense.Click += new System.EventHandler(this.miReplacementForLostOrDamagedLicense_Click);
            // 
            // miReleaseDetainedDrivingLicense
            // 
            this.miReleaseDetainedDrivingLicense.Name = "miReleaseDetainedDrivingLicense";
            this.miReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(359, 24);
            this.miReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            this.miReleaseDetainedDrivingLicense.Click += new System.EventHandler(this.miReleaseDetainedDrivingLicense_Click);
            // 
            // miRetakeTest
            // 
            this.miRetakeTest.Name = "miRetakeTest";
            this.miRetakeTest.Size = new System.Drawing.Size(359, 24);
            this.miRetakeTest.Text = "Retake Test";
            this.miRetakeTest.Click += new System.EventHandler(this.miRetakeTest_Click);
            // 
            // miManageApplications
            // 
            this.miManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLocalDrivingLicenseApplications,
            this.miInternationalLicenseApplications});
            this.miManageApplications.Name = "miManageApplications";
            this.miManageApplications.Size = new System.Drawing.Size(254, 24);
            this.miManageApplications.Text = "Manage Applications";
            // 
            // miLocalDrivingLicenseApplications
            // 
            this.miLocalDrivingLicenseApplications.Name = "miLocalDrivingLicenseApplications";
            this.miLocalDrivingLicenseApplications.Size = new System.Drawing.Size(304, 24);
            this.miLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.miLocalDrivingLicenseApplications.Click += new System.EventHandler(this.miLocalDrivingLicenseApplications_Click);
            // 
            // miInternationalLicenseApplications
            // 
            this.miInternationalLicenseApplications.Name = "miInternationalLicenseApplications";
            this.miInternationalLicenseApplications.Size = new System.Drawing.Size(304, 24);
            this.miInternationalLicenseApplications.Text = "International License Applications";
            this.miInternationalLicenseApplications.Click += new System.EventHandler(this.miInternationalLicenseApplications_Click);
            // 
            // miDetainLicenses
            // 
            this.miDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miManageDetainedLicenses,
            this.miDetainLicense,
            this.miReleaseDetainedLicense});
            this.miDetainLicenses.Name = "miDetainLicenses";
            this.miDetainLicenses.Size = new System.Drawing.Size(254, 24);
            this.miDetainLicenses.Text = "Detain Licenses";
            // 
            // miManageDetainedLicenses
            // 
            this.miManageDetainedLicenses.Name = "miManageDetainedLicenses";
            this.miManageDetainedLicenses.Size = new System.Drawing.Size(255, 24);
            this.miManageDetainedLicenses.Text = "Manage Detained Licenses";
            this.miManageDetainedLicenses.Click += new System.EventHandler(this.miManageDetainedLicenses_Click);
            // 
            // miDetainLicense
            // 
            this.miDetainLicense.Name = "miDetainLicense";
            this.miDetainLicense.Size = new System.Drawing.Size(255, 24);
            this.miDetainLicense.Text = "Detain License";
            this.miDetainLicense.Click += new System.EventHandler(this.miDetainLicense_Click);
            // 
            // miReleaseDetainedLicense
            // 
            this.miReleaseDetainedLicense.Name = "miReleaseDetainedLicense";
            this.miReleaseDetainedLicense.Size = new System.Drawing.Size(255, 24);
            this.miReleaseDetainedLicense.Text = "Release Detained License";
            this.miReleaseDetainedLicense.Click += new System.EventHandler(this.miReleaseDetainedLicense_Click);
            // 
            // miManageApplicationTypes
            // 
            this.miManageApplicationTypes.Name = "miManageApplicationTypes";
            this.miManageApplicationTypes.Size = new System.Drawing.Size(254, 24);
            this.miManageApplicationTypes.Text = "Manage Application Types";
            this.miManageApplicationTypes.Click += new System.EventHandler(this.miManageApplicationTypes_Click);
            // 
            // miManageTestTypes
            // 
            this.miManageTestTypes.Name = "miManageTestTypes";
            this.miManageTestTypes.Size = new System.Drawing.Size(254, 24);
            this.miManageTestTypes.Text = "Manage Test Types";
            this.miManageTestTypes.Click += new System.EventHandler(this.miManageTestTypes_Click);
            // 
            // cmsAccountSettings
            // 
            this.cmsAccountSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAccountSettings.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCurrentUserInfo,
            this.miChangePassword,
            this.miSignOut});
            this.cmsAccountSettings.Name = "cmsAccountSettings";
            this.cmsAccountSettings.Size = new System.Drawing.Size(194, 76);
            // 
            // miCurrentUserInfo
            // 
            this.miCurrentUserInfo.Name = "miCurrentUserInfo";
            this.miCurrentUserInfo.Size = new System.Drawing.Size(193, 24);
            this.miCurrentUserInfo.Text = "Current User Info";
            this.miCurrentUserInfo.Click += new System.EventHandler(this.miCurrentUserInfo_Click);
            // 
            // miChangePassword
            // 
            this.miChangePassword.Name = "miChangePassword";
            this.miChangePassword.Size = new System.Drawing.Size(193, 24);
            this.miChangePassword.Text = "Change Password";
            this.miChangePassword.Click += new System.EventHandler(this.miChangePassword_Click);
            // 
            // miSignOut
            // 
            this.miSignOut.Name = "miSignOut";
            this.miSignOut.Size = new System.Drawing.Size(193, 24);
            this.miSignOut.Text = "Sign Out";
            this.miSignOut.Click += new System.EventHandler(this.miSignOut_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlTopNav);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - DVLD System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.cmsAccountSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem miDrivingLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem miManageApplications;
        private System.Windows.Forms.ToolStripMenuItem miDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem miManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem miManageTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem miCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem miChangePassword;
        private System.Windows.Forms.ToolStripMenuItem miSignOut;
        private System.Windows.Forms.ToolStripMenuItem miNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem miRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem miReplacementForLostOrDamagedLicense;
        private System.Windows.Forms.ToolStripMenuItem miReleaseDetainedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem miRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem miLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem miInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem miLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem miInternationalLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem miManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem miDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem miReleaseDetainedLicense;
        private System.Windows.Forms.Panel plUserDetails;
        private System.Windows.Forms.Panel plUserChange;
    }
}
