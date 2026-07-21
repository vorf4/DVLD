using System;
using System.Data;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmManageTestTypes : Form
    {

        private DataTable dt = new DataTable();
        public frmManageTestTypes()
        {
            InitializeComponent();

            
            _LoadData();
        }

        private void _LoadData()
        {
            dt =clsTestType.GetInfoOfTestType();

            dgvListOfTest.AutoGenerateColumns = false;

            dgvListOfTest.Columns[0].DataPropertyName = "TestTypeID";
            dgvListOfTest.Columns[1].DataPropertyName = "TestTypeTitle";
            dgvListOfTest.Columns[2].DataPropertyName = "TestTypeDescription";
            dgvListOfTest.Columns[3].DataPropertyName = "TestTypeFees";

            dgvListOfTest.DataSource = dt;

            lblRecordsCount.Text = $"Total Records: {dt.Rows.Count}";

        }

        private void dgvListOfTest_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Empty event handler
        }

        private void updateTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TesttypeID = Convert.ToInt32(dgvListOfTest.CurrentRow.Cells[0].Value);  
            frmUpdateTestType frmUpdateTestType = new frmUpdateTestType(TesttypeID);
            frmUpdateTestType.ShowDialog();

            _LoadData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
