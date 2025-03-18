class Program
{
    static void Main()
    {
        string[] nomes = { "Emerson", "Vitoria", "Laura", "Julia", "Paula" };
        int[] idades = { 19, 28, 12, 27, 45 };

        int indiceMaior = 0;
        for (int i = 1; i < idades.Length; i++)
        {
            if (idades[i] > idades[indiceMaior])
            {
                indiceMaior = i;
            }
        }

        Console.WriteLine($"A Pessoa mais velha: {nomes[indiceMaior]}");
    }
}