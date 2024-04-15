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

internal class Program
{
    private static void Main(string[] args)
    {
        var a = Kata33.summation(8);
        Console.WriteLine( a );
        Console.ReadLine();
    }
}


class Difference
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;

        for (int i = 1; i < max; i++)
        {
            sum += i;
        }

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;

        for (int i = 0; i < max; i++)
        {
            sum += i * i;
        }

        return sum;
    }
    public static int CalculateDifferenceOfSquares(int max)
    {
        int x = CalculateSquareOfSum(max);
        int y = CalculateSumOfSquares(max);

        return x - y;
    }
}

class Triangle
{
    public static bool IsTriangle(double side1, double side2, double side3)
    {
        if ((side1 + side2 >= side3)||(side2 + side3 >= side1)||(side3 + side1 >= side2))
        {
            return true;
        }
        else return false;
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (IsTriangle(side1, side2, side3) == true)
        {
            if (side1 != side2 && side2 != side3 && side3 != side1)
            {
                return true;
            }
            else return false;
        }
        else return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        if (IsTriangle(side1, side2, side3) == true)
        {
            if ((side1 - side2 == 0)||(side1 - side3 == 0)||(side2 - side3 == 0))
            {
                return true;
            }
            else return false;
        }
        else return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        if ((IsTriangle(side1, side2, side3) == true))
        {
            if (side1 == side2 && side2 == side3 && side3 == side1)
            {
                return true;

            }
            else return false;
        }
        else return false;
    }

}



static class LogLine
{
    public static string Message(string logLine) =>
        logLine[(logLine.IndexOf(':') + 1)..].Trim();
    public static string LogLevel(string logLine) =>
        logLine[1..logLine.IndexOf(']')].ToLower();
    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}


class RemoteControlCar1
{
    public int Battery { get; private set; } = 100;
    public int Distance { get; private set; } = 0;

    public static RemoteControlCar1 Buy() => new RemoteControlCar1();

    public string DistanceDisplay() => $"Driven {Distance} meters";

    public string BatteryDisplay() => Battery <= 0 ? "Battery empty" : $"Battery at {Battery}%";

    public void Drive()
    {
        if (Battery != 0)
        {
            Battery--;
            Distance += 20;
        }
    }
}


class RemoteControlCar
{
    public int Speed { get; set; }
    public int BatteryDrain { get; set; }

    public int Battery { get; set; } = 100;

    public int CurrentDistance { get; set; }

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.Speed = speed;
        this.BatteryDrain = batteryDrain;
    }



    public bool BatteryDrained()
    {
        if (Battery == 0 || Battery <= 0)
        {
          return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return CurrentDistance;
    }

    public void Drive()
    {
        if (Speed != 0 || Speed! < 0)
        {
            Battery -= BatteryDrain;

            while (BatteryDrained() && Battery > 0)
            {
                CurrentDistance += Speed;
            }

        }

    }
    public static RemoteControlCar Nitro()
    {
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }
}

class RaceTrack
{
    public int Meters { get; set; }

  
    public RaceTrack(int meters)
    {
        this.Meters = meters;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}





public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        (bool, bool, string) t1;

        string substring = "555";

        if (phoneNumber.IndexOf(substring, 4) == 4)
        {
            t1.Item2 = true;
        }
        else
        {
            t1.Item2 = false;
        }

        if (phoneNumber.StartsWith("212"))
        {
            t1.Item1 = true;
        }
        else
        {
            t1.Item1 = false;
        }
        t1.Item3 = phoneNumber.Substring(9);

        return t1;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {

        var t1 = phoneNumberInfo.ToTuple();

        return t1.Item2;
    }
}



/*public static class Kata
{
    public static int MakeNegative(int number)
    {

        return number>0 ? (number-(number*2)) : (number);
    }
}*/

public class Kata
{
    public static int[] Between(int a, int b)
    {
        List<int> ints = new List<int>();

        for (int i = a; i <= b; i++)
        {
            ints.Add(i);
        }

        return ints.ToArray();

    }
}


public static class Kata2
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        List<object> list = new List<object>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                list.Add(arr[i]);
            }

        }
        return list.ToArray();
    }
}

public class Kata3
{
    public static string UpdateLight(string current)
    {
        {
            if (current == "yellow")
            {
                return "red";
            }
            else if (current == "red")
            {
                return "green";
            }
            else return "yellow";
        }
    }
}


