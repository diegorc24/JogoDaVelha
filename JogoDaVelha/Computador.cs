using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Computador : Jogador
    {
        public Computador(int jogador) : base(jogador)
        {
            Console.WriteLine("Jogador 'Computador' criado!");
        }

        public override void jogar(Tabuleiro tabuleiro)
        {
            
        }

       

        public override void Tentativa(Tabuleiro tabuleiro)
        {
            
        }
    }
}
