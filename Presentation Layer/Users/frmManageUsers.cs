using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer;
using PresentationLayer;

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

           frmAddOrUpdateUser frm = new frmAddOrUpdateUser();
            frm.ShowDialog();
            _LoadUsers(); // Refresh the user list after adding a new user

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void TextNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _RemoveFilter()
        {
            if (_dtAllUsers != null)
                _dtAllUsers.DefaultView.RowFilter = string.Empty;

            _UpdateRecordsCount();
        }

        private void _FilterID()
        {

            //write only number 

            txtFilterValue.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

        }

        private string _GetFilterColumnName(string filterBy)
        {
            switch (filterBy)
            {
                case "PersonID": return "PersonID";
                case "UserID": return "UserID";
                case "FullName": return "FullName";
                case "UserName": return "UserName";
                case "IsActive": return "IsActive";
                default: return string.Empty;
            }
        }

        private void _ApplyFilter()
        {
            if (_dtAllUsers == null)
                return;

            string filterBy = cbFilterBy.SelectedItem?.ToString() ?? "None";

            if (filterBy == "None" || string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {

                if (filterBy != "IsActive")
                {
                    _RemoveFilter();
                    return;
                }
            }

            string columnName = _GetFilterColumnName(filterBy);
            if (string.IsNullOrEmpty(columnName))
            {
                _RemoveFilter();
                return;
            }

            string value = txtFilterValue.Text.Trim().Replace("'", "''");

            if (columnName == "PersonID" || columnName == "UserID")
                _dtAllUsers.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", columnName, value);
            else if (columnName == "IsActive" )
            {

                string filterValue = cbFilterValue.SelectedItem?.ToString() ?? "All";

                if (filterValue == "Yes")
                {
                    _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 1";
                }
                else if (filterValue == "No")
                {
                    _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 0";
                }
                else
                {
                    _dtAllUsers.DefaultView.RowFilter = string.Empty;
                }
                dgvUsers.DataSource = _dtAllUsers.DefaultView;
            }
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, value);

           

            _UpdateRecordsCount();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterValue.KeyPress += (s, ev) => { ev.Handled = false; }; // Remove any previous KeyPress event handlers

            string filterBy = cbFilterBy.SelectedItem?.ToString() ?? "None";

            if (filterBy == "None")
            {

                txtFilterValue.Visible = false;
                txtFilterValue.Clear();
                _RemoveFilter();
                return;
            }

            if (filterBy == "PersonID" || filterBy == "UserID"|| filterBy == "FullName" || filterBy == "Username")
            {
                cbFilterValue.Visible = false;
                txtFilterValue.Visible = true;
                txtFilterValue.Clear();
            }else if (filterBy == "IsActive")
            {
                txtFilterValue.Visible = false;
                cbFilterValue.Visible = true;
                txtFilterValue.Clear();

            }

            if (filterBy == "PersonID" || filterBy == "UserID")
                _FilterID();

            _ApplyFilter();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            ctrlShowUserDetails personDetailsControl = new ctrlShowUserDetails(UserID);
            personDetailsControl._CheckIfEndTask += btnCloseDetails_Click;
            


            plUserDetails.Controls.Clear();
            plUserDetails.Controls.Add(personDetailsControl);
            plUserDetails.Visible = true;

        }

        private void btnCloseDetails_Click(int check)
        {
            plUserDetails.Visible = false;
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddOrUpdateUser frm = new frmAddOrUpdateUser();
            frm.ShowDialog();
            _LoadUsers(); // Refresh the user list after adding a new user

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            frmAddOrUpdateUser frm = new frmAddOrUpdateUser(UserID);
            frm.ShowDialog();
            _LoadUsers(); // Refresh the user list after adding a new user

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            if (clsUser.DeleteUser(UserID))
            {
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadUsers(); // Refresh the user list after deleting a user
            }
            else
            {
                MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void cbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }
    }
}
