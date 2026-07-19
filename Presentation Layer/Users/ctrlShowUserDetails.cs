using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace PresentationLayer
{
    public partial class ctrlShowUserDetails : UserControl
    {

        

        public delegate void CheckIfEndTask(bool check);
        public event CheckIfEndTask _CheckIfEndTask;

        public clsUser _User;
        public ctrlShowUserDetails(int UserID)
        {
            InitializeComponent();
            _User = clsUser.Find(UserID);
            LoadUserInfo(UserID);

        }

        public void LoadUserInfo(int UserID)
        {

            ctrlShowDetails personDetailsControl = new ctrlShowDetails(_User.PersonId);
            ctrlShowDetails1.Controls.Clear();
            ctrlShowDetails1.Controls.Add(personDetailsControl);
            lblIsActiveValue.Text = _User.IsActive ? "Yes" : "No";
            lblUserIDValue.Text = _User.UserId.ToString();
            lblUserNameValue.Text = _User.UserName;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (_CheckIfEndTask != null)
                _CheckIfEndTask(false);
        }

    }
}


