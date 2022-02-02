using System;
using System.Globalization;
using TreinoInterfaces.Entitites;
using System.Text;
using System.Threading.Tasks;

namespace TreinoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação: ");
            Console.WriteLine("Modelo do veículo: ");
            string carModel = Console.ReadLine();
            Console.WriteLine("Retirada: (dd/mm/aaaa hh:ss)");
            DateTime startTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Devolução: (dd/mm/aaaa hh:ss)");
            DateTime endTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(startTime, endTime, new Vehicles(carModel)); //instancio o veiculo no momento da passagem de parametros

        }
    }
}
