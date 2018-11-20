using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Pipes;

namespace ServerProgram
{
    class ClientListener
    {
        private readonly CancellationTokenSource tokenSource;
        private readonly HashSet<ClientHandler> clients;

        public ClientListener()
        {
            tokenSource = new CancellationTokenSource();
            clients = new HashSet<ClientHandler>();
        }

        public async Task BeginWaitForConnections()
        {
            while (!tokenSource.IsCancellationRequested)
            {
                NamedPipeServerStream instream =
                    new NamedPipeServerStream(
                        "ProjectServerIn",
                        PipeDirection.In,
                        NamedPipeServerStream.MaxAllowedServerInstances,
                        PipeTransmissionMode.Byte,
                        PipeOptions.Asynchronous
                    );
                NamedPipeServerStream outstream =
                    new NamedPipeServerStream(
                        "ProjectServerOut",
                        PipeDirection.Out,
                        NamedPipeServerStream.MaxAllowedServerInstances,
                        PipeTransmissionMode.Byte,
                        PipeOptions.Asynchronous
                    );

                try
                {
                    var inAwaiter = instream.WaitForConnectionAsync(tokenSource.Token);
                    var outAwaiter = outstream.WaitForConnectionAsync(tokenSource.Token);
                    await inAwaiter;
                    await outAwaiter;

                    ClientHandler client = new ClientHandler(instream, outstream);
                    clients.Add(client);
                    client.Disconnected += (sender, e) =>
                    {
                        if (sender is ClientHandler current)
                            clients.Remove(current);
                    };
                    client.Run(tokenSource.Token);
                }
                catch (OperationCanceledException)
                { }
            }
        }

        public void Disconnect()
        {
            if (!tokenSource.IsCancellationRequested)
                tokenSource.Cancel();
            Thread.Sleep(250);
            ClientHandler[] oldClients = new ClientHandler[clients.Count];
            clients.CopyTo(oldClients);
            
            foreach (ClientHandler client in oldClients)
                client.Disconnect();
        }

        public void EndWaitForConnections()
        {
            if (!tokenSource.IsCancellationRequested)
                tokenSource.Cancel();
        }
    }
}
