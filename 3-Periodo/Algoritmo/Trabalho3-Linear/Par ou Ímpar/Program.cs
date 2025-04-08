using System;

class Program 
{
    public static int EncontrarPrimeiroPar(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            
            if (array[i] % 2 == 0)
            {
                return i; 
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 3, 7, 5, 9, 4, 11, 6, 8 };

        int indicePar = EncontrarPrimeiroPar(numeros);

        if (indicePar != -1)
        {
            Console.WriteLine($"O primeiro número par é {numeros[indicePar]} no índice {indicePar}");
            Console.WriteLine($"Array completo: [{string.Join(", ", numeros)}]");
        }
        else
        {
            Console.WriteLine("Nenhum número par encontrado no array");
        }
    }
}