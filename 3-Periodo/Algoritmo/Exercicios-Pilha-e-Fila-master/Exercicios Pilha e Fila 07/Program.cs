using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaAtendimento = new Queue<string>();
        string comando;

        Console.WriteLine("Sistema de Atendimento por Ordem de Chegada");
        Console.WriteLine("Comandos: 'entrar [nome]', 'atender', 'fila', 'sair'\n");

        do
        {
            Console.Write("Comando: ");
            comando = Console.ReadLine();

            if (comando.StartsWith("entrar "))
            {
                string nome = comando.Substring(7).Trim();
                filaAtendimento.Enqueue(nome);
                Console.WriteLine($"{nome} entrou na fila.");
            }
            else if (comando == "atender")
            {
                if (filaAtendimento.Count > 0)
                {
                    string atendido = filaAtendimento.Dequeue();
                    Console.WriteLine($"Atendendo {atendido}.");
                }
                else
                {
                    Console.WriteLine("Nenhum cliente na fila.");
                }
            }
            else if (comando == "fila")
            {
                Console.WriteLine("Clientes na fila:");
                if (filaAtendimento.Count == 0)
                {
                    Console.WriteLine("Nenhum cliente na fila.");
                }
                else
                {
                    foreach (string cliente in filaAtendimento)
                    {
                        Console.WriteLine("- " + cliente);
                    }
                }
            }
            else if (comando != "sair")
            {
                Console.WriteLine("Comando inválido.");
            }

        } while (comando != "sair");

        Console.WriteLine("\nEncerrando o sistema de atendimento.");
    }
}

