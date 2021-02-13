using Estrutura.Queue;
using Estrutura.Stack;
using System;

using System.Text;

namespace Estrutura
{
    public class DataStructure<T>
    {
        public static MyStack<T> Stack()
        {
            return new MyStack<T>();
        }

        public static MyQueue<T> Queue()
        {
            return new MyQueue<T>();
        }
    }
}