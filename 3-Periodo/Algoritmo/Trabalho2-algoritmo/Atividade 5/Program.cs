class Program
{
    static void Main()
    {
        int[] vetor = { 4, 5, 21, 82, 95, 36 };
        var pares = vetor.Where(x => x % 2 == 0).ToArray();
        double media = pares.Average();

        Console.WriteLine($"Media dos numeros pares: {media}");
    }
}