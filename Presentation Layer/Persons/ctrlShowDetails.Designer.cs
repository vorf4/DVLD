namespace PresentationLayer
{
    partial class ctrlShowDetails
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
            this.gbPersonInformation = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lblCountryValue = new System.Windows.Forms.Label();
            this.lblCountryTitle = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblDateOfBirthValue = new System.Windows.Forms.Label();
            this.lblDateOfBirthTitle = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblGenderTitle = new System.Windows.Forms.Label();
            this.lblNationalNoValue = new System.Windows.Forms.Label();
            this.lblNationalNoTitle = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblFullNameTitle = new System.Windows.Forms.Label();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.lblPersonIDTitle = new System.Windows.Forms.Label();
            this.llEditPerson = new System.Windows.Forms.LinkLabel();
            this.gbPersonInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonInformation
            // 
            this.gbPersonInformation.Controls.Add(this.llEditPerson);
            this.gbPersonInformation.Controls.Add(this.btClose);
            this.gbPersonInformation.Controls.Add(this.pbPersonImage);
            this.gbPersonInformation.Controls.Add(this.lblCountryValue);
            this.gbPersonInformation.Controls.Add(this.lblCountryTitle);
            this.gbPersonInformation.Controls.Add(this.lblPhoneValue);
            this.gbPersonInformation.Controls.Add(this.lblPhoneTitle);
            this.gbPersonInformation.Controls.Add(this.lblDateOfBirthValue);
            this.gbPersonInformation.Controls.Add(this.lblDateOfBirthTitle);
            this.gbPersonInformation.Controls.Add(this.lblAddressValue);
            this.gbPersonInformation.Controls.Add(this.lblAddressTitle);
            this.gbPersonInformation.Controls.Add(this.lblEmailValue);
            this.gbPersonInformation.Controls.Add(this.lblEmailTitle);
            this.gbPersonInformation.Controls.Add(this.lblGenderValue);
            this.gbPersonInformation.Controls.Add(this.lblGenderTitle);
            this.gbPersonInformation.Controls.Add(this.lblNationalNoValue);
            this.gbPersonInformation.Controls.Add(this.lblNationalNoTitle);
            this.gbPersonInformation.Controls.Add(this.lblFullNameValue);
            this.gbPersonInformation.Controls.Add(this.lblFullNameTitle);
            this.gbPersonInformation.Controls.Add(this.lblPersonIDValue);
            this.gbPersonInformation.Controls.Add(this.lblPersonIDTitle);
            this.gbPersonInformation.Location = new System.Drawing.Point(13, 13);
            this.gbPersonInformation.Name = "gbPersonInformation";
            this.gbPersonInformation.Size = new System.Drawing.Size(760, 270);
            this.gbPersonInformation.TabIndex = 0;
            this.gbPersonInformation.TabStop = false;
            this.gbPersonInformation.Text = "Person Information";
            this.gbPersonInformation.Enter += new System.EventHandler(this.gbPersonInformation_Enter);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Blue;
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(561, 234);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(150, 36);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Location = new System.Drawing.Point(561, 70);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(150, 150);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 8;
            this.pbPersonImage.TabStop = false;
            // 
            // lblCountryValue
            // 
            this.lblCountryValue.AutoSize = true;
            this.lblCountryValue.Location = new System.Drawing.Point(420, 100);
            this.lblCountryValue.Name = "lblCountryValue";
            this.lblCountryValue.Size = new System.Drawing.Size(35, 15);
            this.lblCountryValue.TabIndex = 7;
            this.lblCountryValue.Text = "[????]";
            // 
            // lblCountryTitle
            // 
            this.lblCountryTitle.AutoSize = true;
            this.lblCountryTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryTitle.Location = new System.Drawing.Point(320, 100);
            this.lblCountryTitle.Name = "lblCountryTitle";
            this.lblCountryTitle.Size = new System.Drawing.Size(54, 15);
            this.lblCountryTitle.TabIndex = 6;
            this.lblCountryTitle.Text = "Country:";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Location = new System.Drawing.Point(420, 70);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(35, 15);
            this.lblPhoneValue.TabIndex = 5;
            this.lblPhoneValue.Text = "[????]";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTitle.Location = new System.Drawing.Point(320, 70);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(45, 15);
            this.lblPhoneTitle.TabIndex = 4;
            this.lblPhoneTitle.Text = "Phone:";
            // 
            // lblDateOfBirthValue
            // 
            this.lblDateOfBirthValue.AutoSize = true;
            this.lblDateOfBirthValue.Location = new System.Drawing.Point(420, 40);
            this.lblDateOfBirthValue.Name = "lblDateOfBirthValue";
            this.lblDateOfBirthValue.Size = new System.Drawing.Size(35, 15);
            this.lblDateOfBirthValue.TabIndex = 3;
            this.lblDateOfBirthValue.Text = "[????]";
            // 
            // lblDateOfBirthTitle
            // 
            this.lblDateOfBirthTitle.AutoSize = true;
            this.lblDateOfBirthTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthTitle.Location = new System.Drawing.Point(320, 40);
            this.lblDateOfBirthTitle.Name = "lblDateOfBirthTitle";
            this.lblDateOfBirthTitle.Size = new System.Drawing.Size(85, 15);
            this.lblDateOfBirthTitle.TabIndex = 2;
            this.lblDateOfBirthTitle.Text = "Date Of Birth:";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Location = new System.Drawing.Point(120, 190);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(35, 15);
            this.lblAddressValue.TabIndex = 11;
            this.lblAddressValue.Text = "[????]";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTitle.Location = new System.Drawing.Point(20, 190);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(54, 15);
            this.lblAddressTitle.TabIndex = 10;
            this.lblAddressTitle.Text = "Address:";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Location = new System.Drawing.Point(120, 160);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(35, 15);
            this.lblEmailValue.TabIndex = 9;
            this.lblEmailValue.Text = "[????]";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTitle.Location = new System.Drawing.Point(20, 160);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(39, 15);
            this.lblEmailTitle.TabIndex = 8;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.lblGenderValue.Location = new System.Drawing.Point(120, 130);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(35, 15);
            this.lblGenderValue.TabIndex = 7;
            this.lblGenderValue.Text = "[????]";
            // 
            // lblGenderTitle
            // 
            this.lblGenderTitle.AutoSize = true;
            this.lblGenderTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderTitle.Location = new System.Drawing.Point(20, 130);
            this.lblGenderTitle.Name = "lblGenderTitle";
            this.lblGenderTitle.Size = new System.Drawing.Size(52, 15);
            this.lblGenderTitle.TabIndex = 6;
            this.lblGenderTitle.Text = "Gender:";
            // 
            // lblNationalNoValue
            // 
            this.lblNationalNoValue.AutoSize = true;
            this.lblNationalNoValue.Location = new System.Drawing.Point(120, 100);
            this.lblNationalNoValue.Name = "lblNationalNoValue";
            this.lblNationalNoValue.Size = new System.Drawing.Size(35, 15);
            this.lblNationalNoValue.TabIndex = 5;
            this.lblNationalNoValue.Text = "[????]";
            // 
            // lblNationalNoTitle
            // 
            this.lblNationalNoTitle.AutoSize = true;
            this.lblNationalNoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNoTitle.Location = new System.Drawing.Point(20, 100);
            this.lblNationalNoTitle.Name = "lblNationalNoTitle";
            this.lblNationalNoTitle.Size = new System.Drawing.Size(75, 15);
            this.lblNationalNoTitle.TabIndex = 4;
            this.lblNationalNoTitle.Text = "National No:";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.Location = new System.Drawing.Point(120, 70);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(35, 15);
            this.lblFullNameValue.TabIndex = 3;
            this.lblFullNameValue.Text = "[????]";
            // 
            // lblFullNameTitle
            // 
            this.lblFullNameTitle.AutoSize = true;
            this.lblFullNameTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameTitle.Location = new System.Drawing.Point(20, 70);
            this.lblFullNameTitle.Name = "lblFullNameTitle";
            this.lblFullNameTitle.Size = new System.Drawing.Size(65, 15);
            this.lblFullNameTitle.TabIndex = 2;
            this.lblFullNameTitle.Text = "Full Name:";
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.AutoSize = true;
            this.lblPersonIDValue.Location = new System.Drawing.Point(120, 40);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(35, 15);
            this.lblPersonIDValue.TabIndex = 1;
            this.lblPersonIDValue.Text = "[????]";
            // 
            // lblPersonIDTitle
            // 
            this.lblPersonIDTitle.AutoSize = true;
            this.lblPersonIDTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIDTitle.Location = new System.Drawing.Point(20, 40);
            this.lblPersonIDTitle.Name = "lblPersonIDTitle";
            this.lblPersonIDTitle.Size = new System.Drawing.Size(64, 15);
            this.lblPersonIDTitle.TabIndex = 0;
            this.lblPersonIDTitle.Text = "Person ID:";
            // 
            // llEditPerson
            // 
            this.llEditPerson.AutoSize = true;
            this.llEditPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEditPerson.Location = new System.Drawing.Point(601, 35);
            this.llEditPerson.Name = "llEditPerson";
            this.llEditPerson.Size = new System.Drawing.Size(74, 17);
            this.llEditPerson.TabIndex = 14;
            this.llEditPerson.TabStop = true;
            this.llEditPerson.Text = "Edit Person";
            this.llEditPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEditPerson_LinkClicked);
            // 
            // ctrlShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbPersonInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlShowDetails";
            this.Size = new System.Drawing.Size(790, 300);
            this.gbPersonInformation.ResumeLayout(false);
            this.gbPersonInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonInformation;
        private System.Windows.Forms.Label lblPersonIDTitle;
        private System.Windows.Forms.Label lblPersonIDValue;
        private System.Windows.Forms.Label lblFullNameTitle;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblNationalNoTitle;
        private System.Windows.Forms.Label lblNationalNoValue;
        private System.Windows.Forms.Label lblGenderTitle;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblDateOfBirthTitle;
        private System.Windows.Forms.Label lblDateOfBirthValue;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblCountryTitle;
        private System.Windows.Forms.Label lblCountryValue;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel llEditPerson;
    }
}
