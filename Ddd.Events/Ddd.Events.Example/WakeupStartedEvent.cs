using System;

namespace Ddd.Events.Example
{
    public class WakeupStartedEvent : IDomainEvents
    {
        public DateTime WakeupTime { get; }
        public string Name { get;}

        public WakeupStartedEvent(DateTime wakeupTime, string name)
        {
            Name = name;
            WakeupTime = wakeupTime;
        }
    }
}
