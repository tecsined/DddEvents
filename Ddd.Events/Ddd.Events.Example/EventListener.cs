using System;

namespace Ddd.Events.Example
{
    /// <summary>
    ///     Listerner simulator.
    ///     This calls should by related to mechanism
    ///     that is used for the domain object to complete
    ///     its transaction. This could be related to ORM or a Repository
    /// </summary>
    public class EventListener
    {
        public void OnSleepStart(Person person)
        {
            DispatchEvent(person);
        }

        public void OnWakeUpStart(Person person)
        {
            DispatchEvent(person);
        }

        internal void DispatchEvent(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));

            foreach (var domainEvent in person.DomainEvents)
            {
                DomainEvents.Dispatch(domainEvent);
            }

            person.ClearEvents();
        }
    }
}
