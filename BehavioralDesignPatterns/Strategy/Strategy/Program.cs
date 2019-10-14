using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();


            // Wait for user
            Console.ReadKey(true);
        }

        /// <summary>
        /// The 'AbstractStrategy' abstract class
        /// </summary>
        abstract class Strategy
        {
            public abstract void AlgorithmInterface();
        }

        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        class ConcreteStrategyA : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
            }
        }

        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        class ConcreteStrategyB : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
            }
        }

        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        class ConcreteStrategyC : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
            }
        }

        /// <summary>
        /// The 'Context' class
        /// </summary>
        class Context
        {
            private Strategy strategy;

            // Constructor
            public Context(Strategy strategy)
            {
                this.strategy = strategy;
            }

            public void ContextInterface()
            {
                strategy.AlgorithmInterface();
            }
        }
    }
}
