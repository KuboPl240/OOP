using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Radio
    {
        public bool RadioPowerStatus { get; set; }
        public double frequency { get; private set; }
        private Dictionary<int, double> stations = new Dictionary<int, double>();

        public void setNewStation(int number, double frequency)
        {
            stations.Add(number, frequency);
        }

       public void stationFromList(int number)
        {
            if (stations.ContainsKey(number))
            {
                frequency = stations[number];
            }
            else
            {
                throw new Exception("Radio station is not listed");
            }
        }
    }
}
