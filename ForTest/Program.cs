using ForTest.DifferenceOfSquares;
using ForTest.Interest_is_Interesting;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net;
using ForTest._2MonthAlgoFights;

/*Write a method that will search an array of strings for all strings that contain another string, ignoring capitalization. Then return an array of the found strings.

The method takes two parameters, the query string and the array of strings to search, and returns an array.

If the string isn't contained in any of the strings in the array, the method returns an array containing a single string: "Empty" (or Nothing in Haskell, or "None" in Python and C)

Examples

If the string to search for is "me", and the array to search is ["home", "milk", "Mercury", "fish"], the method should return ["home", "Mercury"].*/

public class KataPartialWordSearching
{
  public static string[] WordSearch(string query, string[] seq)
  {
     List<string> foundStrings = new List<string>();
    string queryLower = query.ToLower();
    foreach (string s in seq)
    {
        string sLower = s.ToLower();
        if (sLower.Contains(queryLower))
        {
            foundStrings.Add(s);
        }
    }
    if (foundStrings.Count == 0)
    {
        return new string[] { "Empty" };
    }

    return foundStrings.ToArray();
  }
}

/*Task
Given a string str, reverse it and omit all non-alphabetic characters.

Example
For str = "krishan", the output should be "nahsirk".

For str = "ultr53o?n", the output should be "nortlu".

Input/Output
[input] string str
A string consists of lowercase latin letters, digits and symbols.*/

public class KataReversLetter
{
    public string ReverseLetter(string str)
    {
        string result = string.Empty;

        for (int i = str.Length-1; i>=0 ; i--)
        {
            if (char.IsLetter(str[i]))
            {
                result += str[i];
            }
        }

        return result;

    }


    /*Your task is to find the first element of an array that is not consecutive.

By not consecutive we mean not exactly 1 larger than the previous element of the array.

E.g. If we have an array [1,2,3,4,6,7,8] then 1 then 2 then 3 then 4 are all consecutive but 6 is not, so that's the first non-consecutive number.

If the whole array is consecutive then return null2.

The array will always have at least 2 elements1 and all elements will be numbers. The numbers will also all be unique and in ascending order. The numbers could be positive or negative and the first non-consecutive could be either too!

If you like this Kata, maybe try this one next: https://www.codewars.com/kata/represent-array-of-numbers-as-ranges

1 Can you write a solution that will return null2 for both [] and [ x ] though? (This is an empty array and one with a single number and is not tested for, but you can write your own example test. )

2
Swift, Ruby and Crystal: nil
Haskell: Nothing
Python, Rust, Scala: None
Julia: nothing
Nim: none(int) (See options)*/

    public class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1] + 1)
                {
                    return arr[i];
                }
            }
            return null;

        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {



        }
    }
}
