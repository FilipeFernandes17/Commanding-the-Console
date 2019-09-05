using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; //for the HttpClient class
using static System.Console; //for using the static methods of the console class without having to referance the class name

namespace Reop
{
    class Program
    {
        const string API_BASE = "https://www.gitignore.io/api/";
        const string API_LIST_LINES = API_BASE + "lsit?format=lines";

        static void Main(string[] args)
        {
            var client = new HttpClient();
            var response = client.GetAsync
                (API_LIST_LINES).GetAwaiter().GetResult(); //run async code synchronously 
            if(response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync
                    ().GetAwaiter().GetResult();
                WriteLine(content);//notice no console
            }
        }
    }
}
