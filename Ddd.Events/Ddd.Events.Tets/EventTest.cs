using System.Linq;
using Ddd.Events.Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ddd.Events.Tets
{
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void ShowFlowsOfInitilializeFireAndCaptureDomainEvents()
        {
            //Arrange
            
                //Register event handlers. This should add 
                //on the entry point of the application
                DomainEvents.Init();


                // Created domain objects. These are registering event for wake up and go to sleep.
                var mama = new Mother("Jessica");
                var bebe = new Baby("Benjamin");

                // Create fake listener. This is going to be direct related to the event process.
                var listener = new EventListener();

            //Act

                bebe.GoToSleep(DateTime.Now);
                mama.GoToSleep(DateTime.Now.AddMinutes(20));
                bebe.Wakeup(DateTime.Now.AddHours(2));
                mama.Wakeup(DateTime.Now.AddHours(2));

            //The process of the Event is complete and the 
            //listener recieved the domain on the specific event  
                listener.OnSleepStart(bebe);
                listener.OnSleepStart(mama);
                listener.OnWakeUpStart(bebe);
                listener.OnWakeUpStart(mama);

            //Assert 

            //Events where processed. 
            Assert.IsFalse(bebe.DomainEvents.Any());
               Assert.IsFalse(mama.DomainEvents.Any());
        }
    }
}
