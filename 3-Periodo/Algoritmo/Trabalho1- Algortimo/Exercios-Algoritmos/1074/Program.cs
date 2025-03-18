namespace _1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    string paridade = (valor % 2 == 0) ? "EVEN" : "ODD";
                    string sinal = (valor > 0) ? "POSITIVE" : "NEGATIVE";

                    Console.WriteLine($"{paridade} {sinal}");
                }
            }

            Console.ReadLine();
        }
    }
}
