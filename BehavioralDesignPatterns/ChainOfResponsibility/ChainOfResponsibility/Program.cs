using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            AbstractHandler h1 = new ConcreteHandler1();
            AbstractHandler h2 = new ConcreteHandler2();
            AbstractHandler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 20, 5, 0, -5, 220, 18, 7 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The 'AbstractHandler' abstract class
        /// </summary>
        abstract class AbstractHandler
        {
            protected AbstractHandler successor;

            public void SetSuccessor(AbstractHandler successor)
            {
                this.successor = successor;
            }

            public abstract void HandleRequest(int request);
        }

        /// <summary>
        /// The 'ConcreteHandler1' class
        /// </summary>
        class ConcreteHandler1 : AbstractHandler
        {
            public override void HandleRequest(int request)
            {
                if (request <= 0)
                {
                    Console.WriteLine($"{request} -> frozen");
                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }

        /// <summary>
        /// The 'ConcreteHandler2' class
        /// </summary>
        class ConcreteHandler2 : AbstractHandler
        {
            public override void HandleRequest(int request)
            {
                if (request > 0 && request < 100)
                {
                    Console.WriteLine($"{request} -> liquid");
                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }

        /// <summary>
        /// The 'ConcreteHandler3' class
        /// </summary>
        class ConcreteHandler3 : AbstractHandler
        {
            public override void HandleRequest(int request)
            {
                if (request >= 100)
                {
                    Console.WriteLine($"{request} -> steam");
                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }
    }
}
