﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;
using System.Xml.Serialization;
using DBEntities;

namespace CSIS3540Project
{
    class Program
    {
        //const string PIPE_SERVER_NAME = ".";
        public const string PIPE_FROM_SERVER = "ProjectServerOut";
        public const string PIPE_TO_SERVER = "ProjectServerIn";

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
                NamedPipeClientStream outstream = new NamedPipeClientStream(".", PIPE_TO_SERVER, PipeDirection.Out);
                NamedPipeClientStream instream = new NamedPipeClientStream(".", PIPE_FROM_SERVER, PipeDirection.In);
                try
                {
                    outstream.Connect(3000);
                    instream.Connect(3000);

                    if (result == DialogResult.OK)
                    {
                        // Attempt to login
                        using (StreamWriter toserver = new StreamWriter(outstream))
                        {
                            toserver.WriteLine($"LOGIN");
                            toserver.WriteLine(login.Username);
                            toserver.WriteLine(login.Password);
                        }

                        string response;
                        using (StreamReader fromserver = new StreamReader(instream))
                            response = fromserver.ReadLine();
                        if (response != "FAIL") // Login successful
                        {
                            if (response == "ADMIN")
                            {
                                // Show admin form
                                Application.Run(new AdminForm());
                            }
                            else if (response == "STUDENT")
                            {
                                // Show student form
                                Application.Run(new StudentsReservations());
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
                        using (StreamWriter toserver = new StreamWriter(outstream))
                        {
                            toserver.WriteLine($"REGISTER");
                            toserver.WriteLine(login.Username);
                            toserver.WriteLine(login.Password);
                            toserver.WriteLine(login.StudentID);
                        }

                        string response;
                        using (StreamReader fromserver = new StreamReader(instream))
                            response = fromserver.ReadLine();

                        if (response == "STUDENT") // Account created
                        {
                            Application.Run(new StudentsReservations());
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
