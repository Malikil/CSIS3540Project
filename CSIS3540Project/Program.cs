using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540Project
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Login form shouldn't have login in and of itself, the actual
            // thinking should be done here
            LoginForm form = new LoginForm();
            for (
                DialogResult result = form.ShowDialog();
                result != DialogResult.Cancel;
                result = form.ShowDialog()
                ) // I suppose this is a tad unconventional, but w/e
            {
                if (result == DialogResult.OK)
                {
                    // Attempt to login
                }
                else // result == DialogResult.Ignore
                {
                    // Attempt to create account
                }
            }
        }
    }
}
