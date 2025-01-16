using Animal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Dog : AnimalBase
    {
        public string Name { get; private set; } = "Без имени";
        public override void Eat()
        {
            Console.WriteLine($"собака по имени {Name} ест");
        }

        public override string GetName()
        {
            return Name;
        }

        public override void SetName(string name)
        {
            Name = name;
        }
    }
}
