using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.BL
{
    public class Podcast
    {
        public string title { get; set; }
        public string category { get; set; }
        public string url { get; set; }
        public int interval { get; set; }

        private List<Episode> episodes;

        public Podcast() {
        }
        
        public Podcast(string title, string category, string url, int interval, List<Episode> episodes)
        {
            this.title = title;
            this.category = category;
            this.url = url;
            this.interval = interval;
            this.episodes = episodes;
        }
    }
}