using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma sequência de parênteses: ");
        string sequencia = Console.ReadLine();

        if (EstaBalanceada(sequencia))
        {
            Console.WriteLine("Sequência VÁLIDA (balanceada).");
        }
        else
        {
            Console.WriteLine("Sequência INVÁLIDA (não balanceada).");
        }
    }

    static bool EstaBalanceada(string seq)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char c in seq)
        {
            if (c == '(')
            {
                pilha.Push(c);
            }
            else if (c == ')')
            {
                if (pilha.Count == 0)
                {
                    return false;
                }
                pilha.Pop();
            }
        }

        return pilha.Count == 0;
    }
}