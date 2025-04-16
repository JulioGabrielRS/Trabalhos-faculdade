using System.Collections.Generic;

public class MinhaFila<T>
{
    private LinkedList<T> lista;

    public MinhaFila()
    {
        lista = new LinkedList<T>();
    }

    public void Enqueue(T item)
    {
        lista.AddLast(item);
    }

    public T Dequeue()
    {
        if (Count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        T valor = lista.First.Value;
        lista.RemoveFirst();
        return valor;
    }

    public T Peek()
    {
        if (Count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        return lista.First.Value;
    }

    public int Count
    {
        get { return lista.Count; }
    }
}

class Program
{
    static void Main()
    {
        MinhaFila<int> fila = new MinhaFila<int>();

        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);

        Console.WriteLine("Primeiro da fila: " + fila.Peek());
        Console.WriteLine("Quantidade na fila: " + fila.Count);

        Console.WriteLine("Dequeue: " + fila.Dequeue());
        Console.WriteLine("Quantidade na fila após Dequeue: " + fila.Count);

        Console.WriteLine("Dequeue: " + fila.Dequeue());
        Console.WriteLine("Dequeue: " + fila.Dequeue());

        try
        {
            fila.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
