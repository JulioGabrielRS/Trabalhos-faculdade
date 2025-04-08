using System;

class Program 
{
    public string Nome { get; set; }
    public int Matricula { get; set; }

    public Aluno(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

    public override string ToString()
    {
        return $"Aluno: {Nome} (Matrícula: {Matricula})";
    }
}

class BuscaAluno
{
    public static Aluno BuscarPorMatricula(Aluno[] alunos, int matriculaProcurada)
    {
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Matricula == matriculaProcurada)
            {
                return aluno;
            }
        }
        return null; 
    }

    static void Main(string[] args)
    {
        Aluno[] alunos = {
            new Aluno("Vitoria Cunha", 1),
            new Aluno("Maria Clara silva", 2),
            new Aluno("Pedro Oliveira", 3),
            new Aluno("Emerson Junior", 4)
        };

        Console.Write("Digite a matrícula a ser buscada: ");
        int matricula = int.Parse(Console.ReadLine());

        Aluno alunoEncontrado = BuscarPorMatricula(alunos, matricula);

        if (alunoEncontrado != null)
        {
            Console.WriteLine("Aluno encontrado:");
            Console.WriteLine(alunoEncontrado);
        }
        else
        {
            Console.WriteLine($"Nenhum aluno com a matrícula {matricula} foi encontrado.");
        }
    }
}