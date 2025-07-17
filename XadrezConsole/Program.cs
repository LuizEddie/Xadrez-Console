using tabuleiro;
using XadrezConsole;
using xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
                
                Console.WriteLine();
                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                partida.ExecutaMovimento(origem, destino);
            }


        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }

        //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
        //Console.WriteLine(pos);

        //Console.WriteLine(pos.ToPosicao());

        Console.ReadLine();

    }
}