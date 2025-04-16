using System.Collections.Generic;

public class Pilha<T>
{
    private List<T> elementos;

    public Pilha()
    {
        elementos = new List<T>();
    }

    public void Push(T item)
    {
        elementos.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A pilha está vazia.");

        T item = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A pilha está vazia.");

        return elementos[elementos.Count - 1];
    }

    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }

    public int Count
    {
        get { return elementos.Count; }
    }
}

public class Program
{
    static void Main()
    {
        Console.Write("Digite um número decimal: ");
        int numeroDecimal = int.Parse(Console.ReadLine());

        Pilha<int> pilha = new Pilha<int>();

        while (numeroDecimal > 0)
        {
            pilha.Push(numeroDecimal % 2);
            numeroDecimal /= 2;
        }

        Console.Write("Número binário: ");
        while (!pilha.IsEmpty())
        {
            Console.Write(pilha.Pop());
        }
        Console.WriteLine();
    }
}

