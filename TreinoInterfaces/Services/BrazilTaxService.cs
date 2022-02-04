

namespace TreinoInterfaces.Services
{
    class BrazilTaxService : ITaxServices //identificação do subtipo BrazilTaxService atraves da interface ITaxServices, de forma parecida com a Herança
    {
        //a operação do serviço deve ser compativel com a interface, usando o mesmo nome (Tax) do construtor da interface
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
