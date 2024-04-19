using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class CEO
    {
        Museum of_What_Museum { get; set; }

        public void DeleteExhibit(Exhibit ex)
        {
            if (this.of_What_Museum.IsExhibitExists(ex))
            {
                this.of_What_Museum.RemoveExhibit(ex);
            }
            else
            {
                throw new Exception("This exhibit doesn't exist in museum.");
            }
        }
        public void ShowAllGuides()
        {
            foreach (Guide guide in this.of_What_Museum.guides)
            {
                Console.WriteLine(guide.name + " " + guide.surname + ", " + guide.id + ".");
            }
        }
        public void ShowAllVisitors()
        {
            foreach (Visitor visitor in this.of_What_Museum.visitors)
            {
                Console.WriteLine(visitor.name + " " + visitor.surname + ", " + visitor.id + ".");
            }
        }
        public void FireGuide(long id)
        {
            foreach (Guide guide in this.of_What_Museum.guides)
            {
                if (guide.id.Equals(id))
                {
                    this.of_What_Museum.guides.Remove(guide);
                }
            }
        }
        public void RemoveVisitor(long id)
        {
            foreach (Visitor visitor in this.of_What_Museum.visitors)
            {
                if (visitor.id.Equals(id))
                {
                    this.of_What_Museum.visitors.Remove(visitor);
                }
            }
        }
        public void AddExhibit(Exhibit ex)
        {
            this.of_What_Museum.AddExhibit(ex);
        }

        public CEO(string name, string surname, Museum of_What_Museum)
        {
            this.name = name ?? "[No name]";
            this.surname = surname ?? "[No surname]";
            GenerateId();
            this.of_What_Museum = of_What_Museum;
        }
    }
}
