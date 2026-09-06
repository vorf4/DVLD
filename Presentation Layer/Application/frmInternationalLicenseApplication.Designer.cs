namespace DVLD.Presentation_Layer
{
    partial class frmInternationalLicenseApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterValue = new System.Windows.Forms.ComboBox();
            this.dgvInternationalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.colIntLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsInternationalLicenseApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseApplications)).BeginInit();
            this.cmsInternationalLicenseApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "International License Applications";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbFilterValue);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.lblFilterBy);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbFilter.Location = new System.Drawing.Point(20, 85);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(650, 60);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(15, 23);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(69, 19);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Int License ID",
            "Application ID",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(95, 20);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(160, 25);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(270, 20);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(200, 25);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cbFilterValue
            // 
            this.cbFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterValue.FormattingEnabled = true;
            this.cbFilterValue.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbFilterValue.Location = new System.Drawing.Point(270, 20);
            this.cbFilterValue.Name = "cbFilterValue";
            this.cbFilterValue.Size = new System.Drawing.Size(150, 25);
            this.cbFilterValue.TabIndex = 3;
            this.cbFilterValue.Visible = false;
            this.cbFilterValue.SelectedIndexChanged += new System.EventHandler(this.cbFilterValue_SelectedIndexChanged);
            // 
            // dgvInternationalLicenseApplications
            // 
            this.dgvInternationalLicenseApplications.AllowUserToAddRows = false;
            this.dgvInternationalLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenseApplications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInternationalLicenseApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalLicenseApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInternationalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenseApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInternationalLicenseApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalLicenseApplications.ColumnHeadersHeight = 38;
            this.dgvInternationalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInternationalLicenseApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntLicenseID,
            this.colApplicationID,
            this.colDriverID,
            this.colLLicenseID,
            this.colIssueDate,
            this.colExpirationDate,
            this.colIsActive});
            this.dgvInternationalLicenseApplications.ContextMenuStrip = this.cmsInternationalLicenseApplications;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalLicenseApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternationalLicenseApplications.EnableHeadersVisualStyles = false;
            this.dgvInternationalLicenseApplications.Location = new System.Drawing.Point(20, 155);
            this.dgvInternationalLicenseApplications.MultiSelect = false;
            this.dgvInternationalLicenseApplications.Name = "dgvInternationalLicenseApplications";
            this.dgvInternationalLicenseApplications.ReadOnly = true;
            this.dgvInternationalLicenseApplications.RowHeadersVisible = false;
            this.dgvInternationalLicenseApplications.RowTemplate.Height = 32;
            this.dgvInternationalLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenseApplications.Size = new System.Drawing.Size(944, 415);
            this.dgvInternationalLicenseApplications.TabIndex = 2;
            this.dgvInternationalLicenseApplications.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInternationalLicenseApplications_CellMouseDown);
            // 
            // colIntLicenseID
            // 
            this.colIntLicenseID.HeaderText = "Int License ID";
            this.colIntLicenseID.Name = "colIntLicenseID";
            this.colIntLicenseID.ReadOnly = true;
            // 
            // colApplicationID
            // 
            this.colApplicationID.HeaderText = "Application ID";
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.ReadOnly = true;
            // 
            // colDriverID
            // 
            this.colDriverID.HeaderText = "Driver ID";
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.ReadOnly = true;
            // 
            // colLLicenseID
            // 
            this.colLLicenseID.HeaderText = "L. License ID";
            this.colLLicenseID.Name = "colLLicenseID";
            this.colLLicenseID.ReadOnly = true;
            // 
            // colIssueDate
            // 
            this.colIssueDate.HeaderText = "Issue Date";
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.ReadOnly = true;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.HeaderText = "Expiration Date";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.ReadOnly = true;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmsInternationalLicenseApplications
            // 
            this.cmsInternationalLicenseApplications.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsInternationalLicenseApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsInternationalLicenseApplications.Name = "cmsInternationalLicenseApplications";
            this.cmsInternationalLicenseApplications.Size = new System.Drawing.Size(241, 76);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRecord.Location = new System.Drawing.Point(20, 595);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(101, 20);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "# Records: 0";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(864, 585);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 640);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.dgvInternationalLicenseApplications);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmInternationalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International License Applications";
            this.Load += new System.EventHandler(this.frmInternationalLicenseApplications_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseApplications)).EndInit();
            this.cmsInternationalLicenseApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterValue;
        private System.Windows.Forms.DataGridView dgvInternationalLicenseApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnClose;
    }
}
