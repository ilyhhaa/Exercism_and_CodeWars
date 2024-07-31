using System.Reflection.Metadata.Ecma335;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {

    }
}
/*Complete the function which returns the weekday according to the input number:

1 returns "Sunday"
2 returns "Monday"
3 returns "Tuesday"
4 returns "Wednesday"
5 returns "Thursday"
6 returns "Friday"
7 returns "Saturday"
Otherwise returns "Wrong, please enter a number between 1 and 7"*/

public class KataWhatDay
{
  public static string WhatDay(int n)
  {
    switch (n)
    {
        case 1:
            return "Sunday";
        case 2:
            return "Monday";
        case 3:
            return "Tuesday";
        case 4:
            return "Wednesday";
        case 5:
            return "Thursday";
        case 6:
            return "Friday";
        case 7:
            return "Saturday";
        default:
            return "Wrong, please enter a number between 1 and 7";
        }
  }
}

/*To find the volume (centimeters cubed) of a cuboid you use the formula:

volume = Length * Width * Height

But someone forgot to use proper record keeping, so we only have the volume, and the length of a single side!

It's up to you to find out whether the cuboid has equal sides (= is a cube).

Return true if the cuboid could have equal sides, return false otherwise.

Return false for invalid numbers too (e.g volume or side is less than or equal to 0).

*/

public class CubeChecker
  {
    public bool IsCube(double volume, double side)
    {
      if (volume <= 0 || side <= 0)
    {
        return false;
    }
    double sideCubed = Math.Pow(side, 3);
    return volume == sideCubed;
    }
  }


/*You were camping with your friends far away from home, but when it's time to go back, you realize that your fuel is running out and the nearest pump is 50 miles away! You know that on average, your car runs on about 25 miles per gallon. There are 2 gallons left.

Considering these factors, write a function that tells you if it is possible to get to the pump or not.

Function should return true if it is possible and false if not.*/

public static class KataZeroFuel
{
  public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
  {
    return mpg * fuelLeft >= distanceToPump;
  }
}

/*Remove an exclamation mark from the end of a string. For a beginner kata, you can assume that the input data is always a string, no need to verify it.

Examples

"Hi!"     ---> "Hi"
"Hi!!!"   ---> "Hi!!"
"!Hi"     ---> "!Hi"
"!Hi!"    ---> "!Hi"
"Hi! Hi!" ---> "Hi! Hi"
"Hi"      ---> "Hi"*/

public class KataRemove
{
  public static string Remove(string s)
  {
   return s.EndsWith("!") ? s.Substring(0, s.Length - 1) : s;
  }
}


/*Write a function that always returns 5

Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/

Good luck :*/

class KataUnusualFive
{
    public static int UnusualFive() => "Hello".Length;
}

/*In this simple exercise, you will create a program that will take two lists of integers, a and b. Each list will consist of 3 positive integers above 0, representing the dimensions of cuboids a and b. You must find the difference of the cuboids' volumes regardless of which is bigger.

For example, if the parameters passed are ([2, 2, 3], [5, 4, 1]), the volume of a is 12 and the volume of b is 20. Therefore, the function should return 8.

Your function will be tested with pre-made examples as well as random ones.*/

public class Kata
{
  public static int FindDifference(int[] a, int[] b) =>
    Math.Abs(a.Aggregate(1, (acc, val) => acc * val) - b.Aggregate(1, (acc, val) => acc * val));
}


/*You are given an array(list) strarr of strings and an integer k. Your task is to return the first longest string consisting of k consecutive strings taken in the array.

Examples:

strarr = ["tree", "foling", "trashy", "blue", "abcdef", "uvwxyz"], k = 2

Concatenate the consecutive strings of strarr by 2, we get:

treefoling   (length 10)  concatenation of strarr[0] and strarr[1]
folingtrashy ("      12)  concatenation of strarr[1] and strarr[2]
trashyblue   ("      10)  concatenation of strarr[2] and strarr[3]
blueabcdef   ("      10)  concatenation of strarr[3] and strarr[4]
abcdefuvwxyz ("      12)  concatenation of strarr[4] and strarr[5]

Two strings are the longest: "folingtrashy" and "abcdefuvwxyz".
The first that came is "folingtrashy" so 
longest_consec(strarr, 2) should return "folingtrashy".

In the same way:
longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"
n being the length of the string array, if n = 0 or k > n or k <= 0 return "" (return Nothing in Elm, "nothing" in Erlang).

Note

consecutive strings : follow one after another without an interruption
*/

