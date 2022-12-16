using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using OPEN_FNB.Model;
using System.Threading;

namespace OPEN_FNB
{
    internal class Client
    {
        public Socket _socket { get; set; }

        public User user { get; set; }
        public bool running { get; set; }

        Thread _thread;
        Server _server;

        public Client(Socket socket, Server server)
        {
            _socket = socket;
            _server = server;

            running = true;

            _thread = new Thread(startClient);
            _thread.Start();

            sendToClient(new Packet("hello", 0, new User("khang", "123", "", 1)));
            
        }

        void startClient()
        {
            while (_socket.Connected)
            {
                byte[] data = new byte[1024];
                try
                {
                    _socket.Receive(data);
                    _server.handleRequest(Packet.fromBytes(data));
                }
                catch(Exception ex) 
                { 
                    Console.WriteLine(ex); 
                }
            }
            _thread.Join();
        }

        void receiveFromClient()
        {

        }

        public void sendToClient(Packet packet)
        {
            _socket.Send(packet.toBytes());
        }
    }
}
