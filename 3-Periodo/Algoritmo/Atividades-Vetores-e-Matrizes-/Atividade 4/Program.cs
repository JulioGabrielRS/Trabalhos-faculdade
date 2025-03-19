class Program
{
    static void Main()
    {
        const int tamanho = 5;
        int[,] matriz = new int[tamanho, tamanho];
        int valor = 1;

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                matriz[i, j] = valor++;
            }
        }

        Console.WriteLine("Valores das diagonais da matriz:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"{matriz[i, i]} {matriz[i, tamanho - 1 - i]}");
        }
    }
}
