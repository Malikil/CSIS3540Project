using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;

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
                // Try to make connection
                NamedPipeClientStream outstream = new NamedPipeClientStream(".", "ProjectServerIn", PipeDirection.Out);
                NamedPipeClientStream instream = new NamedPipeClientStream(".", "ProjectServerOut", PipeDirection.In);
                try
                {
                    outstream.Connect(3000);
                    instream.Connect(3000);
                    StreamWriter toserver = new StreamWriter(outstream);
                    StreamReader fromserver = new StreamReader(instream);

                    if (result == DialogResult.OK)
                    {
                        // Attempt to login
                        toserver.WriteLine($"m=Login;u={login.Username};p={login.Password}");
                        string response = fromserver.ReadLine();
                        if (response != "false") // Login successful
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
                            
                            if (response == "admin")
                            {
                                // Show admin form
                                //Application.Run(new AdminForm(toserver, fromserver));
                                toserver.Close();
                                fromserver.Close();
                            }
                            else // response == "student"
                            {
                                // Show student form
                            }
                        }
                        else // Login failed
                        {
                            MessageBox.Show("Incorrect Username or Password", "Login Error");
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
                            MessageBox.Show("That username is already taken or your student ID could not be found", "Login Error");
                            login.ClearInfo();
                        }
                    }
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Could not connect to server.", "Timeout");
                }
            }
        }
    }
}
