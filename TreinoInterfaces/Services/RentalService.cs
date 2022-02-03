﻿using System;
using TreinoInterfaces.Entitites;

namespace TreinoInterfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set;}
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); //obtenho o tempo decorrido subtraindo o inicio da locação com o fim da locação, ficando com o tempo de locação total
            double basicPaymant = 0.0; //inicializo zerando a variavel para não ter erro
            if (duration.TotalHours <= 12.00) //utilizo a propriedade totalhours para obter um valor double para comparar
            {
                basicPaymant = PricePerHour * Math.Ceiling(duration.TotalHours); // faco o arredondamento para cima do valor de horas e multiplico pelo valor do pagamento
            } else
            {
                basicPaymant = PricePerDay * Math.Ceiling(duration.TotalDays);// faco o arredondamento para cima do valor de dias e multiplico pelo valor do pagamento
            }

            double Tax = _brazilTaxService.Tax(basicPaymant); //aciono o serviço de calculo de tributos com o objeto recebendo o valor base do pagamento, que irá retornar o valor do imposto adicionado.

            carRental.Invoice = new Invoice(basicPaymant, Tax);
        }
    }
}
