class Program
{
    static void Main()
    {
        const int tamanho = 10;
        string[] nomes = new string[tamanho];
        double[] precos = new double[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Nome do {i + 1}º produto: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Preço do {i + 1}º produto: ");
            while (!double.TryParse(Console.ReadLine(), out precos[i]) || precos[i] < 0)
            {
                Console.Write("Valor inválido. Digite novamente: ");
            }
        }

        Console.Write("Digite um valor para filtrar produtos: ");
        double valorPesquisa;
        while (!double.TryParse(Console.ReadLine(), out valorPesquisa) || valorPesquisa < 0)
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        Console.WriteLine("Produtos com preço até o valor informado:");
        bool encontrou = false;
        foreach (var (nome, preco) in nomes.Zip(precos, (n, p) => (n, p)))
        {
            if (preco <= valorPesquisa)
            {
                Console.WriteLine($"{nome} - R$ {preco:F2}");
                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Nenhum produto encontrado.");
        }
    }
}