public class LongestConsecutives 
{
    
    public static string LongestConsec(string[] strarr, int k) 
    {
       if (strarr.Length == 0 || k > strarr.Length || k <= 0)
        {
            return "";
        }

        string longest = "";
        for (int i = 0; i <= strarr.Length - k; i++)
        {
            string current = string.Concat(strarr.Skip(i).Take(k));
            if (current.Length > longest.Length)
            {
                longest = current;
            }
        }

        return longest;
    }
}
/*Looks like some hoodlum plumber and his brother has been running around and damaging your stages again.

The pipes connecting your level's stages together need to be fixed before you receive any more complaints.

The pipes are correct when each pipe after the first is 1 more than the previous one.

Task

Given a list of unique numbers sorted in ascending order, return a new list so that the values increment by 1 for each index from the minimum value up to the maximum value (both included).*/

public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
  {
    int min = numbers.First();
        int max = numbers.Last();
        return Enumerable.Range(min, max - min + 1).ToList();
  }
}
/*Create a class Ball. Ball objects should accept one argument for "ball type" when instantiated.

If no arguments are given, ball objects should instantiate with a "ball type" of "regular."

ball1 = new Ball();
ball2 = new Ball("super");

ball1.ballType     //=> "regular"
ball2.ballType     //=> "super"*/

public class Ball
{
    public string ballType { get; set; }

    public Ball(string ballType = "regular")
    {
        this.ballType = ballType;
    }
}
/*Starting with .NET Framework 3.5, C# supports a Where (in the System.Linq namespace) method which allows a user to filter arrays based on a predicate. Use the Where method to complete the function given.

Enumerable.Where documentation: https://msdn.microsoft.com/en-us/library/bb534803(v=vs.110).aspx

The solution would work like the following:

Kata.GetEvenNumbers(new int[] {2, 4, 5, 6}) => new int[] {2, 4, 6}*/

public class KataGetEvenNumber
{
  public static int[] GetEvenNumbers(int[] numbers)
  {
     return numbers.Where(n => n % 2 == 0).ToArray();
  }
}
/*When provided with a letter, return its position in the alphabet.

Input :: "a"

Ouput :: "Position of alphabet: 1"*/
public class KataPosition
{
  public static string Position(char alphabet)
  {
    int position = char.ToLower(alphabet) - 'a' + 1;
    return $"Position of alphabet: {position}";
  }
}


/*Your start-up's BA has told marketing that your website has a large audience in Scandinavia and surrounding countries. Marketing thinks it would be great to welcome visitors to the site in their own language. Luckily you already use an API that detects the user's location, so this is an easy win.

The Task

Think of a way to store the languages as a database. The languages are listed below so you can copy and paste!
Write a 'welcome' function that takes a parameter 'language', with a type String, and returns a greeting - if you have it in your database. It should default to English if the language is not in the database, or in the event of an invalid input.
The Database

[ ("english", "Welcome")
, ("czech", "Vitejte")
, ("danish", "Velkomst")
, ("dutch", "Welkom")
, ("estonian", "Tere tulemast")
, ("finnish", "Tervetuloa")
, ("flemish", "Welgekomen")
, ("french", "Bienvenue")
, ("german", "Willkommen")
, ("irish", "Failte")
, ("italian", "Benvenuto")
, ("latvian", "Gaidits")
, ("lithuanian", "Laukiamas")
, ("polish", "Witamy")
, ("spanish", "Bienvenido")
, ("swedish", "Valkommen")
, ("welsh", "Croeso")
]
Possible invalid inputs include:

IP_ADDRESS_INVALID - not a valid ipv4 or ipv6 ip address
IP_ADDRESS_NOT_FOUND - ip address not in the database
IP_ADDRESS_REQUIRED - no ip address was supplied*/


public static class KataGreet
    {
        public static string Greet(string language)
        {
            switch (language?.ToLower())
    {
        case "czech":
            return "Vitejte";
        case "danish":
            return "Velkomst";
        case "dutch":
            return "Welkom";
        case "estonian":
            return "Tere tulemast";
        case "finnish":
            return "Tervetuloa";
        case "flemish":
            return "Welgekomen";
        case "french":
            return "Bienvenue";
        case "german":
            return "Willkommen";
        case "irish":
            return "Failte";
        case "italian":
            return "Benvenuto";
        case "latvian":
            return "Gaidits";
        case "lithuanian":
            return "Laukiamas";
        case "polish":
            return "Witamy";
        case "spanish":
            return "Bienvenido";
        case "swedish":
            return "Valkommen";
        case "welsh":
            return "Croeso";
        default:
            return "Welcome";
                }
        }
    }

