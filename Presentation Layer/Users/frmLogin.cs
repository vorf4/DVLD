using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class frmLogin : Form
    {

        private clsUser _User;
        public frmLogin()
        {
            InitializeComponent();
            _frmLogin_Load();
        }

        private bool _IsLoggedIn() {


            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isLoggedIn = true;

            _User=clsUser.Find(username, password);

            if (_User != null)
            {
                if (_User.UserName != username || _User.Password != password)
                {

                    isLoggedIn = false;
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (!_User.IsActive)
                {
                    
                    isLoggedIn = false;
                    MessageBox.Show("Your account is inactive. Please contact the administrator.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                isLoggedIn = false;
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isLoggedIn;

        }

        private void _frmLogin_Load()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRememberMe.Checked = true;
            }
        }

        private void _CheckRememberMe()
        {

            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }

            Properties.Settings.Default.Save();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            if (_IsLoggedIn())
            {
                
                _CheckRememberMe();
                frmMainMenu Main = new frmMainMenu(_User);
                this.Hide();
                Main.ShowDialog();
                this.Close();

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Add remember me logic here.
        }
    }
}
