
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

    }
}

/*Find the sum of the odd numbers within an array, after cubing the initial integers. The function should return undefined/None/nil/NULL if any of the values aren't numbers.

Note: There are ONLY integers in the JAVA and C# versions of this Kata.*/

public class KataCubeOdd
{
    public static int CubeOdd(int[] arr)
    {
        var oddCubes = arr.Select(z => z * z * z).Where(cube => cube % 2 != 0);
        int result = oddCubes.Sum();
        return result;
    }
}


/*Write a function which removes from string all non-digit characters and parse the remaining to number. E.g: "hell5o wor6ld" -> 56

Function:

GetNumberFromString(string s)*/

public static class ProgramgetNumberFromString
{
    public static int getNumberFromString(string s)
    {
        return int.Parse(string.Concat(s.Where(char.IsDigit)));
    }
}

/*You can print your name on a billboard ad. Find out how much it will cost you. Each character has a default price of £30, but that can be different if you are given 2 parameters instead of 1 (allways 2 for Java).

You can not use multiplier "*" operator.

If your name would be Jeong-Ho Aristotelis, ad would cost £600. 20 leters * 30 = 600 (Space counts as a character).*/


public class KataBillboard
{
    public static double Billboard(string name, double price = 30)
    {
        double result = 0;

        for (int i = 0; i < name.Length; i++)
        {
            result += price;
        }

        return result;
    }
}


/*Create a function close_compare that accepts 3 parameters: a, b, and an optional margin. The function should return whether a is lower than, close to, or higher than b.

Please note the following:

When a is close to b, return 0.
For this challenge, a is considered "close to" b if margin is greater than or equal to the absolute distance between a and b.
Otherwise...

When a is less than b, return -1.

When a is greater than b, return 1.

If margin is not given, treat it as if it were zero.

Assume: margin >= 0

Tip: Some languages have a way to make parameters optional.

Example 1
If a = 3, b = 5, and margin = 3, then close_compare(a, b, margin) should return 0.

This is because a and b are no more than 3 numbers apart.

Example 2
If a = 3, b = 5, and margin = 0, then close_compare(a, b, margin) should return -1.

This is because the distance between a and b is greater than 0, and a is less than b.*/

public class KataCloseCompare
{
    public static int CloseCompare(double a, double b, double margin = 0)
    {
        if (Math.Abs(a - b) <= margin)
        {
            return 0;
        }
        else if (a < b)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}

/*Template Strings
Template Strings, this kata is mainly aimed at the new JS ES6 Update introducing Template Strings
Task
Your task is to return the correct string using the Template String Feature.
Input
Two Strings, no validation is needed.
Output
You must output a string containing the two strings with the word ```' are '```*/

public class Templates
{
    public static string TempleStrings(string obj, string feature)
    {
        return $"{obj} are {feature}";
    }
}


/*Classy Classes
Basic Classes, this kata is mainly aimed at the new JS ES6 Update introducing classes

Task
Your task is to complete this Class, the Person class has been created. You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return johns age is 34*/
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Info
    {
        get { return $"{Name}s age is {Age}"; }
    }
}


/*Create a method all which takes two params:

a sequence
a function (function pointer in C)
and returns true if the function in the params returns true for every element in the sequence. Otherwise, it should return false. If the sequence is empty, it should return true, since technically nothing failed the test.

Example
all((1, 2, 3, 4, 5), greater_than_9) -> false
all((1, 2, 3, 4, 5), less_than_9)    -> True*/

public class KataALL
{
    public static bool All(int[] arr, Func<int, bool> fun)
    {
        return arr.All(fun);
    }
}

/*Given a string s, your task is to return another string such that even-indexed and odd-indexed characters of s are grouped and the groups are space-separated. Even-indexed group comes as first, followed by a space, and then by the odd-indexed part.

Examples
input:    "CodeWars" => "CdWr oeas"
           ||||||||      |||| ||||
indices:   01234567      0246 1357
Even indices 0, 2, 4, 6, so we have "CdWr" as the first group.
Odd indices are 1, 3, 5, 7, so the second group is "oeas".
And the final string to return is "Cdwr oeas".*/

public class KataSortMyString
{
    public static string SortMyString(string s)
    {
        return $"{string.Concat(s.Where((x, i) => i % 2 == 0))} {string.Concat(s.Where((x, i) => i % 2 != 0))}";
    }
}



