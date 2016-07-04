﻿using System;

namespace Ddd.Events.Example
{
    public class WakeupStartedEventHandler: IHandler<WakeupStartedEvent>
    {
        public void Handle(WakeupStartedEvent domainEvent)
        {
            var name = domainEvent.Name;
            var wakeupTime = domainEvent.WakeupTime;

            //Test
            Console.WriteLine($@"Name: {name}. Waked up at: {wakeupTime}");
        }
    }
}
