using System;
using GameTop.Interface;

namespace GameTop
{
    class JogoFODA
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;
        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            //System.Console.Write($"{_jogador._Nome} deu um passe");
            Console.Write(_jogador1.Corre());
            Console.Write(_jogador1.Chuta());
            Console.Write(_jogador1.Passe());

            Console.Write("\nPRÓXIMO JOGADOR\n");

            Console.Write(_jogador2.Corre());
            Console.Write(_jogador2.Chuta());
            Console.Write(_jogador2.Passe());

        }
    }
}