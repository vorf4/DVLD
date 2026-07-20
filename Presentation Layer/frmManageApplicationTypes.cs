using System;
using System.Drawing;
using System.Windows.Forms;
using Presentation_Layer;
using Business_Layer;
using System.Data;

namespace DVLD.Presentation_Layer
{
    public partial class frmManageApplicationTypes : Form
    {
        private clsUser CurrentUser;
        private DataTable DTApplicationType;
        public frmManageApplicationTypes(clsUser user)
        {

            InitializeComponent();

            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            CurrentUser = user;
            DTApplicationType = clsApplicationType.GetAllApplicationTypes();
            LoadData();

        }

        private void LoadData()
        {
            // 1. Get your data (Example using a hypothetical Business Layer method)
            DataTable dt = clsApplicationType.GetAllApplicationTypes();

            // 2. IMPORTANT: Stop the grid from creating new columns automatically
            dgvApplicationTypes.AutoGenerateColumns = false;

            // 3. Map your pre-created grid columns to the exact names of your database columns
            // (Replace "DB_ID_Name", etc., with the actual column names from your SQL table)
            dgvApplicationTypes.Columns["ID"].DataPropertyName = "ApplicationTypeID";
            dgvApplicationTypes.Columns["Title"].DataPropertyName = "ApplicationTypeTitle";
            dgvApplicationTypes.Columns["Fees"].DataPropertyName = "ApplicationFees";

            // 4. Bind the data to the grid
            dgvApplicationTypes.DataSource = dt;
            lblRecordsCount.Text = $"Records : {dgvApplicationTypes.Rows.Count}";
        }

        private void dgvApplicationTypes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvApplicationTypes.ClearSelection();
                dgvApplicationTypes.Rows[e.RowIndex].Selected = true;
            }
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ApplicationTypeID = Convert.ToInt32(dgvApplicationTypes.SelectedRows[0].Cells["ID"].Value);
            frmUpdateApplicationType updateForm = new frmUpdateApplicationType(ApplicationTypeID);
            updateForm.ShowDialog();
            DTApplicationType = clsApplicationType.GetAllApplicationTypes();
            LoadData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
