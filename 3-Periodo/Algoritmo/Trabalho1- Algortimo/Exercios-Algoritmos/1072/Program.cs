namespace _1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0;

            for (int i = 0; i < N; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");

            Console.ReadLine();
        }
    }
}
