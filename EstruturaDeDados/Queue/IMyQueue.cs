using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura.Queue
{
    internal interface IMyQueue<T>
    {
        public bool Add(T item);

        public bool Offer(T item);

        public T Poll();

        public T Element();

        public T Peek();

        public T Remove();
    }
}