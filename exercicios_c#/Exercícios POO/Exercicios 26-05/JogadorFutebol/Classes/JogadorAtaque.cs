namespace JogadorFutebol.Classes
{
    public class JogadorAtaque : Jogador
    {
        public string Aposentadoria()
        {
            if (idade < 35)
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