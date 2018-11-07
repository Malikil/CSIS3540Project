using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ServerProgram
{
    class ClientHandler : IClientHandler
    {
        public event EventHandler<string> MessageReceived;
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

            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        public void Disconnect()
        {
            _out.Close();
            _in.Close();

            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        public void SendMessage(string message)
        {
            _out.WriteLine(message);
        }
    }
}
