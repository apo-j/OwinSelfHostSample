using System;
using Microsoft.Owin.Hosting;

namespace Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {                
                Console.ReadLine();
            }
        }
    }
}
