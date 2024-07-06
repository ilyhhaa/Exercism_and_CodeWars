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
using System.Net.WebSockets;

internal class Program
    {
        private static void Main(string[] args)
        {
        int[] ints = { 1, 1, 2, 3 };

        var a = KataSumNoDuplicates.SumNoDuplicates(ints);

        Console.WriteLine(a);

        Console.ReadLine();

        }
    }


/*Please write a function that sums a list, but ignores any duplicated items in the list.

For instance, for the list [3, 4, 3, 6] the function should return 10,
and for the list [1, 10, 3, 10, 10] the function should return 4.*/

public class KataSumNoDuplicates
{
    public static int SumNoDuplicates(int[] arr)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (countMap.ContainsKey(num))
            {
                countMap[num]++;
            }
            else
            {
                countMap[num] = 1;
            }
        }

        int sum = 0;
        foreach (int num in arr)
        {
            if (countMap[num] == 1)
            {
                sum += num;
            }
        }

        return sum;
    }
}


/*ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

If the function is passed a valid PIN string, return true, else return false.

Examples (Input --> Output)
"1234"   -->  true
"12345"  -->  false
"a234"   -->  false*/

public class KataATMVALID
{
  public static bool ValidatePin(string pin)
  {
     if (pin.Length == 4 || pin.Length == 6)
    { 
        foreach (char c in pin)
        {
            if (!char.IsDigit(c))
            {
                return false; 
            }
        }
        return true;
    }
    return false;
  }
}

/*Your task, is to create N×N multiplication table, of size provided in parameter.

For example, when given size is 3:

1 2 3
2 4 6
3 6 9
For the given example, the return value should be:

[[1,2,3],[2,4,6],[3,6,9]]
*/

class Solution6kyu
{
    public static int[,] MultiplicationTable(int size)
    {
        int[,] table = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                table[row, col] = (row + 1) * (col + 1);
            }
        }

        return table;
    }
}

/*Terminal game move function
In this game, the hero moves from left to right. The player rolls the dice and moves the number of spaces indicated by the dice two times.

Create a function for the terminal game that takes the current position of the hero and the roll (1-6) and return the new position.

Example:
move(3, 6) should equal 15*/

public class GameFuckthisGame
{
    public static int Move(int position, int roll)
    {
        int newPosition = position + (roll * 2);

        return newPosition;
    }
}

/*What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?

Example(Input --> Output)

"apple ban" --> ["apple 5", "ban 3"]
"you will win" -->["you 3", "will 4", "win 3"]
Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .*/



public class AddLengthKata
{
    public static string[] AddLength(string str)
    {
        string[] words = str.Split();
        return words.Select(word => $"{word} {word.Length}").ToArray();
    }
}


/*Task
Given a square matrix, your task is to reverse the order of elements on both of its longest diagonals.

The longest diagonals of a square matrix are defined as follows:

the first longest diagonal goes from the top left corner to the bottom right one;
the second longest diagonal goes from the top right corner to the bottom left one.
Example
For the matrix

1, 2, 3
4, 5, 6
7, 8, 9
the output should be:

9, 2, 7
4, 5, 6
3, 8, 1
Input/Output
[input] 2D integer array matrix

Constraints: 1 ≤ matrix.length ≤ 10, matrix.length = matrix[i].length, 1 ≤ matrix[i][j] ≤ 1000

[output] 2D integer array

Matrix with the order of elements on its longest diagonals reversed.*/

public class KataReverseOnDiagonals
{
    public int[][] ReverseOnDiagonals(int[][] matrix)
    {


        int n = matrix.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = matrix[i][i];
            matrix[i][i] = matrix[n - 1 - i][n - 1 - i];
            matrix[n - 1 - i][n - 1 - i] = temp;
            temp = matrix[i][n - 1 - i];
            matrix[i][n - 1 - i] = matrix[n - 1 - i][i];
            matrix[n - 1 - i][i] = temp;
        }
        return matrix;
    }
}


/*Define a method hello that returns "Hello, Name!" to a given name, or says Hello, World! if name is not given (or passed as an empty String).

Assuming that name is a String and it checks for user typos to return a name with a first capital letter (Xxxx).

Examples:

* With `name` = "john"  => return "Hello, John!"
* With `name` = "aliCE" => return "Hello, Alice!"
* With `name` not given 
  or `name` = ""        => return "Hello, World!"*/

public static class KataNotEightNINE
{
    public static string Hello(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hello, World!";
        }
        else
        {
            string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return $"Hello, {formattedName}!";
        }
    }
}


/*You ask a small girl,"How old are you?" She always says, "x years old", where x is a random number between 0 and 9.

Write a program that returns the girl's age (0-9) as an integer.

Assume the test input string is always a valid string. For example, the test input may be "1 year old" or "5 years old". The first character in the string is always a number.*/


public class KataEightAgain
{
    public static int GetAge(string inputString)
    {
        int.TryParse(inputString.Substring(0, 1), out int age);

        return age;
    }
}



/*Write a function named sumDigits which takes a number as input and 
 * returns the sum 
 * of the absolute value of each of the number's decimal digits.

For example: (Input --> Output)

10 --> 1
99 --> 18
-32 --> 5*/
public class KataSumDigits
{
    //Переписал
    //public static int SumDigits(int number)=> Math.Abs(number).ToString().Select(n => int.Parse(n.ToString())).Sum();
    
   /* //firstВариант
    public static int SumDigits(int number) 
        
     {


        var a = number.ToString();
        int r = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (!char.IsNumber(a[i]))
            {
                continue;
            }

            r += Int32.Parse(a[i].ToString());
        }

        return r;
    }*/
}

