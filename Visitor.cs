using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Visitor : Person
    {
        public Visitor(string name, string surname)
        {
            this.name = name ?? "[No name]";
            this.surname = surname ?? "[No surname]";
            GenerateId();
        }
    }
}
