using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Jogo
    {
        private Tabuleiro tabuleiro;
        private int rodada = 1, vez = 1;
        private Jogador jogador1;
        private Jogador jogador2;


        public Jogo()
        {
            tabuleiro = new Tabuleiro();
            iniciarJogadores();

            while (Jogar()) ;
        }

        public void iniciarJogadores()
        {
            Console.WriteLine("Quem vai ser o Jogador 1 ?");
            if (escolherJogador() == 1)
                this.jogador1 = new Humano(1);
            else
                this.jogador1 = new Computador(1);

            Console.WriteLine("----------------------");
            Console.WriteLine("Quem vai ser o Jogador 2 ?");

            if (escolherJogador() == 1)
                this.jogador2 = new Humano(2);
            else
                this.jogador2 = new Computador(2);

        }

        public int escolherJogador()
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("1. Humano");
                Console.WriteLine("2. Computador\n");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao != 1 && opcao != 2)
                    Console.WriteLine("Opção inválida! Tente novamente");
            } while (opcao != 1 && opcao != 2);

            return opcao;
        }

        public bool Jogar()
        {
            if (ganhou() == 0)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("\nRodada " + rodada);
                Console.WriteLine("É a vez do jogador " + Vez());

                if (Vez() == 1)
                    jogador1.jogar(tabuleiro);
                else
                    jogador2.jogar(tabuleiro);


                if (tabuleiro.tabuleiroCompleto())
                {
                    Console.WriteLine("Tabuleiro Completo. Jogo empatado");
                    return false;
                }
                vez++;
                rodada++;

                return true;
            }
            else
            {
                if (ganhou() == -1)
                    Console.WriteLine("Jogador 1 ganhou!");
            else
                    Console.WriteLine("Jogador 2 ganhou!");

                return false;
            }

        }

        public int Vez()
        {
            if (vez % 2 == 1)
                return 1;
            else
                return 2;
        }

        public int ganhou()
        {
            if (tabuleiro.checaLinhas() == 1)
                return 1;
            if (tabuleiro.checaColunas() == 1)
                return 1;
            if (tabuleiro.checaDiagonais() == 1)
                return 1;

            if (tabuleiro.checaLinhas() == -1)
                return -1;
            if (tabuleiro.checaColunas() == -1)
                return -1;
            if (tabuleiro.checaDiagonais() == -1)
                return -1;

            return 0;
        }
    }
}