/*n John's car the GPS records every s seconds the distance travelled from an origin (distances are measured in an arbitrary but consistent unit). For example, below is part of a record with s = 15:

x = [0.0, 0.19, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25]
The sections are:

0.0-0.19, 0.19-0.5, 0.5-0.75, 0.75-1.0, 1.0-1.25, 1.25-1.50, 1.5-1.75, 1.75-2.0, 2.0-2.25
We can calculate John's average hourly speed on every section and we get:

[45.6, 74.4, 60.0, 60.0, 60.0, 60.0, 60.0, 60.0, 60.0]
Given s and x the task is to return as an integer the *floor* of the maximum average speed per hour obtained on the sections of x. If x length is less than or equal to 1 return 0 since the car didn't move.

Example:
With the above data your function gps(s, x) should return 74

Note
With floats it can happen that results depends on the operations order. To calculate hourly speed you can use:

 (3600 * delta_distance) / s.*/
public class GpsSpeed
{

    public static int Gps(int s, double[] x)
    {
        if (x.Length <= 1)
        {
            return 0;
        }

        int maxSpeed = 0;
        for (int i = 1; i < x.Length; i++)
        {
            int speed = (int)(3600 * (x[i] - x[i - 1]) / s);
            maxSpeed = Math.Max(maxSpeed, speed);
        }

        return maxSpeed;
    }
}

/*Complete the method which returns the number which is most frequent in the given input array. If there is a tie for most frequent number, return the largest number among them.

Note: no empty arrays will be given.

Examples
[12, 10, 8, 12, 7, 6, 4, 10, 12]              -->  12
[12, 10, 8, 12, 7, 6, 4, 10, 12, 10]          -->  12
[12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10]  -->   3*/

public class Kata
{
    public static int HighestRank(int[] arr)
    {
        return arr
           .GroupBy(x => x)
           .OrderByDescending(g => g.Count())
           .ThenByDescending(g => g.Key)
           .First()
           .Key;
    }
}


/*Remove the duplicates from a list of integers, keeping the last ( rightmost ) occurrence of each element.

Example:
For input: [3, 4, 4, 3, 6, 3]

remove the 3 at index 0
remove the 4 at index 1
remove the 3 at index 3
Expected output: [4, 6, 3]

More examples can be found in the test cases.

Good luck!*/

public class SolutionSolve
{
    public static int[] Solve(int[] arr)
    {

        Dictionary<int, int> lastOccurrence = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            lastOccurrence[arr[i]] = i;
        }

        return lastOccurrence.OrderBy(kv => kv.Value).Select(kv => kv.Key).ToArray();
    }
}

/*Determine the total number of digits in the integer (n>=0) given as input to the function. For example, 9 is a single digit, 66 has 2 digits and 128685 has 6 digits. Be careful to avoid overflows/underflows.

All inputs will be valid.*/

public class DecTools
{
    public static int Digits(ulong n) => $"{n}".Length;
}


/*Given two numbers and an arithmetic operator (the name of it, as a string), return the result of the two numbers having that operator used on them.

a and b will both be positive integers, and a will always be the first number in the operation, and b always the second.

The four operators are "add", "subtract", "divide", "multiply".

A few examples:(Input1, Input2, Input3 --> Output)

5, 2, "add"      --> 7
5, 2, "subtract" --> 3
5, 2, "multiply" --> 10
5, 2, "divide"   --> 2.5*/

public class KataArithmetic
{
    public static double Arithmetic(double a, double b, string op)
    {
        switch (op)
        {
            case "add":
                return a + b;
            case "subtract":
                return a - b;
            case "multiply":
                return a * b;
            case "divide":
                return a / b;
            default:

                throw new ArgumentException($"Invalid operator:" + op);
        }
    }
}


/*Find the total sum of internal angles (in degrees) in an n-sided simple polygon. N will be greater than 2.
*/

public class KataAngle
{
    public static int Angle(int n)
    {
        return (n - 2) * 180;
    }
}

