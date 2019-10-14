using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSample
{
    public class EventLogger : EventMonitor
    {
        private EventReceiver _receiver;

        public EventLogger(EventReceiver receiver)
        {
            _receiver = receiver;
        }

        public override void Update()
        {
            string message = _receiver.GetLastMessage();
            Console.WriteLine("Logging: {0}", message);
        }
    }
}
