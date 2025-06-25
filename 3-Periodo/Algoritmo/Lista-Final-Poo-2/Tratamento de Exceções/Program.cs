using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Resultado: {num1 / num2}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
            }
        }
    }
}
