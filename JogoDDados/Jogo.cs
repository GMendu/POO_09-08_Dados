using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDDados
{
    class Jogo
    {
        Random rnd = new Random();
        public int Dado1 { get; set; }
        public int Dado2 { get; set; }
        public int Comp { get; set; }
        public bool vitoria { get; set; }
        public void Jogar(int DadoJogador)
        {
            Dado1 = rnd.Next(1, 7);
            Dado2 = rnd.Next(1, 7);
            if (Dado1 + Dado2 == DadoJogador ) // vitoria
            {
                do
                {
                    Comp = rnd.Next(1, 7);
                } while (Comp == DadoJogador);
                vitoria = true;
            }
            else // derrota
            {
                Comp = Dado1 + Dado2;
                vitoria = false;
            }
        }
    }
}
