using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Car
    {

        public float FuelTankSize { get; protected set; }
        public float FuelTankLevel { get; protected set; }
        public enum FuelType
        {
            diesel,
            gas
        }
        private Radio radio { get; set; }

        public void setStation(int number)
        {
            radio.stationFromList(number);
        }

        public void addStation(int number, double frequncy)
        {
            radio.setNewStation(number, frequncy);
        }
        protected Car(float FuelTankSize, FuelType Fuel)
        {
            this.FuelTankSize = FuelTankSize;
            this.Fuel = Fuel;
            radio = new Radio();
        }
        public FuelType Fuel { get; protected set; }
        public void Refuel(FuelType Fuel, float FuelAmount)
        {
            if (Fuel != this.Fuel)throw new ArgumentException("Incorrect fuel type");
            if (FuelAmount > FuelTankSize) throw new ArgumentException("FuelTank overflow");
            FuelTankLevel += FuelAmount;
        }
        public override string ToString()
        {
            return $"Fuel type: {Fuel}\n" +
                   $"Fuel tank level: {FuelTankLevel}\n" +
                   $"Radio status: {radio.RadioPowerStatus}\n" +
                   $"Radio frequncy: {radio.frequency}";
        }
    }
}
