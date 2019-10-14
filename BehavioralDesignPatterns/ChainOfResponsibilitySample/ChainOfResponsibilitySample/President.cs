using System;

namespace ChainOfResponsibilitySample
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    class President : Approver
    {
        public override void HandleRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number} for amount {purchase.Amount}");
            }
            else
            {
                // no more successors
                Console.WriteLine($"Request# {purchase.Number} requires an executive meeting!");
            }
        }
    }
}
