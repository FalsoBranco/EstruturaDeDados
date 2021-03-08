using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura.Sort
{
    public class SortTypes
    {
        public int[] InsertionSort(int[] vet)
        {
            int TamanhoArray = vet.Length; // Tamanho da Lista
            for (int i = 1; i < TamanhoArray; i++) //  Itera do arr[1] (segundo elemento) ate arr[n] (n-esimo elemento) da lista
            {
                int elementoAtual = vet[i]; // elemento que sera movido
                int Antecessor = i - 1; // um elemento antes

                while (Antecessor >= 0 && vet[Antecessor] > elementoAtual) // enqunato o elemento anterior é maior que o elemento que sera movido
                {
                    vet[Antecessor + 1] = vet[Antecessor]; // move o elemento antecesor  para uma posição acima
                    Antecessor--; // elemento antecessor -1
                }
                vet[Antecessor + 1] = elementoAtual;
            }
            return vet;
        }

        public int[] BubbleSort(int[] vet)
        {
            int tamanhoLista = vet.Length;

            for (int iteracaoExterna = 0; iteracaoExterna < tamanhoLista; iteracaoExterna++)
            {
                for (int iteracaoInterna = 0; iteracaoInterna < tamanhoLista - 1; iteracaoInterna++)
                {
                    if (vet[iteracaoInterna] > vet[iteracaoInterna + 1])
                    {
                        var t = vet[iteracaoInterna + 1];
                        vet[iteracaoInterna + 1] = vet[iteracaoInterna];
                        vet[iteracaoInterna] = t;
                    }
                }
            }

            return vet;
        }

        public override string ToString()
        {
            return "Sorts(InsertionSort)";
        }
    }
}