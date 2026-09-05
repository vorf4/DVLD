using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;
using DVLD.Presentation_Layer;
using DVLD.PresentationLayer;
using PresentationLayer;

namespace Presentation_Layer
{
    public partial class frmMainMenu : Form
    {

        public frmMainMenu(clsUser User)
        {
            InitializeComponent();
            ApplyMenuRenderer();
            _User = User;
            this.FormBorderStyle = FormBorderStyle.Sizable; // Prevent resizing
            this.WindowState = FormWindowState.Maximized; // Start maximized

        }


        private clsUser _User;

        private void ApplyMenuRenderer()
        {
            ToolStripProfessionalRenderer renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
            renderer.RoundedEdges = false;
            cmsApplications.Renderer = renderer;
            cmsAccountSettings.Renderer = renderer;
        }

        private class CustomColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected => Color.FromArgb(227, 242, 253);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(227, 242, 253);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(227, 242, 253);
            public override Color MenuItemBorder => Color.LightGray;
            public override Color ToolStripDropDownBackground => Color.White;
            public override Color ImageMarginGradientBegin => Color.White;
            public override Color ImageMarginGradientMiddle => Color.White;
            public override Color ImageMarginGradientEnd => Color.White;
            public override Color MenuBorder => Color.LightGray;
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(227, 242, 253);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(227, 242, 253);
            public override Color MenuItemPressedGradientMiddle => Color.FromArgb(227, 242, 253);
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            // Show the context menu right below the applications button
            cmsApplications.Show(btnApplications, new Point(0, btnApplications.Height));
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {

            frmPersons frmPersons = new frmPersons();
            this.Visible =false; // Hide the main menu form
            frmPersons.ShowDialog();
            this.Visible = true; // Show the main menu form again after frmPersons is closed


        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            frmManageUsers frmUsers = new frmManageUsers();
            this.Visible =false;
            frmUsers.ShowDialog();
            this.Visible = true;

        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            // Show the context menu right below the account settings button
            cmsAccountSettings.Show(btnAccountSettings, new Point(0, btnAccountSettings.Height));
        }

        private void miLocalLicense_Click(object sender, EventArgs e)
        {

            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(_User);
            frm.ShowDialog();

        }

        private void miInternationalLicense_Click(object sender, EventArgs e)
        {

           frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication(_User);
            frm.ShowDialog();

        }

        private void miRenewDrivingLicense_Click(object sender, EventArgs e)
        {
        }

        private void miReplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
        }

        private void miReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
        }

        private void miRetakeTest_Click(object sender, EventArgs e)
        {
        }

        private void miLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {

              frmLocalDrivingLicenseApplicationManage frm = new frmLocalDrivingLicenseApplicationManage(_User);
              frm.ShowDialog();

        }

        private void miInternationalLicenseApplications_Click(object sender, EventArgs e)
        {
        }

        private void miManageDetainedLicenses_Click(object sender, EventArgs e)
        {
        }

        private void miDetainLicense_Click(object sender, EventArgs e)
        {
        }

        private void miReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
        }

        private void miManageApplicationTypes_Click(object sender, EventArgs e)
        {

            frmManageApplicationTypes frmManageApplicationTypes = new frmManageApplicationTypes(_User);
            frmManageApplicationTypes.ShowDialog();

        }

        private void miManageTestTypes_Click(object sender, EventArgs e)
        {

            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();

        }

        private void miCurrentUserInfo_Click(object sender, EventArgs e)
        {

            ctrlShowUserDetails ctrlShowUserDetails = new ctrlShowUserDetails(_User.UserId);
            ctrlShowUserDetails._CheckIfEndTask += btnCloseDetails_Click;

            plUserDetails.Controls.Clear();
            plUserDetails.Controls.Add(ctrlShowUserDetails);
            plUserDetails.Visible = true;

        }

        private void btnCloseDetails_Click(bool Success)
        {
            
            plUserDetails.Visible = Success;

        }

        private void miChangePassword_Click(object sender, EventArgs e)
        {

            ctrlChangePassword ctrlChangePassword = new ctrlChangePassword(_User.UserId);
            ctrlChangePassword.TaskIsEnd += btnCloseChnage_Click;

            plUserChange.Controls.Clear();
            plUserChange.Controls.Add(ctrlChangePassword);
            plUserChange.Visible = true;

        }

        private void btnCloseChnage_Click(bool Success)
        {
            plUserChange.Visible = Success;
        }

        private void miSignOut_Click(object sender, EventArgs e)
        {

            frmLogin frmLogin = new frmLogin();
            this.Hide(); // Hide the main menu form
            frmLogin.ShowDialog(this);
            this.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
