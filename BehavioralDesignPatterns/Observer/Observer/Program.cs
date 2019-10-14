using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();


            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'AbstractSubject' abstract class
    /// </summary>
    abstract class AbstractSubject
    {
        private List<AbstractObserver> observers = new List<AbstractObserver>();

        public void Attach(AbstractObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(AbstractObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (AbstractObserver o in observers)
            {
                o.Update();
            }
        }
    }

    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class ConcreteSubject : AbstractSubject
    {
        public string SubjectState { get; set; }
    }

    /// <summary>
    /// The 'AbstractObserver' abstract class
    /// </summary>
    abstract class AbstractObserver
    {
        public abstract void Update();
    }

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    class ConcreteObserver : AbstractObserver
    {
        private string name;
        private string observerState;
        public ConcreteSubject Subject { get; set; }

        // Constructor
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = Subject.SubjectState;
            Console.WriteLine($"Observer {name}'s new state is {observerState}");
        }
    }
}
