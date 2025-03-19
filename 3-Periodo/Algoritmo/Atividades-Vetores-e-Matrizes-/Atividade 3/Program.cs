class Program
{
    static void Main()
    {
        const int linhas = 3, colunas = 5;
        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                    Console.Write("Valor inválido. Tente novamente: ");
            }
        }

        Console.WriteLine("Soma de cada linha:");
        for (int i = 0; i < linhas; i++)
        {
            int soma = 0;
            foreach (int valor in matriz.GetRow(i))
                soma += valor;
            Console.WriteLine($"Linha {i + 1}: {soma}");
        }
    }
}

static class MatrixExtensions
{
    public static int[] GetRow(this int[,] matrix, int row)
    {
        int colunas = matrix.GetLength(1);
        int[] linha = new int[colunas];
        for (int i = 0; i < colunas; i++)
            linha[i] = matrix[row, i];
        return linha;
    }
}
