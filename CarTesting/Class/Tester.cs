using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public class Tester // Класс тестировщиков
    {
        public void Test(Car car) //Метод тестированеия
        {
			try
			{
                car.Test();

                Console.WriteLine("Двигатель рабочий");
            }
			catch (NotWorkExeption)
			{
                return;
			}
        }
    }
}