/*Given a non-negative integer n, write a function to_binary/ToBinary which returns that number in a binary format.
Documentation:
Kata.ToBinary Method (Int32)
Returns the binary representation of a non-negative integer as an integer.
Syntax
public static int ToBinary(
int n
  )

Parameters
n
Type: System.Int32
The integer to convert.

Return Value
Type: System.Int32
The binary representation of the argument as an integer.
to_binary(1) should return 1 
to_binary(5) should return 101to_binary(11) should return 1011 */
public static class KataTiBinary
{
    public static int ToBinary(int n)
    {

        return Convert.ToInt32(Convert.ToString(n, 2));

    }
}


/*Consider the word "abode". We can see that the letter a is in position 1 and b is in position 2. In the alphabet, a and b are also in positions 1 and 2. Notice also that d and e in abode occupy the positions they would occupy in the alphabet, which are positions 4 and 5.

Given an array of words, return an array of the number of letters that occupy their positions in the alphabet for each word. For example,

solve(["abode","ABc","xyzD"]) = [4, 3, 1]
See test cases for more examples.

Input will consist of alphabet characters, both uppercase and lowercase. No spaces.

Good luck!*/

public static class KataSolve
{
    public static List<int> Solve(List<string> arr)
    {
        return arr.Select(word =>
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.ToLower(word[i]) == 'a' + i)
                {
                    count++;
                }
            }
            return count;
        }).ToList();
    }
}

/*Given a string made up of letters a, b, and/or c, switch the position of letters a and b (change a to b and vice versa). Leave any incidence of c untouched.

Example:

'acb' --> 'bca'
'aabacbaa' --> 'bbabcabb'*/

public class KataSwitcheroo
{
    public static string Switcheroo(string x)
    {
        return x.Replace("a", "d").Replace("b", "a").Replace("d", "b");
    }
}



/*Your task is to return the sum of Triangular Numbers up-to-and-including the nth Triangular Number.

Triangular Number: "any of the series of numbers (1, 3, 6, 10, 15, etc.) obtained by continued summation of the natural numbers 1, 2, 3, 4, 5, etc."

[01]
02 [03]
04 05 [06]
07 08 09 [10]
11 12 13 14 [15]
16 17 18 19 20 [21]
e.g. If 4 is given: 1 + 3 + 6 + 10 = 20.

Triangular Numbers cannot be negative so return 0 if a negative number is given.

*/

public class KataSumTriangularNumbers
{
    public static int SumTriangularNumbers(int n)
    {
        if (n < 0)
        {
            return 0;
        }

        return (n * (n + 1) * (n + 2)) / 6;
    }
}

/*Given a sequence of numbers, find the largest pair sum in the sequence.

For example

[10, 14, 2, 23, 19] -->  42 (= 23 + 19)
[99, 2, 2, 23, 19]  --> 122 (= 99 + 23)
Input sequence contains minimum two elements and every element is an integer.*/
public class KataLargestPairSum
{
    public static int LargestPairSum(int[] numbers)
       => numbers.OrderByDescending(x => x).Take(2).Sum();
}

/*Create a function that returns the CSV representation of a two-dimensional numeric array.

Example:

input:
   [[ 0, 1, 2, 3, 4 ],
    [ 10,11,12,13,14 ],
    [ 20,21,22,23,24 ],
    [ 30,31,32,33,34 ]] 
    
output:
     '0,1,2,3,4\n'
    +'10,11,12,13,14\n'
    +'20,21,22,23,24\n'
    +'30,31,32,33,34'
Array's length > 2.*/
public static class KataToCsvText
{
    public static string ToCsvText(int[][] array)
    {
        StringBuilder csvText = new StringBuilder();

        for (int i = 0; i < array.Length; i++)
        {
            csvText.AppendLine(string.Join(",", array[i]));
        }

        return csvText.ToString().TrimEnd();
    }
}

/*Your friend invites you out to a cool floating pontoon around 1km off the beach. Among other things, the pontoon has a huge slide that drops you out right into the ocean, a small way from a set of stairs used to climb out.

As you plunge out of the slide into the water, you see a shark hovering in the darkness under the pontoon... Crap!

You need to work out if the shark will get to you before you can get to the pontoon. To make it easier... as you do the mental calculations in the water you either freeze when you realise you are dead, or swim when you realise you can make it!

You are given 5 variables;

sharkDistance = distance from the shark to the pontoon. The shark will eat you if it reaches you before you escape to the pontoon.

sharkSpeed = how fast it can move in metres/second.

pontoonDistance = how far you need to swim to safety in metres.

youSpeed = how fast you can swim in metres/second.

dolphin = a boolean, if true, you can half the swimming speed of the shark as the dolphin will attack it.

The pontoon, you, and the shark are all aligned in one dimension.

If you make it, return "Alive!", if not, return "Shark Bait!".*/

