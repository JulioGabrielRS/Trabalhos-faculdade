class Program
{
    static void Main()
    {
        string[] nomes = { "Carne", "Batata", "Feijão", "Arroz" };
        double[] precoCompra = { 70.00, 25.00, 12.00, 35.00 };
        double[] precoVenda = { 120.00, 35.00, 20.00, 42.00 };

        int lucroAbaixo10 = 0, lucroEntre10e20 = 0, lucroAcima20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

        for (int i = 0; i < nomes.Length; i++)
        {
            double lucro = (precoVenda[i] - precoCompra[i]) / precoCompra[i] * 100;

            if (lucro < 10) lucroAbaixo10++;
            else if (lucro <= 20) lucroEntre10e20++;
            else lucroAcima20++;

            totalCompra += precoCompra[i];
            totalVenda += precoVenda[i];
            lucroTotal += (precoVenda[i] - precoCompra[i]);
        }

        Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo10}");
        Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Lucro acima de 20%: {lucroAcima20}");
        Console.WriteLine($"Valor total de compra: {totalCompra}");
        Console.WriteLine($"Valor total de venda: {totalVenda}");
        Console.WriteLine($"Lucro total: {lucroTotal}");
    }
}