using System;
using System.Windows.Forms;
using PresentationLayer;
using Business_Layer;

namespace DVLD.PresentationLayer
{
    public partial class ctrlChangePassword : UserControl
    {
        private int _UserID;

        public delegate void CheckTaskEnd(bool Success);
        public event CheckTaskEnd TaskIsEnd;
        public ctrlChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            LoadUser();
        }

        public void LoadUser()
        {
            ctrlShowUserDetails showUserDetailsControl = new ctrlShowUserDetails(_UserID);
            gbUserInformation.Controls.Clear();
            gbUserInformation.Controls.Add(showUserDetailsControl);
        }

        private bool CheckPassword(string currentPassword, string newPassword, string confirmPassword)
        {
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(currentPassword != clsUser.GetPassword(_UserID))
            {
                MessageBox.Show("Current password is incorrect.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Additional password validation logic can be added here (e.g., length, complexity)
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (CheckPassword(txtCurrentPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text))
            {
                
                clsUser User = clsUser.Find(_UserID);
                User.Password = txtNewPassword.Text;

                if (User != null)
                {
                    clsUser.enSave result = User.Save();
                    switch(result)
                    {
                        case clsUser.enSave.enAddScc:
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case clsUser.enSave.enUpdateScc:
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case clsUser.enSave.enfailed:
                            MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            if(TaskIsEnd != null)
            {
                TaskIsEnd(false);
            }

        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            // Implementation logic
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            // Implementation logic
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // Implementation logic
        }

        private void ctrlShowDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
