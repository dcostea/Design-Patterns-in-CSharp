using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySample
{
    class Program
    {
        static void Main(string[] args)
        {    
            // Setup Chain of Responsibility
            Approver john = new Director();

            Approver sam = new VicePresident();
            john.SetSuccessor(sam); // john is successor for sam

            Approver jim = new President();
            sam.SetSuccessor(jim); // sam is successor for jim

            // Generate and process purchase requests
            john.HandleRequest(new Purchase { Number = 1, Amount = 350.00, Purpose = "Assets" });
            john.HandleRequest(new Purchase { Number = 2, Amount = 32590.10, Purpose = "Project" });
            john.HandleRequest(new Purchase { Number = 3, Amount = 122100.00, Purpose = "Investment" });


            // Wait for user
            Console.ReadKey(true);
        }
    }
}
