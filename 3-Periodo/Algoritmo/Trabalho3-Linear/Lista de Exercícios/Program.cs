using System;

class Program 
{
    public static int Buscar(int[] array, int elemento)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                return i; 
            }
        }
        return -1; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50, 60 };
        int elementoProcurado = 40;

        int indice = Buscar(numeros, elementoProcurado);

        if (indice != -1)
        {
            Console.WriteLine($"Elemento {elementoProcurado} encontrado no índice {indice}");
        }
        else
        {
            Console.WriteLine($"Elemento {elementoProcurado} não encontrado no array");
        }
    }
}
