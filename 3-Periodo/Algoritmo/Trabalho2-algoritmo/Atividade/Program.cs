class Program
{
    static void Main()
    {
        double[] vetor = { 5.0, 7.0, 35.0, 12.0, 14.0, 2.0 };
        double maior = vetor[0];
        int posicao = 0;

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                posicao = i;
            }
        }

        Console.WriteLine($"Maior numero: {maior}");
        Console.WriteLine($"Posicao: {posicao}");
    }
}