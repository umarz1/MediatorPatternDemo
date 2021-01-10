﻿using MediatorPatternDemo.Structural;
using System;

namespace MediatorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var c1 = new Colleague1(mediator);
            var c2 = new Colleague2(mediator);
            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            c1.Send("Hello from C1");
            c2.Send("Hello from C2");
        }
    }
}
