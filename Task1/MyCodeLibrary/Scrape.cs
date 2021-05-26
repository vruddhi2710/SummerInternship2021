using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }
    }
}
