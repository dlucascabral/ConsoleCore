using consoleCore.GameTOP.Interface;

namespace consoleCore.GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} está correndo \n";
        }

        public string Passa()
        {
            return $"{_Nome} está passando \n";
        }
    }
}