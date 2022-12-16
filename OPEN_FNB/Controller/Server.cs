using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace OPEN_FNB
{
    public class Server
    {
        public string serverIp;

        List<Client> clients = new List<Client>();

        public void StartServer()
        {
            var ip = GetLocalIPAddress();
            var port = FreeTcpPort();
            Console.WriteLine($"ip: {ip.ToString()}:{port}");

            TcpListener listener = new TcpListener(ip,5000);
            listener.Start();
            Console.WriteLine(listener.LocalEndpoint.ToString());
            serverIp = listener.LocalEndpoint.ToString();

            while (true)
            {
                var socket = listener.AcceptSocket();
                clients.Add(new Client(socket,this));
                Console.WriteLine("1 client ddax ket noi den");
                
            }
        }
        
        public IPAddress GetLocalIPAddress()
        {
            IPAddress defaultGateway = IPAddress.Parse("192.168.1.1");
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    bool check = false;
                    if (ni.GetIPProperties().GatewayAddresses.Count == 0) continue;
                    else
                    {
                        foreach (var gateWay in ni.GetIPProperties().GatewayAddresses)
                        {
                            /*if (gateWay.Address.ToString().Contains("192.168."))
                            {
                                check = true;
                            }*/
                            if (gateWay.Address.Equals(defaultGateway))
                            {
                                check = true;
                            }
                        }
                    }
                    if (check)
                    {

                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            MessageBox.Show(ip.Address.ToString());
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork && ip.Address.ToString().Contains("192.168.1"))
                            {
                                return ip.Address;
                                
                            }
                        }
                    }
                }
            }
            return null;
        }

        public List<string> GetAllLocalIPAddress()
        {
            List<string> list = new List<string>();
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    bool check = false;
                    if (ni.GetIPProperties().GatewayAddresses.Count == 0) continue;
                    else
                    {
                        foreach (var gateWay in ni.GetIPProperties().GatewayAddresses)
                        {
                            if (gateWay.Address.ToString().Contains("192.168."))
                            {
                                check = true;
                            }

                        }
                    }
                    if (check)
                    {

                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            //MessageBox.Show(ip.Address.ToString());
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork && ip.Address.ToString().Contains("192.168."))
                            {
                                list.Add(ip.Address.ToString());
                            }
                        }
                    }
                }
            }
            return list;
        }


        static int FreeTcpPort()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }
    
        public void handleRequest(Packet packet)
        {

            if (packet.mainObject != null)
            {
                packet.mainObject = JsonConvert.DeserializeObject<object>(packet.mainObject.ToString());
            }
            if (packet.object1 != null)
            {
                packet.object1 = JsonConvert.DeserializeObject<object>(packet.object1.ToString());
            }
            if (packet.object2 != null)
            {
                packet.object2 = JsonConvert.DeserializeObject<object>(packet.object2.ToString());
            }
            if (packet.object3 != null)
            {
                packet.object3 = JsonConvert.DeserializeObject<object>(packet.object3.ToString());
            }

            switch (packet.type)
            {
                case 1:
                    {

                    } 
                    break;

                case 2:
                    {

                    }
                    break;
                case 3:
                    {

                    }
                    break;
            }


        }
    
    }
}
