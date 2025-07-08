using tabuleiro;
using XadrezConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8);

        Tela.ImprimirTabuleiro(tab);

        Console.ReadLine();
    }
}