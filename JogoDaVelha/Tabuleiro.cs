﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Tabuleiro
    {
        private int[,] tabuleiro = new int[3, 3];

        public Tabuleiro()
        {
            zerarTabuleiro();
        }

        public void zerarTabuleiro()
        {
            for (int linha = 0; linha < 3; linha++)
                for (int coluna = 0; coluna < 3; coluna++)
                    tabuleiro[linha,coluna] = 0;
        }

        public void exibeTabuleiro()
        {
            Console.WriteLine();
            for (int linha = 0; linha < 3; linha++)
            {

                for (int coluna = 0; coluna < 3; coluna++)
                {

                    if (tabuleiro[linha,coluna] == -1)
                    {
                        Console.Write(" X ");
                    }
                    if (tabuleiro[linha,coluna] == 1)
                    {
                        Console.Write(" O ");
                    }
                    if (tabuleiro[linha,coluna] == 0)
                    {
                        Console.Write("   ");
                    }

                    if (coluna == 0 || coluna == 1)
                        Console.Write("|");
                }
                Console.WriteLine();
            }

        }

        public int getPosicao(int[] tentativa)
        {
            return tabuleiro[tentativa[0],tentativa[1]];
        }

        public void setPosicao(int[] tentativa, int jogador)
        {
            if (jogador == 1)
                tabuleiro[tentativa[0],tentativa[1]] = -1;
            else
                tabuleiro[tentativa[0],tentativa[1]] = 1;

            exibeTabuleiro();
        }

        public int checaLinhas()
        {

            for (int linha = 0; linha < 3; linha++)
            {

                if ((tabuleiro[linha,0] + tabuleiro[linha,1] + tabuleiro[linha,2]) == -3)
                    return -1;
                if ((tabuleiro[linha,0] + tabuleiro[linha,1] + tabuleiro[linha,2]) == 3)
                    return 1;
            }

            return 0;

        }

        public int checaColunas()
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {

                if ((tabuleiro[0,coluna] + tabuleiro[1,coluna] + tabuleiro[2,coluna]) == -3)
                    return -1;
                if ((tabuleiro[0,coluna] + tabuleiro[1,coluna] + tabuleiro[2,coluna]) == 3)
                    return 1;
            }

            return 0;

        }

        public int checaDiagonais()
        {
            if ((tabuleiro[0,0] + tabuleiro[1,1] + tabuleiro[2,2]) == -3)
                return -1;
            if ((tabuleiro[0,0] + tabuleiro[1,1] + tabuleiro[2,2]) == 3)
                return 1;
            if ((tabuleiro[0,2] + tabuleiro[1,1] + tabuleiro[2,0]) == -3)
                return -1;
            if ((tabuleiro[0,2] + tabuleiro[1,1] + tabuleiro[2,0]) == 3)
                return 1;

            return 0;
        }

        public bool tabuleiroCompleto()
        {
            for (int linha = 0; linha < 3; linha++)
                for (int coluna = 0; coluna < 3; coluna++)
                    if (tabuleiro[linha,coluna] == 0)
                        return false;
            return true;
        }
    }
}
