using System;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class frmLicenseInfo : Form
    {
        private int _licenseID = -1;

        // Default constructor
        public frmLicenseInfo()
        {
            InitializeComponent();
        }

        // Constructor accepting a License ID directly
        public frmLicenseInfo(int licenseID) : this()
        {
            _licenseID = licenseID;
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.ResetDefaultValues();

            if (_licenseID != -1)
            {
                LoadLicenseInfo(_licenseID);
            }
        }

        public void LoadLicenseInfo(int licenseID)
        {
            _licenseID = licenseID;
            ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(licenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
