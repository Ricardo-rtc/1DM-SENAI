namespace JogadorFutebol.Classes
{
    public class JogadorMeio : Jogador
    {
        public string Aposentadoria()
        {
            if (idade < 38)
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