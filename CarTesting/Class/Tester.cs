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
                    throw new WorkExeption("Двигатель рабочий");
                }
                else
                {
                    throw new NotWorkExeption("Двигатель не рабочий",car);
                }
            }
			catch (NotWorkExeption nwe)
			{
				Console.WriteLine(nwe.Message);
			}
            catch (WorkExeption we)
            {
                Console.WriteLine(we.Message);
            }
        }
    }
}