public static class Kata4
{
    public static bool XO(string input)
    {
        return input.ToLower().Count(s => s == 'x') == input.ToLower().Count(s => s == 'o');
    }
}

public class Kata5
{
    public static int FindSmallestInt(int[] args)
    {
        return args.Min();
    }
    public static int CockroachSpeed(double x)
    {
        return Convert.ToInt32(Math.Truncate((Math.Round(x * 100000d / 3600d, 2))));
    }
}

public class kata6
{
    public static string Longest(string s1, string s2)
    {
        var comb = s1.Concat(s2).Distinct().ToArray();

        var sorted = new string(comb.OrderBy(s => s).ToArray());

        return sorted;

    }
}



public static class kata7
/*
 * When provided with a number between 0-9, return it in words.
 * Input :: 1
 * Output :: "One".
 * 
 */
{
    public static string SwitchItUp(int number)
    {
        switch (number)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            case 10:
                return "Ten";
            default:
                return "Invalid number";
        }
    }
    
}


public class Kata8
{
    public static int FinalGrade(int exam, int projects)
    {

        if ((exam > 90 && projects > 10) || (exam > 90 || projects > 10))
        {
            return 100;
        }
        else if((exam>75 && projects > 5)||(exam > 75 || projects > 5))
        {
            return 90;
        }
        else if ((exam>50 && projects >= 2)|| (exam > 50 || projects>2))
        {
            return 75;
        }
        else if((exam<50  && projects < 2) || (exam<50 || projects<2))
        {
            return 0;
        }
        else
        {
            return 0;
        }


    }
}


public static class Kata9
{
    public static string boolToWord(bool word)
    {
        return word == true ? "Yes" : "No";
    }
}

/*Create a function which answers the question "Are you playing banjo?".
If your name starts with the letter "R" or lower case "r", you are playing banjo!

The function takes a name as its only argument, and returns one of the following strings:*/
public class Kata10
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.ToUpper().StartsWith('R') ? $"{name} plays banjo" : $"{name} does not play banjo";
    }
}

public class MinMax
{

    /*Story
    Ben has a very simple idea to make some profit: he buys something and sells it again.Of course, this wouldn't give him any profit at all if he was simply to buy and sell it at the same price. Instead, he's going to buy it for the lowest possible price and sell it at the highest.

    Task
    Write a function that returns both the minimum and maximum number of the given list/array.*/
   
    
    public static int[] minMax(int[] lst)
    {
       return new int[2] {lst.Min(),lst.Max()};
    }
}


/*
 * 
 * This function should test if the factor is a factor of base.

Return true if it is a factor or false if it is not.

About factors
Factors are numbers you can multiply together to get another number.

2 and 3 are factors of 6 because: 2 * 3 = 6

Note: base is a non-negative number, factor is a positive number.
 * 
 */

public class Kata11
{
    public static bool CheckForFactor(int num, int factor) => num%factor == 0;
    
}

/*
 * Given the triangle of consecutive odd numbers:

             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...
Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)

1 -->  1
2 --> 3 + 5 = 8

 */


public static class Kata12
{
    public static long RowSumOddNumbers(long n)
    {
        long firstNumber = (n - 1) * n + 1;
        long rowSum = 0;
        for (int i = 0; i < n; i++)
        {
            rowSum += firstNumber + 2 * i;
        }
        return rowSum;

    }
    public static long RowSumOddNumbers2(long n)
    {
        return (long)Math.Pow(n, 3); //Ohhh
    }
}


/*
 * 
 * In a factory a printer prints labels for boxes. For one kind of boxes the printer has to use colors which, for the sake of simplicity, are named with letters from a to m.

The colors used by the printer are recorded in a control string. For example a "good" control string would be aaabbbbhaijjjm meaning that the printer used three times color a, four times color b, one time color h then one time color a...

Sometimes there are problems: lack of colors, technical malfunction and a "bad" control string is produced e.g. aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.

You have to write a function printer_error which given a string will return the error rate of the printer as a string representing a rational whose numerator is the number of errors and the denominator the length of the control string. Don't reduce this fraction to a simpler expression.

The string has a length greater or equal to one and contains only letters from ato z.
 * 
 */

public class Printer
{
    public static string PrinterError(string s)
    {
        return s.Where(c => c > 'm').Count() + "/" + s.Length;
    }
    
