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
            // Login form shouldn't have to login in and of itself, the actual
            // thinking should be done here
            LoginForm login = new LoginForm();
            for (
                DialogResult result = login.ShowDialog();
                result != DialogResult.Cancel;
                result = login.ShowDialog()
                ) // I suppose this is a tad unconventional, but w/e
            {
                if (result == DialogResult.OK)
                {
                    // Attempt to login
                    bool loggedin = false;
                    if (loggedin) // Login successful
                    {
                        // My current think with this part stems a bit from the
                        // last large project I did for Data Structures and
                        // Algorithms, our project was fairly large and used
                        // windows in java. The goal we were going for with
                        // that was to keep most of the actual logic outside
                        // the forms themselves, and use a controller class
                        // that handles the server communication and just tells
                        // the form what to display when. No actual logic was
                        // in the form itself.

                        // if admin, show admin form
                        // if student, show student form
                    }
                    else // Login failed
                    {
                        MessageBox.Show("Incorrect Username or Password", "Error");
                        login.ClearInfo(true);
                    }
                }
                else // result == DialogResult.Ignore
                {
                    // Attempt to create account
                    bool created = false;
                    if (created) // Account created
                    {
                        // Clear info and show login screen again with
                        // pre-entered username
                        login.ClearInfo(true);
                    }
                    else // Account not created
                    {
                        MessageBox.Show("That username is already taken or your student ID could not be found", "Error");
                        login.ClearInfo();
                    }
                }
            }
        }
    }
}
