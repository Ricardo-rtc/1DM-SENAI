namespace ExemploClassesEstaticas.Classes
{
    public class Conversor
    {
        private static float CotacaoDolar = 5.22f;

        public static float RealParaDolar(float valorReal)
        {
            return valorReal / CotacaoDolar;
        }
        public static float DolarParaReal(float valorDolar)
        {
            return CotacaoDolar * valorDolar;
        }

    }
}