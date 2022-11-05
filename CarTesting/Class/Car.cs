using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public class Car //Класс машин
    {
        public int Id { get; set; }
        public Engine Engine { get; set; }

        public Car(int id, Engine engine)
        {
            Id = id;
            Engine = engine;
        }

        public string Test(Car car)
        {
            car = new Car(Id, Engine);
            return Engine.Start(car);
        }
    }
}