public class KataShark
{
    public static string Shark(int pontoonDistance, int sharkDistance, int yourSpeed, int sharkSpeed, bool dolphin)
    {
        return pontoonDistance * sharkSpeed < yourSpeed * sharkDistance * (dolphin ? 2 : 1)
          ? "Alive!"
          : "Shark Bait!";
    }
}


/*Basic regex tasks. Write a function that takes in a numeric code of any length. The function should check if the code begins with 1, 2, or 3 and return true if so. Return false otherwise.

You can assume the input will always be a number.*/

public class KataValidateCode
{
    public static bool ValidateCode(string code)
    {
        return Regex.IsMatch(code, "^[1-3]");
    }
}

/*Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer. If the array does not contain any numbers then you should return 0.

Examples
Input: [1, 5.2, 4, 0, -1]
Output: 9.2

Input: []
Output: 0

Input: [-2.398]
Output: -2.398

Assumptions
You can assume that you are only given numbers.
You cannot assume the size of the array.
You can assume that you do get an array and if the array is empty, return 0.
What We're Testing
We're testing basic loops and math operations. This is for beginners who are just learning loops and math operations.
Advanced users may find this extremely easy and can easily write this in one line.*/

public class KataSumArray
{
    public static double SumArray(double[] array)
    {
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }
}

/*Write a function that will check if two given characters are the same case.

If either of the characters is not a letter, return -1
If both characters are the same case, return 1
If both characters are letters, but not the same case, return 0
Examples
'a' and 'g' returns 1

'A' and 'C' returns 1

'b' and 'G' returns 0

'B' and 'g' returns 0

'0' and '?' returns -1*/
public class KataSameCase
{
    public static int SameCase(char a, char b)
    {

        if (!char.IsLetter(a) || !char.IsLetter(b))
        {
            return -1;
        }

        return char.IsUpper(a) == char.IsUpper(b) ? 1 : 0;
    }
}


/*You get any card as an argument. Your task is to return the suit of this card (in lowercase).
Our deck (is preloaded):
string[] Deck =
{
    "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
    "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
    "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
    "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
};
DefineSuit("3♣") -> return "clubs"DefineSuit("3♦") -> return "diamonds"DefineSuit("3♥") -> return "hearts"DefineSuit("3♠") -> return "spades"*/

public partial class KataDefineSuit
{
    public static string DefineSuit(string card)
    {
        string suit = card.Substring(card.Length - 1);
        Dictionary<string, string> Map = new Dictionary<string, string>() {
    {"♣", "clubs"},
    {"♦", "diamonds"},
    {"♥", "hearts"},
    {"♠", "spades"}
  };

        return Map[suit];
    }
}


/*Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.
Each two non empty parts will be in a pair (or an array for languages without tuples or a structin C - C: see Examples test Cases - )
Each part will be in a string
Elements of a pair must be in the same order as in the original array.
Examples of returns in different languages:
a = ["az", "toto", "picaro", "zone", "kiwi"] -->
[["az", "toto picaro zone kiwi"], ["az toto", "picaro zone kiwi"], ["az toto picaro", "zone kiwi"], ["az toto picaro zone", "kiwi"]] 
or
 a = {"az", "toto", "picaro", "zone", "kiwi"} -->
{{"az", "toto picaro zone kiwi"}, {"az toto", "picaro zone kiwi"}, {"az toto picaro", "zone kiwi"}, {"az toto picaro zone", "kiwi"}}
or
a = ["az", "toto", "picaro", "zone", "kiwi"] -->
[("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]
or 
a = [|"az", "toto", "picaro", "zone", "kiwi"|] -->
[("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]
or
a = ["az", "toto", "picaro", "zone", "kiwi"] -->
"(az, toto picaro zone kiwi)(az toto, picaro zone kiwi)(az toto picaro, zone kiwi)(az toto picaro zone, kiwi)"*/

