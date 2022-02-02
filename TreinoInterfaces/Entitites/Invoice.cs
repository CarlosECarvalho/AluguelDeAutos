using System.Globalization;

namespace TreinoInterfaces.Entitites
{
    class Invoice
    {
        public double BasicPaymant{ get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPaymant, double tax)
        {   BasicPaymant = basicPaymant;
            Tax = tax;
        }

        public double TotalPaymant //EXEMPLO DE PROPRIEDADE CALCULADA, PODENDO SUBSTITUIR UMA FUNCAO SIMPLES
        {   get
            {
                return BasicPaymant + Tax;
            }
        }

        public override string ToString()
        {
            return "Basic Paymant: "+ BasicPaymant.ToString("F2", CultureInfo.InvariantCulture) + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture) + "\nTotal Paymaant: " + TotalPaymant.ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
