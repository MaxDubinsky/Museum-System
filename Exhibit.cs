using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Exhibit
    {
        public string title { get; set; }
        public string description { get; set; }
        public Exhibit(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
