namespace DVLD.Presentation_Layer
{
    partial class ctrlReleaseLicenseInfo
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
        /// Required method for Designer support – do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbReleaseLicenseInfo = new System.Windows.Forms.GroupBox();

            // ── Left column ──────────────────────────────────────────────
            this.lblDetainIDTitle = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblDetainDateTitle = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblApplicationFeesTitle = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblTotalFeesTitle = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();

            // ── Right column ─────────────────────────────────────────────
            this.lblLicenseIDTitle = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblFineFeesTitle = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();

            this.gbReleaseLicenseInfo.SuspendLayout();
            this.SuspendLayout();

            // ────────────────────────────────────────────────────────────
            // gbReleaseLicenseInfo
            // ────────────────────────────────────────────────────────────
            this.gbReleaseLicenseInfo.Controls.Add(this.lblDetainIDTitle);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblDetainID);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblDetainDateTitle);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblDetainDate);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblApplicationFeesTitle);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblApplicationFees);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblTotalFeesTitle);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblTotalFees);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblLicenseIDTitle);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblLicenseID);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblCreatedByTitle);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblCreatedBy);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblFineFeesTitle);
            this.gbReleaseLicenseInfo.Controls.Add(this.lblFineFees);
            this.gbReleaseLicenseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReleaseLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReleaseLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.gbReleaseLicenseInfo.Location = new System.Drawing.Point(0, 0);
            this.gbReleaseLicenseInfo.Name = "gbReleaseLicenseInfo";
            this.gbReleaseLicenseInfo.Size = new System.Drawing.Size(884, 200);
            this.gbReleaseLicenseInfo.TabIndex = 0;
            this.gbReleaseLicenseInfo.TabStop = false;
            this.gbReleaseLicenseInfo.Text = "Detain Info";

            // ════════════════════════════════
            // LEFT COLUMN   (x-start ≈ 20)
            // ════════════════════════════════

            // Row 1 – Detain ID
            this.lblDetainIDTitle.AutoSize = true;
            this.lblDetainIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblDetainIDTitle.Location = new System.Drawing.Point(20, 35);
            this.lblDetainIDTitle.Name = "lblDetainIDTitle";
            this.lblDetainIDTitle.TabIndex = 0;
            this.lblDetainIDTitle.Text = "Detain ID:";

            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblDetainID.Location = new System.Drawing.Point(160, 35);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.TabIndex = 1;
            this.lblDetainID.Text = "[???]";

            // Row 2 – Detain Date
            this.lblDetainDateTitle.AutoSize = true;
            this.lblDetainDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDateTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblDetainDateTitle.Location = new System.Drawing.Point(20, 75);
            this.lblDetainDateTitle.Name = "lblDetainDateTitle";
            this.lblDetainDateTitle.TabIndex = 2;
            this.lblDetainDateTitle.Text = "Detain Date:";

            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblDetainDate.Location = new System.Drawing.Point(160, 75);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.TabIndex = 3;
            this.lblDetainDate.Text = "[??/??/????]";

            // Row 3 – Application Fees
            this.lblApplicationFeesTitle.AutoSize = true;
            this.lblApplicationFeesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblApplicationFeesTitle.Location = new System.Drawing.Point(20, 115);
            this.lblApplicationFeesTitle.Name = "lblApplicationFeesTitle";
            this.lblApplicationFeesTitle.TabIndex = 4;
            this.lblApplicationFeesTitle.Text = "Application Fees:";

            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblApplicationFees.Location = new System.Drawing.Point(160, 115);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.TabIndex = 5;
            this.lblApplicationFees.Text = "[$$$]";

            // Row 4 – Total Fees
            this.lblTotalFeesTitle.AutoSize = true;
            this.lblTotalFeesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTotalFeesTitle.Location = new System.Drawing.Point(20, 155);
            this.lblTotalFeesTitle.Name = "lblTotalFeesTitle";
            this.lblTotalFeesTitle.TabIndex = 6;
            this.lblTotalFeesTitle.Text = "Total Fees:";

            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTotalFees.Location = new System.Drawing.Point(160, 155);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.TabIndex = 7;
            this.lblTotalFees.Text = "[???]";

            // ════════════════════════════════
            // RIGHT COLUMN  (x-start ≈ 460)
            // ════════════════════════════════

            // Row 1 – License ID
            this.lblLicenseIDTitle.AutoSize = true;
            this.lblLicenseIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseIDTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblLicenseIDTitle.Location = new System.Drawing.Point(460, 35);
            this.lblLicenseIDTitle.Name = "lblLicenseIDTitle";
            this.lblLicenseIDTitle.TabIndex = 8;
            this.lblLicenseIDTitle.Text = "License ID:";

            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblLicenseID.Location = new System.Drawing.Point(600, 35);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.TabIndex = 9;
            this.lblLicenseID.Text = "[???]";

            // Row 2 – Created By
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblCreatedByTitle.Location = new System.Drawing.Point(460, 75);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.TabIndex = 10;
            this.lblCreatedByTitle.Text = "Created By:";

            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblCreatedBy.Location = new System.Drawing.Point(600, 75);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.TabIndex = 11;
            this.lblCreatedBy.Text = "[???]";

            // Row 3 – Fine Fees (read-only label)
            this.lblFineFeesTitle.AutoSize = true;
            this.lblFineFeesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFeesTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblFineFeesTitle.Location = new System.Drawing.Point(460, 115);
            this.lblFineFeesTitle.Name = "lblFineFeesTitle";
            this.lblFineFeesTitle.TabIndex = 12;
            this.lblFineFeesTitle.Text = "Fine Fees:";

            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblFineFees.Location = new System.Drawing.Point(600, 115);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.TabIndex = 13;
            this.lblFineFees.Text = "[$$$]";

            // ────────────────────────────────────────────────────────────
            // ctrlReleaseLicenseInfo  (the UserControl itself)
            // ────────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbReleaseLicenseInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlReleaseLicenseInfo";
            this.Size = new System.Drawing.Size(884, 200);

            this.gbReleaseLicenseInfo.ResumeLayout(false);
            this.gbReleaseLicenseInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbReleaseLicenseInfo;

        // Left column
        private System.Windows.Forms.Label lblDetainIDTitle;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblDetainDateTitle;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblApplicationFeesTitle;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblTotalFeesTitle;
        private System.Windows.Forms.Label lblTotalFees;

        // Right column
        private System.Windows.Forms.Label lblLicenseIDTitle;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblFineFeesTitle;
        private System.Windows.Forms.Label lblFineFees;
    }
}
