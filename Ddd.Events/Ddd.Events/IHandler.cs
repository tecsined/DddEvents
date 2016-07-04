using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddd.Events
{
    public interface IHandler<T> where T: IDomainEvents
    {
        void Handle(T domainEvent);
    }
}
