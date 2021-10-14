using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string chuta()
        {
            return "Maradona estas patendo";
        }

        public string corre()
        {
            return "Maradona estas coriendo";
        }

        public string passe()
        {
            return "Maradona estas passando";
        }
    }
}