using System;

class Program 
{
    public static int BuscarPalavra(string texto, string palavra)
    {
        if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(palavra))
        {
            return -1;
        }

        string textoLower = texto.ToLower();
        string palavraLower = palavra.ToLower();

        for (int i = 0; i <= texto.Length - palavra.Length; i++)
        {
            bool encontrou = true;

            for (int j = 0; j < palavra.Length; j++)
            {
                if (textoLower[i + j] != palavraLower[j])
                {
                    encontrou = false;
                    break;
                }
            }

            if (encontrou)
            {
                bool bordaEsquerdaOK = (i == 0) || !char.IsLetterOrDigit(texto[i - 1]);
                bool bordaDireitaOK = (i + palavra.Length == texto.Length) ||
                                     !char.IsLetterOrDigit(texto[i + palavra.Length]);

                if (bordaEsquerdaOK && bordaDireitaOK)
                {
                    return i;
                }
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o texto:");
        string texto = Console.ReadLine();

        Console.WriteLine("Digite a palavra a buscar:");
        string palavra = Console.ReadLine();

        int posicao = BuscarPalavra(texto, palavra);

        if (posicao != -1)
        {
            Console.WriteLine($"Palavra encontrada na posição {posicao}");
            Console.WriteLine($"Trecho do texto: \"{texto.Substring(posicao, Math.Min(palavra.Length + 20, texto.Length - posicao))}...\"");
        }
        else
        {
            Console.WriteLine("Palavra não encontrada no texto");
        }
    }
}