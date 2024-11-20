using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.DIP
{
    public class Car
    {
        private IEngine engine;
        public Car(IEngine engine)
        {
            this.engine = engine;
        }
        public void startCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started");
        }
    }
}