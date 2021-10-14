using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : iJogador
    {
        public string chuta()
        {
            return "Teste chuta";
        }

        public string corre()
        {
            return "Teste corre";
        }

        public string passe()
        {
            return "Teste passa";
        }
    }
}