
class Program
{
    static void Main()
    {
        double[] vetor = { 40.0, 18.7, 38.7, 15.6 };
        double media = vetor.Average();

        Console.WriteLine($"Media: {media}");
        Console.WriteLine("Elementos abaixo da media:");
        foreach (var num in vetor)
        {
            if (num < media)
            {
                Console.WriteLine(num);
            }
        }
    }
}