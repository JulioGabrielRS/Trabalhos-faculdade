using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pilha = new Stack<int>();

        Console.WriteLine("A pilha está vazia? " + (pilha.Count == 0));

        pilha.Push(10);
        pilha.Push(20);

        Console.WriteLine("A pilha está vazia? " + (pilha.Count == 0));
    }
}