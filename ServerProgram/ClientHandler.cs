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
        private CancellationToken CancellationToken;

        public ClientHandler(Stream instream, Stream outstream)
        {
            _in = new StreamReader(instream);
            _out = new StreamWriter(outstream)
            {
                AutoFlush = true
            };
        }

        public async Task Run(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;

            // TODO Implement
            // This will wait for messages, then respond to them.
            // It might be better practice to handle messages elsewhere,
            // but that's too much thinking for the amount of time we have
            string command = _in.ReadLine();
            // Parse command
            _out.WriteLine("NULL");


            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        public void Disconnect()
        {
            _out.Close();
            _in.Close();

            Disconnected?.Invoke(this, EventArgs.Empty);
        }
    }
}
