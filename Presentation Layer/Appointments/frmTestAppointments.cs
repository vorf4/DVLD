using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class frmTestAppointments : Form
    {
        public frmTestAppointments()
        {
            InitializeComponent();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            // TODO: Implement Add Appointment logic
        }

        private void dgvAppointments_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAppointments.ClearSelection();
                dgvAppointments.Rows[e.RowIndex].Selected = true;
            }
        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement Edit logic
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement Take Test logic
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
