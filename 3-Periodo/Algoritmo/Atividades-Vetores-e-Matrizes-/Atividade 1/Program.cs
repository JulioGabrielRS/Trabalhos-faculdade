class Program
{
    static void Main()
    {
        int[] vetor = new int[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números nas posições pares:");
        for (int i = 0; i < 15; i += 2) 
        {
            Console.WriteLine(vetor[i]);
        }
    }
}
