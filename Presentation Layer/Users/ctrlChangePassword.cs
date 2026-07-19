using System;
using System.Windows.Forms;
using PresentationLayer;

namespace DVLD.PresentationLayer
{
    public partial class ctrlChangePassword : UserControl
    {
        public ctrlChangePassword()
        {
            InitializeComponent();
        }

        public void LoadUser(int UserID)
        {
            
            // Prepare the control for password changing
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Implementation logic for saving the new password
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close logic
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
    }
}