/*Just make Fuctorial func*/
public static class FactorialFunc
  {
    public static ulong Factorial(int n)
    {
    ulong result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= (ulong)i;
    }
    return result;
    }
  }
/*Two red beads are placed between every two blue beads. There are N blue beads. After looking at the arrangement below work out the number of red beads.

@ @@ @ @@ @ @@ @ @@ @ @@ @

Implement count_red_beads(n) (in PHP count_red_beads($n); in Java, Javascript, TypeScript, C, C++ countRedBeads(n)) so that it returns the number of red beads.
If there are less than 2 blue beads return 0.*/

public static class KataCountBeads
{
  public static int CountRedBeads(int n)
  {
    if (n < 2)
    {
        return 0;
    }
    return 2 * (n - 1);
  }
}
/*Given an array of positive integers (the weights of the people), return a new array/tuple of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

Notes

Array size is at least 1.
All numbers will be positive.
Input >> Output Examples

rowWeights([13, 27, 49])  ==>  return (62, 27)
Explanation:

The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
Explanation:

The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

rowWeights([80])  ==>  return (80, 0)
Explanation:

The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.*/

class KataRowWeights
{
    public static int[] RowWeights(int[] a)
    {
        int team1Weight = 0;
    int team2Weight = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (i % 2 == 0)
            team1Weight += a[i];
        else
            team2Weight += a[i];
    }

    return new int[] { team1Weight, team2Weight };
    }
}/*You are given two sorted arrays that both only contain integers. Your task is to find a way to merge them into a single one, sorted in asc order. Complete the function mergeArrays(arr1, arr2), where arr1 and arr2 are the original sorted arrays.

You don't need to worry about validation, since arr1 and arr2 must be arrays with 0 or more Integers. If both arr1 and arr2 are empty, then just return an empty array.

Note: arr1 and arr2 may be sorted in different orders. Also arr1 and arr2 may have same integers. Remove duplicated in the returned result.

Examples (input -> output)

* [1, 2, 3, 4, 5], [6, 7, 8, 9, 10] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

* [1, 3, 5, 7, 9], [10, 8, 6, 4, 2] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]*/


public class KataMergeArrays
{
  public static int[] MergeArrays(int[] arr1, int[] arr2)
  {
   return arr1.Concat(arr2).Distinct().OrderBy(x => x).ToArray();
  }
}

/*You are given two vectors starting from the origin (x=0, y=0) with coordinates (x1,y1) and (x2,y2). Your task is to find out if these vectors are collinear. Collinear vectors are vectors that lie on the same straight line. They can be directed in the same or opposite directions. One vector can be obtained from another by multiplying it by a certain number. In terms of coordinates, vectors (x1, y1) and (x2, y2) are collinear if (x1, y1) = (k*x2, k*y2) , where k is any number acting as a coefficient.Problem Description

Write the function collinearity(x1, y1, x2, y2), which returns a Boolean type depending on whether the vectors are collinear or not.

all coordinates are integers
-1000 <= any coordinate <= 1000
Notes

All vectors start from the origin (x=0, y=0).
Be careful when handling cases where x1, x2, y1, or y2 are zero to avoid division by zero errors.
A vector with coordinates (0, 0) is collinear to all vectors.
Examples

(1,1,1,1) ➞ true
(1,2,2,4) ➞ true
(1,1,6,1) ➞ false
(1,2,-1,-2) ➞ true
(1,2,1,-2) ➞ false
(4,0,11,0) ➞ true
(0,1,6,0) ➞ false
(4,4,0,4) ➞ false
(0,0,0,0) ➞ true
(0,0,1,0) ➞ true
(5,7,0,0) ➞ true
*/

public class KataCollinearity
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
       if ((x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0))
        return true;

    if (x2 == 0)
        return x1 == 0;
    if (y2 == 0)
        return y1 == 0;
    double ratioX = (double)x1 / x2;
    double ratioY = (double)y1 / y2;

    return Math.Abs(ratioX - ratioY) < 1e-9;
    }
}

/*Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

If you want to know more: http://en.wikipedia.org/wiki/DNA

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". Your function receives one side of the DNA (string, except for Haskell); you need to return the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

Example: (input --> output)

"ATTGC" --> "TAACG"
"GTAT" --> "CATA"*/

