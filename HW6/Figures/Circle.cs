using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : IShape, IShapeInfo
    {
        private double _radius;
        public double Radius {
            get {
                return _radius; 
            } 
            private set {

                if (value < 0) throw new ArgumentException("Радиус не может быть отрицательным");
                _radius = value; 
            } 
        }
        public string Name { get; private set; }
        public Circle(string name, double radius)
        {
            Radius = radius;
            Name = name;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
