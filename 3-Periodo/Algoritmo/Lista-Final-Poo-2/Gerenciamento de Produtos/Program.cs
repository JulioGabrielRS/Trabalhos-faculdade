using System;
using System.Collections.Generic;
using System.Linq;

class Produto
{
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
}

class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main()
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Remover Produto");
            Console.WriteLine("3. Pesquisar Produto");
            Console.WriteLine("4. Mostrar Mais Barato");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CadastrarProduto();
                    break;
                case "2":
                    RemoverProduto();
                    break;
                case "3":
                    PesquisarProduto();
                    break;
                case "4":
                    MostrarMaisBarato();
                    break;
                case "5":
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void CadastrarProduto()
    {
        var produto = new Produto();

        Console.Write("Descrição: ");
        produto.Descricao = Console.ReadLine();

        Console.Write("Valor: ");
        produto.Valor = decimal.Parse(Console.ReadLine());

        produtos.Add(produto);
        Console.WriteLine("Produto cadastrado!");
    }

    static void RemoverProduto()
    {
        Console.Write("Digite a descrição: ");
        string desc = Console.ReadLine();

        var produto = produtos.FirstOrDefault(p => p.Descricao == desc);
        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado!");
            return;
        }

        produtos.Remove(produto);
        Console.WriteLine("Produto removido!");
    }

    static void PesquisarProduto()
    {
        Console.Write("Digite a descrição: ");
        string desc = Console.ReadLine();

        var produto = produtos.FirstOrDefault(p => p.Descricao == desc);
        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado!");
            return;
        }

        Console.WriteLine($"Descrição: {produto.Descricao} | Valor: R${produto.Valor}");
    }

    static void MostrarMaisBarato()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado!");
            return;
        }

        var maisBarato = produtos.OrderBy(p => p.Valor).First();
        Console.WriteLine($"Mais barato: {maisBarato.Descricao} - R${maisBarato.Valor}");
    }
}