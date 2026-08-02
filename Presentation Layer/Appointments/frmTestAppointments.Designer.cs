namespace DVLD.Presentation_Layer
{
    partial class frmTestAppointments
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAppointmentsTitle = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.colAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlDrivingLicenseApplicationInfo = new DVLD.Presentation_Layer.ctrlDrivingLicenseApplicationInfo();
            this.ctrlApplicationBasicInfo = new DVLD.Presentation_Layer.ctrlApplicationBasicInfo();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Test Appointments";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppointmentsTitle
            // 
            this.lblAppointmentsTitle.AutoSize = true;
            this.lblAppointmentsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAppointmentsTitle.Location = new System.Drawing.Point(20, 370);
            this.lblAppointmentsTitle.Name = "lblAppointmentsTitle";
            this.lblAppointmentsTitle.Size = new System.Drawing.Size(119, 21);
            this.lblAppointmentsTitle.TabIndex = 6;
            this.lblAppointmentsTitle.Text = "Appointments";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(770, 360);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(160, 35);
            this.btnAddAppointment.TabIndex = 1;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 40;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAppointmentID,
            this.colAppointmentDate,
            this.colPaidFees,
            this.colIsLocked});
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.Location = new System.Drawing.Point(20, 410);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 35;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(910, 250);
            this.dgvAppointments.TabIndex = 0;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            this.dgvAppointments.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointments_CellMouseDown);
            // 
            // colAppointmentID
            // 
            this.colAppointmentID.HeaderText = "Appointment ID";
            this.colAppointmentID.Name = "colAppointmentID";
            this.colAppointmentID.ReadOnly = true;
            // 
            // colAppointmentDate
            // 
            this.colAppointmentDate.HeaderText = "Appointment Date";
            this.colAppointmentDate.Name = "colAppointmentDate";
            this.colAppointmentDate.ReadOnly = true;
            // 
            // colPaidFees
            // 
            this.colPaidFees.HeaderText = "Paid Fees";
            this.colPaidFees.Name = "colPaidFees";
            this.colPaidFees.ReadOnly = true;
            // 
            // colIsLocked
            // 
            this.colIsLocked.HeaderText = "Is Locked";
            this.colIsLocked.Name = "colIsLocked";
            this.colIsLocked.ReadOnly = true;
            this.colIsLocked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsLocked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAppointmentToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppointments.Name = "cmsAppointments";
            this.cmsAppointments.Size = new System.Drawing.Size(130, 48);
            // 
            // editAppointmentToolStripMenuItem
            // 
            this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
            this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editAppointmentToolStripMenuItem.Text = "Edit";
            this.editAppointmentToolStripMenuItem.Click += new System.EventHandler(this.editAppointmentToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRecords.Location = new System.Drawing.Point(20, 680);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(79, 19);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "Records: 0";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(810, 672);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            this.ctrlDrivingLicenseApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ctrlDrivingLicenseApplicationInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlDrivingLicenseApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDrivingLicenseApplicationInfo.Location = new System.Drawing.Point(0, 75);
            this.ctrlDrivingLicenseApplicationInfo.Name = "ctrlDrivingLicenseApplicationInfo";
            this.ctrlDrivingLicenseApplicationInfo.Size = new System.Drawing.Size(950, 120);
            this.ctrlDrivingLicenseApplicationInfo.TabIndex = 1;
            // 
            // ctrlApplicationBasicInfo
            // 
            this.ctrlApplicationBasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ctrlApplicationBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlApplicationBasicInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlApplicationBasicInfo.Location = new System.Drawing.Point(0, 195);
            this.ctrlApplicationBasicInfo.Name = "ctrlApplicationBasicInfo";
            this.ctrlApplicationBasicInfo.Size = new System.Drawing.Size(950, 160);
            this.ctrlApplicationBasicInfo.TabIndex = 2;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.Controls.Add(this.lblAppointmentsTitle);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.ctrlApplicationBasicInfo);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Name = "frmTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Appointments";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private DVLD.Presentation_Layer.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo;
        private DVLD.Presentation_Layer.ctrlApplicationBasicInfo ctrlApplicationBasicInfo;
        private System.Windows.Forms.Label lblAppointmentsTitle;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsLocked;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
    }
}
