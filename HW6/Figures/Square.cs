using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square: IShape, IShapeInfo
    {
        private double _side;
        public double Side
        {
            get
            {
                return _side;
            }
            private set
            {

                if (value < 0) throw new ArgumentException("Сторона не может быть отрицательной длины");
                _side = value;
            }
        }
        public string Name { get; private set; }
        public Square(string name, double radius)
        {
            Side = radius;
            Name = name;
        }
        public double GetArea()
        {
            return Side * Side;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
