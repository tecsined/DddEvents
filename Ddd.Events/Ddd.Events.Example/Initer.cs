using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddd.Events.Example
{
   public class Initer
    {
        static Initer()
        {
            DomainEvents.Init();
        }
        
    }
}
