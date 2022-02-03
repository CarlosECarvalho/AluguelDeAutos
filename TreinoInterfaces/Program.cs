using System;
using System.Globalization;
using TreinoInterfaces.Entitites;
using TreinoInterfaces.Services;

namespace TreinoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação: ");
            Console.Write("Modelo do veículo: ");
            string carModel = Console.ReadLine();
            Console.Write("Retirada: (dd/mm/aaaa hh:ss) ");
            DateTime startTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolução: (dd/mm/aaaa hh:ss) ");
            DateTime endTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço da hora de locação: ");
            double hourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço do dia de locação: ");
            double dayPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(startTime, endTime, new Vehicles(carModel)); //instancio o veiculo no momento da passagem de parametros
            RentalService rentalCost = new RentalService(hourPrice, dayPrice); //inicializo o servico que ira gerar a locação e o valor para a nota

            rentalCost.ProcessInvoice(carRental); //chamo o objeto rentalCost com a propriedade ProcessInvoice para calcular a locacao e gerar a nota

            Console.WriteLine("NOTA DE LOCAÇÃO" );
            Console.WriteLine(carRental.Invoice);
        }
    }
}
