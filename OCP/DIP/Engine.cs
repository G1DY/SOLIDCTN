using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.DIP
{
    public class Engine : IEngine
    {
        public void Start()
        {
            System.Console.WriteLine("Car Started");
        }
    }
}