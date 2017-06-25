using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Configuration;
 
class EmployeeUDPServer
{
    public static void Main()
    {
        UdpClient udpc = new UdpClient(2055);
        Console.WriteLine("Server started, servicing on port 2055");
        IPEndPoint ep = null;
        while (true)
        {
            byte[] rdata = udpc.Receive(ref ep);
            string name = Encoding.ASCII.GetString(rdata);
            string job = ConfigurationSettings.AppSettings[name];
            if (job == null) job = "No such employee";
            byte[] sdata = Encoding.ASCII.GetBytes(job);
            udpc.Send(sdata, sdata.Length, ep);
        }
    }
