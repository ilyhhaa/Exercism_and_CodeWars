using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.Lucian_s_Luscious_Lasagna.logic
{
    internal class Logic
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake || archerIsAwake || prisonerIsAwake == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (archerIsAwake == false && petDogIsPresent == true)
            {
                return true;
            }
            else if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
