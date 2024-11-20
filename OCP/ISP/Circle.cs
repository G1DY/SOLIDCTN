using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.ISP
{
    public class Circle : IShape2D
    {
        public double Radius { get; set; }
        double IShape2D.Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}