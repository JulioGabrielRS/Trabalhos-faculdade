namespace _1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i <= N; i += 2)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }

            Console.ReadLine();
        }
    }
}