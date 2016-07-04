using System;

namespace Ddd.Events.Example
{
    public class Mother: Person
    {
        public Mother(string name) : base(name)
        {}


        public override void GoToSleep(DateTime sleepTime)
        {
            //Do something here
            // ....
            //Register Event
            AddDomainEvent(new SleepStartedEvent(DateTime.Now, Name));

        }

        public override void Wakeup(DateTime wakeupTime)
        {
            //Do something here
            // ....
            //Register Event
            AddDomainEvent(new WakeupStartedEvent(DateTime.Now, Name));
        }
    }
}
