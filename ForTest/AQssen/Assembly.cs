using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.AQssen
{
    internal class Assembly
    {
        public static double SuccessRate(int speed)
        {
            if (speed == 0)
            {
                return (double)0;
            }
            else if (speed <= 4)
            {
                return (double)1.0;
            }
            else if (speed >= 5 && speed <= 8)
            {
                return (double)0.90;
            }
            else if (speed == 9)
            {
                return (double)0.80;
            }

            else if (speed == 10)
            {
                return (double)0.77;
            }
            return (double)0;

        }

        public static double ProductionRatePerHour(int speed)
        {
            double k = SuccessRate(speed);

            return (double)(speed * 221) * k;

        }

        public static int WorkingItemsPerMinute(int speed)
        {
            double PerHour = ProductionRatePerHour(speed) / 60;

            PerHour = Math.Round(PerHour, MidpointRounding.ToNegativeInfinity);
            return (int)PerHour;
        }
    }
}
