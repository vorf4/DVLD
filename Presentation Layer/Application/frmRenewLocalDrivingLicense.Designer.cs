namespace DVLD.Presentation_Layer
{
    partial class frmRenewLocalDrivingLicense
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
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewLicense = new System.Windows.Forms.Button();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.ctrlDriverLocalLicenseInfo1 = new DVLD.Presentation_Layer.ctrlDriverLicenseInfo();
            this.ctrlApplicationNewLicenseInfo1 = new DVLD.Presentation_Layer.ctrlApplicationNewLicenseInfo();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(884, 70);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Renew Local Driving License";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddNewLicense);
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Controls.Add(this.lblLicenseID);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gbFilter.Location = new System.Drawing.Point(15, 80);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(854, 65);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAddNewLicense
            // 
            this.btnAddNewLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddNewLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewLicense.FlatAppearance.BorderSize = 0;
            this.btnAddNewLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLicense.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLicense.ForeColor = System.Drawing.Color.White;
            this.btnAddNewLicense.Location = new System.Drawing.Point(426, 27);
            this.btnAddNewLicense.Name = "btnAddNewLicense";
            this.btnAddNewLicense.Size = new System.Drawing.Size(160, 32);
            this.btnAddNewLicense.TabIndex = 2;
            this.btnAddNewLicense.Text = "Find";
            this.btnAddNewLicense.UseVisualStyleBackColor = false;
            this.btnAddNewLicense.Click += new System.EventHandler(this.btnAddNewLicense_Click);
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseID.Location = new System.Drawing.Point(180, 25);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(220, 25);
            this.txtLicenseID.TabIndex = 1;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(20, 27);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(75, 17);
            this.lblLicenseID.TabIndex = 0;
            this.lblLicenseID.Text = "License ID:";
            // 
            // ctrlDriverLocalLicenseInfo1
            // 
            this.ctrlDriverLocalLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLocalLicenseInfo1.ClassValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.DateOfBirthValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.DriverIDValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.DriverNameValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.ExpirationDateValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLocalLicenseInfo1.GenderValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.IsActiveValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.IsDetainedValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.IssueDateValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.IssueReasonValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.LicenseIDValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.Location = new System.Drawing.Point(15, 155);
            this.ctrlDriverLocalLicenseInfo1.Name = "ctrlDriverLocalLicenseInfo1";
            this.ctrlDriverLocalLicenseInfo1.NationalNoValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.NotesValue = "[???]";
            this.ctrlDriverLocalLicenseInfo1.Size = new System.Drawing.Size(854, 330);
            this.ctrlDriverLocalLicenseInfo1.TabIndex = 2;
            // 
            // ctrlApplicationNewLicenseInfo1
            // 
            this.ctrlApplicationNewLicenseInfo1.ApplicationDate = "[???]";
            this.ctrlApplicationNewLicenseInfo1.ApplicationFees = "[???]";
            this.ctrlApplicationNewLicenseInfo1.CreatedBy = "[???]";
            this.ctrlApplicationNewLicenseInfo1.ExpirationDate = "[???]";
            this.ctrlApplicationNewLicenseInfo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlApplicationNewLicenseInfo1.IssueDate = "[???]";
            this.ctrlApplicationNewLicenseInfo1.LicenseFees = "[???]";
            this.ctrlApplicationNewLicenseInfo1.Location = new System.Drawing.Point(15, 495);
            this.ctrlApplicationNewLicenseInfo1.Name = "ctrlApplicationNewLicenseInfo1";
            this.ctrlApplicationNewLicenseInfo1.Notes = "";
            this.ctrlApplicationNewLicenseInfo1.OldLicenseID = "[???]";
            this.ctrlApplicationNewLicenseInfo1.RenewedLicenseID = "[???]";
            this.ctrlApplicationNewLicenseInfo1.RenewLocalApplicationID = "[???]";
            this.ctrlApplicationNewLicenseInfo1.Size = new System.Drawing.Size(854, 280);
            this.ctrlApplicationNewLicenseInfo1.TabIndex = 3;
            this.ctrlApplicationNewLicenseInfo1.TotalFees = "[???]";
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenew.FlatAppearance.BorderSize = 0;
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(634, 788);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(110, 35);
            this.btnRenew.TabIndex = 6;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(759, 788);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 835);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.ctrlApplicationNewLicenseInfo1);
            this.Controls.Add(this.ctrlDriverLocalLicenseInfo1);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Local Driving License";
            this.Load += new System.EventHandler(this.frmRenewLocalDrivingLicense_Load);
            this.pnlHeader.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Button btnAddNewLicense;
        private DVLD.Presentation_Layer.ctrlDriverLicenseInfo ctrlDriverLocalLicenseInfo1;
        private DVLD.Presentation_Layer.ctrlApplicationNewLicenseInfo ctrlApplicationNewLicenseInfo1;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
    }
}
