using System.Collections.Generic;

public class GerenciadorDeImpressao
{
    private List<Documento> filaDeImpressao;

    public GerenciadorDeImpressao()
    {
        filaDeImpressao = new List<Documento>();
    }

    public void AdicionarDocumento(string nome, int prioridade)
    {
        var documento = new Documento(nome, prioridade);
        filaDeImpressao.Add(documento);
        filaDeImpressao.Sort((d1, d2) => d1.Prioridade.CompareTo(d2.Prioridade));
        Console.WriteLine($"Documento '{nome}' adicionado com prioridade {prioridade}.");
    }

    public void ImprimirProximo()
    {
        if (filaDeImpressao.Count == 0)
        {
            Console.WriteLine("Não há documentos na fila de impressão.");
            return;
        }

        var documento = filaDeImpressao[0];
        filaDeImpressao.RemoveAt(0);
        Console.WriteLine($"Imprimindo documento: {documento.Nome}");
    }

    public void ExibirFila()
    {
        if (filaDeImpressao.Count == 0)
        {
            Console.WriteLine("Fila de impressão vazia.");
            return;
        }

        Console.WriteLine("Documentos na fila de impressão:");
        foreach (var doc in filaDeImpressao)
        {
            Console.WriteLine($"- {doc.Nome} (Prioridade: {doc.Prioridade})");
        }
    }
}

public class Documento
{
    public string Nome { get; }
    public int Prioridade { get; }

    public Documento(string nome, int prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}

public class Program
{
    static void Main()
    {
        GerenciadorDeImpressao gerenciador = new GerenciadorDeImpressao();

        gerenciador.AdicionarDocumento("Relatório Anual", 3);
        gerenciador.AdicionarDocumento("Certificado de Conclusão", 1);
        gerenciador.AdicionarDocumento("Resumo de Vendas", 2);

        gerenciador.ExibirFila();


        Console.WriteLine("\nIniciando a impressão...");
        gerenciador.ImprimirProximo();
        gerenciador.ImprimirProximo();
        gerenciador.ImprimirProximo();

        gerenciador.ImprimirProximo();
    }
}
