using org.meetingontime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMeetingTimer
{
    class TimeServer
    {
        public MeetingTimer timer { get; set; }
        public void StartServer()
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 8000);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(localEndPoint);
            newsock.Listen(10);
            Socket client = newsock.Accept();
        }
    }
}
