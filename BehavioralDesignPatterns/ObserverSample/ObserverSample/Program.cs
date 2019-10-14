using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSample
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            //EventReceiver receiver = new EventReceiver();
            //receiver.LogMessage("Message with no observers.");


            //EventReceiver receiver = new EventReceiver();
            //EventMonitor emailMonitor = new EventEmailer(receiver);
            //receiver.Attach(emailMonitor);

            //receiver.LogMessage("Message with one observer.");


            EventReceiver receiver = new EventReceiver();
            EventMonitor emailer = new EventEmailer(receiver);
            receiver.Attach(emailer);
            EventMonitor logger = new EventLogger(receiver);
            receiver.Attach(logger);

            receiver.LogMessage("Message with two observers.");

            Console.ReadKey(true);
        }
    }
}
