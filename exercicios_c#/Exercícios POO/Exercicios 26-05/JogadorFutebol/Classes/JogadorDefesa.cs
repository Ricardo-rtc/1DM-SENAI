

namespace JogadorFutebol.Classes
{
    public class JogadorDefesa : Jogador
    {
        public string Aposentadoria()
        {
            if (idade < 40)
            {
                return "Pela sua idade você ainda pode jogar.";
            }
            else
            {
                return "Pela sua idade você deveria se aposentar!";
            }
        }

    }
}