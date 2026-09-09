namespace DVLD.Presentation_Layer
{
    partial class ctrlDetainInfo
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
            this.components = new System.ComponentModel.Container();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();

            // Left Column Title & Value Controls
            this.lblDetainIDTitle = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblDetainDateTitle = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblFineFeesTitle = new System.Windows.Forms.Label();
            this.txtFineFees = new System.Windows.Forms.TextBox();

            // Right Column Title & Value Controls
            this.lblLicenseIDTitle = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.lblDetainIDTitle);
            this.gbDetainInfo.Controls.Add(this.lblDetainID);
            this.gbDetainInfo.Controls.Add(this.lblDetainDateTitle);
            this.gbDetainInfo.Controls.Add(this.lblDetainDate);
            this.gbDetainInfo.Controls.Add(this.lblFineFeesTitle);
            this.gbDetainInfo.Controls.Add(this.txtFineFees);
            this.gbDetainInfo.Controls.Add(this.lblLicenseIDTitle);
            this.gbDetainInfo.Controls.Add(this.lblLicenseID);
            this.gbDetainInfo.Controls.Add(this.lblCreatedByTitle);
            this.gbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.gbDetainInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetainInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetainInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gbDetainInfo.Location = new System.Drawing.Point(0, 0);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(854, 180);
            this.gbDetainInfo.TabIndex = 0;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info";

            // 
            // LEFT COLUMN
            // 

            // 1. Detain ID Title
            this.lblDetainIDTitle.AutoSize = true;
            this.lblDetainIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDTitle.Location = new System.Drawing.Point(20, 35);
            this.lblDetainIDTitle.Name = "lblDetainIDTitle";
            this.lblDetainIDTitle.Size = new System.Drawing.Size(71, 17);
            this.lblDetainIDTitle.TabIndex = 0;
            this.lblDetainIDTitle.Text = "Detain ID:";

            // 1. Detain ID Value
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(140, 35);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(38, 17);
            this.lblDetainID.TabIndex = 1;
            this.lblDetainID.Text = "[???]";

            // 2. Detain Date Title
            this.lblDetainDateTitle.AutoSize = true;
            this.lblDetainDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDateTitle.Location = new System.Drawing.Point(20, 75);
            this.lblDetainDateTitle.Name = "lblDetainDateTitle";
            this.lblDetainDateTitle.Size = new System.Drawing.Size(86, 17);
            this.lblDetainDateTitle.TabIndex = 2;
            this.lblDetainDateTitle.Text = "Detain Date:";

            // 2. Detain Date Value
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(140, 75);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(38, 17);
            this.lblDetainDate.TabIndex = 3;
            this.lblDetainDate.Text = "[???]";

            // 3. Fine Fees Title
            this.lblFineFeesTitle.AutoSize = true;
            this.lblFineFeesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFeesTitle.Location = new System.Drawing.Point(20, 115);
            this.lblFineFeesTitle.Name = "lblFineFeesTitle";
            this.lblFineFeesTitle.Size = new System.Drawing.Size(70, 17);
            this.lblFineFeesTitle.TabIndex = 4;
            this.lblFineFeesTitle.Text = "Fine Fees:";

            // 3. Fine Fees TextBox
            this.txtFineFees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFineFees.Location = new System.Drawing.Point(140, 111);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(180, 25);
            this.txtFineFees.TabIndex = 5;
            this.txtFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineFees_KeyPress);
            this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);

            // 
            // RIGHT COLUMN
            // 

            // 1. License ID Title
            this.lblLicenseIDTitle.AutoSize = true;
            this.lblLicenseIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseIDTitle.Location = new System.Drawing.Point(440, 35);
            this.lblLicenseIDTitle.Name = "lblLicenseIDTitle";
            this.lblLicenseIDTitle.Size = new System.Drawing.Size(75, 17);
            this.lblLicenseIDTitle.TabIndex = 6;
            this.lblLicenseIDTitle.Text = "License ID:";

            // 1. License ID Value
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(580, 35);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(38, 17);
            this.lblLicenseID.TabIndex = 7;
            this.lblLicenseID.Text = "[???]";

            // 2. Created By Title
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByTitle.Location = new System.Drawing.Point(440, 75);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(80, 17);
            this.lblCreatedByTitle.TabIndex = 8;
            this.lblCreatedByTitle.Text = "Created By:";

            // 2. Created By Value
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(580, 75);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(38, 17);
            this.lblCreatedBy.TabIndex = 9;
            this.lblCreatedBy.Text = "[???]";

            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;

            // 
            // ctrlDetainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDetainInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlDetainInfo";
            this.Size = new System.Drawing.Size(854, 180);
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetainInfo;

        // Left Side
        private System.Windows.Forms.Label lblDetainIDTitle;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblDetainDateTitle;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblFineFeesTitle;
        private System.Windows.Forms.TextBox txtFineFees;

        // Right Side
        private System.Windows.Forms.Label lblLicenseIDTitle;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.Label lblCreatedBy;

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
