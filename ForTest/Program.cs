﻿using ForTest.DifferenceOfSquares;
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
internal class Program
{
    private static void Main(string[] args)
    {
        Main(args);
       

    }
}
