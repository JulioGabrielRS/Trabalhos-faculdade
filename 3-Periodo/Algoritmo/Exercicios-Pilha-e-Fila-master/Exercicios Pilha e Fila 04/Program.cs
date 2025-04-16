using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();

        Console.WriteLine("A fila está vazia? " + (fila.Count == 0));

        fila.Enqueue("Kelly");
        fila.Enqueue("Emerson");

        Console.WriteLine("A fila está vazia? " + (fila.Count == 0));
    }
}