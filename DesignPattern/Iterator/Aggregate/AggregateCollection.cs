﻿using Iterator.Interfaces;
using Iterator.Iterator;
using System.Collections;

namespace Iterator.Aggregate
{
    public class AggregateCollection : IAggregate
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new IteratorCollection(this);
        }

        public int Count()
        {
            return _items.Count;
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public void Add(object value)
        {
            _items.Insert(Count(), value);
        }
    }
}
