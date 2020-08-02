using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste Chuta\n";
        }

        public string Corre()
        {
            return "Teste Corre\n";
        }

        public string Passe()
        {
            return "Teste Passe\n";
        }
    }
}