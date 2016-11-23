using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ping p1 = new Ping();
                PingReply PR = p1.Send("199.21.60.52:7990");
                Console.WriteLine("Server Response******" + PR.Status.ToString());
                Console.WriteLine("Round Trip Time******" + PR.RoundtripTime.ToString());
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
               Console.ReadLine();
        }
        
    }
}
