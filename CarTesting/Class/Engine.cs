using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public partial class Engine // Класс двигателей
    {
        //Я НАВЕРНОЕ понимаю что тут нужно будет использовать словать (но вы не написали его использовать)

        public static int IdCount = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public EngineType Type { get; set; }

        public Engine (EngineType type, string name)
        {
            ID = IdCount;
            Name = name;
            Type = type;

            IdCount++;
        }

        public string Start(Car car)
        {
            if(Type == EngineType.Work)
            {
                throw new WorkExeption("Двигатель рабочий");
            }
            else
            {
                throw new NotWorkExeption("Двигатель не рабочий",car);
            }
        }
    }
}
