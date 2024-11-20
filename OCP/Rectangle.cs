using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
    public class Rectangle : Shapes
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}