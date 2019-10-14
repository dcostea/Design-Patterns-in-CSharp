namespace ObserverSample
{
    public class EventReceiver : EventReceiverBase
    {
        private string _lastMessage;

        public string GetLastMessage()
        {
            return _lastMessage;
        }

        public void LogMessage(string message)
        {
            _lastMessage = message;
            Notify();
        }
    }
}
