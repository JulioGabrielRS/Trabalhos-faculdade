class Program
{
    static void Main()
    {
        const int numAlunos = 10, numNotas = 3;
        string[] alunos = new string[numAlunos];
        double[,] notas = new double[numAlunos, numNotas];
        double[] medias = new double[numAlunos];

        for (int i = 0; i < numAlunos; i++)
        {
            Console.Write($"Digite o nome do {i + 1}º aluno: ");
            alunos[i] = Console.ReadLine();

            double soma = 0;
            for (int j = 0; j < numNotas; j++)
            {
                Console.Write($"Digite a {j + 1}ª nota de {alunos[i]}: ");
                while (!double.TryParse(Console.ReadLine(), out notas[i, j]) || notas[i, j] < 0 || notas[i, j] > 10)
                    Console.Write("Nota inválida. Digite novamente: ");
                soma += notas[i, j];
            }

            medias[i] = soma / numNotas;
        }

        Console.WriteLine("\nRelatório dos alunos:");
        for (int i = 0; i < numAlunos; i++)
        {
            Console.ForegroundColor = medias[i] >= 7.0 ? ConsoleColor.Blue : ConsoleColor.Red;
            Console.WriteLine($"Aluno: {alunos[i]}");
            Console.Write("Notas: ");
            for (int j = 0; j < numNotas; j++)
            {
                Console.Write($"{notas[i, j]:F1} ");
            }
            Console.WriteLine($"| Média: {medias[i]:F1} | {(medias[i] >= 7.0 ? "Aprovado" : "Reprovado")}");
        }
        Console.ResetColor();
    }
}