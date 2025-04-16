using System.Collections.Generic;

class MinhaPilha<T>
{
    private List<T> elementos = new List<T>();

    public void Push(T item)
    {
        elementos.Add(item);
    }

    public T Pop()
    {
        if (elementos.Count == 0)
            throw new InvalidOperationException("A pilha está vazia.");

        T topo = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        return topo;
    }

    public T Peek()
    {
        if (elementos.Count == 0)
            throw new InvalidOperationException("A pilha está vazia.");

        return elementos[elementos.Count - 1];
    }

    public int Count
    {
        get { return elementos.Count; }
    }
}
class Program
{
    static void Main()
    {
        MinhaPilha<int> pilha = new MinhaPilha<int>();

        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);

        Console.WriteLine("Topo: " + pilha.Peek());
        Console.WriteLine("Removido: " + pilha.Pop());
        Console.WriteLine("Novo topo: " + pilha.Peek());
        Console.WriteLine("Tamanho da pilha: " + pilha.Count);
    }
}
