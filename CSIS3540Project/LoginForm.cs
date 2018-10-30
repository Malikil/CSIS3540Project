using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540Project
{
    public partial class LoginForm : Form
    {
        public string Username => textBoxUsername.Text;
        public string Password => textBoxPassword.Text;
        public string StudentID => textBoxStudentId.Text;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void ClearInfo() => ClearInfo(false);
        public void ClearInfo(bool keepUsername)
        {
            textBoxStudentId.Clear();
            textBoxPassword.Clear();
            if (!keepUsername)
            {
                textBoxUsername.Clear();
                textBoxUsername.Focus();
            }
            else
                textBoxPassword.Focus();
        }

        private void BeginRegister(object sender, EventArgs e)
        {
            // Copy username and password to registration boxes and
            // clear student id box
            textBoxRegisterName.Text = textBoxUsername.Text;
            textBoxRegisterWord.Text = textBoxPassword.Text;
            textBoxStudentId.Clear();
            // Set register ok button as accept button
            AcceptButton = buttonRegOk;
            // Show registration information
            registerGrid.Visible = true;
        }

        private void RegisterOk(object sender, EventArgs e)
        {
            // Copy username and password to login boxes
            textBoxUsername.Text = textBoxRegisterName.Text;
            textBoxPassword.Text = textBoxRegisterWord.Text;
            // Hide register grid for next time
            registerGrid.Visible = false;
            AcceptButton = buttonLogin;
            // Return with DialogResult ignore
            DialogResult = DialogResult.Ignore;
        }

        private void RegisterCancel(object sender, EventArgs e)
        {
            // Hide registration grid
            registerGrid.Visible = false;
            // Set login button back to accept button
            AcceptButton = buttonLogin;
            // Optionally clear password from login box
            //textBoxPassword.Clear();
        }
    }
}
