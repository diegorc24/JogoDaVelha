using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Humano : Jogador
    {
        //protected int jogador;

        public Humano(int jogador) : base(jogador)
        {
            this.jogador = jogador;
            Console.WriteLine("Jogador 'Humano' criado!");
        }

        //public void jogar(Tabuleiro tabuleiro)
        //{
        //        Tentativa(tabuleiro);
        //        tabuleiro.setPosicao(tentativa, jogador);
        //}

        public override void jogar(Tabuleiro tabuleiro)
        {
            Tentativa(tabuleiro);
            tabuleiro.setPosicao(tentativa, jogador);
        }

        //public void Tentativa(Tabuleiro tabuleiro)
        //{
        //    do
        //    {
        //        do
        //        {
        //            Console.Write("Linha: ");
        //            tentativa[0] = int.Parse(Console.ReadLine());

        //            if (tentativa[0] > 3 || tentativa[0] < 1)
        //                Console.WriteLine("Linha inválida. É 1, 2 ou 3");

        //        } while (tentativa[0] > 3 || tentativa[0] < 1);

        //        do
        //        {
        //            Console.Write("Coluna: ");
        //            tentativa[1] = int.Parse(Console.ReadLine());

        //            if (tentativa[1] > 3 || tentativa[1] < 1)
        //                Console.WriteLine("Coluna inválida. É 1, 2 ou 3");

        //        } while (tentativa[1] > 3 || tentativa[1] < 1);

        //        tentativa[0]--;
        //        tentativa[1]--;

        //        if (!checaTentativa(tentativa, tabuleiro))
        //            Console.WriteLine("Esse local já foi marcado. Tente outro.");
        //    } while (!checaTentativa(tentativa, tabuleiro));
        //}

        public override void Tentativa(Tabuleiro tabuleiro)
        {
            do
            {
                do
                {
                    Console.Write("Linha: ");
                    tentativa[0] = int.Parse(Console.ReadLine());

                    if (tentativa[0] > 3 || tentativa[0] < 1)
                        Console.WriteLine("Linha inválida. É 1, 2 ou 3");

                } while (tentativa[0] > 3 || tentativa[0] < 1);

                do
                {
                    Console.Write("Coluna: ");
                    tentativa[1] = int.Parse(Console.ReadLine());

                    if (tentativa[1] > 3 || tentativa[1] < 1)
                        Console.WriteLine("Coluna inválida. É 1, 2 ou 3");

                } while (tentativa[1] > 3 || tentativa[1] < 1);

                tentativa[0]--;
                tentativa[1]--;

                if (!checaTentativa(tentativa, tabuleiro))
                    Console.WriteLine("Esse local já foi marcado. Tente outro.");
            } while (!checaTentativa(tentativa, tabuleiro));
        }
    }
}
