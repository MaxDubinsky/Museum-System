using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Museum
    {
        public List<Visitor> visitors { get; set; } = new List<Visitor>();
        public List<Guide> guides { get; set; } = new List<Guide>();
        public List<Exhibit> exhibits { get; set; } = new List<Exhibit>();
        public string title { get; set; }
        public void AddExhibit(Exhibit exhibit)
        {
            this.exhibits.Add(exhibit);
        }
        public void RemoveExhibit(Exhibit exhibit)
        {
            this.exhibits.Remove(exhibit);
        }
        public Exhibit FindExhibitByName(string name)
        {
            foreach (Exhibit ex in this.exhibits)
            {
                if (ex.title.Equals(name))
                {
                    return ex;
                }
            }
            return new Exhibit("[No title]", "[No description]");
        }
        public bool IsExhibitExists(Exhibit ex)
        {
            foreach (Exhibit exhibit in this.exhibits)
            {
                if (exhibit == ex)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
