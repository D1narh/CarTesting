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

            Engine engineNumber1 = new Engine(Engine.EngineType.NotWork,"Дизельный двигатель");
            Car pyatyorka = new Car(1, engineNumber1);

            Console.WriteLine("");
            Engine engineNumber2 = new Engine(Engine.EngineType.Work, "Литьевые батарейки");
            Car tesla = new Car(1, engineNumber2);

            Tester Davit = new Tester();

            Davit.Test(pyatyorka);
            Davit.Test(tesla);

            Console.ReadLine();
        }
    }
}
