using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> fila = new Queue<int>();
        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);
        fila.Enqueue(4);
        fila.Enqueue(5);

        Console.WriteLine("Fila original:");
        MostrarFila(fila);

        Stack<int> pilha = new Stack<int>();
        while (fila.Count > 0)
        {
            pilha.Push(fila.Dequeue());
        }

        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }

        Console.WriteLine("\nFila invertida:");
        MostrarFila(fila);
    }

    static void MostrarFila(Queue<int> fila)
    {
        foreach (int item in fila)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}