using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
    public class Square : Shapes
    {
        public double SideLength { get; set; }
        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}