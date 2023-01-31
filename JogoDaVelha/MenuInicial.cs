using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class MenuInicial
    {
        public void menuInicial()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO");
            Console.WriteLine("JOGO DA VELHA");

            Console.WriteLine("|---------------------------------------------------------------------------------------------------------|\n" +
                            "|                                              INSTRUÇÕES                                                 |\n" +
                            "|---------------------------------------------------------------------------------------------------------|\n" +
                            "|Objetivo do jogo:                                                                                        |\n" +
                            "|Ser o primeiro a fazer uma sequência de três símbolos iguais, seja em uma linha, coluna ou diagonal.     |\n" +
                            "|                                                                                                         |\n" +
                            "| Regras:                                                                                                 |\n" +
                            "| - Um jogador joga com o círculo 'O' e outro com o xis 'X'.                                              |\n" +
                            "| - Cada jogador, na sua vez, marca uma lacuna que esteja vazia.                                          |\n" +
                            "| - Quando um jogador conquista o objetivo, ganha 1 ponto.                                                |\n" +
                            "| - Quando há empate, o jogo informa que “deu velha”, e ninguém marca ponto.                              |\n" +
                            "| - O jogador que joga com os xis 'X' sempre é o primeiro jogar.                                          |\n" +
                            "|---------------------------------------------------------------------------------------------------------|");

            Console.WriteLine(
                            "|---------------------------------------------------------------------------------------------------------|\n" +
                            "|                                                 MENU                                                    |\n" +
                            "|---------------------------------------------------------------------------------------------------------|\n" +
                            "|                   Insira 'r' para iniciar o jogo                                                      |\n" +
                            "|                   Insira 's' para sair                                                                  |\n" +
                            "|                   Ou insira qualquer outro digito para retomar a partida.                               |\n" +
                            "|---------------------------------------------------------------------------------------------------------|\n" +
                            "Insira sua opção aqui:");

            string escolher = Console.ReadLine().ToLower();

            switch (escolher)
            {
                case "s":
                    Console.WriteLine("Até mais!");
                    Environment.Exit(0);
                    break;

                case "r":
                    Jogo jogo = new Jogo();
                    break;

                default:
                    Console.Clear();
                    break;

            }
        }
    }
}
