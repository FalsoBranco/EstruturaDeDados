using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura.Queue
{
    public class MyQueue<T> : IMyQueue<T>
    {
        private readonly List<T> _queue;
        private readonly int _size;

        public MyQueue()
        {
            _queue = new List<T>();
            _size = _queue.Count;
        }

        private bool CheckEmpty() => _queue.Count > 0;

        public bool Add(T item)
        {
            try
            {
                _queue.Add(item);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public T Element()
        {
            if (CheckEmpty())
            {
                return _queue[0];
            }
            else
            {
                throw new Exception("Could not return from empty queue");
            }
        }

        public bool Offer(T item)
        {
            try
            {
                _queue.Add(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public T Peek() => CheckEmpty() ? _queue[0] : default(T);

        public T Poll()
        {
            if (CheckEmpty())
            {
                T head = _queue[0];
                _queue.RemoveAt(0);
                return head;
            }
            else
            {
                return default;
            }
        }

        public T Remove()
        {
            if (CheckEmpty())
            {
                T head = _queue[0];
                _queue.RemoveAt(0);
                return head;
            }
            else
            {
                throw new Exception("Empty queue");
            }
        }
    }
}