public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        char[] complementaryStrand = new char[dna.Length];
        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    complementaryStrand[i] = 'T';
                    break;
                case 'T':
                    complementaryStrand[i] = 'A';
                    break;
                case 'C':
                    complementaryStrand[i] = 'G';
                    break;
                case 'G':
                    complementaryStrand[i] = 'C';
                    break;
                default:
                    complementaryStrand[i] = dna[i];
                    break;
            }
        }
        return new string(complementaryStrand);
    }
}

/*Write a function that accepts two integers and returns the remainder of dividing the larger value by the smaller value.

Divison by zero should throw a DivideByZeroException.

Examples:
n = 17
m = 5
result = 2 (remainder of `17 / 5`)

n = 13
m = 72
result = 7 (remainder of `72 / 13`)

n = 0
m = -1
result = 0 (remainder of `0 / -1`)

n = 0
m = 1
result - division by zero (refer to the specifications on how to handle this in your language)*/

public class KataRemainder
{
    public static int Remainder(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        return Math.Max(a, b) % Math.Min(a, b);
    }
}

/*Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained (Read the notes for more detail about it)
Example
With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:

1 * (2 + 3) = 5
1 * 2 * 3 = 6
1 + 2 * 3 = 7
(1 + 2) * 3 = 9
So the maximum value that you can obtain is 9.

Notes
The numbers are always positive.
The numbers are in the range (1  ≤  a, b, c  ≤  10).
You can use the same operation more than once.
It's not necessary to place all the signs and brackets.
Repetition in numbers may occur .
You cannot swap the operands. For instance, in the given example you cannot get expression (1 + 3) * 2 = 8.
Input >> Output Examples:
expressionsMatter(1,2,3)  ==>  return 9*/

public class KataExpMatter
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
        int option1 = a * (b + c);
        int option2 = a * b * c;
        int option3 = a + b * c;
        int option4 = (a + b) * c;
        int option5 = a + b + c;

        return Math.Max(Math.Max(Math.Max(Math.Max(option1, option2), option3), option4), option5);
    }
}



/*Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.

Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s. So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

Example:
"MM"      -> 2000
"MDCLXVI" -> 1666
"M"       -> 1000
"CD"      ->  400
"XC"      ->   90
"XL"      ->   40
"I"       ->    1
Help:
Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000*/
public class RomanDecode
{
    public static int Solution(string roman)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

        int total = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && romanValues[roman[i]] < romanValues[roman[i + 1]])
            {
                total -= romanValues[roman[i]];
            }
            else
            {
                total += romanValues[roman[i]];
            }
        }

        return total;
    }
}

/*There is an array with some numbers. All numbers are equal except for one. Try to find it!

findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
It’s guaranteed that array contains at least 3 numbers.

The tests contain some very huge arrays, so think about performance.

This is the first kata in series:*/

public class KataGetUnique
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var grouped = numbers.GroupBy(n => n);
        return grouped.Single(g => g.Count() == 1).Key;
    }
}

/*You are given an odd-length array of integers, in which all of them are the same, except for one single number.

Complete the method which accepts such an array, and returns that single different number.

The input array will always be valid! (odd-length >= 3)*/

class SolutionStray
{
    public static int Stray(int[] numbers)
    {
        var grouped = numbers.GroupBy(n => n);
        return grouped.Single(g => g.Count() == 1).Key;
    }
}

/*As a part of this Kata, you need to create a function that when provided with a triplet, returns the index of the numerical element that lies between the other two elements.

The input to the function will be an array of three distinct numbers (Haskell: a tuple).

For example:

gimme([2, 3, 1]) => 0
2 is the number that fits between 1 and 3 and the index of 2 in the input array is 0.

Another example (just to make sure it is clear):

gimme([5, 10, 14]) => 1
10 is the number that fits between 5 and 14 and the index of 10 in the input array is 1.*/

public class KataGimme
{
    public static int Gimme(double[] inputArray)
    {
        double[] sortedArray = (double[])inputArray.Clone();
        Array.Sort(sortedArray);
        double middleValue = sortedArray[1];
        return Array.IndexOf(inputArray, middleValue);
    }
}


/*Create a function that returns the name of the winner in a fight between two fighters.

Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

Your function also receives a third argument, a string, with the name of the fighter that attacks first.

Example:
  declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"
  
  Lew attacks Harry; Harry now has 3 health.
  Harry attacks Lew; Lew now has 6 health.
  Lew attacks Harry; Harry now has 1 health.
  Harry attacks Lew; Lew now has 2 health.
  Lew attacks Harry: Harry now has -1 health and is dead. Lew wins.
public class Fighter {
  public string Name;
  public int Health, DamagePerAttack;
  public Fighter(string name, int health, int damagePerAttack) {
    this.Name = name;
    this.Health = health;
    this.DamagePerAttack = damagePerAttack;
  }

}*/


