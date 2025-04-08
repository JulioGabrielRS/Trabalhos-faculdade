using System;

class Program
{
    public static int BuscarNome(string[] nomes, string nomeProcurado)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i].Equals(nomeProcurado, StringComparison.OrdinalIgnoreCase))
            {
                return i; 
            }
        }
        return -1; 
    }

    static void Main(string[] args)
    {
        string[] nomes = { "Ana", "Bruno", "Carlos", "Emerson", "Eduardo" };

        Console.Write("Digite o nome a ser buscado: ");
        string nome = Console.ReadLine();

        int indice = BuscarNome(nomes, nome);

        if (indice != -1)
        {
            Console.WriteLine($"Nome '{nome}' encontrado no índice {indice}");
        }
        else
        {
            Console.WriteLine($"Nome '{nome}' não encontrado na lista");
        }
    }
}