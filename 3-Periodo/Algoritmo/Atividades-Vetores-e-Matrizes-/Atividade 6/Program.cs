class JgoDaVelhao
{
    static void ExibirTabuleiro(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---------");
        }
    }

    static bool VerificarVitoria(char[,] tabuleiro, char jogador)
    {
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador) return true;
            if (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador) return true;
        }
        if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador) return true;
        if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador) return true;

        return false;
    }

    static int ObterEntradaJogador(string mensagem)
    {
        int entrada;
        while (true)
        {
            Console.WriteLine(mensagem);
            if (int.TryParse(Console.ReadLine(), out entrada) && entrada >= 0 && entrada <= 2)
                return entrada;
            else
                Console.WriteLine("Entrada inválida! Por favor, insira um número entre 0 e 2.");
        }
    }

    static void Main()
    {
        char[,] tabuleiro = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        int contador = 0;
        char jogador = 'X';

        while (true)
        {
            ExibirTabuleiro(tabuleiro);
            int linha = ObterEntradaJogador($"Jogador {jogador}, escolha a linha (0, 1, 2): ");
            int coluna = ObterEntradaJogador($"Jogador {jogador}, escolha a coluna (0, 1, 2): ");

            if (tabuleiro[linha, coluna] != ' ')
            {
                Console.WriteLine("Espaço já ocupado! Tente novamente.");
                continue;
            }

            tabuleiro[linha, coluna] = jogador;

            if (VerificarVitoria(tabuleiro, jogador))
            {
                ExibirTabuleiro(tabuleiro);
                Console.WriteLine($"Jogador {jogador} venceu!");
                break;
            }

            if (++contador == 9)
            {
                ExibirTabuleiro(tabuleiro);
                Console.WriteLine("Empate!");
                break;
            }

            jogador = (jogador == 'X') ? 'O' : 'X';
        }
    }
}
