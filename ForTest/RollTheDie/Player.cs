using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.RollTheDie
{
    public class Player
    {
        Random Random = new Random();
        public int RollDie()
        {
            return Random.Next(1,18);
        }

        public double GenerateSpellStrength()
        {
            return (double)Random.Next(0, 100);
        }
    }

}
