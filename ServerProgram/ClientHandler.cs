using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using ServerProgram.Mappers;

namespace ServerProgram
{
    class ClientHandler
    {
        public event EventHandler Disconnected;

        private readonly StreamReader _in;
        private readonly StreamWriter _out;

        public ClientHandler(Stream instream, Stream outstream)
        {
            Console.WriteLine("Connection Received");
            _in = new StreamReader(instream);
            _out = new StreamWriter(outstream)
            {
                AutoFlush = true
            };
        }

        public async Task Run()
        {
            Console.WriteLine("Connection Accepted");
            try
            {
                // The first message will always be logging in
                string command = await _in.ReadLineAsync();
                string[] args = command.Split(new[] { ';' },StringSplitOptions.None);
                if (args.Length > 0)
                {
                    Entities.Account account = null;
                    if (args[0] == "LOGIN")
                        account = AccountMapper.ReadAccountByUserPass(args[1], args[2]);
                    else if (args[0] == "REGISTER")
                    {
                        // Make sure the student exists
                        if (StudentMapper.ReadStudentByID(int.Parse(args[3])) != null &&
                            AccountMapper.ReadAccountByUserPass(args[1], args[2]) == null)
                        {
                            account = new Entities.Account()
                            {
                                Username = args[1],
                                Password = args[2],
                                StudentID = int.Parse(args[3])
                            };
                            AccountMapper.CreateAccount(account);
                        }
                    }

                    if (account == null)
                        await _out.WriteLineAsync("FAIL");
                    else if (account.StudentID == null)
                        await _out.WriteLineAsync("ADMIN");
                    else
                        await _out.WriteLineAsync("STUDENT");

                    while ((command = await _in.ReadLineAsync()) != null)
                    {
                        Console.WriteLine("Received: " + command);
                        // TODO
                        await _out.WriteLineAsync("NULL");
                    }
                }
                else
                    await _out.WriteLineAsync("FAIL");
            }
            catch (ObjectDisposedException)
            { }
            
            Disconnected?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("Connection Ended");
        }

        public void Disconnect()
        {
            _out.Close();
            _in.Close();

            // Disconnected?.Invoke(this, EventArgs.Empty);
        }
    }
}
