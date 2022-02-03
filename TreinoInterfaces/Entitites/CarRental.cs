using System;

namespace TreinoInterfaces.Entitites
{
    class CarRental
    {
        public DateTime Start { get; set;}
        public DateTime Finish { get; set; }
        public Vehicles Vehicle { get; set; } //propriedades que serao instanciadas com os objetos ja criados
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicles vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
