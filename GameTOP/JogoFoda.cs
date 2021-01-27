using consoleCore.GameTOP.Interface;

namespace consoleCore.GameTOP

{
    public class JogoFoda
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;

        public JogoFoda(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
            public void IniciarJogo()
        {
            System.Console.Write(_jogador1.Corre());
            System.Console.Write(_jogador1.Chuta());
            System.Console.Write(_jogador1.Passa());

            System.Console.Write(_jogador2.Corre());
            System.Console.Write(_jogador2.Chuta());
            System.Console.Write(_jogador2.Passa());

        }
    }
}