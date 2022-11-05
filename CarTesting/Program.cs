using CarTesting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            Engine engine = new Engine(Engine.EngineType.NotWork,"Дизельная батарея");
            Car car = new Car(1,engine);


            Engine jj = new Engine(Engine.EngineType.Work, "Слезы края");
            Car cc = new Car(1, jj);

            Tester Davit = new Tester();

            Davit.Test(car);
            Davit.Test(cc);

            Console.ReadLine();
        }
    }
}
