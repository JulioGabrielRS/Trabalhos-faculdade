using System;

class Program 
{
    public static int BuscarUltimaOcorrencia(int[] array, int elemento)
    {
        int ultimoIndice = -1; 

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                ultimoIndice = i; 
            }
        }

        return ultimoIndice;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 20, 50, 20, 60 };
        int elementoProcurado = 20;

        int ultimoIndice = BuscarUltimaOcorrencia(numeros, elementoProcurado);

        if (ultimoIndice != -1)
        {
            Console.WriteLine($"A última ocorrência de {elementoProcurado} está no índice {ultimoIndice}");
            Console.WriteLine($"Array: [{string.Join(", ", numeros)}]");
        }
        else
        {
            Console.WriteLine($"Elemento {elementoProcurado} não encontrado no array");
        }
    }
}