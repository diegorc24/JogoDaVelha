using System;

namespace JogoDaVelha
{
    public class Instrucoes
    {
        public static void instrucoes()
        {
            TelaLimpa.telaLimpa();

            Console.WriteLine("|---------------------------------------------------------------------------------------------------------|\n" +
                    "|                                              INSTRUÇÕES                                                 |\n" +
                    "|---------------------------------------------------------------------------------------------------------|\n" +
                    "|Objetivo do jogo:                                                                                      |\n" +
                    "|Ser o primeiro a fazer uma sequência de três símbolos iguais, seja em uma linha, coluna ou diagonal.    |\n" +
                    "|                                                                                                         |                \n" +
                    "| Regras:                                                                                                 |\n" +
                    "| - Um jogador joga com o círculo 'O' e outro com o xis 'X'.                                              |\n" +
                    "| - Cada jogador, na sua vez, marca uma lacuna que esteja vazia.                                          |\n" +
                    "| - Quando um jogador conquista o objetivo, ganha 1 ponto.                                               |\n" +
                    "| - Quando há empate, o jogo informa que “deu velha”, e ninguém marca ponto.                              |\n" +
                    "| - O jogador que joga com os xis 'X' sempre é o primeiro jogar.                                          |\n" +
                    "|---------------------------------------------------------------------------------------------------------|" );
            Console.WriteLine("Insira qualquer digito para voltar:");
            Console.WriteLine();
            TelaLimpa.telaLimpa();
        }
    }
}