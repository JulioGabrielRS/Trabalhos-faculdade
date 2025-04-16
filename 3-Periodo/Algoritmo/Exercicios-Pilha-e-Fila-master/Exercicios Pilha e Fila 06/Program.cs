using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> historico = new Stack<string>();
        string paginaAtual = "Página Inicial";

        while (true)
        {
            Console.WriteLine($"\nVocê está em: {paginaAtual}");
            Console.WriteLine("Digite o endereço de uma nova página ou 'voltar' para retornar à anterior.");
            Console.WriteLine("Digite 'sair' para encerrar.");
            Console.Write("Comando: ");
            string comando = Console.ReadLine();

            if (comando.ToLower() == "sair")
            {
                break;
            }
            else if (comando.ToLower() == "voltar")
            {
                if (historico.Count > 0)
                {
                    paginaAtual = historico.Pop();
                }
                else
                {
                    Console.WriteLine("Não há páginas anteriores no histórico.");
                }
            }
            else
            {
                historico.Push(paginaAtual);
                paginaAtual = comando;
            }
        }

        Console.WriteLine("\nEncerrando o navegador. Até mais!");
    }
}
