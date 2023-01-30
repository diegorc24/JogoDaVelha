using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Comecar
    {
        public static void comecar()
        {
            TelaLimpa.telaLimpa();
            Titulo.titulo();

            Console.WriteLine("Insira qualquer digito para iniciar ou insira 'm' para acessar o menu de opções:");

            string escolher = Console.ReadLine().ToLower();

            if (escolher.Equals("m"))
            {
                MenuInicial.menuInicial();
            }
        }
    }
}
