using Estrutura.Queue;
using Estrutura.Stack;
using System;
using Estrutura.Sort;
using System.Text;

namespace Estrutura
{
    static public class DataStructure
    {
        public static MyStack<T> Stack<T>() => new MyStack<T>();

        public static MyQueue<T> Queue<T>() => new MyQueue<T>();

        public static SortTypes Sorts() => new SortTypes();
    }
}