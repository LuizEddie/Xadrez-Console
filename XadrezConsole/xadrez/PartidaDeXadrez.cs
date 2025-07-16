using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {

        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada {  get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQteMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas() {
            //Peças Brancas
            //Principais
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('b', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('f', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('g', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 1).ToPosicao());
            //Peões
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('b', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('f', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('g', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 2).ToPosicao());

            //Peças Pretas
            //Principais
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('b', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('f', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('g', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('h', 8).ToPosicao());
            //Peões
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('b', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('f', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('g', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('h', 7).ToPosicao());
        }
    }
}
