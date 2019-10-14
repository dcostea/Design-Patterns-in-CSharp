using System;

namespace ObserverSample
{
    public class EventEmailer : EventMonitor
    {
        private EventReceiver _receiver;

        public EventEmailer(EventReceiver receiver)
        {
            _receiver = receiver;
        }

        public override void Update()
        {
            string message = _receiver.GetLastMessage();
            Console.WriteLine("Emailing: {0}", message);
        }
    }
}
