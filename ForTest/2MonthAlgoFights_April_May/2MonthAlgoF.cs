﻿using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ForTest._2MonthAlgoFights
{
    /*Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

For example (Input --> Output):

39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit, there are 3 multiplications)
999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2, there are 4 multiplications)
4 --> 0 (because 4 is already a one-digit number, there is no multiplication)*/

    public class KataPersist
    {
        public static int Persistence(long n)
        {
            if (n < 10)
            {
                return 0;
            }
            long product = 1;
            while (n > 0)
            {
                product *= n % 10;
                n /= 10;
            }
            return 1 + Persistence(product);
        }
    }
    /*The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

    What if the string is empty? Then the result should be empty object literal, {}.*/
    public class KataDictionary
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            return charCount;

            /*return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count()); - BEst Codewars Pract*/
        }
    }


    /*Given a non-empty array of integers, return the result of multiplying the values together in order. Example:

    [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24*/

    public class KataKUY8
    {
        public static int Grow(int[] x)
        {
            int result = 1;
            foreach (int value in x)
            {
                result *= value;
            }
            return result;
        }
    }

    /*The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:

    maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
    -- should be 6: [4, -1, 2, 1]
    Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. If the list is made up of only negative numbers, return 0 instead.

    Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.*/


    public static class KataSubarray
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int maxSum = arr[0];
            int currentSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currentSum = Math.Max(arr[i], currentSum + arr[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;

            //Cleanest on Codewars ! Запомнить.

            /*int max = 0, res = 0, sum = 0;
            foreach(var item in arr)
            {
                sum += item;
                max = sum > max ? max : sum;
                res = res > sum - max ? res : sum - max;
            }
            return res;*/



        }
    }


    /*Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

    Examples
    "This is an example!" ==> "sihT si na !elpmaxe"
    "double  spaces"      ==> "elbuod  secaps"*/


    public static class KataReverseWords
    {
        public static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            return string.Join(" ", words);
        }
    }



    /*Write a function that accepts a square matrix (N x N 2D array) and returns the determinant of the matrix.

    How to take the determinant of a matrix -- it is simplest to start with the smallest cases:

    A 1x1 matrix |a| has determinant a.

    A 2x2 matrix [ [a, b], [c, d] ] or

    |a  b|
    |c  d|
    has determinant: a*d - b*c.

    The determinant of an n x n sized matrix is calculated by reducing the problem to the calculation of the determinants of n matrices ofn-1 x n-1 size.

    For the 3x3 case, [ [a, b, c], [d, e, f], [g, h, i] ] or

    |a b c|  
    |d e f|  
    |g h i|  
    the determinant is: a * det(a_minor) - b * det(b_minor) + c * det(c_minor) where det(a_minor) refers to taking the determinant of the 2x2 matrix created by crossing out the row and column in which the element a occurs:

    |- - -|
    |- e f|
    |- h i|  
    Note the alternation of signs.

    The determinant of larger matrices are calculated analogously, e.g. if M is a 4x4 matrix with first row [a, b, c, d], then:

    det(M) = a * det(a_minor) - b * det(b_minor) + c * det(c_minor) - d * det(d_minor)*/

    public class Matrix
    {
        public static int Determinant(int[][] matrix)
        {
            int n = matrix.Length;
            if (n == 1)
                return matrix[0][0];

            int det = 0;
            for (int j = 0; j < n; j++)
            {
                int[][] minor = new int[n - 1][];
                for (int i = 1; i < n; i++)
                {
                    minor[i - 1] = new int[n - 1];
                    for (int k = 0, l = 0; k < n; k++)
                    {
                        if (k != j)
                            minor[i - 1][l++] = matrix[i][k];
                    }
                }

                int sign = (j % 2 == 0) ? 1 : -1;
                det += sign * matrix[0][j] * Determinant(minor);
            }

            return det;
        }


    }/*Write the following function:

public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
It should calculate the area of a regular polygon of numberOfSides, number-of-sides, or number_of_sides sides inside a circle of radius circleRadius, circle-radius, or circle_radius which passes through all the vertices of the polygon (such circle is called circumscribed circle or circumcircle).

The answer should be a number rounded to 3 decimal places.

Input :: Output Examples

AreaOfPolygonInsideCircle(3, 3) // returns 11.691

AreaOfPolygonInsideCircle(5.8, 7) // returns 92.053

AreaOfPolygonInsideCircle(4, 5) // returns 38.042
Note: if you need to use Pi in your code, use the native value of your language unless stated otherwise.*/



    public class CalculatorOOooooomy
    {
        public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            double sideLength = 2 * circleRadius * Math.Sin(Math.PI / numberOfSides);
            double area = (numberOfSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numberOfSides));
            return Math.Round(area, 3);
        }
    }




    /*The museum of incredibly dull things
    The museum of incredibly dull things wants to get rid of some exhibits. Miriam, the interior architect, comes up with a plan to remove the most boring exhibits. She gives them a rating, and then removes the one with the lowest rating.

    However, just as she finished rating all exhibits, she's off to an important fair, so she asks you to write a program that tells her the ratings of the exhibits after removing the lowest one. Fair enough.

    Task
    Given an array of integers, remove the smallest value. Do not mutate the original array/list. If there are multiple elements with the same value, remove the one with the lowest index. If you get an empty array/list, return an empty array/list.

    Don't change the order of the elements that are left.

    Examples
    * Input: [1,2,3,4,5], output = [2,3,4,5]
    * Input: [5,3,2,1,4], output = [5,3,2,4]
    * Input: [2,2,1,2,1], output = [2,2,2,1]*/

    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return new List<int>();
            }
            int minValue = numbers.Min();
            int minIndex = numbers.IndexOf(minValue);
            List<int> result = new List<int>(numbers);
            result.RemoveAt(minIndex);
            return result;
        }
    }

    /*A square of squares
    You like building blocks. You especially like building blocks that are squares. And what you even like more, is to arrange them into a square of square building blocks!

    However, sometimes, you can't arrange them into a square. Instead, you end up with an ordinary rectangle! Those blasted things! If you just had a way to know, whether you're currently working in vain… Wait! That's it! You just have to check if your number of building blocks is a perfect square.

    Task
    Given an integral number, determine if it's a square number:

    In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself.

    The tests will always use some integral number, so don't worry about that in dynamic typed languages.

    Examples
    -1  =>  false
     0  =>  true
     3  =>  false
     4  =>  true
    25  =>  true
    26  =>  false*/

    public class KataYoureSqarrrrrrr
    {
        public static bool IsSquare(int n)
        {
            double result = Math.Sqrt(n);
            return result % 1 == 0;
        }
    }

    /*You will be given an array and a limit value. You must check that all values in the array are below or equal to the limit value. If they are, return true. Else, return false.

    You can assume all values in the array are numbers.*/

    public class KataSmallEnough
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            return a.All(value => value <= limit);
        }
    }


    //2june goodNight

    /*altERnaTIng cAsE <=> ALTerNAtiNG CaSe
    Define String.prototype.toAlternatingCase (or a similar function/method such as to_alternating_case/toAlternatingCase/ToAlternatingCase in your selected language; see the initial solution for details) such that each lowercase letter becomes uppercase and each uppercase letter becomes lowercase. For example:

    "hello world".ToAlternatingCase() == "HELLO WORLD"
    "HELLO WORLD".ToAlternatingCase() == "hello world"
    "hello WORLD".ToAlternatingCase() == "HELLO world"
    "HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
    "12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
    "1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
    "String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTERNATINGcASE"*/

    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            char[] result = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                result[i] = char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c);
            }
            return new string(result);
        }
    }

    /*There is a bus moving in the city which takes and drops some people at each bus stop.

    You are provided with a list (or array) of integer pairs. Elements of each pair represent the number of people that get on the bus (the first item) and the number of people that get off the bus (the second item) at a bus stop.

    Your task is to return the number of people who are still on the bus after the last bus stop (after the last array). Even though it is the last bus stop, the bus might not be empty and some people might still be inside the bus, they are probably sleeping there :D

    Take a look on the test cases.

    Please keep in mind that the test cases ensure that the number of people in the bus is always >= 0. So the returned integer can't be negative.

    The second value in the first pair in the array is 0, since the bus is empty in the first bus stop.*/


    public class KataBUS
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int peopleOnBus = 0;
            foreach (var pair in peopleListInOut)
            {
                peopleOnBus += pair[0];
                peopleOnBus -= pair[1];
            }
            return Math.Max(0, peopleOnBus);
        }
    }

    /*Fix the function
    I created this function to add five to any number that was passed in to it and return the new value. It doesn't throw any errors but it returns the wrong number.

    Can you help me fix the function?*/


    public class KataISITKYU100
    {
        public static int AddFive(int num)
        {
            int total = num + 5;
            return total;
        }
    }


    /*Enough is enough!
    Alice and Bob were on a holiday. Both of them took many pictures of the places they've been, and now they want to show Charlie their entire collection. However, Charlie doesn't like these sessions, since the motif usually repeats. He isn't fond of seeing the Eiffel tower 40 times.
    He tells them that he will only sit for the session if they show the same motif at most N times. Luckily, Alice and Bob are able to encode the motif as a number. Can you help them to remove numbers such that their list contains each number only up to N times, without changing the order?

    Task
    Given a list and a number, create a new list that contains each number of list at most N times, without reordering.
    For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
    With list [20,37,20,21] and number 1, the result would be [20,37,21].*/
    public class KataOHHHHNICEEEEEEE
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            if (arr == null)
            {
                return new int[0];
            }

            var occurrences = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (var num in arr)
            {
                if (!occurrences.ContainsKey(num))
                {
                    occurrences[num] = 0;
                }

                if (occurrences[num] < x)
                {
                    result.Add(num);
                    occurrences[num]++;
                }
            }

            return result.ToArray();
        }
    }


    /*Finish the solution so that it sorts the passed in array of numbers. If the function passes in an empty array or null/nil value then it should return an empty array.

    For example:

    SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
    SortNumbers(null); // should return new int[] { }*/
    public class KataSort
    {
        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }

            return nums.OrderBy(n => n).ToArray();
        }
    }

    /*Bob is working as a bus driver. However, he has become extremely popular amongst the city's residents. With so many passengers wanting to get aboard his bus, he sometimes has to face the problem of not enough space left on the bus! He wants you to write a simple program telling him if he will be able to fit all the passengers.

    Task Overview:
    You have to write a function that accepts three parameters:

    cap is the amount of people the bus can hold excluding the driver.
    on is the number of people on the bus excluding the driver.
    wait is the number of people waiting to get on to the bus excluding the driver.
    If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.

    Usage Examples:
    cap = 10, on = 5, wait = 5 --> 0 # He can fit all 5 passengers
    cap = 100, on = 60, wait = 50 --> 10 # He can't fit 10 of the 50 waiting*/
    public static class KataWill
    {
        public static int Enough(int cap, int on, int wait)
        {
            int remainingCapacity = cap - on;
            if (remainingCapacity >= wait)
            {
                return 0;
            }
            else
            {
                return wait - remainingCapacity;
            }

        }
    }
    public class RoundedKata
    {
        public static int RoundToNext5(int n)
        {
            int rounded = (int)Math.Ceiling((double)n / 5) * 5;

            return rounded;
        }
    }


    /*An anagram is the result of rearranging the letters of a word to produce a new word (see wikipedia).

    Note: anagrams are case insensitive

    Complete the function to return true if the two arguments given are anagrams of each other; return false otherwise.

    Examples

    "foefet" is an anagram of "toffee"

    "Buckethead" is an anagram of "DeathCubeK"*/

    public class KataAnagram
    {
        public static bool IsAnagram(string test, string original)
        {
            string cleanedTest = new string(test.ToLower().Where(char.IsLetter).ToArray());
            string cleanedOriginal = new string(original.ToLower().Where(char.IsLetter).ToArray());

            char[] sortedTest = cleanedTest.ToCharArray();
            char[] sortedOriginal = cleanedOriginal.ToCharArray();
            Array.Sort(sortedTest);
            Array.Sort(sortedOriginal);

            return sortedTest.SequenceEqual(sortedOriginal);
        }
    }
    /*Create a function with two arguments that will return an array of the first n multiples of x.

    Assume both the given number and the number of times to count will be positive numbers greater than 0.

    Return the results as an array or list ( depending on language ).

    Examples

    countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
    countBy(2,5)  should return {2,4,6,8,10}*/

    public static class EzKata
    {
        public static int[] CountBy(int x, int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = (i + 1) * x;
            }
            return result;
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
            if ((side1 + side2 >= side3) || (side2 + side3 >= side1) || (side3 + side1 >= side2))
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
                if ((side1 - side2 == 0) || (side1 - side3 == 0) || (side2 - side3 == 0))
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
            else if ((exam > 75 && projects > 5) || (exam > 75 || projects > 5))
            {
                return 90;
            }
            else if ((exam > 50 && projects >= 2) || (exam > 50 || projects > 2))
            {
                return 75;
            }
            else if ((exam < 50 && projects < 2) || (exam < 50 || projects < 2))
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
            return new int[2] { lst.Min(), lst.Max() };
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
        public static bool CheckForFactor(int num, int factor) => num % factor == 0;

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



            return $"{a - b}" + "/" + $"{a}";
        }
    }


    public class Kata13
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();

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
            var a = integers.ToList().Count(p => p % 2 == 0);

            int res = 0;

            if (a == 1)
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
                return (flower1 % 2 == 0 && flower2 % 2 != 0) || (flower1 % 2 != 0 && flower2 % 2 == 0) ? true : false;
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

            if (n == null)
            {

            }

            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                {
                    ints.Add(i);
                }
            }
            if (ints.Count == 0)
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


            } while (ints.Count() != 1);

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
            return str.Count(c => c == letter);
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

    class NumberEven
    {
        public bool IsEven(double n) => n % 2 == 0;

    }

    //совсем не выглядит как 7Kuy

    /*
     write function accum:

    Examples:

    accum("abcd") -> "A-Bb-Ccc-Dddd"
    accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    accum("cwAt") -> "C-Ww-Aaa-Tttt"*/

    public class Accumul
    {
        public static string Accum(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                string part = s[i].ToString().ToUpper() + new string(s[i], i).ToLower();
                result += (i != 0 ? "-" : "") + part;
            }
            return result;
        }
    }


    /*To solve this Kata, complete the function, calculateHypotenuse(a,b), which will return the length of the hyptenuse for a right angled triangle with the other two sides having a length equal to the inputs. More details:

    The returned value should be a number rounded to three decimal places
    An error (ArgumentException in C#) should be thrown if an invalid input is provided (inputs should both be numbers that are above zero)
    Kata.CalculateHypotenuse(1,1)           // returns 1.414
    Kata.CalculateHypotenuse(3,4)           // returns 5
    Kata.CalculateHypotenuse(-2,1)          // throws ArgumentException
    Kata.CalculateHypotenuse(2, Double.NaN) // throws ArgumentException*/

    public class Kata37
    {
        public static double CalculateHypotenuse(double a, double b)
        {
            if (a <= 0 || b <= 0 || Double.IsNaN(a) || Double.IsNaN(b))
            {
                throw new ArgumentException("Inputs should both be numbers that are above zero");
            }


            double hypotenuse = Math.Sqrt(a * a + b * b);

            return Math.Round(hypotenuse, 3);
        }
    }

    /*Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

    Return your answer as a number.*/

    public class Kata38
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            foreach (var item in x)
            {
                sum += Convert.ToInt32(item);
            }
            return sum;
        }
    }

    /*Given some sticks by an array V of positive integers, where V[i] represents the length of the sticks, find the number of ways we can choose three of them to form a triangle.

    Example
    For V = [2, 3, 7, 4], the result should be 1.

    There is only (2, 3, 4) can form a triangle.

    For V = [5, 6, 7, 8], the result should be 4.

    (5, 6, 7), (5, 6, 8), (5, 7, 8), (6, 7, 8)

    Input/Output
    [input] integer array V
    stick lengths

    3 <= V.length <= 100

    0 < V[i] <=100

    [output] an integer
    number of ways we can choose 3 sticks to form a triangle.*/


    public class Kata39
    {
        public int CountingTriangles(int[] V)
        {
            Array.Sort(V);
            int count = 0;
            for (int i = 0; i < V.Length - 2; i++)
            {
                int k = i + 2;
                for (int j = i + 1; j < V.Length; j++)
                {
                    while (k < V.Length && V[i] + V[j] > V[k])
                    {
                        k++;
                    }
                    count += k - j - 1;
                }
            }
            return count;

        }
    }

    class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0) return 0;
            return array.Average();
        }
    }

    /*Given a string of words, you need to find the highest scoring word.

    Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

    For example, the score of abad is 8 (1 + 2 + 1 + 4).

    You need to return the highest scoring word as a string.

    If two words score the same, return the word that appears earliest in the original string.

    All letters will be lowercase and all inputs will be valid.*/

    public class Kata40
    {
        public static string High(string s)
        {
            var res = s.Split(',').ToList();
            int max = 0;
            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (var item in res)
            {

                for (int i = 0; i < item.Length; i++)
                {
                    char letter = 'a';
                    max += letter - 'a' + 1;


                }
                dict.Add(max, item.ToString());

            }

            return dict[dict.Keys.Max()];
        }
    }


    /*Take the following IPv4 address: 128.32.10.1. This address has 4 octets where each octet is a single byte (or 8 bits).

    1st octet 128 has the binary representation: 10000000
    2nd octet 32 has the binary representation: 00100000
    3rd octet 10 has the binary representation: 00001010
    4th octet 1 has the binary representation: 00000001
    So 128.32.10.1 == 10000000.00100000.00001010.00000001

    Because the above IP address has 32 bits, we can represent it as the 32 bit number: 2149583361.

    Write a function ip_to_int32(ip) ( JS: ipToInt32(ip) ) that takes an IPv4 address and returns a 32 bit number.*/

    //using System;
    //using System.Net;
    public class IPConvert
    {
        public static uint ToInt32(string ip)
        {
            if (!IPAddress.TryParse(ip, out IPAddress address))
                return 0;


            byte[] addressBytes = address.GetAddressBytes();
            uint intAddress = (uint)(addressBytes[0] << 24 | addressBytes[1] << 16 | addressBytes[2] << 8 | addressBytes[3]);
            return intAddress;
        }

        public static string UInt32ToIp(uint address)
        {

            return new IPAddress(address).ToString();
        }
    }
    /*Count the number of divisors of a positive integer n.

    Random tests go up to n = 500000.

    Examples (input --> output)
    4 --> 3 // we have 3 divisors - 1, 2 and 4
    5 --> 2 // we have 2 divisors - 1 and 5
    12 --> 6 // we have 6 divisors - 1, 2, 3, 4, 6 and 12
    30 --> 8 // we have 8 divisors - 1, 2, 3, 5, 6, 10, 15 and 30
    Note you should only return a number, the count of divisors. The numbers between parentheses are shown only for you to see which numbers are counted in each case.

    */

    public class Kata41
    {
        public static int Divisors(int n)
        {
            int totalDivisors = 1;


            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                isPrime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    int count = 0;
                    if (n % p == 0)
                    {
                        while (n % p == 0)
                        {
                            n /= p;
                            count++;
                        }
                        totalDivisors *= (count + 1);
                    }
                }
            }

            if (n > 1)
                totalDivisors *= 2;

            return totalDivisors;
        }

        /*Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

    For example:

    uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
    uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
    uniqueInOrder([1,2,2,3,3])       == {1,2,3}*/

        public static class Kata42
        {
            public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
            {
                T prev = default!;
                bool hasPrev = false;

                foreach (T item in iterable)
                {
                    if ((!hasPrev && (hasPrev = true)) || !EqualityComparer<T>.Default.Equals(item, prev))
                    {
                        yield return item;
                    }
                    prev = item;
                }

            }

        }
    }

    /*Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

    Rules for a smiling face:

    Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
    A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
    Every smiling face must have a smiling mouth that should be marked with either ) or D
    No additional characters are allowed except for those mentioned.

    Valid smiley face examples: :) :D ;-D :~)
    Invalid smiley faces: ;( :> :} :]

    Example
    countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
    countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
    countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;*/

    //using System.Text.RegularExpressions;
    public static class Kata43
    {
        public static int CountSmileys(string[] smileys)
        {
            int count = 0;

            foreach (string s in smileys)
            {
                if (Regex.IsMatch(s, @"[:;][-~]?[)D]"))
                {
                    count++;
                }
            }

            return count;
        }
    }
    /*You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

    Increment the large integer by one and return the resulting array of digits.

    Example 1:

    Input: digits = [1,2,3]
    Output: [1,2,4]
    Explanation: The array represents the integer 123.
    Incrementing by one gives 123 + 1 = 124.
    Thus, the result should be [1,2,4].
    Example 2:

    Input: digits = [4,3,2,1]
    Output: [4,3,2,2]
    Explanation: The array represents the integer 4321.
    Incrementing by one gives 4321 + 1 = 4322.
    Thus, the result should be [4,3,2,2].*/

    public class SolutionPlusOne
    {


        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }


            int[] result = new int[n + 1];
            result[0] = 1;
            return result;

        }
    }
    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    You can return the answer in any order.
    Example 1:

    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    Example 2:

    Input: nums = [3,2,4], target = 6
    Output: [1,2]
    Example 3:

    Input: nums = [3,3], target = 6
    Output: [0,1]*/
    //classic twosum
    public class TwoSumSol
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> ints = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ints.Add(i);
                        ints.Add(j);


                    }

                }
            }
            return ints.ToArray();
        }
    }

    /*Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

    Each row must contain the digits 1-9 without repetition.
    Each column must contain the digits 1-9 without repetition.
    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
    Note:

    A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    Only the filled cells need to be validated according to the mentioned rules.


    Example 1:


    Input: board = 
    [["5","3",".",".","7",".",".",".","."]
    ,["6",".",".","1","9","5",".",".","."]
    ,[".","9","8",".",".",".",".","6","."]
    ,["8",".",".",".","6",".",".",".","3"]
    ,["4",".",".","8",".","3",".",".","1"]
    ,["7",".",".",".","2",".",".",".","6"]
    ,[".","6",".",".",".",".","2","8","."]
    ,[".",".",".","4","1","9",".",".","5"]
    ,[".",".",".",".","8",".",".","7","9"]]
    Output: true
    Example 2:

    Input: board = 
    [["8","3",".",".","7",".",".",".","."]
    ,["6",".",".","1","9","5",".",".","."]
    ,[".","9","8",".",".",".",".","6","."]
    ,["8",".",".",".","6",".",".",".","3"]
    ,["4",".",".","8",".","3",".",".","1"]
    ,["7",".",".",".","2",".",".",".","6"]
    ,[".","6",".",".",".",".","2","8","."]
    ,[".",".",".","4","1","9",".",".","5"]
    ,[".",".",".",".","8",".",".","7","9"]]
    Output: false
    Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.*/

    public class SolutionValidSud
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!IsValidRow(board, i) || !IsValidColumn(board, i) || !IsValidSubgrid(board, i))
                    return false;
            }
            return true;
        }

        static bool IsValidRow(char[][] board, int row)
        {
            bool[] seen = new bool[10];
            for (int j = 0; j < 9; j++)
            {
                char c = board[row][j];
                if (c != '.')
                {
                    int num = c - '0';
                    if (seen[num])
                        return false;
                    seen[num] = true;
                }
            }
            return true;
        }

        static bool IsValidColumn(char[][] board, int col)
        {
            bool[] seen = new bool[10];
            for (int i = 0; i < 9; i++)
            {
                char c = board[i][col];
                if (c != '.')
                {
                    int num = c - '0';
                    if (seen[num])
                        return false;
                    seen[num] = true;
                }
            }
            return true;
        }

        static bool IsValidSubgrid(char[][] board, int subgrid)
        {
            bool[] seen = new bool[10];
            int rowStart = (subgrid / 3) * 3;
            int colStart = (subgrid % 3) * 3;
            for (int i = rowStart; i < rowStart + 3; i++)
            {
                for (int j = colStart; j < colStart + 3; j++)
                {
                    char c = board[i][j];
                    if (c != '.')
                    {
                        int num = c - '0';
                        if (seen[num])
                            return false;
                        seen[num] = true;
                    }
                }
            }
            return true;
        }
    }

    /*You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

    You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.



    Example 1:


    Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    Output: [[7,4,1],[8,5,2],[9,6,3]]
    Example 2:


    Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
    Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]*/

    public class SolutionRotateIMG
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = temp;
                }
            }
        }
    }
    public class SolutionMovesZero
    {
        public void MoveZeroes(int[] nums)
        {

            var listofInts = nums.ToList();
            listofInts.RemoveAll(a => a == 0);

            for (int i = nums.Length - listofInts.Count; i > 0; i--)
            {
                listofInts.Add(0);
            }

            listofInts.ToArray();

        }
    }
    public class Solution
    {
        public void ReverseString(char[] s)
        {

            for (int i = 0; i < s.Length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }

    /*public bool IsUpperCase(this string text)
        {
            string NoWhiteSpaces = text.Replace(" ", "");
            return text.Count(a => char.IsUpper(a)) == NoWhiteSpaces.Length ? true : false;
        }*/


    /*Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of 
    𝑛
    3
    n 
    3
     , the cube above will have volume of 
    (
    𝑛
    −
    1
    )
    3
    (n−1) 
    3
      and so on until the top which will have a volume of 
    1
    3
    1 
    3
     .

    You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

    The parameter of the function findNb (find_nb, find-nb, findNb, ...) will be an integer m and you have to return the integer n such as 
    𝑛
    3
    +
    (
    𝑛
    −
    1
    )
    3
    +
    (
    𝑛
    −
    2
    )
    3
    +
    .
    .
    .
    +
    1
    3
    =
    𝑚
    n 
    3
     +(n−1) 
    3
     +(n−2) 
    3
     +...+1 
    3
     =m if such a n exists or -1 if there is no such n.

    Examples:
    findNb(1071225) --> 45

    findNb(91716553919377) --> -1*/

    public class ASum
    {

        public static long findNb(long m)
        {
            long n = 0;
            long sum = 0;
            while (sum < m)
            {
                n++;
                sum += n * n * n;
            }
            if (sum == m)
            {
                return n;
            }
            else
            {
                return -1;
            }

        }
    }
    //find "needle" in object[]
    public class KataFindNeedle
    {
        public static string FindNeedle(object[] haystack)
        {
            return string.Concat($"found the needle at position {Array.IndexOf(haystack, "needle")}");

        }
    }
    //sort stirng[] by length of words inside
    public class KataSortByLength
    {
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(a => a.Length).ToArray();
        }
    }
    public static class CenturyFY
    {
        public static int СenturyFromYear(int year)
        {
            if (year % 100 == 0)
            {
                return year / 100;
            }
            else
            {
                return (year / 100) + 1;
            }
        }
    }
    //O(1)
    public static class GetVowel
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(a => a == 97 || a == 101 || a == 105 || a == 111 || a == 117);
        }
    }
    public class Multiplier
    {
        public static int Multiply(int x)
        {
            return x % 2 == 0 ? x * 8 : x * 9;
        }
    }

    public static class Strungssum
    {
        public static string StringsSum(string s1, string s2)
        {
            int a = s1 == string.Empty ? 0 : Int32.Parse(s1);

            int b = s2 == string.Empty ? 0 : Int32.Parse(s2);


            return (a + b).ToString();

        }
    }


    public static class SumWithoutHighestAndLowestNumber

    {
        public static int Sum(int[] numbers)
        {
            return numbers == null || numbers.Length < 2
                ? 0
                : numbers.Sum() - numbers.Max() - numbers.Min();
        }
    }

    public class RemoveExclamationMarks_
    {
        public static string RemoveExclamationMarks(string s)
        {
            return s.Replace("!", "");
        }
    }
}
