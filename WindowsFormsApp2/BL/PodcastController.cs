using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.BL
{
    class PodcastController
    {
        public void createGGardiz()
        {
            Podcast p = new Podcast("bajs", "kuk", "www.bajs.se", 2);
            p.url = "drererer";
            p.interval = 3;
            
        }
    }
}
