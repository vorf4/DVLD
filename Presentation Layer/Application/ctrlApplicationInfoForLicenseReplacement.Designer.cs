namespace DVLD.Presentation_Layer
{
    partial class ctrlApplicationInfoForLicenseReplacement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();

            // Left side titles & values
            this.lblReplacementApplicationIDTitle = new System.Windows.Forms.Label();
            this.lblReplacementApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationDateTitle = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationFeesTitle = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();

            // Right side titles & values
            this.lblReplacedLicenseIDTitle = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.lblOldLicenseIDTitle = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();

            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();

            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.lblReplacementApplicationIDTitle);
            this.gbApplicationInfo.Controls.Add(this.lblReplacementApplicationID);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationDateTitle);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationFeesTitle);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.gbApplicationInfo.Controls.Add(this.lblReplacedLicenseIDTitle);
            this.gbApplicationInfo.Controls.Add(this.lblReplacedLicenseID);
            this.gbApplicationInfo.Controls.Add(this.lblOldLicenseIDTitle);
            this.gbApplicationInfo.Controls.Add(this.lblOldLicenseID);
            this.gbApplicationInfo.Controls.Add(this.lblCreatedByTitle);
            this.gbApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.gbApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApplicationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gbApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(850, 150);
            this.gbApplicationInfo.TabIndex = 0;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Application Info for License Replacement";

            // 
            // LEFT SIDE - TITLES & VALUES
            // 

            // 1. L.R.Application ID
            this.lblReplacementApplicationIDTitle.AutoSize = true;
            this.lblReplacementApplicationIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacementApplicationIDTitle.Location = new System.Drawing.Point(20, 35);
            this.lblReplacementApplicationIDTitle.Name = "lblReplacementApplicationIDTitle";
            this.lblReplacementApplicationIDTitle.Size = new System.Drawing.Size(135, 17);
            this.lblReplacementApplicationIDTitle.TabIndex = 0;
            this.lblReplacementApplicationIDTitle.Text = "L.R.Application ID:";

            this.lblReplacementApplicationID.AutoSize = true;
            this.lblReplacementApplicationID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacementApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblReplacementApplicationID.Location = new System.Drawing.Point(175, 35);
            this.lblReplacementApplicationID.Name = "lblReplacementApplicationID";
            this.lblReplacementApplicationID.Size = new System.Drawing.Size(38, 17);
            this.lblReplacementApplicationID.TabIndex = 1;
            this.lblReplacementApplicationID.Text = "[???]";

            // 2. Application Date
            this.lblApplicationDateTitle.AutoSize = true;
            this.lblApplicationDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateTitle.Location = new System.Drawing.Point(20, 70);
            this.lblApplicationDateTitle.Name = "lblApplicationDateTitle";
            this.lblApplicationDateTitle.Size = new System.Drawing.Size(115, 17);
            this.lblApplicationDateTitle.TabIndex = 2;
            this.lblApplicationDateTitle.Text = "Application Date:";

            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblApplicationDate.Location = new System.Drawing.Point(175, 70);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(36, 17);
            this.lblApplicationDate.TabIndex = 3;
            this.lblApplicationDate.Text = "[???]";

            // 3. Application Fees
            this.lblApplicationFeesTitle.AutoSize = true;
            this.lblApplicationFeesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesTitle.Location = new System.Drawing.Point(20, 105);
            this.lblApplicationFeesTitle.Name = "lblApplicationFeesTitle";
            this.lblApplicationFeesTitle.Size = new System.Drawing.Size(115, 17);
            this.lblApplicationFeesTitle.TabIndex = 4;
            this.lblApplicationFeesTitle.Text = "Application Fees:";

            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblApplicationFees.Location = new System.Drawing.Point(175, 105);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(36, 17);
            this.lblApplicationFees.TabIndex = 5;
            this.lblApplicationFees.Text = "[???]";

            // 
            // RIGHT SIDE - TITLES & VALUES
            // 

            // 1. Replaced License ID
            this.lblReplacedLicenseIDTitle.AutoSize = true;
            this.lblReplacedLicenseIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseIDTitle.Location = new System.Drawing.Point(450, 35);
            this.lblReplacedLicenseIDTitle.Name = "lblReplacedLicenseIDTitle";
            this.lblReplacedLicenseIDTitle.Size = new System.Drawing.Size(135, 17);
            this.lblReplacedLicenseIDTitle.TabIndex = 6;
            this.lblReplacedLicenseIDTitle.Text = "Replaced License ID:";

            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(615, 35);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(38, 17);
            this.lblReplacedLicenseID.TabIndex = 7;
            this.lblReplacedLicenseID.Text = "[???]";

            // 2. Old License ID
            this.lblOldLicenseIDTitle.AutoSize = true;
            this.lblOldLicenseIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIDTitle.Location = new System.Drawing.Point(450, 70);
            this.lblOldLicenseIDTitle.Name = "lblOldLicenseIDTitle";
            this.lblOldLicenseIDTitle.Size = new System.Drawing.Size(100, 17);
            this.lblOldLicenseIDTitle.TabIndex = 8;
            this.lblOldLicenseIDTitle.Text = "Old License ID:";

            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblOldLicenseID.Location = new System.Drawing.Point(615, 70);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(36, 17);
            this.lblOldLicenseID.TabIndex = 9;
            this.lblOldLicenseID.Text = "[???]";

            // 3. Created By
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByTitle.Location = new System.Drawing.Point(450, 105);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(78, 17);
            this.lblCreatedByTitle.TabIndex = 10;
            this.lblCreatedByTitle.Text = "Created By:";

            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(615, 105);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(36, 17);
            this.lblCreatedBy.TabIndex = 11;
            this.lblCreatedBy.Text = "[???]";

            // 
            // ctrlApplicationInfoForLicenseReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbApplicationInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlApplicationInfoForLicenseReplacement";
            this.Size = new System.Drawing.Size(850, 150);
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbApplicationInfo;

        private System.Windows.Forms.Label lblReplacementApplicationIDTitle;
        private System.Windows.Forms.Label lblReplacementApplicationID;
        private System.Windows.Forms.Label lblApplicationDateTitle;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationFeesTitle;
        private System.Windows.Forms.Label lblApplicationFees;

        private System.Windows.Forms.Label lblReplacedLicenseIDTitle;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label lblOldLicenseIDTitle;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.Label lblCreatedBy;
    }
}
