using System;

interface IPagamento
{
    void ProcessarPagamento(decimal valor);
}

class PagamentoCartaoCredito : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado no cartão de crédito.");
    }
}

class PagamentoBoleto : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado via boleto bancário.");
    }
}

class PagamentoPix : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado via PIX.");
    }
}

class LojaVirtual
{
    public void RealizarPagamento(IPagamento metodo, decimal valor)
    {
        metodo.ProcessarPagamento(valor);
    }
}

class Program
{
    static void Main()
    {
        var loja = new LojaVirtual();

        Console.WriteLine("Selecione o método:");
        Console.WriteLine("1. Cartão de Crédito");
        Console.WriteLine("2. Boleto");
        Console.WriteLine("3. PIX");
        Console.Write("Opção: ");

        IPagamento metodo = Console.ReadLine() switch
        {
            "1" => new PagamentoCartaoCredito(),
            "2" => new PagamentoBoleto(),
            "3" => new PagamentoPix(),
            _ => throw new Exception("Opção inválida")
        };

        Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        loja.RealizarPagamento(metodo, valor);
    }
}