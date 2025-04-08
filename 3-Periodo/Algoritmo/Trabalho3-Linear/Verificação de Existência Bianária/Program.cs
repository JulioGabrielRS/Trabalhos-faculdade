using System;

class Program
{
    public static bool NumeroExiste(int[] arrayOrdenado, int numeroProcurado)
    {
        int esquerda = 0;
        int direita = arrayOrdenado.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (arrayOrdenado[meio] == numeroProcurado)
                return true;  

            if (arrayOrdenado[meio] < numeroProcurado)
                esquerda = meio + 1;  
            else
                direita = meio - 1;    
        }

        return false; 
    }

    static void Main(string[] args)
    {
        int[] numerosOrdenados = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        Console.WriteLine("Array ordenado: " + string.Join(", ", numerosOrdenados));
        Console.Write("Digite o número a verificar: ");
        int numero = int.Parse(Console.ReadLine());

        bool existe = NumeroExiste(numerosOrdenados, numero);

        Console.WriteLine($"O número {numero} {(existe ? "existe" : "não existe")} no array");
    }
}