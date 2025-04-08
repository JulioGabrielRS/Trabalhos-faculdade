using System;
using System.Collections.Generic;

class Program
{
    private static int EncontrarLimiteInferior(int[] array, int valor)
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        int resultado = -1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] >= valor)
            {
                if (array[meio] == valor)
                    resultado = meio;
                direita = meio - 1;
            }
            else
            {
                esquerda = meio + 1;
            }
        }

        return resultado;
    }

    private static int EncontrarLimiteSuperior(int[] array, int valor)
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        int resultado = -1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] <= valor)
            {
                if (array[meio] == valor)
                    resultado = meio;
                esquerda = meio + 1;
            }
            else
            {
                direita = meio - 1;
            }
        }

        return resultado;
    }

    public static List<int> EncontrarTodasOcorrencias(int[] array, int valor)
    {
        List<int> indices = new List<int>();

        int primeiro = EncontrarLimiteInferior(array, valor);
        if (primeiro == -1) return indices; 

        int ultimo = EncontrarLimiteSuperior(array, valor);

        for (int i = primeiro; i <= ultimo; i++)
        {
            if (array[i] == valor)
                indices.Add(i);
        }

        return indices;
    }

    static void Main(string[] args)
    {
        int[] arrayOrdenado = { 1, 2, 2, 2, 3, 4, 4, 4, 4, 5, 6, 6, 7 };

        Console.WriteLine("Array ordenado: " + string.Join(", ", arrayOrdenado));
        Console.Write("Digite o número a buscar: ");
        int numero = int.Parse(Console.ReadLine());

        List<int> ocorrencias = EncontrarTodasOcorrencias(arrayOrdenado, numero);

        if (ocorrencias.Count > 0)
        {
            Console.WriteLine($"O número {numero} aparece {ocorrencias.Count} vezes nos índices:");
            Console.WriteLine(string.Join(", ", ocorrencias));
        }
        else
        {
            Console.WriteLine($"O número {numero} não foi encontrado no array");
        }
    }
}
