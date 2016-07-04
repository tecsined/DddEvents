using System;

namespace Ddd.Events.Example
{
    public class SleepStartedEventHandler : IHandler<SleepStartedEvent>
    {
        public void Handle(SleepStartedEvent domainEvent)
        {
            var name = domainEvent.Name;
            var sleepTime = domainEvent.SleepTime;

            //Test
            Console.WriteLine($"Name: {name}. Sleep began at: {sleepTime}");
        }
    }
}
