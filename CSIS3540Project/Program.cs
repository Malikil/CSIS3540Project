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
                    StreamWriter toserver = new StreamWriter(outstream)
                    {
                        AutoFlush = true
                    };
                    StreamReader fromserver = new StreamReader(instream);

                    if (result == DialogResult.OK)
                    {
                        // Attempt to login
                        toserver.WriteLine($"LOGIN;{login.Username};{login.Password}");
                        string response = fromserver.ReadLine();
                        if (response != "FAIL") // Login successful
                        {
                            if (response == "ADMIN")
                            {
                                // Show admin form
                                MessageBox.Show("Logged in as admin", "Logged in");
                                //Application.Run(new AdminForm(toserver, fromserver));
                            }
                            else if (response == "STUDENT")
                            {
                                // Show student form
                                MessageBox.Show("Logged in as student", "Logged in");
                            }
                            else
                            {
                                MessageBox.Show("Server rejected connection", "Login Error");
                                login.ClearInfo();
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

                    try
                    {
                        toserver.Close();
                        fromserver.Close();
                    }
                    catch (IOException)
                    { }
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Could not connect to server.", "Timeout");
                }
            }
        }
    }
}
