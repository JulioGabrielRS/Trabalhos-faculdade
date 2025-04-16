using System;

public class FilaCircular<T>
{
    private T[] fila;
    private int frente;
    private int traseira;
    private int capacidade;
    private int tamanho;

    public FilaCircular(int capacidade)
    {
        this.capacidade = capacidade;
        fila = new T[capacidade];
        frente = 0;
        traseira = 0;
        tamanho = 0;
    }

    public void Enqueue(T item)
    {
        if (tamanho == capacidade)
        {
            throw new InvalidOperationException("A fila está cheia.");
        }

        fila[traseira] = item;
        traseira = (traseira + 1) % capacidade;
        tamanho++;
    }

    public T Dequeue()
    {
        if (tamanho == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        T item = fila[frente];
        frente = (frente + 1) % capacidade;
        tamanho--;
        return item;
    }

    public T Peek()
    {
        if (tamanho == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return fila[frente];
    }

    public int Count
    {
        get { return tamanho; }
    }

    public bool IsEmpty()
    {
        return tamanho == 0;
    }

    public bool IsFull()
    {
        return tamanho == capacidade;
    }
}

public class Program
{
    static void Main()
    {
        Console.Write("Digite a capacidade da fila circular: ");
        int capacidade = int.Parse(Console.ReadLine());

        FilaCircular<int> fila = new FilaCircular<int>(capacidade);

        try
        {
            fila.Enqueue(10);
            fila.Enqueue(20);
            fila.Enqueue(30);

            Console.WriteLine("Primeiro item: " + fila.Peek());

            Console.WriteLine("Dequeue: " + fila.Dequeue());
            Console.WriteLine("Dequeue: " + fila.Dequeue());

            fila.Enqueue(40);
            fila.Enqueue(50);

            Console.WriteLine("Primeiro item: " + fila.Peek());

            fila.Enqueue(60);
            fila.Enqueue(70);

            Console.WriteLine("Dequeue: " + fila.Dequeue());
            Console.WriteLine("Dequeue: " + fila.Dequeue());
            Console.WriteLine("Dequeue: " + fila.Dequeue());
            Console.WriteLine("Dequeue: " + fila.Dequeue());
            Console.WriteLine("Dequeue: " + fila.Dequeue());
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

