using System;

class Program
{
    public static int BuscaBinaria(int[] array, int numeroProcurado)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == numeroProcurado)
                return meio;

            if (array[meio] < numeroProcurado)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] arrayOrdenado = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.WriteLine("Array ordenado: " + string.Join(", ", arrayOrdenado));
        Console.Write("Digite o número a ser buscado: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = BuscaBinaria(arrayOrdenado, numero);

        if (resultado != -1)
            Console.WriteLine($"Número encontrado no índice {resultado}");
        else
            Console.WriteLine("Número não encontrado no array");
    }
}