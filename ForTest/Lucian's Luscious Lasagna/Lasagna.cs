using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.Lucian_s_Luscious_Lasagna
{
    internal class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;

        }

        public int RemainingMinutesInOven(int min)
        {
            return 40 - min;
        }

        public int PreparationTimeInMinutes(int layer)
        {
            return layer * 2;
        }

        public int ElapsedTimeInMinutes(int layers, int minutes)
        {
            return (layers * 2) + minutes;
        }
    }
}
