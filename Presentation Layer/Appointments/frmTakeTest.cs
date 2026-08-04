using System;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class frmTakeTest : Form
    {
        public frmTakeTest()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------
        //  Result radio buttons
        // -------------------------------------------------------

        private void rbPass_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbFail_CheckedChanged(object sender, EventArgs e)
        {
        }

        // -------------------------------------------------------
        //  Notes text box
        // -------------------------------------------------------

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
        }

        // -------------------------------------------------------
        //  Bottom buttons
        // -------------------------------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
