using System.Collections.Generic;

public class SistemaUndoRedo
{
    private Stack<string> pilhaDesfazer;
    private Stack<string> pilhaRefazer;

    public SistemaUndoRedo()
    {
        pilhaDesfazer = new Stack<string>();
        pilhaRefazer = new Stack<string>();
    }

    public void AdicionarAcao(string acao)
    {
        pilhaDesfazer.Push(acao);
        pilhaRefazer.Clear();
        Console.WriteLine($"Ação '{acao}' adicionada.");
    }

    public void Desfazer()
    {
        if (pilhaDesfazer.Count > 0)
        {
            string ultimaAcao = pilhaDesfazer.Pop();
            pilhaRefazer.Push(ultimaAcao);
            Console.WriteLine($"Ação '{ultimaAcao}' desfeita.");
        }
        else
        {
            Console.WriteLine("Não há ações para desfazer.");
        }
    }

    public void Refazer()
    {
        if (pilhaRefazer.Count > 0)
        {
            string ultimaAcao = pilhaRefazer.Pop();
            pilhaDesfazer.Push(ultimaAcao);
            Console.WriteLine($"Ação '{ultimaAcao}' refeita.");
        }
        else
        {
            Console.WriteLine("Não há ações para refazer.");
        }
    }

    public void ExibirEstado()
    {
        Console.WriteLine("\nAções realizadas:");
        foreach (var acao in pilhaDesfazer)
        {
            Console.WriteLine($"- {acao}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        SistemaUndoRedo sistema = new SistemaUndoRedo();

        sistema.AdicionarAcao("Ação 1");
        sistema.AdicionarAcao("Ação 2");
        sistema.AdicionarAcao("Ação 3");

        sistema.ExibirEstado();

        Console.WriteLine("\nDesfazendo ações...");
        sistema.Desfazer();
        sistema.Desfazer();

        sistema.ExibirEstado();

        Console.WriteLine("\nRefazendo ação...");
        sistema.Refazer();

        sistema.ExibirEstado();
    }
}

