namespace _1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int menor = Math.Min(X, Y);
            int maior = Math.Max(X, Y);
            int soma = 0;

            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