public class Fighter
{
    public string Name;
    public int Health;
    public int DamagePerAttack;

    public Fighter(string name, int health, int damagePerAttack)
    {
        this.Name = name;
        this.Health = health;
        this.DamagePerAttack = damagePerAttack;
    }
}
public class KataDeclareWinner
{
    public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        Fighter attacker = firstAttacker == fighter1.Name ? fighter1 : fighter2;
        Fighter defender = firstAttacker == fighter1.Name ? fighter2 : fighter1;

        while (true)
        {
            defender.Health -= attacker.DamagePerAttack;
            if (defender.Health <= 0)
            {
                return attacker.Name;
            }
            Fighter temp = attacker;
            attacker = defender;
            defender = temp;
        }
    }
}

/*Take an integer n (n >= 0) and a digit d (0 <= d <= 9) as an integer.

Square all numbers k (0 <= k <= n) between 0 and n.

Count the numbers of digits d used in the writing of all the k**2.

Implement the function taking n and d as parameters and returning this count.

Examples:
n = 10, d = 1 
the k*k are 0, 1, 4, 9, 16, 25, 36, 49, 64, 81, 100
We are using the digit 1 in: 1, 16, 81, 100. The total count is then 4.

The function, when given n = 25 and d = 1 as argument, should return 11 since
the k*k that contain the digit 1 are:
1, 16, 81, 100, 121, 144, 169, 196, 361, 441.
So there are 11 digits 1 for the squares of numbers between 0 and 25.

public static int NbDig(int n, int d) */

public class CountDig
{

    public static int NbDig(int n, int d)
    {
        int count = 0;
        char digit = d.ToString()[0];

        for (int k = 0; k <= n; k++)
        {
            int square = k * k;
            string squareStr = square.ToString();

            foreach (char c in squareStr)
            {
                if (c == digit)
                {
                    count++;
                }
            }
        }

        return count;
    }
}

//Is it letter????
public class Kata
{
    public static bool IsItLetter(char c)
    {
        if (!char.IsLetter(c)) return false;
        if (char.IsDigit(c)) return false;
        if (char.IsHighSurrogate(c)) return false;
        if (char.IsLowSurrogate(c)) return false;
        return char.IsLetter(c);
    }
}
/*Implement a function that accepts 3 integer values a, b, c. The function should return true if a triangle can be built with the sides of given length and false in any other case.

(In this case, all triangles must have surface greater than 0 to be accepted).

Examples:

Input -> Output
1,2,2 -> true
4,2,3 -> true
2,2,2 -> true
1,2,3 -> false
-5,1,3 -> false
0,2,3 -> false
1,2,9 -> false */
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {

        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
/*This kata requires you to write a function which merges two strings together.
 * It does so by merging the end of the first string with the start
 * of the second string together when they are an exact match.

"abcde" + "cdefgh" => "abcdefgh"
"abaab" + "aabab" => "abaabab"
"abc" + "def" => "abcdef"
"abc" + "abc" => "abc"
NOTE: The algorithm should always use the longest possible overlap.

"abaabaab" + "aabaabab" would be "abaabaabab" and not "abaabaabaabab"*/
public class KataMergeStrings
{
    public static string MergeStrings(string first, string second)
    {
        int maxOverlap = 0;
        for (int i = 1; i <= Math.Min(first.Length, second.Length); i++)
        {
            if (first.Substring(first.Length - i) == second.Substring(0, i))
            {
                maxOverlap = i;
            }
        }
        return first + second.Substring(maxOverlap);
    }
}
/*Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

Examples:

* 'abc' =>  ['ab', 'c_']
* 'abcdef' => ['ab', 'cd', 'ef']*/

public class SplitString
{
    public static string[] Solution(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException("Argument is NULL Or Empty ");
        }
        List<string> list = new List<string>();
        for (int i = 0; i < str.Length; i += 2)
        {
            if (i + 1 < str.Length)
            {
                list.Add(str.Substring(i, 2));
            }
            else
            {
                list.Add(str[i] + "_");
            }
        }

        return list.ToArray();
    }
}
/*Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
Examples (input -> output)
6, "I"     -> "IIIIII"
5, "Hello" -> "HelloHelloHelloHelloHello"*/
public static class KataRepeatStr
{
    public static string RepeatStr(int n, string s)
    {
        StringBuilder sb = new StringBuilder(s.Length * n);
        for (int i = 0; i < n; i++)
        {
            sb.Append(s);
        }
        return sb.ToString();

        // return String.Concat(Enumerable.Repeat(s, n)); Что еще за Repeat()????
    }
}
/*Introduction
The GADERYPOLUKI is a simple substitution cypher used in scouting to encrypt messages. The encryption is based on short, easy to remember key. The key is written as paired letters, which are in the cipher simple replacement.

The most frequently used key is "GA-DE-RY-PO-LU-KI".

 G => A
 g => a
 a => g
 A => G
 D => E
  etc.
The letters, which are not on the list of substitutes, stays in the encrypted text without changes.

Task
Your task is to help scouts to encrypt and decrypt thier messages. Write the Encode and Decode functions.

Input/Output
The input string consists of lowercase and uperrcase characters and white . The substitution has to be case-sensitive.

Example
 Encode("ABCD")          // => GBCE 
 Encode("Ala has a cat") // => Gug hgs g cgt 
 Encode("gaderypoluki"); // => agedyropulik
 Decode("Gug hgs g cgt") // => Ala has a cat 
 Decode("agedyropulik")  // => gaderypoluki
 Decode("GBCE")          // => ABCD*/
