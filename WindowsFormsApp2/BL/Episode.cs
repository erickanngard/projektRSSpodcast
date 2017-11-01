using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.BL
{
    public class Episode
    {
        public String title { get; set; }
        public String link { get; set; }
        public bool isRead { get; set; }

        public Episode(string title, string link, bool isRead)
        {
            this.title = title;
            this.link = link;
            this.isRead = isRead;
        }
    }
}
