using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private string GetTitleStatus(int status)
        {
            switch (status)
            {
                case 1:
                    return "New";
                case 2:
                    return "Cancelled";
                case 3:
                    return "Completed";
                default:
                    return "";
            }
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            
            clsApplication application = clsApplication.Find(ApplicationID);

            lblApplicantValue.Text = clsPerson.GetFullName(application.PersonID);
            lblApplicationDateValue.Text = application.ApplicationDate1.ToString();
            lblApplicationIDValue.Text = application.ApplicationID.ToString();
            lblApplicationTypeValue.Text = clsApplicationType.GetApplicationTypeTitle(application.TypeID1);
            lblCreatedByValue.Text = application.UserID.ToString();
            lblFeesValue.Text ="15";
            lblStatusValue.Text = GetTitleStatus(application.Status);
            lblStatusDateValue.Text = application.LastStatusDate.ToString();


        }



        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Implement View Person Info logic
        }
    }
}
