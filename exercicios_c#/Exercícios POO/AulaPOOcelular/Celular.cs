namespace AulaPOOcelular
{
    public class Celular
    {
        public string cor = "Preto";
        public string modelo = "iPhone 12";
        public string tamanho = "6.06 polegadas";
        public bool ligado = false;
        public int menu;
        public string Ligar;

        public string Ligacao()
        {
            
            return "Discando"; 
        }

        public string mensagem()
        {
            
            return "Mensagem enviada!";
        }

        public bool Desligado()
        {
            ligado = false;
            return ligado;
        }
        public bool Ligado()
        {
            ligado = true;
            return ligado;
        }   
        

    }
}