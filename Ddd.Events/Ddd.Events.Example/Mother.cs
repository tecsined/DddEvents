using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddd.Events.Example
{
    public class Mother: Person
    {
        public Mother(string name) : base(name)
        {}


        public override void GoToSleep(DateTime sleepTime)
        {
            throw new NotImplementedException();
        }

        public override void Wakeup(DateTime wakeupTime)
        {
            throw new NotImplementedException();
        }
    }
}
