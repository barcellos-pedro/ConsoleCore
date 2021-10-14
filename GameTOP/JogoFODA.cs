using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void iniciarJogo()
        {
            System.Console.WriteLine(_jogadorA.corre());
            System.Console.WriteLine(_jogadorA.chuta());
            System.Console.WriteLine(_jogadorA.passe());

            System.Console.WriteLine("\n PRÓXIMO JOGADOR \n");

            System.Console.WriteLine(_jogadorB.corre());
            System.Console.WriteLine(_jogadorB.chuta());
            System.Console.WriteLine(_jogadorB.passe());
        }
    }
}