using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternDemo.Structural
{
    public class Colleague1 : Colleague
    {
        public Colleague1(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 recieves notifcation message: {message}");
        }
    }
}
