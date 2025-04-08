using System;

class Program
{
    public static int PosicaoParaInserir(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == numero)
            {
                return meio; 
            }
            else if (array[meio] < numero)
            {
                esquerda = meio + 1;
            }
            else
            {
                direita = meio - 1;
            }
        }

        return esquerda; 
    }

    static void Main(string[] args)
    {
        int[] arrayOrdenado = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        Console.WriteLine("Array ordenado: " + string.Join(", ", arrayOrdenado));
        Console.Write("Digite o número a ser inserido: ");
        int numero = int.Parse(Console.ReadLine());

        int posicao = PosicaoParaInserir(arrayOrdenado, numero);

        Console.WriteLine($"O número {numero} deve ser inserido na posição {posicao}");
        Console.WriteLine("Array após inserção hipotética:");

        for (int i = 0; i <= arrayOrdenado.Length; i++)
        {
            if (i == posicao)
                Console.Write($"{numero}, ");
            if (i < arrayOrdenado.Length)
                Console.Write($"{arrayOrdenado[i]}" + (i < arrayOrdenado.Length - 1 || posicao == arrayOrdenado.Length ? ", " : ""));
        }
    }
}