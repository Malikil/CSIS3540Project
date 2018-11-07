using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServerProgram
{
    interface IClientListener
    {
        Task BeginWaitForConnections();
        void EndWaitForConnections();
        void Disconnect();
    }
}
