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
				if (car.Test() == "Двигатель рабочий")
				{
                    Console.WriteLine("Двигатель рабочий");
                    Console.WriteLine("Тестирование прошло успешно");
                }
                else
                {
                    throw new ArgumentException($"Двигатель в машине не рабочий. Дата и время проведение тестирования {System.DateTime.Now}"+
                        $"\nТестироваемый двигатель:  {car.Engine.Name}");
                }

            }
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
        }
    }
}
