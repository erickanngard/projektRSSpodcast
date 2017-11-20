using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DL;

namespace WindowsFormsApp2.BL
{
    class PodcastController
    {
        
        public PodcastController()
        {
            // Fråga data-layer om befintlig data.
        }
        public bool createPodcast(String title, String url, String category, int interval)
        {
            Podcast p = new Podcast(title, category, url, interval, new List<Episode>());
            XmlGenerator.SavePodcast(p);
            return false;
        }

        private Podcast[] arrayOfPodcast()
        {
            Podcast a = new Podcast("Frågar Åt En Kompis", "humor", "https://cdn.radioplay.se/data/rss/479.xml", 3, new List<Episode>());
            Podcast b = new Podcast("Knoddpodden", "humor", "https://cdn.radioplay.se/data/rss/477.xml#", 4, new List<Episode>());
            Podcast c = new Podcast("UFOpodden", "humor", "https://cdn.radioplay.se/data/rss/462.xml", 1, new List<Episode>());
            Podcast d = new Podcast("Freakshow", "humor", "https://cdn.radioplay.se/data/rss/457.xml", 5, new List<Episode>());

            Podcast[] arrayOfPodcast = { a, b, c, d};
            return arrayOfPodcast;
        }

        // Om det finns, retunera
        public List<Podcast> LoadLocalPodcasts()
        {
            List<Podcast> localPodcasts = XmlGenerator.loadLocalFiles();
            //List<Podcast> localPodcasts = arrayOfPodcast().ToList(); // Denna del bör hämta från lokala XML-filer.
            return localPodcasts;
        }

        public List<string> LoadCategory()
        {
            List<Podcast> podList = LoadLocalPodcasts();
            List<string> ls = new List<string>();

            foreach (Podcast p in podList)
            {
                if( !ls.Contains(p.category))
                {
                    ls.Add(p.category);
                }
            }
            return ls;
        }

        internal async Task<List<Episode>> downloadXml(string url) => await XmlDownloader.LoadRssXml(url);
    }
}
 