using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Mappers;
using System.Threading;
using ServerProgram.Entities;
using System.Windows.Forms;
using ServerProgram.Forms;

namespace ServerProgram
{
    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login = new LoginForm();
            for (
                DialogResult result = login.ShowDialog();
                result != DialogResult.Cancel;
                result = login.ShowDialog()
                ) // I suppose this is a tad unconventional, but w/e
            {
                if (result == DialogResult.OK)
                {
                    Account account = AccountMapper.ReadAccountByUserPass(login.Username, login.Password);
                    if (account == null)
                        MessageBox.Show("Invalid username or password", "Login Error");
                    else if (account.StudentID == null)
                        Application.Run(new AdminForm());
                    else
                        Application.Run(new StudentsReservations());
                }
                else // result == DialogResult.Ignore
                {
                    if (int.TryParse(login.StudentID, out int id) &&
                        StudentMapper.ReadStudentByID(id) != null &&
                        AccountMapper.ReadAccountByUserPass(login.Username, login.Password) == null)
                    {
                        AccountMapper.CreateAccount(new Account()
                        {
                            Username = login.Username,
                            Password = login.Password,
                            StudentID = id
                        });
                        Application.Run(new StudentsReservations());
                    }
                    else
                        MessageBox.Show("Invalid student ID or username already taken", "Login Error");
                }
            }
        }

        static void ServerMain(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CommandListener server = new CommandListener();
#pragma warning disable CS4014
            server.WaitForConnections(tokenSource.Token);
#pragma warning restore CS4014
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
            Console.WriteLine("Quitting server...");
            tokenSource.Cancel();
        }
    }
}
