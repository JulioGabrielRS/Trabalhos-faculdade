namespace _1155
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N;
            int valor;

            N = new int[10];
            valor = int.Parse(Console.ReadLine());

            N[0] = valor;

            for (int i = 1; i < 10; i++)
            {
                N[i] = N[i - 1] - 1;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("N[" + i + "] = " + N[i]);
            }

            Console.ReadLine();
        }
    }
}
