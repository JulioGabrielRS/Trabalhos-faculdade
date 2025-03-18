using System.Globalization;

namespace _1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int total = 0, coelhos = 0, ratos = 0, sapos = 0;

            for (int i = 0; i < N; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(entrada[0]);
                char tipo = char.Parse(entrada[1]);

                total += quantidade;

                if (tipo == 'C') coelhos += quantidade;
                else if (tipo == 'R') ratos += quantidade;
                else if (tipo == 'S') sapos += quantidade;
            }

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {(coelhos * 100.0 / total).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {(ratos * 100.0 / total).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {(sapos * 100.0 / total).ToString("F2", CultureInfo.InvariantCulture)} %");

            Console.ReadLine();
        }
    }
}
