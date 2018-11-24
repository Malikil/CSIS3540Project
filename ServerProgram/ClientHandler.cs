using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using ServerProgram.Mappers;
using System.Xml.Serialization;
using ServerProgram.Entities;

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
            _out = new StreamWriter(outstream);
        }

        public async Task Run()
        {
            Console.WriteLine("Connection Accepted");
            try
            {
                // The first message will always be logging in
                string command = await _in.ReadLineAsync();
                string[] args = command.Split(';');
                if (args.Length > 0)
                {
                    for (int i = 0; i < args.Length; i++)
                        args[i] = args[i].Trim();

                    Account account = null;
                    if (args[0] == "LOGIN")
                        account = AccountMapper.ReadAccountByUserPass(args[1], args[2]);
                    else if (args[0] == "REGISTER")
                    {
                        // Make sure the student exists
                        if (int.TryParse(args[3], out int id) &&
                            StudentMapper.ReadStudentByID(id) != null &&
                            AccountMapper.ReadAccountByUserPass(args[1], args[2]) == null)
                        {
                            account = new Account()
                            {
                                Username = args[1],
                                Password = args[2],
                                StudentID = id
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
                    await _out.FlushAsync();

                    while ((args = await GetArgs()).Length > 0)
                    {
                        switch (args[0])
                        {
                            // TODO
                            default:
                                await _out.WriteLineAsync("FAIL;END");
                                break;
                        }
                        await _out.FlushAsync();
                    }
                }
                else
                {
                    await _out.WriteLineAsync("FAIL");
                    await _out.FlushAsync();
                }
            }
            catch (ObjectDisposedException)
            { }
            
            Disconnected?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("Connection Ended");
        }

        private async Task<string[]> GetArgs()
        {
            StringBuilder sb = new StringBuilder();
            string current = await _in.ReadLineAsync();
            if (current == null || current == "")
                return new string[0];

            while (!current.EndsWith("END"))
            {
                sb.Append(current);
                current = await _in.ReadLineAsync();
                current = current?.Trim();
            }
            string[] args = sb.ToString().Split(';');
            for (int i = 0; i < args.Length; i++)
                args[i] = args[i].Trim();

            return args;
        }

        // Temp method, not using it after all.
        // Keeping for reference until XmlSerializer is used above
        private async Task HandleCommands()
        {
            string[] args;
            while ((args = (await _in.ReadLineAsync())?.Split(';')).Length > 0)
            {
                new XmlSerializer(typeof(List<Student>)).Serialize(_out, StudentMapper.ReadAllStudents());
                await _out.WriteLineAsync("NULL");
            }
        }

        public void Disconnect()
        {
            _out.Close();
            _in.Close();

            // Disconnected?.Invoke(this, EventArgs.Empty);
        }
    }
}
