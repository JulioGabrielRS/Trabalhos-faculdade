using System.Collections.Generic;

public class CalculadoraPósFixada
{
    public static int ResolverExpressao(string expressao)
    {

        Stack<int> pilha = new Stack<int>();


        string[] tokens = expressao.Split(' ');

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int numero))
            {
                pilha.Push(numero);
            }
            else
            {

                int operando2 = pilha.Pop();
                int operando1 = pilha.Pop();
                int resultado = 0;

                switch (token)
                {
                    case "+":
                        resultado = operando1 + operando2;
                        break;
                    case "-":
                        resultado = operando1 - operando2;
                        break;
                    case "*":
                        resultado = operando1 * operando2;
                        break;
                    case "/":
                        if (operando2 != 0)
                        {
                            resultado = operando1 / operando2;
                        }
                        else
                        {
                            throw new InvalidOperationException("Divisão por zero não permitida.");
                        }
                        break;
                    default:
                        throw new InvalidOperationException("Operador inválido.");
                }

                pilha.Push(resultado);
            }
        }

        return pilha.Pop();
    }
}

public class Program
{
    public static void Main()
    {

        string expressao = "3 4 + 2 *";
        int resultado = CalculadoraPósFixada.ResolverExpressao(expressao);

        Console.WriteLine($"Resultado da expressão '{expressao}': {resultado}");
    }
}
