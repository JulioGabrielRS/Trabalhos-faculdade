class Program
{
    static void Main()
    {
        string[] nomes = { "Emerson", "Maria Clara", "Viviane", "jessica" };
        double[] nota1 = { 10.0, 1.8, 7.9, 2.4 };
        double[] nota2 = { 4.5, 7.0, 8.0, 9.8 };

        Console.WriteLine("Alunos aprovados:");
        for (int i = 0; i < nomes.Length; i++)
        {
            double media = (nota1[i] + nota2[i]) / 2.0;
            if (media >= 6.0)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}