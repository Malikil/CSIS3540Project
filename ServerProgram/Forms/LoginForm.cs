using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerProgram.Forms
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
            // Set enter button
            AcceptButton = buttonRegOk;
            
            // Show registration information
            registerGrid.Visible = true;
            loginGrid.Visible = false;

            // Focus on proper text box
            textBoxRegisterName.Focus();
            textBoxRegisterName.SelectAll();
        }

        private void RegisterOk(object sender, EventArgs e)
        {
            // Copy username and password to login boxes
            textBoxUsername.Text = textBoxRegisterName.Text;
            textBoxPassword.Text = textBoxRegisterWord.Text;

            // Return with DialogResult ignore
            DialogResult = DialogResult.Ignore;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            // Make sure the form is presentable, we're not sure exactly what
            // state it's in right now

            // Hide registration grid
            loginGrid.Visible = true;
            registerGrid.Visible = false;

            // Default button
            AcceptButton = buttonLogin;

            // Focus
            textBoxUsername.SelectAll();
            if (textBoxUsername.CanFocus)
                textBoxUsername.Focus();
        }
    }
}
