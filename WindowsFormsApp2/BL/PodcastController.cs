using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class PodcastController
    {
        public void createPodcast(String title, String url, String category, int interval)
        {
            Podcast p = new Podcast(title, category, url, interval);
        }

        public Array arrayOfPodcast()
        {
            Podcast a = new Podcast("Frågar Åt En Kompis", "humor", "https://cdn.radioplay.se/data/rss/479.xml", 3);
            Podcast b = new Podcast("Knoddpodden", "humor", "https://cdn.radioplay.se/data/rss/477.xml#", 4);
            Podcast c = new Podcast("UFOpodden", "humor", "https://cdn.radioplay.se/data/rss/462.xml", 1);
            Podcast d = new Podcast("Freakshow", "humor", "https://cdn.radioplay.se/data/rss/457.xml", 5);

            Podcast[] arrayOfPodcast = { a, b, c, d};

            return arrayOfPodcast;

        }
    }
}
 