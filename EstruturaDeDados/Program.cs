using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int index;
            var pratos = new Stack<int>();
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                pratos.Push(random.Next(1, 100));
            }
            pratos.ShowStack();
            Console.WriteLine(pratos.Search(55, out index));
            Console.WriteLine(index);
        }
    }
}