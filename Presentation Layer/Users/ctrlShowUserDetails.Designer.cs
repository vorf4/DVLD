using PresentationLayer;
using Business_Layer;

namespace PresentationLayer
{
    partial class ctrlShowUserDetails
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

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbPersonInformation = new System.Windows.Forms.GroupBox();
            this.ctrlShowDetails1 = new PresentationLayer.ctrlShowDetails(clsPerson.Find(1)); // Example PersonID
            this.gbLoginInformation = new System.Windows.Forms.GroupBox();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblUserNameTitle = new System.Windows.Forms.Label();
            this.lblUserNameValue = new System.Windows.Forms.Label();
            this.lblIsActiveTitle = new System.Windows.Forms.Label();
            this.lblIsActiveValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbPersonInformation.SuspendLayout();
            this.gbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPersonInformation
            // 
            this.gbPersonInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPersonInformation.BackColor = System.Drawing.Color.White;
            this.gbPersonInformation.Controls.Add(this.ctrlShowDetails1);
            this.gbPersonInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbPersonInformation.Location = new System.Drawing.Point(15, 85);
            this.gbPersonInformation.Name = "gbPersonInformation";
            this.gbPersonInformation.Padding = new System.Windows.Forms.Padding(10);
            this.gbPersonInformation.Size = new System.Drawing.Size(820, 320);
            this.gbPersonInformation.TabIndex = 1;
            this.gbPersonInformation.TabStop = false;
            this.gbPersonInformation.Text = "Person Information";
            // 
            // ctrlShowDetails1
            // 
            this.ctrlShowDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlShowDetails1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlShowDetails1.Location = new System.Drawing.Point(10, 32);
            this.ctrlShowDetails1.Name = "ctrlShowDetails1";
            this.ctrlShowDetails1.Size = new System.Drawing.Size(800, 278);
            this.ctrlShowDetails1.TabIndex = 0;
            // 
            // gbLoginInformation
            // 
            this.gbLoginInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLoginInformation.BackColor = System.Drawing.Color.White;
            this.gbLoginInformation.Controls.Add(this.lblUserIDTitle);
            this.gbLoginInformation.Controls.Add(this.lblUserIDValue);
            this.gbLoginInformation.Controls.Add(this.lblUserNameTitle);
            this.gbLoginInformation.Controls.Add(this.lblUserNameValue);
            this.gbLoginInformation.Controls.Add(this.lblIsActiveTitle);
            this.gbLoginInformation.Controls.Add(this.lblIsActiveValue);
            this.gbLoginInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbLoginInformation.Location = new System.Drawing.Point(15, 420);
            this.gbLoginInformation.Name = "gbLoginInformation";
            this.gbLoginInformation.Size = new System.Drawing.Size(820, 100);
            this.gbLoginInformation.TabIndex = 2;
            this.gbLoginInformation.TabStop = false;
            this.gbLoginInformation.Text = "Login Information";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Location = new System.Drawing.Point(30, 45);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(69, 21);
            this.lblUserIDTitle.TabIndex = 0;
            this.lblUserIDTitle.Text = "User ID:";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUserIDValue.Location = new System.Drawing.Point(105, 45);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(34, 21);
            this.lblUserIDValue.TabIndex = 1;
            this.lblUserIDValue.Text = "???";
            // 
            // lblUserNameTitle
            // 
            this.lblUserNameTitle.AutoSize = true;
            this.lblUserNameTitle.Location = new System.Drawing.Point(250, 45);
            this.lblUserNameTitle.Name = "lblUserNameTitle";
            this.lblUserNameTitle.Size = new System.Drawing.Size(91, 21);
            this.lblUserNameTitle.TabIndex = 2;
            this.lblUserNameTitle.Text = "Username:";
            // 
            // lblUserNameValue
            // 
            this.lblUserNameValue.AutoSize = true;
            this.lblUserNameValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUserNameValue.Location = new System.Drawing.Point(347, 45);
            this.lblUserNameValue.Name = "lblUserNameValue";
            this.lblUserNameValue.Size = new System.Drawing.Size(34, 21);
            this.lblUserNameValue.TabIndex = 3;
            this.lblUserNameValue.Text = "???";
            // 
            // lblIsActiveTitle
            // 
            this.lblIsActiveTitle.AutoSize = true;
            this.lblIsActiveTitle.Location = new System.Drawing.Point(520, 45);
            this.lblIsActiveTitle.Name = "lblIsActiveTitle";
            this.lblIsActiveTitle.Size = new System.Drawing.Size(78, 21);
            this.lblIsActiveTitle.TabIndex = 4;
            this.lblIsActiveTitle.Text = "Is Active:";
            // 
            // lblIsActiveValue
            // 
            this.lblIsActiveValue.AutoSize = true;
            this.lblIsActiveValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIsActiveValue.Location = new System.Drawing.Point(604, 45);
            this.lblIsActiveValue.Name = "lblIsActiveValue";
            this.lblIsActiveValue.Size = new System.Drawing.Size(34, 21);
            this.lblIsActiveValue.TabIndex = 5;
            this.lblIsActiveValue.Text = "???";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClose.Location = new System.Drawing.Point(715, 540);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbLoginInformation);
            this.Controls.Add(this.gbPersonInformation);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ctrlShowUserDetails";
            this.Size = new System.Drawing.Size(850, 600);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbPersonInformation.ResumeLayout(false);
            this.gbLoginInformation.ResumeLayout(false);
            this.gbLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbPersonInformation;
        private PresentationLayer.ctrlShowDetails ctrlShowDetails1;
        private System.Windows.Forms.GroupBox gbLoginInformation;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblUserNameTitle;
        private System.Windows.Forms.Label lblUserNameValue;
        private System.Windows.Forms.Label lblIsActiveTitle;
        private System.Windows.Forms.Label lblIsActiveValue;
        private System.Windows.Forms.Button btnClose;
    }
}
