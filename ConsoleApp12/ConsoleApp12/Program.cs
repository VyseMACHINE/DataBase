using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string url = "https://swapi.co/api/people/1/?format=json";
            using (WebClient client = new WebClient())
            {
                JObject json = new JObject.Parse(client.DownloadString(url));
            }


        }
    }
}
