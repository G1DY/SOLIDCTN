using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.ISP
{
    public class Sphere : IShapes3D
    {
        public double Radius { get; set; }
        public double SurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        }
    }
}