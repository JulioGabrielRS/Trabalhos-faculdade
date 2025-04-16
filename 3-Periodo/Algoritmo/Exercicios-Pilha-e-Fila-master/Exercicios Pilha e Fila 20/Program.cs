using System.Collections.Generic;

public class LRUCache<T>
{
    private int capacidade;
    private Queue<T> filaCache;
    private HashSet<T> cacheSet;

    public LRUCache(int capacidade)
    {
        this.capacidade = capacidade;
        this.filaCache = new Queue<T>();
        this.cacheSet = new HashSet<T>();
    }

    public void AcessarElemento(T item)
    {
        if (cacheSet.Contains(item))
        {
            RemoverElemento(item);
            filaCache.Enqueue(item);
        }
        else
        {

            if (filaCache.Count >= capacidade)
            {
                T itemRemovido = filaCache.Dequeue();
                cacheSet.Remove(itemRemovido);
                Console.WriteLine($"Removido do cache: {itemRemovido}");
            }

            filaCache.Enqueue(item);
            cacheSet.Add(item);
        }

        Console.WriteLine($"Elemento acessado: {item}");
        ExibirCache();
    }

    private void RemoverElemento(T item)
    {
        Queue<T> novaFila = new Queue<T>();
        while (filaCache.Count > 0)
        {
            T tempItem = filaCache.Dequeue();
            if (!tempItem.Equals(item))
            {
                novaFila.Enqueue(tempItem);
            }
        }
        filaCache = novaFila;
    }

    private void ExibirCache()
    {
        Console.WriteLine("Estado atual do cache:");
        foreach (var item in filaCache)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {

        LRUCache<string> cache = new LRUCache<string>(3);

        cache.AcessarElemento("A");
        cache.AcessarElemento("B");
        cache.AcessarElemento("C");


        cache.AcessarElemento("D");
        cache.AcessarElemento("B");
        cache.AcessarElemento("E");
    }
}

