using System.Collections.Generic;

public class FilaDePrioridade<T>
{
    private List<Elemento<T>> fila;

    public FilaDePrioridade()
    {
        fila = new List<Elemento<T>>();
    }

    public void Enqueue(T item, int prioridade)
    {
        var elemento = new Elemento<T>(item, prioridade);
        fila.Add(elemento);
        fila.Sort((x, y) => y.Prioridade.CompareTo(x.Prioridade));
    }

    public T Dequeue()
    {
        if (fila.Count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        T item = fila[0].Item;
        fila.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (fila.Count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return fila[0].Item;
    }

    public int Count
    {
        get { return fila.Count; }
    }

    public bool IsEmpty()
    {
        return fila.Count == 0;
    }

    private class Elemento<U>
    {
        public U Item { get; set; }
        public int Prioridade { get; set; }

        public Elemento(U item, int prioridade)
        {
            Item = item;
            Prioridade = prioridade;
        }
    }
}

public class Program
{
    static void Main()
    {
        FilaDePrioridade<string> fila = new FilaDePrioridade<string>();

        fila.Enqueue("Elemento 1", 3);
        fila.Enqueue("Elemento 2", 1);
        fila.Enqueue("Elemento 3", 5);
        fila.Enqueue("Elemento 4", 2);

        Console.WriteLine("Elemento com maior prioridade: " + fila.Peek());

        while (!fila.IsEmpty())
        {
            Console.WriteLine("Atendendo: " + fila.Dequeue());
        }
    }
}

