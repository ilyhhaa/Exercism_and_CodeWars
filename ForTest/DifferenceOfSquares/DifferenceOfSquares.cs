using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.DifferenceOfSquares
{
    internal class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            List<int> nums = new List<int>();

            int a=0;
            int b =1;

            while (b < max)
            {

                int res = (int)(Math.Pow(a, 2) + (2 * a * b) + Math.Pow(b, 2));

                nums.Add(res);

                a++;
                b++;

            }

            return nums.Sum();

            //(a + b)^2 = a^2 + 2ab + b^2.
        }

        public static int CalculateSumOfSquares(int max)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public static int CalculateDifferenceOfSquares(int max)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
