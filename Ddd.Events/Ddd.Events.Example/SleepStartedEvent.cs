
using System;

namespace Ddd.Events.Example
{
    public class SleepStartedEvent: IDomainEvents
    {
        public string Name { get; }
        public DateTime SleepTime { get; }

        public SleepStartedEvent(DateTime sleepTime, string name)
        {
            Name = name;
            SleepTime = sleepTime;
        }
    }
}
