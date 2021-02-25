using Estrutura;
using Estrutura.Queue;
using Estrutura.Sort;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SortTypes sorts = DataStructure.Sorts();

            Console.WriteLine(sorts.ToString());
        }
    }
}