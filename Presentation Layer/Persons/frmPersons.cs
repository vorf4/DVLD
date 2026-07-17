using System;
using System.Data;
using System.Windows.Forms;
using Business_Layer;
using Microsoft.Win32;
using PresentationLayer;

namespace Presentation_Layer
{
    public partial class frmPersons : Form
    {
        private DataTable _dtAllPersons;

        public frmPersons()
        {
            InitializeComponent();

            this.Load += frmPersons_Load;

        }

        private void _FilterID() { 

            //write only number 

            txtFilterValue.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

        }

        private void _LoadPersons()
        {
            _dtAllPersons = clsPerson.GetAllPersons();
            dgvPersons.DataSource = _dtAllPersons;
            _UpdateRecordsCount();
        }

        private string _GetFilterColumnName(string filterBy)
        {
            switch (filterBy)
            {
                case "PersonID": return "PersonID";
                case "NationalNo":
                case "National No": return "NationalNo";
                case "FirstName":
                case "First Name": return "FirstName";
                case "SecondName":
                case "Second Name": return "SecondName";
                case "ThirdName":
                case "Third Name": return "ThirdName";
                case "LastName":
                case "Last Name": return "LastName";
                case "Address": return "Address";
                case "Phone": return "Phone";
                case "Email": return "Email";
                default: return string.Empty;
            }
        }

        private void _ApplyFilter()
        {
            if (_dtAllPersons == null)
                return;

            string filterBy = cbFilterBy.SelectedItem?.ToString() ?? "None";

            if (filterBy == "None" || string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                _RemoveFilter();
                return;
            }

            string columnName = _GetFilterColumnName(filterBy);
            if (string.IsNullOrEmpty(columnName))
            {
                _RemoveFilter();
                return;
            }

            string value = txtFilterValue.Text.Trim().Replace("'", "''");

            if (columnName == "PersonID")
                _dtAllPersons.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", columnName, value);
            else
                _dtAllPersons.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, value);

            _UpdateRecordsCount();
        }

        private void _RemoveFilter()
        {
            if (_dtAllPersons != null)
                _dtAllPersons.DefaultView.RowFilter = string.Empty;

            _UpdateRecordsCount();
        }

        private void _UpdateRecordsCount()
        {
            int count = dgvPersons.Rows.GetRowCount(DataGridViewElementStates.Visible);
            lblRecordsCount.Text = "Records: " + count.ToString();
        }

        private void frmPersons_Load(object sender, EventArgs e)
        {
            _LoadPersons();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

            frmAddOrEditPersonInfo frmAddOrEditPersonInfo = new frmAddOrEditPersonInfo("Add New Person");
            frmAddOrEditPersonInfo.ShowDialog();
            _LoadPersons(); // Refresh the DataGridView after adding a new person

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.KeyPress += (s, ev) => { ev.Handled = false; }; // Remove any previous KeyPress event handlers

            string filterBy = cbFilterBy.SelectedItem?.ToString() ?? "None";

            if (filterBy == "None")
            {
                txtFilterValue.Visible = false;
                txtFilterValue.Clear();
                _RemoveFilter();
                return;
            }

            txtFilterValue.Visible = true;
            txtFilterValue.Clear();

            if (filterBy == "PersonID")
                _FilterID();

            _ApplyFilter();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void dgvPersons_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        plCtrlShow.Visible = true;

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddOrEditPersonInfo frmAddOrEditPersonInfo = new frmAddOrEditPersonInfo("Add New Person");
            frmAddOrEditPersonInfo.ShowDialog();
            _LoadPersons(); // Refresh the DataGridView after adding a new person

        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PersonID =(int)dgvPersons.CurrentRow.Cells["PersonID"].Value;
            frmAddOrEditPersonInfo form = new frmAddOrEditPersonInfo("Update Person Info",PersonID);
            form.ShowDialog();
            _LoadPersons(); // Refresh the DataGridView after updating the person

        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PersonID = (int)dgvPersons.CurrentRow.Cells["PersonID"].Value;
            clsPerson.DeletePerson(PersonID);
            _LoadPersons(); // Refresh the DataGridView after deleting the person

        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

            

        }

        private void plCtrlShow_Paint(object sender, PaintEventArgs e)
        {

            int PersonID = (int)dgvPersons.CurrentRow.Cells["PersonID"].Value;
            ctrlShowDetails ctrl = new ctrlShowDetails(PersonID);

            plCtrlShow.Controls.Clear();
            plCtrlShow.Controls.Add(ctrl);

            ctrl.Dock = DockStyle.Fill;

            plCtrlShow.Visible = false;

        }
    }
}