public class KataEncodeDecode
{
    private static readonly Dictionary<char, char> Pairs = new Dictionary<char, char>()
    {
        {'g','a' }, { 'd','e' }, { 'r','y' }, {'p','o' }, { 'l','u' }, { 'k','i' },
        {'a','g' }, { 'e','d' }, { 'y','r' }, {'o','p' }, { 'u','l' }, { 'i','k' },
        {'G','A' }, { 'D','E' }, { 'R','Y' }, {'P','O' }, { 'L','U' }, { 'K','I' },
        {'A','G' }, { 'E','D' }, { 'Y','R' }, {'O','P' }, { 'U','L' }, { 'I','K' }
    };

    public static string Encode(string str) => Transform(str, Pairs);
    public static string Decode(string str)
    {
        var reversePairs = Pairs.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
        return Transform(str, reversePairs);
    }

    private static string Transform(string str, Dictionary<char, char> pairs)
    {
        var result = new StringBuilder();

        foreach (var ch in str)
        {
            result.Append(pairs.ContainsKey(ch) ? pairs[ch] : ch);
        }

        return result.ToString();
    }

    /*
     * 
     * ШОК Контент с кодварс
     * using System.Linq;
  public class Kata
  {
        public static string Encode(string str) => Decode(str);
        public static string Decode(string str)
        {
            var s = "GDRPLKgdrplkAEYOUIaeyoui";
            var t = "AEYOUIaeyouiGDRPLKgdrplk";
            return string.Concat(str.Select(x => s.IndexOf(x) < 0 ? x : t[s.IndexOf(x)]));
        }
  }*/
}


/*You will be given an array of non-negative integers and positive integer bin width.

Your task is to create the Histogram method that will return histogram data corresponding to the input array. The histogram data is an array that stores under index i the count of numbers that belong to bin i. The first bin always starts with zero.

On empty input you should return empty output.

Examples:

For input data [1, 1, 0, 1, 3, 2, 6] and binWidth=1 the result will be [1, 3, 1, 1, 0, 0, 1] as the data contains single element "0", 3 elements "1" etc.
For the same data and binWidth=2 the result will be [4, 2, 0, 1]
For input data [7] and binWidth=1 the result will be [0, 0, 0, 0, 0, 0, 0, 1]
*/
public static class KataHistogram
{
    public static uint[] Histogram(uint[] data, uint binWidth)
    {
        if (data.Length == 0)
        {
            return new uint[0];
        }

        uint max = data.Max();
        uint binCount = (max / binWidth) + 1;
        uint[] histogram = new uint[binCount];

        foreach (var number in data)
        {
            uint binIndex = number / binWidth;
            histogram[binIndex]++;
        }
        return histogram;
    }
}
/*Instructions
Write a function that takes a single non-empty string of only lowercase and uppercase ascii letters (word) as its argument, and returns an ordered list containing the indices of all capital (uppercase) letters in the string.

Example (Input --> Output)
"CodEWaRs" --> [0,3,4,6]*/
public static class KataCapitals
{
    public static int[] Capitals(string word)
    {
        List<int> indices = new List<int>();

        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsUpper(word[i]))
            {
                indices.Add(i);
            }
        }

        return indices.ToArray();
    }
}
/*ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet.
 * ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. 
If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english 
alphabet should be shifted, like in the original Rot13 "implementation".*/

