using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura.Stack
{
    public interface IMyStack<T>
    {
        public void Push(T item);

        public void Clear();

        public string GetType();

        public void Pop();

        public void Pop(out T removido);

        public bool Search(T Target);

        public bool Search(T Target, out int index);

        public void ShowStack();

        public T Peek();
    }
}