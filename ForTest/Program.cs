
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

    }
}

/*Exclusive "or" (xor) Logical Operator
Overview
In some scripting languages like PHP, there exists a logical operator (e.g. &&, ||, and, or, etc.) called the "Exclusive Or" (hence the name of this Kata). The exclusive or evaluates two booleans. It then returns true if exactly one of the two expressions are true, false otherwise. For example:

false xor false == false // since both are false
true xor false == true // exactly one of the two expressions are true
false xor true == true // exactly one of the two expressions are true
true xor true == false // Both are true.  "xor" only returns true if EXACTLY one of the two expressions evaluate to true.
Task
Since we cannot define keywords in Javascript (well, at least I don't know how to do it), your task is to define a function xor(a, b) where a and b are the two expressions to be evaluated. Your xor function should have the behaviour described above, returning true if exactly one of the two expressions evaluate to true, false otherwise.

*/

public class KataXOR
{
    public static bool Xor(bool a, bool b)
    {
        return (a && !b) || (!a && b);
    }
}


/*Complete the function power_of_two/powerOfTwo (or equivalent, depending on your language) that determines if a given non-negative integer is a power of two. From the corresponding Wikipedia entry:

a power of two is a number of the form 2n where n is an integer, i.e. the result of exponentiation with number two as the base and integer n as the exponent.

You may assume the input is always valid.

Examples
power_of_two?(1024) # true
power_of_two?(4096) # true
power_of_two?(333)  # false
Beware of certain edge cases - for example, 1 is a power of 2 since 2^0 = 1 and 0 is not a power of 2.*/

public static class KataPowerOfTwo
{
    public static bool PowerOfTwo(int number)
    {
        if (number <= 0)
        {
            return false;
        }
        while (number > 1)
        {
            if (number % 2 != 0)
            {
                return false;
            }
            number /= 2;
        }

        return true;

    }
    //public static bool PowerOfTwo(int n) => new BigInteger(n).IsPowerOfTwo; !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
}

/*Task
Given an array of integers , Find the minimum sum which is obtained from summing each Two integers product .

Notes
Array/list will contain positives only .
Array/list will always have even size
Input >> Output Examples
minSum({5,4,2,3}) ==> return (22) */

class KataMinSum
{
    public static int MinSum(int[] a)
    {

        Array.Sort(a);

        int minSum = 0;
        for (int i = 0, j = a.Length - 1; i < j; i++, j--)
        {
            minSum += a[i] * a[j];
        }

        return minSum;
    }
}

/*Create a function that gives a personalized greeting. This function takes two parameters: name and owner.

Use conditionals to return the proper message:

case	return
name equals owner	'Hello boss'
otherwise	'Hello guest'*/

public class Kata
{
    public static string Greet(string name, string owner)
    {
        return (name == owner) ? "Hello boss" : "Hello guest";
    }
}

/*Remove all exclamation marks from the end of sentence.

Examples
"Hi!"     ---> "Hi"
"Hi!!!"   ---> "Hi"
"!Hi"     ---> "!Hi"
"!Hi!"    ---> "!Hi"
"Hi! Hi!" ---> "Hi! Hi"
"Hi"      ---> "Hi"*/

public class KataRemove
{
    public static string Remove(string s)
    {
        return Regex.Replace(s, "!+$", "");
    }
}

/*Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').

Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').

Create a function which translates a given DNA string into RNA.

For example:

"GCAT"  =>  "GCAU"
The input string can be of arbitrary length - in particular, it may be empty. All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.*/
public class Converter
{
    public string dnaToRna(string dna)
    {
        return dna.Replace('T', 'U');
    }
}

/*Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.

Notes
Array/list size is at least 2.
Array/list numbers could be a mixture of positives, negatives also zeroes .
Input >> Output Examples
adjacentElementsProduct([1, 2, 3]); ==> return 6
Explanation:
The maximum product obtained from multiplying 2 * 3 = 6, and they're adjacent numbers in the array.adjacentElementsProduct([9, 5, 10, 2, 24, -1, -48]); ==> return 50
Explanation:
Max product obtained from multiplying 5 * 10  =  50 .
adjacentElementsProduct([-23, 4, -5, 99, -27, 329, -2, 7, -921])  ==>  return -14
Explanation:
The maximum product obtained from multiplying -2 * 7 = -14, and they're adjacent numbers in the array.

 public static int AdjacentElementsProduct(int[] array)*/

public class KataAdjacentElementsProduct
{
    public static int AdjacentElementsProduct(int[] array)
    {
        int maxProduct = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int product = array[i] * array[i + 1];
            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }

        return maxProduct;

    }
    // return array.Skip(1).Select((x,i) => x * array[i]).Max();
}