namespace _1097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jInicio = 7;

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = jInicio; j >= jInicio - 2; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
                jInicio += 2;
            }

            Console.ReadLine();
        }
    }
}
