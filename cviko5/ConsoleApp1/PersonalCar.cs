using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PersonalCar : Car
    {
        private int MaxPersons = 0;
        public int Passengers { get; protected set; }
        public PersonalCar(int maxPersons, FuelType fuel, float tanksize) : base(tanksize, fuel)
        {
            MaxPersons = maxPersons;
            Passengers = 0;
        }
        public void setPassengers(int Passengers)
        {
            if (this.Passengers > MaxPersons) throw new ArgumentException("Personal car is fully occupied");
            this.Passengers = Passengers;
        }

        public override string ToString()
        {
            return base.ToString()+
                   $"\nCar type: Pesonal car\n" +
                   $"Maximum number of persons: {MaxPersons}\n" +
                   $"Passengers: {Passengers}\n";
        }
    }
}
