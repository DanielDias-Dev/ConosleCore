using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        string iJogador.Chuta()
        {
            return "teste chuta \n";
        }

        string iJogador.Corre()
        {
            return "teste coore \n";
        }

        string iJogador.Passe()
        {
            return "teste passe \n";
        }
    }
}