using System;

class Program
{
    public static int UltimaOcorrencia(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        int ultimaPosicao = -1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == numero)
            {
                ultimaPosicao = meio;  
                esquerda = meio + 1;   
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

        return ultimaPosicao;
    }

    static void Main(string[] args)
    {
        int[] arrayComRepeticoes = { 2, 2, 5, 5, 5, 5, 8, 9, 9, 9, 10, 12, 12 };

        Console.WriteLine("Array ordenado: " + string.Join(", ", arrayComRepeticoes));
        Console.Write("Digite o número a buscar: ");
        int numero = int.Parse(Console.ReadLine());

        int posicao = UltimaOcorrencia(arrayComRepeticoes, numero);

        if (posicao != -1)
            Console.WriteLine($"Última ocorrência de {numero} na posição {posicao}");
        else
            Console.WriteLine($"Número {numero} não encontrado no array");
    }
}