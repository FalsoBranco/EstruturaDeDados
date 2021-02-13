using System;
using System.Collections.Generic;

namespace Estrutura.Stack
{
    public class MyStack<T> : IMyStack<T>
    {
        private readonly List<T> _stack;

        private readonly int _size;

        private bool CheckHasItem()
        {
            return _stack.Count > 0;
        }

        public MyStack()
        {
            _stack = new List<T>();
            _size = _stack.Count;
        }

        public void Push(T item)
        {
            _stack.Add(item);
        }

        public void Pop()
        {
            if (CheckHasItem())
            {
                _stack.Remove(_stack[^1]);
            }
        }

        public void Pop(out T removido)
        {
            removido = default;
            if (CheckHasItem())
            {
                removido = _stack[^1];
                _stack.Remove(_stack[^1]);
            }
        }

        public bool Search(T Target)
        {
            if (CheckHasItem())
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_stack[i].Equals(Target))
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public bool Search(T Target, out int index)
        {
            index = -1;
            if (CheckHasItem())
            {
                for (int i = 0; i < _stack.Count; i++)
                {
                    if (_stack[i].Equals(Target))
                    {
                        index = i;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public void ShowStack()
        {
            _stack.ForEach((number) => Console.WriteLine(number));
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public T Peek()
        {
            return _stack[^1];
        }

        public T[] ToArray()
        {
            return _stack.ToArray();
        }

        string IMyStack<T>.GetType()
        {
            throw new NotImplementedException();
        }
    }
}