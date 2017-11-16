using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.BL
{
    public class Category
    {
        public string name { get; set; }
        public List<Podcast> podcasts { get; set; }
        
        public Category( string name)
        {
            this.name = name;
        }
    }
}
