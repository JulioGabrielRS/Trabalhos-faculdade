using System;
using System.Collections.Generic;
using System.Linq;

class Competidor
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Modalidade { get; set; }
}

class Competicao
{
    public string Nome { get; set; }
    public List<Competidor> Competidores { get; } = new List<Competidor>();

    public void AdicionarCompetidor(Competidor competidor)
    {
        Competidores.Add(competidor);
    }
}

class Program
{
    static Competicao competicao = new Competicao();

    static void Main()
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Cadastrar Competição");
            Console.WriteLine("2. Adicionar Competidor");
            Console.WriteLine("3. Listar Competidores");
            Console.WriteLine("4. Sair");
            Console.Write("Opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CadastrarCompeticao();
                    break;
                case "2":
                    AdicionarCompetidor();
                    break;
                case "3":
                    ListarCompetidores();
                    break;
                case "4":
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void CadastrarCompeticao()
    {
        Console.Write("Nome da Competição: ");
        competicao.Nome = Console.ReadLine();
        Console.WriteLine("Competição cadastrada!");
    }

    static void AdicionarCompetidor()
    {
        if (string.IsNullOrEmpty(competicao.Nome))
        {
            Console.WriteLine("Cadastre uma competição primeiro!");
            return;
        }

        var competidor = new Competidor();

        Console.Write("Nome: ");
        competidor.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        competidor.Idade = int.Parse(Console.ReadLine());

        Console.Write("Modalidade: ");
        competidor.Modalidade = Console.ReadLine();

        competicao.AdicionarCompetidor(competidor);
        Console.WriteLine("Competidor adicionado!");
    }

    static void ListarCompetidores()
    {
        if (competicao.Competidores.Count == 0)
        {
            Console.WriteLine("Nenhum competidor cadastrado!");
            return;
        }

        Console.WriteLine($"\nCompetição: {competicao.Nome}");
        foreach (var c in competicao.Competidores)
        {
            Console.WriteLine($"Nome: {c.Nome} | Idade: {c.Idade} | Modalidade: {c.Modalidade}");
        }
    }
}