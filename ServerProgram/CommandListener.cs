using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Pipes;

namespace ServerProgram
{
    class CommandListener
    {
        public async Task WaitForConnections(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
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
                    var inAwaiter = instream.WaitForConnectionAsync(cancellationToken);
                    var outAwaiter = outstream.WaitForConnectionAsync(cancellationToken);
                    await inAwaiter;
                    await outAwaiter;
                    
                    CommandHandler.Run(instream, outstream);
                }
                catch (OperationCanceledException)
                { }
            }
        }
    }
}
