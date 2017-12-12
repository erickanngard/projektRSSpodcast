using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WindowsFormsApp2.BL;

namespace WindowsFormsApp2.DL
{
    class XmlDownloader
    {

        public static async Task<List<Episode>> LoadRssXml(String rssString, Podcast p)
        {
            List<Episode> listOfEpisodes = new List<Episode>();

            var xml = await Download(rssString);
            //Skapa en objektrepresentation.
            var dom = new XmlDocument();
            dom.LoadXml(xml);

            foreach(XmlNode node in dom.DocumentElement.SelectNodes("channel/item"))
            {
                var title = node.SelectSingleNode("title").InnerText;
                var url = node.SelectSingleNode("link").InnerText;
                //var desc = node.SelectSingleNode("itunes:summary").InnerText;
                var desc = "";
                Episode e = new Episode(title, url,desc, false, p);
                listOfEpisodes.Add(e);
            }

            return listOfEpisodes;
        }

        private static async Task<String> Download(String url)
        {
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            return xml;
        }


        /*
   public void LoopXml()
   {
       //Iterera igenom elementet item.
       foreach (System.Xml.XmlNode item
          in dom.DocumentElement.SelectNodes("channel/item"))
       {
           //Skriv ut dess titel.
           var title = item.SelectSingleNode("title");
           Console.WriteLine(title.InnerText);
       }
   }*/
    }
}
