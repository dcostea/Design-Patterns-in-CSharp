using System.Collections;

namespace ObserverSample
{
    public abstract class EventReceiverBase
    {
        private ArrayList _monitors = new ArrayList();

        public void Attach(EventMonitor monitor)
        {
            _monitors.Add(monitor);
        }

        public void Detach(EventMonitor monitor)
        {
            _monitors.Remove(_monitors);
        }

        public void Notify()
        {
            foreach (EventMonitor monitor in _monitors)
            {
                monitor.Update();
            }
        }
    }
}
