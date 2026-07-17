using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class frmManageUsers : Form
    {

        private DataTable _dtAllUsers;
        public frmManageUsers()
        {
            InitializeComponent();
            ApplyModernMenuStyling();

            this.Load += frmManageUsers_Load;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _LoadUsers();
        }

        private  void _LoadUsers()
        {
            _dtAllUsers = Business_Layer.clsUser.GetAll();
            dgvUsers.DataSource = _dtAllUsers;
            _UpdateRecordsCount();
        }

        private void _UpdateRecordsCount()
        {
            lblRecordsCount.Text = $"Total Records: {_dtAllUsers.Rows.Count}";
        }

        private void ApplyModernMenuStyling()
        {
            // Apply custom renderer for modern context menu styling
            cmsUsers.Renderer = new ToolStripProfessionalRenderer(new ModernMenuColorTable());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Custom Color Table for Context Menu Strip
        private class ModernMenuColorTable : ProfessionalColorTable
        {
            // BackColor of the entire menu
            public override Color ToolStripDropDownBackground
            {
                get { return Color.White; }
            }

            // Image margin background
            public override Color ImageMarginGradientBegin
            {
                get { return Color.White; }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.White; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return Color.White; }
            }

            // Selected Item BackColor
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(227, 242, 253); } // Light Blue #E3F2FD
            }

            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(227, 242, 253); } // Light Blue #E3F2FD border to blend in
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
