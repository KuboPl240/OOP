using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FreightCar : Car
    {
        public int MaxFreight { get; private set; }
        public int Freight  { get; protected set;}
        public FreightCar(int MaxFreight, FuelType fuel, float FuelTankSize):base(FuelTankSize,fuel)
        {
            MaxFreight = this.MaxFreight;
            Freight = 0;   
        }
        public void setFreight(int Freight)
        {
            if (this.Freight > MaxFreight) throw new ArgumentException("Car is full");
            this.Freight = Freight;
        }
        public override string ToString()
        {
            return base.ToString() + 
                   $"\nMaximum number of freight: {MaxFreight}\n" +
                   $"Freight: {Freight}\n";
        }
    }

}
