using System.Collections;

namespace IteratorWithEnumerableSample
{
    public class ConcreteAggregate : IEnumerable
    {
        private ArrayList _items = new ArrayList();

        public IEnumerator GetEnumerator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return _items[index]; }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public void Add(object o)
        {
            _items.Add(o);
        }
    }
}
