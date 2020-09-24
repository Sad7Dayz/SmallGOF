using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class ConcreteAggregate : Aggregate
    {
        private ArrayList _item = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get
            {
                return _item.Count;
            }
        }

        public object this[int index]
        {
            get
            {
                return _item[index];
            }
            set
            {
                _item.Insert(index, value);
            }
        }
    }
}
