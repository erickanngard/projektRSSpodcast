using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.BL;

namespace WindowsFormsApp2.DL
{
    class XmlDownloader
    {

        public static void DownloadRssXml(String rssString)
        {
            //Ladda hem XML.
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(rssString);
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);
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
