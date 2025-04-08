using System;

class Program
{
    public static int EncontrarMaisProximo(int[] array, int x)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array não pode ser nulo ou vazio");

        if (array.Length == 1)
            return array[0];

        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda < direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == x)
                return array[meio]; 

            if (array[meio] < x)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        if (esquerda == 0)
            return array[0];

        if (esquerda == array.Length - 1)
            return array[array.Length - 1];

        int anterior = array[esquerda - 1];
        int atual = array[esquerda];
        int proximo = esquerda + 1 < array.Length ? array[esquerda + 1] : atual;

        int difAnterior = Math.Abs(anterior - x);
        int difAtual = Math.Abs(atual - x);
        int difProximo = Math.Abs(proximo - x);

        int menorDif = Math.Min(difAnterior, Math.Min(difAtual, difProximo));

        if (menorDif == difAnterior)
            return anterior;
        else if (menorDif == difAtual)
            return atual;
        else
            return proximo;
    }

    static void Main(string[] args)
    {
        int[] arrayOrdenado = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        Console.WriteLine("Array ordenado: " + string.Join(", ", arrayOrdenado));
        Console.Write("Digite o valor de X: ");
        int x = int.Parse(Console.ReadLine());

        int maisProximo = EncontrarMaisProximo(arrayOrdenado, x);

        Console.WriteLine($"O número mais próximo de {x} é: {maisProximo}");
    }
}