    public static string PrinterErrorFORFUNxD(string s)
    {
        byte[] ascii_Res = Encoding.ASCII.GetBytes(s);

        var a = ascii_Res.OrderBy(x => x).ToList().Count();

        var b = ascii_Res.ToList().RemoveAll(x => x > 109);



        return $"{a-b}" + "/" + $"{a}";
    }
}


public class Kata13
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
       return a.Where(x=>!b.Contains(x)).ToArray();

        /*
         * 
         * 
         * Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

              It should remove all values from list a, which are present in list b keeping their order.

             Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
                If a value is present in b, all of its occurrences must be removed from the other:

                Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
         * 
         * 
         * 
         * 
         */

    }
}

public class Kata14_1
{
    public static int FindShort(string s)
    {
        return s.Split(' ').ToList().OrderBy(s => s.Length).FirstOrDefault().Count();
        
    }
}







public static class Kata15
{
    public static string AlphabetPosition(string text)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char lowerC = char.ToLower(c);
                int position = lowerC - 'a' + 1;
                result.Append(position).Append(" ");
            }
        }

       
        if (result.Length > 0)
            result.Length--;

        return result.ToString();


        //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));



    }
}


/*
 * 
 * input
an array of integers, all numbers in the array are either even or odd except one

output
The number does not match the array.
 * 
 * 
 * 
 */

public class Kata16
{
    public static int Find(int[] integers)
    {
       var a =  integers.ToList().Count(p => p % 2 == 0);

        int res = 0;

        if (a==1)
        {
            res = Array.Find(integers, num => num % 2 == 0);
        }
        else
        {
            res = Array.Find(integers, num => num % 2 != 0);
        }

        return res;
       
    }
}



//pop growth
class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int years = 0;
        while (p0 < p)
        {
            p0 += (int)(p0 * percent / 100) + aug;
            years++;
        }
        return years;

    }
}

public class Kata17
{
    public static string DuplicateEncode(string word)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();
        foreach (char c in word)
        {
            if (charCounts.ContainsKey(c))
                charCounts[c]++;
            else
                charCounts[c] = 1;
        }
        string result = "";
        foreach (char c in word)
        {
            if (charCounts[c] == 1)
                result += "(";
            else
                result += ")";
        }

        return result;
    }
}


public class Kata18
{
    public static string Smash(string[] words)
    {
        return string.Join(" ", words);
    }
}


/*public class DirReduction
{

    static string[] SimplifyDirections(string[] arr)
    {
        Stack<string> stack = new Stack<string>();
        Dictionary<string, string> opposites = new Dictionary<string, string>
            {
                { "NORTH", "SOUTH" },
                { "SOUTH", "NORTH" },
                { "EAST", "WEST" },
                { "WEST", "EAST" }
            };

        foreach (string direction in arr)
        {
            if (stack.Count > 0 && stack.Peek() == opposites[direction])
            {
                stack.Pop();
            }
            else
            {
                stack.Push(direction);
            }
        }

        return stack.ToArray();
    }*/ //Разберись что пошло не по плану


public class Kata19
{
    public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return (flower1 % 2 == 0 && flower2 % 2 != 0)||(flower1%2!=0 && flower2%2==0) ? true:false;
        }
    }
}

public class Kata20
{
    public static string HighAndLow(string numbers)
    {
       var sstring = numbers.Split(" ", ',');

        List<int> values = new List<int>();

        for (int i = 0; i < sstring.Length; i++)
        {
            int res = Int32.Parse(sstring[i]);
            values.Add(res);

        }

        StringBuilder stringBuilder = new StringBuilder();

        return stringBuilder.Append($"{values.Max()}" + " " + $"{values.Min()}").ToString();

        
   }
}
public class Kata22
{
    public static int[] Divisors(int n)
    {
        List<int> ints = new List<int>();

        if (n==null)
        {

        }

        for (int i = 2; i < n-1; i++)
        {
            if (n%i==0)
            {
                ints.Add(i);
            }
        }
        if (ints.Count==0)
        {
            return null;
        }
        return ints.ToArray();
    }
}

