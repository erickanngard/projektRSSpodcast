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
    }
}
