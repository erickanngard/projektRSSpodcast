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
            Podcast a = new Podcast("monopoly", "ekonomi", "fjasfjaskg.sdf", 3);
            Podcast b = new Podcast("lol", "humor", "humor.se", 4);
            Podcast c = new Podcast("rappakalja", "humor", "rapparkalja.se", 1);
            Podcast d = new Podcast("ekonomy 101", "ekonomi", "ekonomi101.se", 5);

            Podcast[] arrayOfPodcast = { a, b, c, d};

            return arrayOfPodcast;

        }
    }
}
 