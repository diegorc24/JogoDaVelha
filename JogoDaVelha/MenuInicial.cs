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
        public static void menuInicial()
        {
            TelaLimpa.telaLimpa();

            Console.WriteLine(
                    "|---------------------------------------------------------------------------------------------------------|\n" +
                            "|                                                  MENU                                                    |\n" +
                            "|---------------------------------------------------------------------------------------------------------|\n" +
                            "| Insira 'i' para ver instruções                                                                        |\n" +
                            "| Insira 'r' para reiniciar o jogo                                                                       |\n" +
                            "| Insira 's' para sair                                                                                    |\n" +
                            "| Ou insira qualquer outro digito para retornar ao menu principal                                         |\n" +
                            "|---------------------------------------------------------------------------------------------------------|\n" +
                            "Insira sua opção aqui:");

            string choose = Console.ReadLine().ToLower();

            if (choose.Equals("s"))
            {
                FimDeJogo.fimDeJogo();
            }
            else if (choose.Equals("i"))
            {
                Instrucoes.instrucoes();
                menuInicial();
            }
            else
            {
                Comecar.comecar();
            }
        }
    }
}
