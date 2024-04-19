using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Guide : Person
    {
        Museum of_What_Museum { get; set; }
        public Guide(string name, string surname, Museum of_What_Museum)
        {
            this.name = name ?? "[No name]";
            this.surname = surname ?? "[No surname]";
            GenerateId();
            this.of_What_Museum = of_What_Museum;
        }
    }
}
