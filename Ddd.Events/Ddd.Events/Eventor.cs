using System.Collections.Generic;
using System.Diagnostics;

namespace Ddd.Events
{
    public abstract class Eventor
    {
        private readonly List<IDomainEvents> _domainEvents = new List<IDomainEvents>();

        public virtual IReadOnlyList<IDomainEvents> DomainEvents => _domainEvents;

        protected virtual void DomainEvent(IDomainEvents domainEvent)
        {
            Debug.Assert(_domainEvents != null, "_domainEvents != null");
            _domainEvents.Add(domainEvent);
        }
        
        public virtual void ClearEvents() => _domainEvents.Clear();
    }
}
