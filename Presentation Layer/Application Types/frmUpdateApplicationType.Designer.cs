namespace DVLD.Presentation_Layer
{
    partial class frmUpdateApplicationType
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
            this.gbApplicationType = new System.Windows.Forms.GroupBox();
            this.lblIDTitle = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.txtApplicationTitle = new System.Windows.Forms.TextBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.txtApplicationFees = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbApplicationType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(550, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Application Type";
            // 
            // gbApplicationType
            // 
            this.gbApplicationType.BackColor = System.Drawing.Color.White;
            this.gbApplicationType.Controls.Add(this.txtApplicationFees);
            this.gbApplicationType.Controls.Add(this.lblApplicationFees);
            this.gbApplicationType.Controls.Add(this.txtApplicationTitle);
            this.gbApplicationType.Controls.Add(this.lblApplicationTitle);
            this.gbApplicationType.Controls.Add(this.lblIDValue);
            this.gbApplicationType.Controls.Add(this.lblIDTitle);
            this.gbApplicationType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApplicationType.Location = new System.Drawing.Point(30, 100);
            this.gbApplicationType.Name = "gbApplicationType";
            this.gbApplicationType.Size = new System.Drawing.Size(480, 250);
            this.gbApplicationType.TabIndex = 1;
            this.gbApplicationType.TabStop = false;
            // 
            // lblIDTitle
            // 
            this.lblIDTitle.AutoSize = true;
            this.lblIDTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblIDTitle.Location = new System.Drawing.Point(30, 50);
            this.lblIDTitle.Name = "lblIDTitle";
            this.lblIDTitle.Size = new System.Drawing.Size(31, 21);
            this.lblIDTitle.TabIndex = 0;
            this.lblIDTitle.Text = "ID:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblIDValue.Location = new System.Drawing.Point(120, 50);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(42, 21);
            this.lblIDValue.TabIndex = 1;
            this.lblIDValue.Text = "[???]";
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.AutoSize = true;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblApplicationTitle.Location = new System.Drawing.Point(30, 100);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(48, 21);
            this.lblApplicationTitle.TabIndex = 2;
            this.lblApplicationTitle.Text = "Title:";
            // 
            // txtApplicationTitle
            // 
            this.txtApplicationTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApplicationTitle.Location = new System.Drawing.Point(120, 98);
            this.txtApplicationTitle.Name = "txtApplicationTitle";
            this.txtApplicationTitle.Size = new System.Drawing.Size(300, 29);
            this.txtApplicationTitle.TabIndex = 3;
            this.txtApplicationTitle.TextChanged += new System.EventHandler(this.txtApplicationTitle_TextChanged);
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblApplicationFees.Location = new System.Drawing.Point(30, 150);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(47, 21);
            this.lblApplicationFees.TabIndex = 4;
            this.lblApplicationFees.Text = "Fees:";
            // 
            // txtApplicationFees
            // 
            this.txtApplicationFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApplicationFees.Location = new System.Drawing.Point(120, 148);
            this.txtApplicationFees.Name = "txtApplicationFees";
            this.txtApplicationFees.Size = new System.Drawing.Size(300, 29);
            this.txtApplicationFees.TabIndex = 5;
            this.txtApplicationFees.TextChanged += new System.EventHandler(this.txtApplicationFees_TextChanged);
            this.txtApplicationFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApplicationFees_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(390, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(260, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(550, 440);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbApplicationType);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Application Type";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbApplicationType.ResumeLayout(false);
            this.gbApplicationType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbApplicationType;
        private System.Windows.Forms.Label lblIDTitle;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.TextBox txtApplicationTitle;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.TextBox txtApplicationFees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
