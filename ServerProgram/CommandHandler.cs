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
    class CommandHandler
    {
        public static async Task Run(Stream instream, Stream outstream)
        {
            Console.WriteLine("Message Received");
            using (StreamReader _in = new StreamReader(instream))
            {
                string[] header = _in.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Task<string> body = _in.ReadToEndAsync();
                switch (header[0])
                {
                    case "LOGIN": case "REGISTER":
                        Login(outstream, (await body).Split('\n'), header[0] == "LOGIN");
                        break;
                    case "AVAILABLE":
                        Available(outstream, (await body).Split('\n'));
                        break;
                }
            }

            Console.WriteLine("Connection Ended");
        }

        private static void Available(Stream outstream, string[] args)
        {
            for (int i = 0; i < args.Length; i++)
                args[i] = args[i].Trim();

            DateTime start = DateTime.Parse(args[0]);
            DateTime end = DateTime.Parse(args[1]);

            List<DBEntities.DormRoom> rooms = DormRoomMapper.GetAvailableRoomsByDate(start, end);
            XmlSerializer ser = new XmlSerializer(typeof(List<DBEntities.DormRoom>));
            using (StreamWriter _out = new StreamWriter(outstream))
            {
                _out.WriteLine("ROOMS");
                ser.Serialize(_out, rooms);
            }
        }

        private static void Login(Stream outstream, string[] args, bool loggingIn)
        {
            for (int i = 0; i < args.Length; i++)
                args[i] = args[i].Trim();
            Account account = null;
            if (loggingIn)
                account = AccountMapper.ReadAccountByUserPass(args[0], args[1]);
            else
            {
                // Make sure the student exists
                if (int.TryParse(args[2], out int id) &&
                    StudentMapper.ReadStudentByID(id) != null &&
                    AccountMapper.ReadAccountByUserPass(args[0], args[1]) == null)
                {
                    account = new Account()
                    {
                        Username = args[0],
                        Password = args[1],
                        StudentID = id
                    };
                    AccountMapper.CreateAccount(account);
                }
            }

            using (StreamWriter _out = new StreamWriter(outstream))
            {
                try
                {
                    if (account == null)
                        _out.WriteLine("FAIL");
                    else if (account.StudentID == null)
                        _out.WriteLine("ADMIN");
                    else
                        _out.WriteLine("STUDENT");
                    // _out.Flush();
                }
                catch (ObjectDisposedException)
                { }
            }
        }
    }
}
