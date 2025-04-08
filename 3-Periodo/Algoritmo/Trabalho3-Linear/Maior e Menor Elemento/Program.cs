using System;

class Program 
{
    public static void EncontrarMaiorEMenor(int[] numeros, out int maior, out int menor)
    {
        if (numeros == null || numeros.Length == 0)
        {
            throw new ArgumentException("O array não pode ser nulo ou vazio");
        }

        maior = numeros[0];
        menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i]; 
            }
            else if (numeros[i] < menor)
            {
                menor = numeros[i]; 
            }
        }
    }

    static void Main(string[] args)
    {
        int[] numeros = { 14, 43, 7, 53, 86, 19, 3, 67 };

        EncontrarMaiorEMenor(numeros, out int maior, out int menor);

        Console.WriteLine($"Array: [{string.Join(", ", numeros)}]");
        Console.WriteLine($"Maior elemento: {maior}");
        Console.WriteLine($"Menor elemento: {menor}");
    }
}