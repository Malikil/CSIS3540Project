using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServerProgram
{
    interface IClientHandler
    {
        event EventHandler<string> MessageReceived;
        event EventHandler Disconnected;

        Task Run(CancellationToken cancellationToken);
        void Disconnect();
        void SendMessage(string message);
    }
}