public class PartList
{
    public static string[][] Partlist(string[] arr)
    {
        int n = arr.Length;
        string[][] result = new string[n - 1][];

        for (int i = 0; i < n - 1; i++)
        {
            result[i] = new string[2];
            result[i][0] = string.Join(" ", arr.Take(i + 1));
            result[i][1] = string.Join(" ", arr.Skip(i + 1));
        }

        return result;
    }
}

/*Write a function that returns a string in which firstname is swapped with last name.

Example(Input --> Output)

"john McClane" --> "McClane john"*/

public class KataNameShuffler
{
    public static string NameShuffler(string str)
    {
        string[] names = str.Split(' ');
        return names[1] + " " + names[0];
    }
}

/*Christmas is coming and many people dreamed of having a ride with Santa's sleigh. But, of course, only Santa himself is allowed to use this wonderful transportation. And in order to make sure, that only he can board the sleigh, there's an authentication mechanism.

Your task is to implement the authenticate() method of the sleigh, which takes the name of the person, who wants to board the sleigh and a secret password. If, and only if, the name equals "Santa Claus" and the password is "Ho Ho Ho!" (yes, even Santa has a secret password with uppercase and lowercase letters and special characters :D), the return value must be true. Otherwise it should return false.*/


public class Sleigh
{
    public static bool Authenticate(string name, string password)
    {
        return name == "Santa Claus" && password == "Ho Ho Ho!";
    }
}


/*Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no negative integers.

*/

public static class KataCountSheep
{
    public static string CountSheep(int n)
    {
        string result = "";
        for (int i = 1; i <= n; i++)
        {
            result += $"{i} sheep...";
        }
        return result;
    }
}

/*Very simple, given a number (integer / decimal / both depending on the language), find its opposite (additive inverse).

Examples:

1: -1
14: -14
-34: 34*/

public class KataOposite
{
    public static int Opposite(int number)
    {
        return -number;
    }
}


/*Given an array of numbers, check if any of the numbers are the character codes for lower case vowels (a, e, i, o, u).

If they are, change the array value to a string of that vowel.

Return the resulting array.*/
public class KataISVow
{
    public static object[] IsVow(object[] a)
    {

        int[] vowelCodes = { 97, 101, 105, 111, 117 };


        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] is int && Array.Exists(vowelCodes, code => code == (int)a[i]))
            {
                a[i] = ((char)(int)a[i]).ToString();
            }
        }


        return a;

        //return a.Select(x => "aeiou".Contains(Convert.ToChar(x)) ? Convert.ToChar(x).ToString() : x).ToArray();

    }
}

/*You're on your way to the market when you hear beautiful music coming from a nearby street performer. The notes come together like you wouln't believe as the musician puts together patterns of tunes. As you wonder what kind of algorithm you could use to shift octaves by 8 pitches or something silly like that, it dawns on you that you have been watching the musician for some 10 odd minutes. You ask, "how much do people normally tip for something like this?" The artist looks up. "It's always gonna be about tree fiddy."

It was then that you realize the musician was a 400 foot tall beast from the paleolithic era! The Loch Ness Monster almost tricked you!

There are only 2 guaranteed ways to tell if you are speaking to The Loch Ness Monster: A) it is a 400 foot tall beast from the paleolithic era; B) it will ask you for tree fiddy.

Since Nessie is a master of disguise, the only way accurately tell is to look for the phrase "tree fiddy". Since you are tired of being grifted by this monster, the time has come to code a solution for finding The Loch Ness Monster. Note that the phrase can also be written as "3.50" or "three fifty". Your function should return true if you're talking with The Loch Ness Moster, false otherwise.*/
public static class KataIsLockNessMonster
{
    public static bool IsLockNessMonster(string sentence)
    {
        string lowerCaseSentence = sentence.ToLower();
        return lowerCaseSentence switch
        {
            var s when s.Contains("tree fiddy") => true,
            var s when s.Contains("3.50") => true,
            var s when s.Contains("three fifty") => true,
            _ => false
        };
    }
}


/*Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

Example:

"riley" --> "Hello Riley!"
"JACK"  --> "Hello Jack!"*/

public static class KataGreet
{
    public static string Greet(string name)
    {
        return "Hello " + name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower() + "!";
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

public class KataGreetIsGood
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