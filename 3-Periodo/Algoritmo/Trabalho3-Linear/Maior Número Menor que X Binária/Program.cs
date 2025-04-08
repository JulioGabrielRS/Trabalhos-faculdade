using System;

class Program
{
    public static int MaiorNumeroMenorQueX(int[] array, int x)
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        int resultado = -1; 

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] < x)
            {
                resultado = array[meio]; 
                esquerda = meio + 1;    
            }
            else
            {
                direita = meio - 1;    
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        int[] arrayOrdenado = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.WriteLine("Array ordenado: " + string.Join(", ", arrayOrdenado));
        Console.Write("Digite o valor de X: ");
        int x = int.Parse(Console.ReadLine());

        int resultado = MaiorNumeroMenorQueX(arrayOrdenado, x);

        if (resultado != -1)
            Console.WriteLine($"O maior número menor que {x} é: {resultado}");
        else
            Console.WriteLine($"Não existe número menor que {x} no array");
    }
}