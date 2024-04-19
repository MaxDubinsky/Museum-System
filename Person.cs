using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal abstract class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public long id { get; }
        protected long GenerateId()
        {
            Random rand = new Random();
            return rand.Next(0, 999999999);
        }
        protected void GetExhibitName(ref Museum mus, string name)
        {
            Console.WriteLine(mus.FindExhibitByName(name).title);
        }
        protected void GetExhibitDesc(ref Museum mus, string name)
        {
            Console.WriteLine(mus.FindExhibitByName(name).description);
        }
        protected void GetExhibitAllInfo(ref Museum mus, string name)
        {
            Console.WriteLine(mus.FindExhibitByName(name).title);
            Console.WriteLine("-------------------");
            Console.WriteLine(mus.FindExhibitByName(name).description);
        }
    }
}
