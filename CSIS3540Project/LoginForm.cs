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

        public LoginForm()
        {
            InitializeComponent();
        }

        public void ClearInfo(bool keepUsername = false)
        {
            textBoxPassword.Clear();
            if (!keepUsername)
            {
                textBoxUsername.Clear();
                textBoxUsername.Focus();
            }
            else
                textBoxPassword.Focus();
        }
    }
}
