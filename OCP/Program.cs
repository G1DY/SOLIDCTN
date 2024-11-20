using OCP.ISP;

IShapes3D sphere = new Sphere {Radius = 5};

System.Console.WriteLine($"The SurfaceArea is {sphere.SurfaceArea()}");
System.Console.WriteLine($"The volume is {sphere.Volume()}");
