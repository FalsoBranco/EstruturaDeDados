using Estrutura.Sort;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var stack = new Stack<int>();
            //Random randomNumber = new Random();
            //for (int i = 0; i < 30; i++)
            //{
            //    stack.Push(randomNumber.Next(1, 25));
            //}
            //Sort sort = new Sort();
            //var array = sort.InsertionSort(stack.ToArray());
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            var stack = new Stack<string>();
            int poped;
            stack.Pop(out poped);
            Console.WriteLine(poped);
        }
    }
}