using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create adapter and place a request
            ITarget target = new Adapter();
            target.Request();
        }

        class Client
        {
            private ITarget target;

            public Client(ITarget target)
            {
                this.target = target;
            }

            public void MakeRequest()
            {
                target.Request();
            }
        }

        /// <summary>
        /// The 'Target' class
        /// </summary>
        interface ITarget
        {
            void Request();
        }

        /// <summary>
        /// The 'Adapter' class
        /// </summary>
        class Adapter : ITarget
        {
            public void Request()
            {
                // Possibly do some other work and then call SpecificRequest
                Adaptee adaptee = new Adaptee();
                adaptee.SpecificRequest();
            }
        }

        /// <summary>
        /// The 'Adaptee' class
        /// </summary>
        class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
    }
}
