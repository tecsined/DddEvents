using System;

namespace Ddd.Events.Example
{
    public  abstract class Person : Eventor
    {
        public string Name { get;}

        protected Person(string name)
        { Name = name; }

        public abstract void GoToSleep(DateTime sleepTime);

        public abstract void Wakeup(DateTime wakeupTime);
    }
}
