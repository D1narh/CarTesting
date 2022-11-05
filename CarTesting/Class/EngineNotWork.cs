using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTesting.Class
{
    public class EngineNotWork : Engine
    {
        public EngineNotWork(EngineType type, string name) : base(type, name)
        {
        }

        public override void Test()
        {
            var engine = new EngineNotWork(Type, Name);
            if (Type == EngineType.NotWork)
            {
                throw new NotWorkExeption(engine, DateTime.Now);
            }
            else

                return;
        }
    }
}
