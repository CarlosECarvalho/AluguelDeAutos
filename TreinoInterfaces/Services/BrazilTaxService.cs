

namespace TreinoInterfaces.Services
{
    class BrazilTaxService
    {
        public double Tax ( double amount) //crio uma funcao que ja inicializa calculando a taxa a ser aplicada com retorno do valor calculado
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            } else
            {
                return amount * 0.15;
            }
        }
    }
}
