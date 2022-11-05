using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public class WorkExeption : ArgumentException
    {
        public WorkExeption(string message): base(message)
        {
            Console.WriteLine($"Дата и время проведение тестирования {System.DateTime.Now}");
        }
    }
}
