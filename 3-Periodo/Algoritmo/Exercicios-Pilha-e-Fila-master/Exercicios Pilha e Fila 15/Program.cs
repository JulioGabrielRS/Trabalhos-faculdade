using System.Collections.Generic;

public class Estacionamento
{
    private Stack<string> estacionamento;
    private int capacidade;

    public Estacionamento(int capacidade)
    {
        this.capacidade = capacidade;
        estacionamento = new Stack<string>(capacidade);
    }

    public void Entrar(string carro)
    {
        if (estacionamento.Count < capacidade)
        {
            estacionamento.Push(carro);
            Console.WriteLine($"Carro {carro} entrou no estacionamento.");
        }
        else
        {
            Console.WriteLine("Estacionamento cheio. Não é possível entrar.");
        }
    }

    public void Sair(string carro)
    {
        if (estacionamento.Count == 0)
        {
            Console.WriteLine("Estacionamento vazio. Nenhum carro para sair.");
            return;
        }

        Stack<string> carrosTemporarios = new Stack<string>();

        while (estacionamento.Count > 0)
        {
            string carroAtual = estacionamento.Pop();
            if (carroAtual == carro)
            {
                Console.WriteLine($"Carro {carro} saiu do estacionamento.");
                break;
            }
            else
            {
                carrosTemporarios.Push(carroAtual);
            }
        }

        while (carrosTemporarios.Count > 0)
        {
            estacionamento.Push(carrosTemporarios.Pop());
        }
    }

    public void ExibirCarros()
    {
        if (estacionamento.Count == 0)
        {
            Console.WriteLine("Estacionamento vazio.");
        }
        else
        {
            Console.WriteLine("Carros no estacionamento:");
            foreach (var carro in estacionamento)
            {
                Console.WriteLine(carro);
            }
        }
    }

    public bool EstaCheio()
    {
        return estacionamento.Count == capacidade;
    }

    public bool EstaVazio()
    {
        return estacionamento.Count == 0;
    }
}

public class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento(5);

        estacionamento.Entrar("Carro 1");
        estacionamento.Entrar("Carro 2");
        estacionamento.Entrar("Carro 3");
        estacionamento.Entrar("Carro 4");
        estacionamento.Entrar("Carro 5");

        estacionamento.ExibirCarros();

        estacionamento.Entrar("Carro 6");

        estacionamento.Sair("Carro 3");

        estacionamento.ExibirCarros();

        estacionamento.Sair("Carro 6");

        estacionamento.ExibirCarros();
    }
}
