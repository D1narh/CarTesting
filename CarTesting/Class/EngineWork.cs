using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public class EngineWork : Engine
    {
        public EngineWork(EngineType type, string name) : base(type, name)
        {
        }

        public override void Test()
        {
            var engine = new EngineWork(Type, Name);
            if (Type == EngineType.NotWork)
            {
                throw new NotWorkExeption(engine, DateTime.Now);
            }
            else

                return;
        }
    }
}
