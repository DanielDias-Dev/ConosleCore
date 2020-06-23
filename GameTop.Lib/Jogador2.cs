using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        string iJogador.Chuta()
        {
            return "Maradona estas pateando \n";
        }

        string iJogador.Corre()
        {
            return "Maradona estas corriendo \n";
        }

        string iJogador.Passe()
        {
            return "Maradona estas pasando \n";
        }
    }
}