using System;

namespace Exemplo_24_05.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;
        protected float Valor = 2599f;

        public string Cancelar()
        {
            return "Pagamento cancelado!";
        }
    }
}