using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Program
    {
        static void Main(string[] args)
        {
            Comecar.comecar();

            TelaLimpa.telaLimpa();

            Console.WriteLine("Ok, vamos começar!");

            string[] jogadoresNomes = Nomesjogadores();
            string[] simboloJogadores = { "X", "O" };

            Console.WriteLine("\nEntendido! %s jogará com o xis 'X' e %s jogará com o círculo 'O'.\n\n", jogadoresNomes[0], jogadoresNomes[1]);

            Jogo(jogadoresNomes[0], simboloJogadores[0], jogadoresNomes[1], simboloJogadores[1], args);
        }

        private static string[] Nomesjogadores()
        {
            string[] playersArray = { "abc", "cde" };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Insira nome do %dª jogador:\n", i + 1);
                string name = Console.ReadLine();   
                if (name.Trim().Equals(""))
                {
                    i--;
                }
                else
                {
                    playersArray[i] = name.ToLower();
                }
            }
            return playersArray;
        }

        public static void Jogo(string jogadorUm, string jogadorUmSimbolo, string jogadorDois, string jogadorDoisSimbolo, string[] args)
        {
            int rodada = 1;

            int[] placar = { 0, 0 };

            string jogador = jogadorUm;
            string simboloJogador = jogadorUmSimbolo;

            char[] posicoes = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool revenche = true;
            do
            {
                //Chama as classes que exibem a rodada e placar.
                Rodadas.rodadas(rodada);

                //score(playerOne, playerTwo);
                Pontuacao(jogadorUm, placar, jogadorDois);

                //Armazenará a numeração partida
                int turno = 0;
                bool vencedor = false;

                Scanner sc = new Scanner(System.in);
                while (!vencedor && turno <= 8)
                {

                    //Intercala as jogadas entre os jogadores '1' e '2'.
                    turno++;
                    if (turno % 2 == 1)
                    {
                        jogador = jogadorUm;
                        simboloJogador = jogadorUmSimbolo;
                    }
                    else
                    {
                        jogador = jogadorDois;
                        simboloJogador = jogadorDoisSimbolo;
                    }

                    Console.WriteLine("\nÉ a vez do '%s' jogar! %s, escolha uma posição livre.", simboloJogador, jogador);

                    //Chama método que exibe o tabuleiro.
                    ObterTabela(posicoes);

                    // Tratar as entradas do jogador
                    Console.WriteLine("Informe sua jogada:");

                    // transformar a posição escolhida em um array com os índices
                    int[] index = ObterIndiceEscolha(sc);

                    // Checa a posição está disponível
                    while (!availablePosition(index, boardPositions))
                    {
                        System.err.println("Posição inválida.");
                        System.out.println("Informe novamente a sua jogada:");
                        index = getChoiceIndex(sc); ;
                    }

                    //Muda a posição escolhida pelo jogador pelo seu símbolo
                    changePosition(index, boardPositions, playerSymbol);
                    winner = checkWinner(boardPositions);
                }

                if (winner)
                    win(boardPositions, player, playerOne, scoreBoard, playerTwo, playerSymbol, args);
                else
                    tie(boardPositions, playerOne, scoreBoard, playerTwo, args);

                round++;

                // limpa o tabuleiro
                boardPositions = new String[][] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            } while (rematch);
            CleanScreen.cleanScreen();
        }       

        private static string ObterTabela(char[] posicoes)
        {
            return $"__{posicoes[0]}__|__{posicoes[1]}__|__{posicoes[2]}__\n" +
                   $"__{posicoes[3]}__|__{posicoes[4]}__|__{posicoes[5]}__\n" +
                   $"  {posicoes[6]}  |  {posicoes[7]}  |  {posicoes[8]}  \n\n";
        }

        public static void Pontuacao(string jogador1, int[] placar, string jogador2)
        {
            Console.WriteLine("PLACAR: %s %d VS %d %s\n", jogador1, placar[0], placar[1], jogador2);
        }
    }
}
