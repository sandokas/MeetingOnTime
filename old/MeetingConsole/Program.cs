using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleTCP.SimpleTcpServer tcpServer = new SimpleTCP.SimpleTcpServer();
            tcpServer.Start(51914);
            tcpServer.BroadcastLine("This is a broadcast");
            tcpServer.DataReceived += HandleReceivedData;
        }
        static void HandleReceivedData(object tcpServer, SimpleTCP.Message e)
        {
            Console.WriteLine(tcpServer.);
        }
    }
}
