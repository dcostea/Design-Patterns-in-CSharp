using System;

namespace ChainOfResponsibilitySample
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    class Director : Approver
    {
        public override void HandleRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number} for amount {purchase.Amount}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(purchase);
            }
        }
    }
}
