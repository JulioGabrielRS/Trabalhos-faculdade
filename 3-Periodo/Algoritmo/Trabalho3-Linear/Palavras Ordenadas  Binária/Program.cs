using System;

class Program
{
    public static int BuscarPalavra(string[] dicionario, string palavra)
    {
        int esquerda = 0;
        int direita = dicionario.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;
            int comparacao = String.Compare(dicionario[meio], palavra, StringComparison.OrdinalIgnoreCase);

            if (comparacao == 0) 
                return meio;
            else if (comparacao < 0) 
                esquerda = meio + 1;
            else 
                direita = meio - 1;
        }

        return -1; 
    }

    static void Main(string[] args)
    {
        string[] dicionario = {
            "abacaxi", "banana", "computador", "dado", "elefante",
            "futebol", "girassol", "hospital", "igreja", "janela"
        };

        Console.WriteLine("Dicionário: " + string.Join(", ", dicionario));
        Console.Write("Digite a palavra a buscar: ");
        string palavra = Console.ReadLine();

        int posicao = BuscarPalavra(dicionario, palavra);

        if (posicao != -1)
            Console.WriteLine($"Palavra encontrada na posição {posicao}");
        else
            Console.WriteLine("Palavra não encontrada no dicionário");
    }
}