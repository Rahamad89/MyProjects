using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebResponseChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            MyWebRequest myWebRequest = new MyWebRequest("http://199.21.60.52:7990", "GET");
            List<string> webResponse = new List<string>();
            webResponse = myWebRequest.GetResponse();
            Console.WriteLine("Web Response:"+webResponse[0]);
            if (webResponse[1] == "OK")
                Console.WriteLine("*****************Response:SUCCESS************************");
            else
                Console.WriteLine("*****************Response:FAILURE************************");
            Console.ReadKey();
            
        }
    }
}
