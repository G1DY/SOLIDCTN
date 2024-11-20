using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.ISP
{
    public interface IShapes3D
    {
        double SurfaceArea();
        double Volume();
    }
}