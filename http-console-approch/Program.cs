using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace http_console_approch
{
    class Program
    {
        static  void Main(string[] args)
        {//desynchrous.
            webConnect();
            Console.WriteLine("Synchronous...");
            apple();
            orange();
            Console.ReadKey();
        }
        public static async void webConnect()
        {
            try
            {
                HttpClient client = new HttpClient();
                //HttpResponseMessage httpResponse = await client.GetAsync("http://www.contoso.com/");
                //Console.WriteLine(httpResponse.EnsureSuccessStatusCode());
                //string responseBody = await client.GetStringAsync("");
                
                string readresponse = await  client.GetStringAsync("http://www.contoso.com/");
                Task task = second();
                Console.WriteLine(readresponse);

            }
            catch
            {

            }
        }

        public static async Task  second()
        {
            Console.WriteLine("first");
            await Task.Delay(5000);
            Console.WriteLine("second");
        }

        public static void apple()
        {
            Console.WriteLine("Apple");

        }
        public static void orange()
        {
            Console.WriteLine("Orange");
        }


    }
}
