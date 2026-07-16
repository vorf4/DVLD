using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            ApplyMenuRenderer();
        }

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
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            // Show the context menu right below the account settings button
            cmsAccountSettings.Show(btnAccountSettings, new Point(0, btnAccountSettings.Height));
        }

        private void miLocalLicense_Click(object sender, EventArgs e)
        {
        }

        private void miInternationalLicense_Click(object sender, EventArgs e)
        {
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
        }

        private void miManageTestTypes_Click(object sender, EventArgs e)
        {
        }

        private void miCurrentUserInfo_Click(object sender, EventArgs e)
        {
        }

        private void miChangePassword_Click(object sender, EventArgs e)
        {
        }

        private void miSignOut_Click(object sender, EventArgs e)
        {
        }
    }
}
