namespace SistemaElevador.Classes
{
    public class ElevadorServico : Elevador
    {
        private int caixas;
        private int capacidadeCaixas = 5;

        public string SomarCaixa()
        {
            if (caixas < capacidadeCaixas)
            {
                caixas++;
                return $@"
Foi adicionada uma caixa no elevador
Quantidade de caixas {caixas} ";
            }
            else
            {
                return "Elevador cheio de caixas!";
            }
        }
        public string RetirarCaixa()
        {
            if (caixas != 0)
            {
                caixas--;
                return $@"
Foi retirada uma caixa do elevador
Quantidade de caixas {caixas} ";
            }
            else
            {
                return "Elevador vazio!";
            }
        }
    }
}