using consoleCore.GameTOP.Interface;

namespace consoleCore.GameTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passa()
        {
            return "Maradona estas pasando \n";
        }
    }
}