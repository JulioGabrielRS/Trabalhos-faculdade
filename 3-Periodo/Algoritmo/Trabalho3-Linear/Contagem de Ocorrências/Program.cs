using System;

class Program
{
    public static int ContarOcorrencias(int[] array, int elemento)
    {
        int contador = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                contador++; 
            }
        }

        return contador; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 20, 50, 20, 60 };
        int elementoProcurado = 20;

        int totalOcorrencias = ContarOcorrencias(numeros, elementoProcurado);

        Console.WriteLine($"O elemento {elementoProcurado} aparece {totalOcorrencias} vezes no array");
    }
}