using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public class NotWorkExeption : ArgumentException
    {
        public NotWorkExeption(Engine engine,DateTime date)
        {
            Console.WriteLine($"Дата и время проведение тестирования {date}\nТестироваемый двигатель:  {engine.Name}\nДвигатель не рабочий");
        }
    }

}