public class Kata_ROT13
{

    public static string Rot13(string message)
    {
        //Dictionary<порядок,буква>

        return string.Empty;

    }
}
/*Kids drink toddy.
Teens drink coke.
Young adults drink beer.
Adults drink whisky.
Make a function that receive age, and return what they drink.

Rules:

Children under 14 old.
Teens under 18 old.
Young under 21 old.
Adults have 21 or more.
Examples: (Input --> Output)

13 --> "drink toddy"
17 --> "drink coke"
18 --> "drink beer"
20 --> "drink beer"
30 --> "drink whisky"*/
public class KataPeopleWithAgeDrink
{
    public static string PeopleWithAgeDrink(int old)
    {
        switch (old)
        {
            case var _ when old < 14:
                return "drink toddy";
            case var _ when old < 18:
                return "drink coke";
            case var _ when old < 21:
                return "drink beer";
            default:
                return "drink whisky";
        }
    }
}
/*Story
Your online store likes to give out coupons for special occasions. Some customers try to cheat the system by entering invalid codes or using expired coupons.

Task
Your mission:
Write a function called checkCoupon which verifies that a coupon code is valid and not expired.

A coupon is no more valid on the day AFTER the expiration date. All dates will be passed as strings in this format: "MONTH DATE, YEAR".

Examples:
CheckCoupon("123", "123", "July 9, 2015", "July 9, 2015")  ==  true
CheckCoupon("123", "123", "July 9, 2015", "July 2, 2015")  ==  false*/
public static class KataCheckCoupon
{
    public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
    {
        if (enteredCode != correctCode)
        {
            return false;
        }
        DateTime currentDateParsed = DateTime.Parse(currentDate);
        DateTime expirationDateParsed = DateTime.Parse(expirationDate);
        return currentDateParsed <= expirationDateParsed;
    }
}
/*Character recognition software is widely used to digitise printed texts. Thus the texts can be edited, searched and stored on a computer.

When documents (especially pretty old ones written with a typewriter), are digitised character recognition softwares often make mistakes.

Your task is correct the errors in the digitised text. You only have to handle the following mistakes:

S is misinterpreted as 5
O is misinterpreted as 0
I is misinterpreted as 1
The test cases contain numbers only by mistake.
*/
public class KataCorrect
{
    public static string Correct(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        text = text.Replace('5', 'S')
                   .Replace('0', 'O')
                   .Replace('1', 'I');
        return text;
    }
}
/*Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

If the input is an empty array or is null, return an empty array.

Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].*/

