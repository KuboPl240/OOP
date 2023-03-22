using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko7
{
    internal class Extreme
    {
        public static T Smallest<T>(T[] pole) where T : IComparable
        {
            if (pole.Length == 0) { throw new ArgumentException(""); }

            T min = pole[0];
            for (int i = 0; i < pole.Length; i++)
            {
                if (min.CompareTo(pole[i]) > 0)
                {
                    min = pole[i];
                }
            }
            return min;

        }
        public static T Biggest<T>(T[] pole) where T : IComparable
        {
            if (pole.Length == 0) { throw new ArgumentException(""); }

            T max = pole[0];
            for (int i = 0; i < pole.Length; i++)
            {
                if (max.CompareTo(pole[i]) < 0)
                {
                    max = pole[i];
                }
            }
            return max;
        }
    }
}
