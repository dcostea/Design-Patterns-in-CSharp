using System;
using System.Collections;

namespace IteratorWithEnumerableSample
{
    public class ConcreteIterator : IEnumerator
    {
        private ConcreteAggregate _aggregate;
        int _position;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
            _position = 0;
        }

        public void Reset()
        {
            _position = -1;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _aggregate.Count;
        }

        public object Current
        {
            get
            {
                if (_position < _aggregate.Count)
                    return _aggregate[_position];
                else
                    throw new InvalidOperationException();
            }
        }
    }
}