public class KataCountPositivesSumNegatives
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int positiveCount = 0;
        int negativeSum = 0;

        if (input == null || input.Length == 0)
        {
            return new int[0];
        }

        foreach (int num in input)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeSum += num;
            }
        }

        return new int[] { positiveCount, negativeSum };
    }
    /*n this Kata, you will be given a string that may have mixed uppercase and lowercase letters and your task is to convert that string to either lowercase only or uppercase only based on:

    make as few changes as possible.
    if the string contains equal number of uppercase and lowercase letters, convert the string to lowercase.
    For example:

    solve("coDe") = "code". Lowercase characters > uppercase. Change only the "D" to lowercase.
    solve("CODe") = "CODE". Uppercase characters > lowecase. Change only the "e" to uppercase.
    solve("coDE") = "code". Upper == lowercase. Change all to lowercase.
    More examples in test cases. Good luck!*/
    class Kata_Fix_String_Case
    {
        public static string Solve(string s)
        {
            return s.Count(char.IsLower) < s.Length / 2 ? s.ToUpper() : s.ToLower();
        }
    }

    /*Given a string, capitalize the letters that occupy even indexes and odd indexes separately, and return as shown below. Index 0 will be considered even.

    For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.

    The input will be a lowercase string with no spaces.

    Good luck!*/
    public static class KataCapitalize
    {
        public static string[] Capitalize(string s)
        {
            var evenChars = new string(s.Select((c, index) => index % 2 == 0 ? char.ToUpper(c) : c).ToArray());
            var oddChars = new string(s.Select((c, index) => index % 2 != 0 ? char.ToUpper(c) : c).ToArray());

            return new string[] { evenChars, oddChars };
        }
    }
    /*Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside and the longer string on the inside. The strings will not be the same length, but they may be empty ( zero length ).

    Hint for R users:

    The length of string is not always the same as the number of characters
    For example: (Input1, Input2) --> output

    ("1", "22") --> "1221"
    ("22", "1") --> "1221"
    ShortLongShort.solution("1", "22"); // returns "1221"
    ShortLongShort.solution("22", "1"); // returns "1221"*/
    public class ShortLongShort
    {
        public static string Solution(string a, string b)
        {
            int lenA = a.Length;
            int lenB = b.Length;

            if (lenA > lenB)
                return b + a + b;
            else
                return a + b + a;
        }
    }
    /*Given a starting list/array of data, it could make some statistical sense to know how much each value differs from the average.

    If for example during a week of work you have collected 55,95,62,36,48 contacts for your business, it might be interesting to know the total (296), the average (59.2), but also how much you moved away from the average each single day.

    For example on the first day you did something less than the said average (55, meaning -4.2 compared to the average), much more in the second day (95, 35.8 more than the average and so on).

    The resulting list/array of differences starting from [55, 95, 62, 36, 48] is thus [4.2, -35.8, -2.8, 23.2, 11.2].

    Assuming you will only get valid inputs (ie: only arrays/lists with numbers), create a function to do that, rounding each difference to the second decimal digit (this is not needed in Haskell); extra points if you do so in some smart, clever or concise way :)

    With Clojure to round use:
    (defn roundTo2 [n] (/ (Math/round (* n 100.0)) 100.0))*/
    public class KataDistancesFromAverage
    {
        public static double[] DistancesFromAverage(int[] input)
        {
            List<double> result = new List<double>();

            foreach (int i in input)
            {
                result.Add(Math.Round(input.Average() - i, 2));
            }

            return result.ToArray();

            /*double average = input.Average();
        return input.Select(i => Math.Round(average - i, 2)).ToArray();*/
        }
    }

    /*You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

    #Examples:

    Kata.getMiddle("test") should return "es"

    Kata.getMiddle("testing") should return "t"

    Kata.getMiddle("middle") should return "dd"

    Kata.getMiddle("A") should return "A"
    #Input

    A word (string) of length 0 < str < 1000 (In javascript you may get slightly more than 1000 in some test cases due to an error in the test cases). You do not need to test for this. This is only here to tell you that you do not need to worry about your solution timing out.

    #Output

    The middle character(s) of the word represented as a string.*/
    public class KataGetMiddle
    {
        public static string GetMiddle(string s)
        {
            if (s.Length % 2 == 0)
            {
                return string.Concat(s.ElementAt(s.Length / 2 - 1), s.ElementAt(s.Length / 2));
            }
            else
            {
                return string.Concat(s.ElementAt(s.Length / 2));
            }
        }
    }
    /*Given an array of integers, return a new array with each value doubled.

    For example:

    [1, 2, 3] --> [2, 4, 6]
    */
    public class KataMaps
    {
        public static int[] Maps(int[] x)
        {
            return x.Select(x => x * 2).ToArray();
        }
    }
    /*Santa believes in fairness and wants to give each giftee a present in turn rather than handing all of an individual's presents to them, then all to the next person, and so on.
    Santa would much rather give one to Sarah, one to Mo, one to Kai, one to Charlie, and cycle through until he's out of presents. But if Sarah is only given 10 presents and after the 10th cycle Santa has no more for her, Santa will continue the loop of gift-giving but excluding Sarah.
    Write a function which accepts a string[] and returns a string[], re-ordering the random input passed into Santa's defined order.
    The output array length will be the same as the input length. The sorted list should be alphabetical by name.
    Examples:
    input:        "Sarah", "Charlie", "Mo"          
    santa sorted: "Charlie", "Mo", "Sarah"
    input:        "Sarah", "Sarah", "Charlie", "Charlie", "Charlie", "Mo", "Mo"
    santa sorted: "Charlie", "Mo", "Sarah", "Charlie", "Mo", "Sarah", "Charlie"*/
    public static class SantaKata
    {
        public static string[] SantaSort(string[] unsortedNames)
        {
            var sortedNames = unsortedNames.OrderBy(name => name).ToList();


            var nameCounts = sortedNames.GroupBy(name => name)
                                        .ToDictionary(group => group.Key, group => group.Count());


            var result = new List<string>();
            while (nameCounts.Values.Sum() > 0)
            {
                foreach (var name in nameCounts.Keys.OrderBy(name => name))
                {
                    if (nameCounts[name] > 0)
                    {
                        result.Add(name);
                        nameCounts[name]--;
                    }
                }
            }

            return result.ToArray();
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

            for (int i = str.Length - 1; i >= 0; i--)
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
}