/*Digital root is the recursive sum of all the digits in a number.

Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

Examples

    16  -->  1 + 6 = 7
   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6 */
    
    public class Number
{
    public static int DigitalRoot(long n)
    {
        List<int> ints = new List<int>();
        do
        {
            ints.Clear();
            var a = n.ToString().ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                int f = int.Parse(a[i].ToString());

                ints.Add(f);
               
               


            }
            n = ints.Sum();
            

        } while (ints.Count()!=1);

        return ints.First();
        
        
    }
}
///Есть такое решение и его надо запомнить !!!!
/*
public class Number
{
    // See: https://en.wikipedia.org/wiki/Digital_root#Congruence_formula
    public static int DigitalRoot(long number)
    {
        if (number == 0)
            return 0;
        if (number % 9 == 0)
            return 9;
        return (int)(number % 9);
    }
}
*/

  public class Sum
{
    public static int GetSum(int a, int b)
    {


        if (a == b)
        {
            return a;
        }
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }

        return sum;
    }

}

public class Kata23
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        return ClassPoints.Average() < YourPoints;
    }
}

public static class SpacesRemover
{
    public static string NoSpace(string input)
    {
        return new string(input.ToCharArray()
        .Where(c => !Char.IsWhiteSpace(c))
        .ToArray());

        //return input.Replace(" ", ""); Запомнить записать  
    }

    /*
    
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

Additionally, if the number is negative, return 0.

Note: If the number is a multiple of both 3 and 5, only count it once    
    
    
    */

    public static class Mult35
    {
        public static int Solution(int value)
        {
            if (value < 0)
            {
                return 0;
            }

            List<int> ints = new List<int>();
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    ints.Add(i);
                }
            }
            ints.ToHashSet();
            return ints.Sum();
        }

        /*
public static class Kata
{
  public static int Solution(int value) => Enumerable.Range(0, value).Sum(i => i % 3 == 0 || i % 5 == 0 ? i : 0);
}
        Запомнить разобрать проработать!
        
        */
    }

    /*
    Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

Examples:

solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false    
    */

    public class Kata25
    {
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }

    /*
     In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

    Example

    ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
    ListFilterer.GetIntegersFromList(new List<object>(){1, "a", "b", 0, 15}) => {1, 0, 15}
    ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 123}) => {1, 2, 231}


     */
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {

            return listOfItems.OfType<int>();
        }
    }


    /*
     Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

    The binary number returned should be a string.

    Examples:(Input1, Input2 --> Output (explanation)))

    1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
    5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)

     */

    public static class Kata26
    {
        public static string AddBinary(int a, int b) => Convert.ToString((a + b), 2);

    }


    /*
     Create a function that checks if a number n is divisible by two numbers x AND y. All inputs are positive, non-zero numbers.
     */

    public class DivisibleNb
    {
        public static bool IsDivisible(int n, int x, int y)
        {
            return (n % x == 0 && n % y == 0) ? true : false;
        }
    }

    public class kata27
    {
        public static string BooleanToString(bool b)
        {
            return b.ToString();
        }
    }

    /*

     You get an array of numbers, return the sum of all of the positives ones.

    Example [1,-4,7,12] => 1 + 7 + 12 = 20 
     */
    public class Kata28
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(c => c < 0).Sum();

        }
    }
    /*
 Make me a window. I'll give you a number (num). You return a window.

Rules:

The window will always be 2 x 2.

The window needs to have N number of periods across and N number of periods vertically in each pane.

Example:

N = 3

---------
|...|...|
|...|...|
|...|...|
|---+---|
|...|...|
|...|...|
|...|...|
---------
Note: there should be no trailing new line characters at the end.
 */

    static class KataWindow
    {
        public static string MakeAWindow(int num)
        {
            string line = new string('.', num);
            string pane = "|" + string.Join("|", Enumerable.Repeat(line, 2)) + "|";
            string window = string.Join("\n", Enumerable.Repeat(pane, num)) + "\n" +
                            "|" + string.Join("+", Enumerable.Repeat(new string('-', num), 2)) + "|\n" +
                            string.Join("\n", Enumerable.Repeat(pane, num));

            return new string('-', num * 2 + 3) + "\n" + window + "\n" + new string('-', num * 2 + 3);
        }
    }
}

