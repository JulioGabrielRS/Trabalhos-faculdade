using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    public string RA { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main()
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Listar Alunos");
            Console.WriteLine("3. Alterar Aluno");
            Console.WriteLine("4. Remover Aluno");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CadastrarAluno();
                    break;
                case "2":
                    ListarAlunos();
                    break;
                case "3":
                    AlterarAluno();
                    break;
                case "4":
                    RemoverAluno();
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

    static void CadastrarAluno()
    {
        var aluno = new Aluno();

        Console.Write("RA: ");
        aluno.RA = Console.ReadLine();

        if (alunos.Any(a => a.RA == aluno.RA))
        {
            Console.WriteLine("RA já cadastrado!");
            return;
        }

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        aluno.Idade = int.Parse(Console.ReadLine());

        alunos.Add(aluno);
        Console.WriteLine("Aluno cadastrado!");
    }

    static void ListarAlunos()
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
            return;
        }

        foreach (var aluno in alunos)
        {
            Console.WriteLine($"RA: {aluno.RA} | Nome: {aluno.Nome} | Idade: {aluno.Idade}");
        }
    }

    static void AlterarAluno()
    {
        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();

        var aluno = alunos.FirstOrDefault(a => a.RA == ra);
        if (aluno == null)
        {
            Console.WriteLine("Aluno não encontrado!");
            return;
        }

        Console.Write("Novo Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Nova Idade: ");
        aluno.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados atualizados!");
    }

    static void RemoverAluno()
    {
        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();

        var aluno = alunos.FirstOrDefault(a => a.RA == ra);
        if (aluno == null)
        {
            Console.WriteLine("Aluno não encontrado!");
            return;
        }

        alunos.Remove(aluno);
        Console.WriteLine("Aluno removido!");
    }
}