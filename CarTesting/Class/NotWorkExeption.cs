using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public class NotWorkExeption : ArgumentException
    {
        public NotWorkExeption(string message, Car car) : base(message)
        {
            Console.WriteLine($"Дата и время проведение тестирования {System.DateTime.Now}\nТестироваемый двигатель:  {car.Engine.Name}");
        }
    }

}
