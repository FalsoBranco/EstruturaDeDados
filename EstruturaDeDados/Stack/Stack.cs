using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Stack<T> : IStack<T>
    {
        private readonly List<T> _stack;

        private readonly int _size;

        public Stack()
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
            T removido = _stack[^1];
            Console.WriteLine($"Removendo o {removido}");
            _stack.Remove(_stack[^1]);
        }

        public void Pop(out T removido)
        {
            removido = _stack[^1];
            Console.WriteLine($"Removendo o {removido}");
            _stack.Remove(_stack[^1]);
        }

        public bool Search(T Target)
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

        public bool Search(T Target, out int index)
        {
            index = -1;
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

        public void ShowStack()
        {
            for (int i = _size; i >= 1; i--)
            {
                Console.WriteLine(i + ": " + _stack[i - 1]);
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        string IStack<T>.GetType()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}