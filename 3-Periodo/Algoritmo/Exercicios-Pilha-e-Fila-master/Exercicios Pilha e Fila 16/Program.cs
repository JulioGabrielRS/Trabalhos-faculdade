using System.Collections.Generic;

public class Deque<T>
{
    private List<T> lista;

    public Deque()
    {
        lista = new List<T>();
    }

    public void InserirNoInicio(T item)
    {
        lista.Insert(0, item);
    }

    public void InserirNoFinal(T item)
    {
        lista.Add(item);
    }

    public T RemoverDoInicio()
    {
        if (lista.Count == 0)
        {
            throw new InvalidOperationException("Deque vazio.");
        }

        T item = lista[0];
        lista.RemoveAt(0);
        return item;
    }

    public T RemoverDoFinal()
    {
        if (lista.Count == 0)
        {
            throw new InvalidOperationException("Deque vazio.");
        }

        T item = lista[lista.Count - 1];
        lista.RemoveAt(lista.Count - 1);
        return item;
    }

    public T VerNoInicio()
    {
        if (lista.Count == 0)
        {
            throw new InvalidOperationException("Deque vazio.");
        }

        return lista[0];
    }

    public T VerNoFinal()
    {
        if (lista.Count == 0)
        {
            throw new InvalidOperationException("Deque vazio.");
        }

        return lista[lista.Count - 1];
    }

    public bool EstaVazio()
    {
        return lista.Count == 0;
    }

    public int Count
    {
        get { return lista.Count; }
    }

    public void Exibir()
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("Deque vazio.");
            return;
        }

        Console.WriteLine("Elementos no Deque:");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}

public class Program
{
    static void Main()
    {
        Deque<int> deque = new Deque<int>();

        deque.InserirNoInicio(10);
        deque.InserirNoFinal(20);
        deque.InserirNoInicio(5);
        deque.InserirNoFinal(25);

        deque.Exibir();

        Console.WriteLine("\nRemovendo do início: " + deque.RemoverDoInicio());
        Console.WriteLine("Removendo do final: " + deque.RemoverDoFinal());

        deque.Exibir();

        Console.WriteLine("\nInício: " + deque.VerNoInicio());
        Console.WriteLine("Final: " + deque.VerNoFinal());
    }
}
