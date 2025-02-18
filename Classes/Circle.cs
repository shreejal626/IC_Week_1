using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public override int GetArea()
        {
            double area = Math.PI * radius * radius;
            int area2 = Convert.ToInt32(area);
            return (int)area2;

        }
    }

}
