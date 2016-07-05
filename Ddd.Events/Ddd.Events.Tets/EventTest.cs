using System.Linq;
using Ddd.Events.Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ddd.Events.Tets
{
    [TestClass]
    public class EventTest
    {
        

        [TestInitialize]
        public void Initialize()
        {
         
        }

        [TestMethod]
        public void ShowFlowsOfInitilializeFireAndCaptureDomainEvents()
        {
            //Arrange

            //Register event handlers. This should add 
            //on the entry point of the application
            var initer = new Initer();


            // Created domain objects. These are registering event for wake up and go to sleep.
            var mama = new Mother("Jessica");
                var bebe = new Baby("Benjamin");

                // Create fake listener. This is going to be direct related to the event process.
                var listener = new EventListener();

            //Act
                //When the process of the events are completed the 
                //listeners will recieved the domain on the specific events
                //and dispacht events
                //This is simulating that process of firing and listeing events.

                bebe.GoToSleep(DateTime.Now);
                listener.OnSleepStart(bebe);

                mama.GoToSleep(DateTime.Now.AddMinutes(20));
                listener.OnSleepStart(mama);

                bebe.Wakeup(DateTime.Now.AddHours(2));
                listener.OnWakeUpStart(bebe);
                mama.Wakeup(DateTime.Now.AddHours(2));
                listener.OnWakeUpStart(mama);
            
            //Assert 
            Assert.IsFalse(bebe.DomainEvents.Any());
            Assert.IsFalse(mama.DomainEvents.Any());
        }
    }
}
