class Program
{
    static void Main()
    {
        int[] vetor = { 7, 4, 18, 25, 45, 70 };
        var pares = vetor.Where(x => x % 2 == 0).ToArray();

        Console.WriteLine("Numeros pares: " + string.Join(" ", pares));
        Console.WriteLine($"Quantidade de numeros pares: {pares.Length}");
    }
}