/*Given an array of ones and zeroes, convert the equivalent binary value to an integer.

Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.

Examples:

Testing: [0, 0, 0, 1] ==> 1
Testing: [0, 0, 1, 0] ==> 2
Testing: [0, 1, 0, 1] ==> 5
Testing: [1, 0, 0, 1] ==> 9
Testing: [0, 0, 1, 0] ==> 2
Testing: [0, 1, 1, 0] ==> 6
Testing: [1, 1, 1, 1] ==> 15
Testing: [1, 0, 1, 1] ==> 11

Задачка с подвохом
 */ 
class Kata29
{
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
        return Convert.ToInt32(string.Join("", BinaryArray), 2);
    }
}
/*Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.

Write a function which takes a list of strings and returns each line prepended by the correct number.

The numbering starts at 1. The format is n: string. Notice the colon and space in between.

Examples: (Input --> Output)

[] --> []
["a", "b", "c"] --> ["1: a", "2: b", "3: c"]*/
public class LineNumbering
{
    public static List<string> Number(List<string> lines)
    {
        List<string> numberedLines = new List<string>();
        for (int i = 0; i < lines.Count; i++)
        {
            string numberedLine = $"{i + 1}: {lines[i]}";
            numberedLines.Add(numberedLine);
        }
        return numberedLines;
    }
}

/*
 Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

Examples (Input -> Output):
* "String"      -> "SSttrriinngg"
* "Hello World" -> "HHeelllloo  WWoorrlldd"
* "1234!_ "     -> "11223344!!__  "*/
public class Kata30
{
    public static string DoubleChar(string s)
    {
        string result = "";


        foreach (char c in s)
        {

            result += c.ToString() + c.ToString();
        }

        return result;
    }
}

/*
 You are given two interior angles (in degrees) of a triangle.

Write a function to return the 3rd.

Note: only positive integers will be tested.

https://en.wikipedia.org/wiki/Triangle

*/
class Kata31
{
    public static int OtherAngle(int a, int b)
    {
        return 180 - a - b;
    }
}

public static class Kata32
{
    // Write a public static method "greet" that returns "hello world!"
    public static string greet()
    {
        string line = "";
        line += (char)0b_0110_1000; // h
        line += (char)0b_0110_0101; // e
        line += (char)0b_0110_1100; // l
        line += (char)0b_0110_1100; // l
        line += (char)0b_0110_1111; // o
        line += (char)0b_0010_0000; // 
        line += (char)0b_0111_0111; // w
        line += (char)0b_0110_1111; // o
        line += (char)0b_0111_0010; // r
        line += (char)0b_0110_1100; // l
        line += (char)0b_0110_0100; // d
        line += (char)0b_0010_0001; // !
        return line;
    }
}

/*
 Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0. Your function only needs to return the result, what is shown between parentheses in the example below is how you reach that result and it's not part of it, see the sample tests.

For example (Input -> Output):

2 -> 3 (1 + 2)
8 -> 36 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)*/
public static class Kata33
{
    public static int summation(int num)
    {
        return Enumerable.Range(1, num).Sum();
    }
}

/*
 Create a function isAlt() that accepts a string as an argument and validates whether the vowels (a, e, i, o, u) and consonants are in alternate order.

Kata.IsAlt("amazon")
// true
Kata.IsAlt("apple")
// false
Kata.IsAlt("banana")
// true*/

public class Kata34
{
    public static bool IsAlt(string word)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        for (int i = 0; i < word.Length - 1; i++)
        {
            bool isVowel1 = Array.Exists(vowels, v => v == word[i]);
            bool isVowel2 = Array.Exists(vowels, v => v == word[i + 1]);

            if (isVowel1 == isVowel2)
            {
                return false;
            }
        }

        return true;
    }
}

/*Create a function that accepts a string and a single character, and returns an integer of the count of occurrences the 2nd argument is found in the first one.

If no occurrences can be found, a count of 0 should be returned.

("Hello", "o")  ==>  1
("Hello", "l")  ==>  2
("", "z")       ==>  0
str_count("Hello", 'o'); // returns 1
str_count("Hello", 'l'); // returns 2
str_count("", 'z'); // returns 0*/
class Kata35
{
    public static int StrCount(string str, char letter)
    {
        return str.Count(c=>c == letter);
    }
}

/*
 Complete the solution so that the function will break up camel casing, using a space between words.

Example
"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
*/
public class Kata36
{
    public static string BreakCamelCase(string str)
    {
        return string.Concat(str.Select(c => char.IsUpper(c) ? " " + c.ToString() : c.ToString()));
    }
}