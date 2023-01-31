using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public abstract class Jogador
    {
        protected int[] tentativa = new int[2];
        protected int jogador;


        public Jogador(int jogador)
        {
            this.jogador = jogador;
        }

        public abstract void jogar(Tabuleiro tabuleiro);

        public abstract void Tentativa(Tabuleiro tabuleiro);

        public bool checaTentativa(int[] tentativa, Tabuleiro tabuleiro)
        {
            if (tabuleiro.getPosicao(tentativa) == 0)
                return true;
            else
                return false;

        }
    }
}
