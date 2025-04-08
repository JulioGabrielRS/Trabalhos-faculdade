using System;

class Program 
{
    public static int EncontrarPrimeiroMultiplo(int[] array, int x)
    {
        if (x == 0)
        {
            throw new ArgumentException("X não pode ser zero", nameof(x));
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % x == 0)
            {
                return i; 
            }
        }

        return -1; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 7, 12, 5, 21, 8, 15, 10 };
        int x = 3; 

        int indice = EncontrarPrimeiroMultiplo(numeros, x);

        if (indice != -1)
        {
            Console.WriteLine($"O primeiro múltiplo de {x} é {numeros[indice]} no índice {indice}");
        }
        else
        {
            Console.WriteLine($"Nenhum múltiplo de {x} encontrado no array");
        }
    }
}