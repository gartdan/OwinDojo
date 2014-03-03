using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace SelfHostWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";
            //start the owin host
            using (WebApp.Start<Startup>(url: baseAddress)) {
                //make a http request to our web api service
                var client = new HttpClient();
                var response = client.GetAsync(baseAddress + "api/movies").Result;
                Console.WriteLine(response);
                Console.Write(response.Content.ReadAsStringAsync().Result);
            }
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
