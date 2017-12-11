using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.BL
{
    [Serializable()]
    public class Podcast
    {
        public string title { get; set; }
        public string category { get; set; }
        public string url { get; set; }
        public int interval { get; set; }
        public int id { get; set; }

        private List<Episode> episodes;

        public Podcast() {
        }

        public Podcast(string title, string category, string url, int interval, int id, List<Episode> episodes)
        {
            this.id =  0;
            this.title = title;
            this.category = category;
            this.url = url;
            this.interval = interval;
            this.id = id;
            this.episodes = episodes;
            Random random = new Random();
            if ( id == 0) {this.id = random.Next(0,999999999); }
            
        }
    }
}