/*Task

Given a list of digits, return the smallest number that could be formed from these digits, using the digits only once (ignore duplicates).*/

class KataDelete
{
    public static long MinValue(int[] a)
    {
        StringBuilder stringBuilder = new StringBuilder();

        var r = a.Distinct().OrderBy(b => b).ToArray();

        for (int i = 0; i < r.Length; i++)
        {
            stringBuilder.Append(r[i]);
        }

        return long.Parse(stringBuilder.ToString());
 /*var res = string.Concat(a.OrderBy(x => x).Distinct());
        return Convert.ToInt64(res);*/ //reworked
    }
}
/*Define a function that removes duplicates from an array of non negative numbers and returns it as a result.

The order of the sequence has to stay the same.

Examples:

Input -> Output
[1, 1, 2] -> [1, 2]
[1, 2, 1, 1, 3, 2] -> [1, 2, 3]*/

public class KataDeleteDuplicates
  {
    public int[] distinct(int[] a)
    {
      return a.ToHashSet().ToArray();
    }
  }


/*Americans are odd people: in their buildings, the first floor is actually the ground floor and there is no 13th floor (due to superstition).

Write a function that given a floor in the american system returns the floor in the european system.

With the 1st floor being replaced by the ground floor and the 13th floor being removed, the numbers move down to take their place. In case of above 13, they move down by two because there are two omitted numbers below them.

Basements (negatives) stay the same as the universal level.

More information here

Examples
1  =>  0 
0  =>  0
5  =>  4
15  =>  13
-3  =>  -3*/


public static class KataGetRealFloor
{
  public static int GetRealFloor(int n)
  {
    if (n > 0)
    {
        if (n >= 13)
        {
            return n - 2;
        }
        else
        {
            return n - 1;
        }
    }
    else
    {
        return n;
  }
}
}

/*Replace all vowel to exclamation mark in the sentence. aeiouAEIOU is vowel.

Examples
replace("Hi!") === "H!!"
replace("!Hi! Hi!") === "!H!! H!!"
replace("aeiou") === "!!!!!"
replace("ABCDE") === "!BCD!"


public static class Kata
{
  public static string Replace(string s)
   => Regex.Replace(s, @"[aeiou]","!", RegexOptions.IgnoreCase);
} - запомнить решение через регулярные выражения

*/

public static class KataReplace
{
  public static string Replace(string s)
  {
     char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    StringBuilder result = new StringBuilder();

    foreach (char c in s)
    {
        if (vowels.Contains(c))
        {
            result.Append('!');
        }
        else
        {
            result.Append(c);
        }
    }

    return result.ToString();
  }
}




/*Numbers ending with zeros are boring.

They might be fun in your world, but not here.

Get rid of them. Only the ending ones.

1450 -> 145
960000 -> 96
1050 -> 105
-1050 -> -105
Zero alone is fine, don't worry about it. Poor guy anyway*/

public class NoBoring 
{
    public static int NoBoringZeros(int n) 
    {
        while (n % 10 == 0 && n != 0)
        {
            n /= 10;
        }
        return n;
    }
}



/*Your goal is to return multiplication table for number that is always an integer from 1 to 10.

For example, a multiplication table (string) for number == 5 looks like below:

1 * 5 = 5
2 * 5 = 10
3 * 5 = 15
4 * 5 = 20
5 * 5 = 25
6 * 5 = 30
7 * 5 = 35
8 * 5 = 40
9 * 5 = 45
10 * 5 = 50
P. S. You can use \n in string to jump to the next line.*/


public static class KataMultiplTable
{
    public static string MultiTable(int number)
    {
       StringBuilder table = new StringBuilder();

    for (int i = 1; i <= 10; i++)
    {
        int result = i * number;
        table.Append($"{i} * {number} = {result}");
        if (i < 10)
        {
            table.AppendLine();
        }
    }

    return table.ToString();
    }
}

/*Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).

For example,

[true,  true,  true,  false,
  true,  true,  true,  true ,
  true,  false, true,  false,
  true,  false, false, true ,
  true,  true,  true,  true ,
  false, false, true,  true]
The correct answer would be 17.*/


public static class KataCountingSheep
{
  public static int CountSheeps(bool[] sheeps)
  {
    int count = 0;

    foreach (bool isPresent in sheeps)
    {
        if (isPresent)
        {
            count++;
        }
    }

    return count;
  }
}

/*We need a function that can transform a number (integer) into a string.

What ways of achieving this do you know?

Examples (input --> output):
123  --> "123"
999  --> "999"
-100 --> "-100"*/

public class Eightkyu
{
  public static string NumberToString(int num)
  {
    return num.ToString();
  }
}

/*Build a function that returns an array of integers from n to 1 where n>0.

Example : n=5 --> [5,4,3,2,1]

*/

public static class KataRevSeq
{
  public static int[] ReverseSeq(int n)
  {
   int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = n - i;
    }
    return result;
  }
}

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

    public class KataFirstNONConsecutive
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

    /*A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).

Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.*/

    //a=97
    //z=122
    public static class KataIsPanagram
    {
        public static bool IsPangram(string str)
        {
            var lowerCaseStr = str.ToLower();
            var alphabet = Enumerable.Range('a', 26).Select(i => (char)i);

            return alphabet.All(letter => lowerCaseStr.Contains(letter));

        }
    }

  /*Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple / list (depending on your language) like so: (index1, index2).

For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).

Based on: https://leetcode.com/problems/two-sum/

two_sum([1, 2, 3], 4) == {0, 2}
two_sum([3, 2, 4], 6) == {1, 2}*/


public class KataAnotherTwoSum
{
  public static int[] TwoSum(int[] numbers, int target)
  {
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] + numbers[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return new int[] { -1, -1 };
  }
}

    
}

