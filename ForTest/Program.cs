
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {

    }

    /*Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.

Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.

Example:
n= 5, m=5: 25
n=-5, m=5:  0*/

    public static class Paper
    {
        public static int Paperwork(int n, int m)
        {
            if (n <= 0 || m <= 0)
                return 0;

            return n * m;
        }
    }

    /*Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

Examples
"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
""  -->  ""*/

    //Hard one 

    public static class KataOrder
    {
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                return string.Empty;
            }

            return string.Join(" ", words.Split(' ')
                                         .OrderBy(word => word.First(char.IsDigit)));
        }
    }

    /*I assume most of you are familiar with the ancient legend of the rice (but I see wikipedia suggests wheat, for some reason) problem, but a quick recap for you: a young man asks as a compensation only 1 grain of rice for the first square, 2 grains for the second, 4 for the third, 8 for the fourth and so on, always doubling the previous.

Your task is pretty straightforward (but not necessarily easy): given an amount of grains, you need to return up to which square of the chessboard one should count in order to get at least as many.

As usual, a few examples might be way better than thousands of words from me:

0 grains need 0 cells
1 grain needs 1 cell
2 grains need 2 cells
3 grains need 2 cells
4 grains need 3 cells
and etc.*/

    class KataSqarNeeded
    {
        public static int SquaresNeeded(long grains)
          => grains > 0 ? 1 + SquaresNeeded(grains / 2) : 0;
    }

    /*Write a function that takes a positive integer n, sums all the cubed values from 1 to n (inclusive), and returns that sum.

Assume that the input n will always be a positive integer.

Examples: (Input --> output)

2 --> 9 (sum of the cubes of 1 and 2 is 1 + 8)
3 --> 36 (sum of the cubes of 1, 2, and 3 is 1 + 8 + 27)*/

    public static class KataSumCubes
    {
        public static long SumCubes(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (long)Math.Pow(i, 3);
            }
            return sum;
        }
    }
    /*Jack really likes his number five: the trick here is that you have to multiply each number by 5 raised to the number of digits of each numbers, so, for example:

  3 -->    15  (  3 * 5¹)
 10 -->   250  ( 10 * 5²)
200 --> 25000  (200 * 5³)
  0 -->     0  (  0 * 5¹)
 -3 -->   -15  ( -3 * 5¹)*/
    public class KataMultiplyОчередной
    {
        public static int Multiply(int number)
        {
            int digits = number == 0 ? 1 : (int)Math.Log10(Math.Abs(number)) + 1;
            return number * (int)Math.Pow(5, digits);
        }
    }

    /*Your task is to write a function which calculates the value of a word based off the sum of the alphabet positions of its characters.

The input will always be made of only lowercase letters and will never be empty.*/
    public static class KataWordsToMarks
    {
        public static int WordsToMarks(string str) =>
    str.Sum(c => c - 96);
    }

    /*Input: Array of elements

["h","o","l","a"]

Output: String with comma delimited elements of the array in th same order.

"h,o,l,a"

Note: if this seems too simple for you try the next level

Note2: the input data can be: boolean array, array of objects, array of string arrays, array of number arrays... 😕*/

    public class KataPrintArray
    {
        public static string PrintArray(object[] array)
        {
            return string.Join(",", array.Select(a => a.GetType().IsArray ? string.Join(",", (object[])a) : a));
        }
    }


    /*You are required to create a simple calculator that returns the result of addition, subtraction, multiplication or division of two numbers.

Your function will accept three arguments:
The first and second argument should be numbers.
The third argument should represent a sign indicating the operation to perform on these two numbers.

If the sign is not a valid sign, throw an ArgumentException.

Example:
Kata.Calculator(1, 2, '+') => 3
Kata.Calculator(1, 2, '$') // throws ArgumentException*/

    public class KataCalc
    {
        public static double Calculator(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                        throw new ArgumentException("Division by zero is not allowed.");
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operation sign.");
            }
        }
    }


    /*The wide-mouth frog is particularly interested in the eating habits of other creatures.

He just can't stop asking the creatures he encounters what they like to eat. But, then he meets the alligator who just LOVES to eat wide-mouthed frogs!

When he meets the alligator, it then makes a tiny mouth.

Your goal in this kata is to create complete the mouth_size method this method takes one argument animal which corresponds to the animal encountered by the frog. If this one is an alligator (case-insensitive) return small otherwise return wide.*/


    public class KataMouthSize
    {
        public static string MouthSize(string animal)
        {
            return animal.ToLower() == "alligator" ? "small" : "wide";
        }
    }

    /*Suzuki is a monk who climbs a large staircase to the monastery as part of a ritual. Some days he climbs more stairs than others depending on the number of students he must train in the morning. He is curious how many stairs might be climbed over the next 20 years and has spent a year marking down his daily progress.

The sum of all the stairs logged in a year will be used for estimating the number he might climb in 20.

20_year_estimate = one_year_total * 20

You will receive the following data structure representing the stairs Suzuki logged in a year. You will have all data for the entire year so regardless of how it is logged the problem should be simple to solve.

stairs = [sunday,monday,tuesday,wednesday,thursday,friday,saturday]
Make sure your solution takes into account all of the nesting within the stairs array.

Each weekday in the stairs array is an array.

sunday = [6737, 7244, 5776, 9826, 7057, 9247, 5842, 5484, 6543, 5153, 6832, 8274, 7148, 6152, 5940, 8040, 9174, 7555, 7682, 5252, 8793, 8837, 7320, 8478, 6063, 5751, 9716, 5085, 7315, 7859, 6628, 5425, 6331, 7097, 6249, 8381, 5936, 8496, 6934, 8347, 7036, 6421, 6510, 5821, 8602, 5312, 7836, 8032, 9871, 5990, 6309, 7825]
Your function should return the 20 year estimate of the stairs climbed using the formula above.*/
    public class KataStairsIn20
    {
        public static long StairsIn20(int[][] stairs)
        {
            long totalStairs = 0;
            foreach (var day in stairs)
            {
                totalStairs += day.Sum();
            }
            long twentyYearEstimate = totalStairs * 20;
            return twentyYearEstimate;
        }
        // public static long StairsIn20(int[][] stairs) => stairs.Sum(x => x.Sum()) * 20;
    }

    //Create a method that accepts a list and an item, and returns true if the item belongs to the list, otherwise false.
    public class KataInclude
    {
        public static bool Include(int[] arr, int item)
        {
            return arr.Contains(item);
        }
    }


    /*Create a function that converts US dollars (USD) to Chinese Yuan (CNY) . The input is the amount of USD as an integer, and the output should be a string that states the amount of Yuan followed by 'Chinese Yuan'

Examples (Input -> Output)
15  -> '101.25 Chinese Yuan'
465 -> '3138.75 Chinese Yuan'
The conversion rate you should use is 6.75 CNY for every 1 USD. All numbers should be represented as a string with 2 decimal places. (e.g. "21.00" NOT "21.0" or "21")

*/

    public static class KataUsdCny
    {
        public static string Usdcny(int usd)
        {
            return $"{(usd * 6.75f):0.00} Chinese Yuan";
        }
    }


    /*Debugging sayHello function
The starship Enterprise has run into some problem when creating a program to greet everyone as they come aboard. It is your job to fix the code and get the program working again!

Example output:

Hello, Mr. Spock*/

    public class KataSayHello
    {
        public static string SayHello(string name)
        {
            return $"Hello, {name}";
        }
    }

    /*Create a method that takes as input a name, city, and state to welcome a person. Note that name will be an array consisting of one or more values that should be joined together with one space between each, and the length of the name array in test cases will vary.

Example:

['John', 'Smith'], 'Phoenix', 'Arizona'
This example will return the string Hello, John Smith! Welcome to Phoenix, Arizona!
    */

    public class KataSayHelloCity
    {
        public static string SayHello(string[] name, string city, string state) =>
    $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
    }

    /*Philip's just turned four and he wants to know how old he will be in various years in the future such as 2090 or 3044. His parents can't keep up calculating this so they've begged you to help them out by writing a programme that can answer Philip's endless questions.

Your task is to write a function that takes two parameters: the year of birth and the year to count years in relation to. As Philip is getting more curious every day he may soon want to know how many years it was until he would be born, so your function needs to work with both dates in the future and in the past.

Provide output in this format: For dates in the future: "You are ... year(s) old." For dates in the past: "You will be born in ... year(s)." If the year of birth equals the year requested return: "You were born this very year!"

"..." are to be replaced by the number, followed and proceeded by a single space. Mind that you need to account for both "year" and "years", depending on the result.

Good Luck!*/
    public static class AgeDiff
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            if (birth == yearTo)
                return "You were born this very year!";

            int x = yearTo - birth;
            string s = Math.Abs(x) > 1 ? "s" : "";

            return x > 0 ? $"You are {x} year{s} old." : $"You will be born in {-x} year{s}.";
        }
    }

    /*In JavaScript, if..else is the most basic conditional statement, it consists of three parts:condition, statement1, statement2, like this:

if (condition) { doThis(); } 
else           { doThat(); } // Note: This code is valid with or without brackets, but it is strongly recommended to use brackets.
It means that if the condition is true, then execute the statementa, otherwise execute the statementb. If the statementa or statementb are more than one line, you need to add { and } at the head and tail of statements in JS, to keep the same indentation on Python and to put an end in Ruby where it indeed ends.

For example, if we want to judge whether a number is odd or even, we can write code like this:

public static string OddEven(int n)
{
  if (n % 2 == 0) { return "even number"; }
  else            { return "odd number"; }
}
If there is more than one condition to judge, we can use the compound if...else statement. For example:

public static string OldYoung(int age)
{
  if (age < 16)      { return "children"; }
  else if (age < 50) { return "young man"; } // use "else if" if needed
  else               { return "old man"; }
}
This function returns a different value depending on the parameter age.

Looks very complicated? Well, JS and Ruby also support the ternary operator and Python has something similar too:

condition ? DoThis() : DoThat();
Condition and statement separated by "?", different statement separated by ":" in both Ruby and JS; in Python you put the condition in the middle of two alternatives. The two examples above can be simplified with ternary operator:

public static int OldYoung(int age)
{
  return age < 16 ? "children" : age < 50 ? "young man" : "old man";
}
Task:
Complete function saleHotdogs/SaleHotDogs/sale_hotdogs, function accepts 1 parameter:n, n is the number of hotdogs a customer will buy, different numbers have different prices (refer to the following table), return how much money will the customer spend to buy that number of hotdogs.

number of hotdogs	price per unit (cents)
n < 5	100
n >= 5 and n < 10	95
n >= 10	90
You can use if..else or ternary operator to complete it.

When you have finished the work, click "Run Tests" to see if your code is working properly.

In the end, click "Submit" to submit your code and pass this kata.*/

    public class KataSaleHotDogs
    {
        public static int SaleHotDogs(int n)
        {
            if (n < 5)
            {
                return n * 100;
            }
            else if (n < 10)
            {
                return n * 95;
            }
            else
            {
                return n * 90;
            }
        }
    }


    /*Complete the function/method so that it returns the url with anything after the anchor (#) removed.

Examples
"www.codewars.com#about" --> "www.codewars.com"
"www.codewars.com?page=1" -->"www.codewars.com?page=1"
    */

    public static class KataRemoveUrls
    {
        public static string RemoveUrlAnchor(string url)
        {
            int anchorIndex = url.IndexOf('#');
            if (anchorIndex >= 0)
            {
                return url.Substring(0, anchorIndex);
            }
            else
            {
                return url;

            }
        }
    }

    /*My grandfather always predicted how old people would get, and right before he passed away he revealed his secret!

In honor of my grandfather's memory we will write a function using his formula!

Take a list of ages when each of your great-grandparent died.
Multiply each number by itself.
Add them all together.
Take the square root of the result.
Divide by two.
Example
predictAge(65, 60, 75, 55, 60, 63, 64, 45) == 86
Note: the result should be rounded down to the nearest integer.

Some random tests might fail due to a bug in the JavaScript implementation. Simply resubmit if that happens to you.*/

    public class AgePredictor
    {
        public static int PredictAge(params int[] ages)
        {
            return (int)Math.Sqrt(ages.Sum(x => x * x)) / 2;
        }

        /*As a treat, I'll let you read part of the script from a classic 'I'm Alan Partridge episode:

    Lynn: Alan, there’s that teacher chap.
    Alan: Michael, if he hits me, will you hit him first?
    Michael: No, he’s a customer. I cannot hit customers. I’ve been told. I’ll go and get some stock.
    Alan: Yeah, chicken stock.
    Phil: Hello Alan.
    Alan: Lynn, hand me an apple pie. And remove yourself from the theatre of conflict.
    Lynn: What do you mean?
    Alan: Go and stand by the yakults. The temperature inside this apple turnover is 1,000 degrees. If I squeeze it, a jet of molten Bramley apple is going to squirt out. Could go your way, could go mine. Either way, one of us is going down.
    Alan is known for referring to the temperature of the apple turnover as Hotter than the sun!. According to space.com the temperature of the sun's corona is 2,000,000 degrees Celsius, but we will ignore the science for now.

    Task
    Your job is simple, if x squared is more than 1000, return It's hotter than the sun!!, else, return Help yourself to a honeycomb Yorkie for the glovebox.*/
        public class KataApple
        {
            public static string Apple(object n)
            {
                return Convert.ToDouble(n) * Convert.ToDouble(n) > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
            }
        }



        /*Make multiple functions that will return the sum, difference, modulus, product, quotient, and the exponent respectively.

    Please use the following function names:

    addition = Add

    multiply = Multiply

    division = Divide

    modulus = Mod

    exponential = Exponent

    subtraction = Subt

    Note: All funcitons can return int and all will recieve 2 integers.

    Note: All math operations will be: a (operation) b*/

        public static class KataFunctions
        {
            public static int Add(int a, int b) => a + b;

            public static int Subt(int a, int b) => a - b;

            public static int Multiply(int a, int b) => a * b;

            public static int Divide(int a, int b) => a / b;

            public static int Mod(int a, int b) => a % b;

            public static int Exponent(int a, int b) => Convert.ToInt32(Math.Pow(a, b));

        }

        /*Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the list/array.

    If you need help, here's a reference:

    https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1*/

        public static class KataTake
        {
            public static int[] Take(int[] arr, int n)
            {
                if (n > arr.Length)
                {

                    return arr;
                }

                int[] result = new int[n];
                for (int i = 0; i < n; i++)
                {
                    result[i] = arr[i];
                }
                return result;
            }
        }

        /*I have a cat and a dog.

    I got them at the same time as kitten/puppy. That was humanYears years ago.

    Return their respective ages now as [humanYears,catYears,dogYears]

    NOTES:

    humanYears >= 1
    humanYears are whole numbers only
    Cat Years
    15 cat years for first year
    +9 cat years for second year
    +4 cat years for each year after that
    Dog Years
    15 dog years for first year
    +9 dog years for second year
    +5 dog years for each year after that*/

        public class Dinglemouse
        {

            public static int[] humanYearsCatYearsDogYears(int humanYears)
            {
                int catYear = 15 + (humanYears >= 2 ? 9 + 4 * (humanYears - 2) : 0);
                int dogYear = 15 + (humanYears >= 2 ? 9 + 5 * (humanYears - 2) : 0);

                return new int[] { humanYears, catYear, dogYear };
            }

        }

        /*Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

    [1, 2, 3, 4, 5] --> [-1, -2, -3, -4, -5]
    [1, -2, 3, -4, 5] --> [-1, 2, -3, 4, -5]
    [] --> []*/

        public static class ArraysInversion
        {
            public static int[] InvertValues(int[] input)
            {
                return input.Select(n => -n).ToArray();
            }
        }

        /*Your task is to sum the differences between consecutive pairs in the array in descending order.

    Example
    [2, 1, 10]  -->  9
    In descending order: [10, 2, 1]

    Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9*/

        public static class KataSumOfDiffer
        {
            public static int SumOfDifferences(int[] arr)
            {
                return arr.Length > 1 ? arr.Max() - arr.Min() : 0;
            }
        }

        /*Complete the method which accepts an array of integers, and returns one of the following:

    "yes, ascending" - if the numbers in the array are sorted in an ascending order
    "yes, descending" - if the numbers in the array are sorted in a descending order
    "no" - otherwise
    You can assume the array will always be valid, and there will always be one correct answer.*/

        public class KataIsSortAndHow
        {
            public static string IsSortedAndHow(int[] array)
            {
                if (array.OrderBy(a => a).SequenceEqual(array)) return "yes, ascending";
                if (array.OrderByDescending(a => a).SequenceEqual(array)) return "yes, descending";
                return "no";
            }
        }


        /*Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".

    Note: in C#, you'll always get the input as a string, so the above applies if the string isn't representing a double value.*/


        public class KataProblem
        {
            public static string Problem(string a)
            {
                try
                {
                    double value = double.Parse(a);
                    double result = value * 50 + 6;
                    return result.ToString();
                }
                catch (FormatException)
                {
                    return "Error";
                }
            }
        }


        /*Your task is to write a function which returns the n-th term of the following series, which is the sum of the first n terms of the sequence (n is the input parameter).

    S
    e
    r
    i
    e
    s
    :
    1
    +
    1
    4
    +
    1
    7
    +
    1
    10
    +
    1
    13
    +
    1
    16
    +
    …
    Series:1+ 
    4
    1
    ​
     + 
    7
    1
    ​
     + 
    10
    1
    ​
     + 
    13
    1
    ​
     + 
    16
    1
    ​
     +…
    You will need to figure out the rule of the series to complete this.

    Rules
    You need to round the answer to 2 decimal places and return it as String.

    If the given value is 0 then it should return "0.00".

    You will only be given Natural Numbers as arguments.

    Examples (Input --> Output)
    n
    1 --> 1 --> "1.00"
    2 --> 1 + 1/4 --> "1.25"
    5 --> 1 + 1/4 + 1/7 + 1/10 + 1/13 --> "1.57"*/

        public class NthSeries
        {

            public static string seriesSum(int n)
            {
                double sum = 0.0;

                for (int k = 1; k <= n; k++)
                {
                    sum += 1.0 / (1 + 3 * (k - 1));
                }

                return sum.ToString("F2");
            }
        }

        /*
         * This program tests the life of an evaporator containing a gas.

    We know the content of the evaporator (content in ml), the percentage of foam or gas lost every day (evap_per_day) and the threshold (threshold) in percentage beyond which the evaporator is no longer useful. All numbers are strictly positive.

    The program reports the nth day (as an integer) on which the evaporator will be out of use.

    Example:
    evaporator(10, 10, 5) -> 29
    Note:
    Content is in fact not necessary in the body of the function "evaporator", you can use it or not use it, as you wish. Some people might prefer to reason with content, some other with percentages only. It's up to you but you must keep it as a parameter because the tests have it as an argument.
         */

        public class Evaporator
        {

            public static int evaporator(double content, double evap_per_day, double threshold)
            {
                double remainingContent = content;
                int days = 0;

                while (remainingContent > (threshold / 100) * content)
                {
                    remainingContent -= (evap_per_day / 100) * remainingContent;
                    days++;
                }

                return days;
            }
        }

        /*Our football team has finished the championship.

    Our team's match results are recorded in a collection of strings. Each match is represented by a string in the format "x:y", where x is our team's score and y is our opponents score.

    For example: ["3:1", "2:2", "0:1", ...]

    Points are awarded for each match as follows:

    if x > y: 3 points (win)
    if x < y: 0 points (loss)
    if x = y: 1 point (tie)
    We need to write a function that takes this collection and returns the number of points our team (x) got in the championship by the rules given above.

    Notes:

    our team always plays 10 matches in the championship
    0 <= x <= 4
    0 <= y <= 4
    */

        public static class KataTotalPoints
        {
            public static int TotalPoints(string[] games)
            {
                return games.Sum(match =>
                {
                    var scores = match.Split(':');
                    int ourScore = int.Parse(scores[0]);
                    int opponentScore = int.Parse(scores[1]);

                    return ourScore > opponentScore ? 3 :
                           ourScore == opponentScore ? 1 : 0;
                });
            }
        }

        /*Write a simple regex to validate a username. Allowed characters are:

          lowercase letters,
          numbers,
           underscore
           Length should be between 4 and 16 characters (both included).*/
        public class KataValidateUs
        {
            public static bool ValidateUsr(string username)
            {
                string pattern = @"^[a-z0-9_]{4,16}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(username);
            }
        }

        /*Each number should be formatted that it is rounded to two decimal places. You don't need to check whether the input is a valid number because only valid numbers are used in the tests.

           Example:    
           5.5589 is rounded 5.56   
           3.3424 is rounded 3.34*/


        public class Numbers
        {
            public static double TwoDecimalPlaces(double number)
            {
                return Math.Round(number * 100.0) / 100.0;
            }
        }

        /*Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n ( inclusive ).
          Examples
            n = 0  ==> [1]        # [2^0]
             n = 1  ==> [1, 2]     # [2^0, 2^1]
             n = 2  ==> [1, 2, 4]  # [2^0, 2^1, 2^2]*/

        public class Kata
        {
            public static BigInteger[] PowersOfTwo(int n)
            {
                BigInteger[] result = new BigInteger[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    result[i] = BigInteger.Pow(2, i);
                }
                return result;
            }
        }
    }
    /*You are going to be given a string. Your job is to return that string in a certain order that I will explain below:

    Let's say you start with this: "012345"

    The first thing you do is reverse it:"543210"
    Then you will take the string from the 1st position and reverse it again:"501234"
    Then you will take the string from the 2nd position and reverse it again:"504321"
    Then you will take the string from the 3rd position and reverse it again:"504123"

    Continue this pattern until you have done every single position, and then you will return the string you have created. For this particular number, you would return:"504132"*/

    public class KataFlipNumber
    {
        public static string FlipNumber(string n)
        {
            char[] arr = n.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Array.Reverse(arr, i, arr.Length - i);
            }
            return new string(arr);
        }
    }


    /*Create a function named (Combine_names) that accepts two parameters (first and last name). The function should return the full name.

    Example:

    CombineNames("James", "Stevens")
    returns:

    "James Stevens"*/
    public static class KataCombineNames
    {

        public static string Combine_names(string a, string b)
        {
            return $"{a} {b}";
        }
    }

    /*Write a small function that returns the values of an array that are not odd.

    All values in the array will be integers. Return the good values in the order they are given.*/

    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            return values.Where(x => x % 2 == 0).ToArray();
        }
    }

    /*John has invited some friends. His list is:

    s = "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
    Could you make a program that

    makes this string uppercase
    gives it sorted in alphabetical order by last name.
    When the last names are the same, sort them by first name. Last name and first name of a guest come in the result between parentheses separated by a comma.

    So the result of function meeting(s) will be:

    "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)"
    It can happen that in two distinct families with the same family name two people have the same first name too.*/

    public class JohnMeeting
    {
        public static string Meeting(string s)
        {
            var names = s.Split(';');
            var formattedNames = new List<string>();

            foreach (var name in names)
            {
                var parts = name.Split(':');
                var firstName = parts[0].ToUpper();
                var lastName = parts[1].ToUpper();

                formattedNames.Add($"({lastName}, {firstName})");
            }
            formattedNames.Sort();
            return string.Join("", formattedNames);
        }
    }

    /*This function takes two numbers as parameters, the first number being the coefficient, and the second number being the exponent.

    Your function should multiply the two numbers, and then subtract 1 from the exponent. Then, it has to return an expression (like 28x^7). "^1" should not be truncated when exponent = 2.

    For example:

    derive(7, 8)
    In this case, the function should multiply 7 and 8, and then subtract 1 from 8. It should output "56x^7", the first number 56 being the product of the two numbers, and the second number being the exponent minus 1.

    derive(7, 8) --> this should output "56x^7" 
    derive(5, 9) --> this should output "45x^8" */


    public class KataDerive
    {
        public static string Derive(double coefficient, double exponent)
        {
            return new string($"{coefficient * exponent}x^{exponent - 1}");
        }
    }

    /*Bob needs a fast way to calculate the volume of a cuboid with three values: the length, width and height of the cuboid. Write a function to help Bob with this calculation.

    */

    public class KataGetVolumeofCuboid
    {
        public static double GetVolumeOfCuboid(double length, double width, double height)
        {
            return length * width * height;
        }

        //public static double getVolumeOfCubiod(double length, double width, double height) => length * width * height;
    }

    /*Write function bmi that calculates body mass index (bmi = weight / height2).

    if bmi <= 18.5 return "Underweight"

    if bmi <= 25.0 return "Normal"

    if bmi <= 30.0 return "Overweight"

    if bmi > 30 return "Obese"*/

    public class KataBmi
    {
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);

            if (bmi <= 18.5)
                return "Underweight";
            else if (bmi <= 25.0)
                return "Normal";
            else if (bmi <= 30.0)
                return "Overweight";
            else
                return "Obese";
        }
    }


    /*fastest as u can you need to double the integer and return it.*/

    public static class KataDoubleInt
    {
        public static int DoubleInteger(int n)
        {
            return n * 2;
        }
    }


    /*You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

    Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

    []                                -->  "no one likes this"
    ["Peter"]                         -->  "Peter likes this"
    ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
    ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
    ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
    Note: For 4 or more names, the number in "and 2 others" simply increases.*/

    public static class KataLikes
    {
        public static string Likes(string[] name)
        {
            int count = name.Length;

            switch (count)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    return $"{name[0]}, {name[1]} and {count - 2} others like this";
            }
        }
    }

    /*Your task is to find the nearest square number, nearest_sq(n) or nearestSq(n), of a positive integer n.

    For example, if n = 111, then nearest\_sq(n) (nearestSq(n)) equals 121, since 111 is closer to 121, the square of 11, than 100, the square of 10.

    If the n is already the perfect square (e.g. n = 144, n = 81, etc.), you need to just return n.*/

    public static class KatanearestSq
    {
        public static int NearestSq(int n)
        {
            double sqrt = Math.Sqrt(n);
            if (Math.Abs(sqrt - Math.Floor(sqrt)) < 1e-9)
                return n;

            int aboveN = (int)Math.Pow(Math.Ceiling(sqrt), 2);
            int belowN = (int)Math.Pow(Math.Floor(sqrt), 2);

            int diff1 = aboveN - n;
            int diff2 = n - belowN;

            return diff1 > diff2 ? belowN : aboveN;
        }
    }
    /*Your task is to write a function which returns the sum of a sequence of integers.

    The sequence is defined by 3 non-negative values: begin, end, step.

    If begin value is greater than the end, your function should return 0. If end is not the result of an integer number of steps, then don't add it to the sum. See the 4th example below.

    Examples

    2,2,2 --> 2
    2,6,2 --> 12 (2 + 4 + 6)
    1,5,1 --> 15 (1 + 2 + 3 + 4 + 5)
    1,5,3  --> 5 (1 + 4)*/

    public static class KataSequenceSum
    {
        public static int SequenceSum(int start, int end, int step)
        {
            if (start > end)
            {
                return 0;
            }

            int n = (end - start) / step + 1;
            return Enumerable.Range(0, n).Sum(i => start + i * step);
        }
    }

    /*There's a "3 for 2" (or "2+1" if you like) offer on mangoes. For a given quantity and price (per mango), calculate the total cost of the mangoes.

    Examples
    mango(2, 3) ==> 6    # 2 mangoes for $3 per unit = $6; no mango for free
    mango(3, 3) ==> 6    # 2 mangoes for $3 per unit = $6; +1 mango for free
    mango(5, 3) ==> 12   # 4 mangoes for $3 per unit = $12; +1 mango for free
    mango(9, 5) ==> 30   # 6 mangoes for $5 per unit = $30; +3 mangoes for free*/

    public class KataMango
    {
        public static int Mango(int quantity, int price)
        {
            int paidMangoes = quantity - (quantity / 3);
            int totalCost = paidMangoes * price;
            return totalCost;
        }
    }

    /*Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively.

    Examples (Input -> Output)
    * [4,6,2,1,9,63,-134,566]         -> max = 566, min = -134
    * [-52, 56, 30, 29, -54, 0, -110] -> min = -110, max = 56
    * [42, 54, 65, 87, 0]             -> min = 0, max = 87
    * [5]                             -> min = 5, max = 5*/

    public class KataMINMAX
    {
        public int Min(int[] list)
        {
            if (list == null || !list.Any())
            {
                throw new ArgumentException("Input list cannot be empty.");
            }

            return list.Min();
        }

        public int Max(int[] list)
        {
            if (list == null || !list.Any())
            {
                throw new ArgumentException("Input list cannot be empty.");
            }

            return list.Max();
        }
    }

    /*You are given a string containing a sequence of character sequences separated by commas.

    Write a function which returns a new string containing the same character sequences except the first and the last ones but this time separated by spaces.

    If the input string is empty or the removal of the first and last items would cause the resulting string to be empty, return an empty value (represented as a generic value NULL in the examples below).

    Examples
    "1,2,3"      =>  "2"
    "1,2,3,4"    =>  "2 3"
    "1,2,3,4,5"  =>  "2 3 4"

    ""     =>  NULL
    "1"    =>  NULL
    "1,2"  =>  NULL*/

    public static class KataArray
    {
        public static string Array(string s)
        {
            var sequences = s.Split(',');
            if (sequences.Length < 3)
                return null;

            return string.Join(" ", sequences.Skip(1).Take(sequences.Length - 2));
        }
    }

    /*Given a string of arbitrary length with any ascii characters. Write a function to determine whether the string contains the whole word "English".

    The order of characters is important -- a string "abcEnglishdef" is correct but "abcnEglishsef" is not correct.

    Upper or lower case letter does not matter -- "eNglisH" is also correct.

    Return value as boolean values, true for the string to contains "English", false for it does not.*/


    static class KataSpeakEnglish
    {
        public static bool SpeakEnglish(string sentence)
        {
            return sentence.ToLower().Contains("english");
        }
    }

    /*Alex just got a new hula hoop, he loves it but feels discouraged because his little brother is better than him.

    Write a program where Alex can input (n) how many times the hoop goes round and it will return him an encouraging message:

    If Alex gets 10 or more hoops, return the string "Great, now move on to tricks".
    If he doesn't get 10 hoops, return the string "Keep at it until you get it".*/


    public class KataHoopCount
    {
        public static string HoopCount(int n)
        {
            return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
        }
    }
    /*In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.

    Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#) or IllegalArgumentException (Java) or RangeException (PHP) or throw a RangeError (JavaScript) or ValueError (Python) or return -1 (C).

    */

    public static class KataFactorial
    {
        public static int Factorial(int n)
        {
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Invalid input))))).");
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
    public class KataSquare
    {
        public static double Square(double number)
        {
            return number * number;
        }
    }

    /*Given a 2D ( nested ) list ( array, vector, .. ) of size m * n, your task is to find the sum of the minimum values in each row.

    For Example:

    [ [ 1, 2, 3, 4, 5 ]        #  minimum value of row is 1
    , [ 5, 6, 7, 8, 9 ]        #  minimum value of row is 5
    , [ 20, 21, 34, 56, 100 ]  #  minimum value of row is 20
    ]
    So the function should return 26 because the sum of the minimums is 1 + 5 + 20 = 26.

    Note: You will always be given a non-empty list containing positive values.*/

    class KataSumOfMinimums
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int min = Enumerable.Range(0, numbers.GetLength(1))
                                    .Select(j => numbers[i, j])
                                    .Min();
                sum += min;
            }
            return sum;
        }
    }

    /*Create a combat function that takes the player's current health and the amount of damage recieved, and returns the player's new health. Health can't be less than 0.*/

    public static class Game
    {
        public static float Combat(float health, float damage)
        {
            float newHealth = health - damage;
            return newHealth < 0 ? 0 : newHealth;
        }
    }

    /*The following was a question that I received during a technical interview for an entry level software developer position. I thought I'd post it here so that everyone could give it a go:

    You are given an unsorted array containing all the integers from 0 to 100 inclusively. However, one number is missing. Write a function to find and return this number. What are the time and space complexities of your solution?*/

    public static class KataMissingNo
    {
        public static int MissingNo(int[] nums)
        {
            int n = 100;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = nums.Sum();
            return expectedSum - actualSum;


            //return 5050 - nums.Sum();
        }
    }

    /*The purpose of this kata is to work out just how many bottles of duty free whiskey you would have to buy such that the savings over the normal high street price would effectively cover the cost of your holiday.

    You will be given the high street price (normPrice, in £ (Pounds)), the duty free discount (discount, in percent) and the cost of the holiday (in £).

    For example, if a bottle costs £10 normally and the duty free discount is 10%, you would save £1 per bottle. If your holiday will cost £500, you would have to purchase 500 bottles to save £500, so the answer you return should be 500.

    Another example: if a bottle costs £12 normally and the duty free discount is 50%, you would save £6 per bottle. If your holiday will cost £1000, you would have to purchase 166.66 bottles to save £1000, so your answer should be 166 bottles.

    All inputs will be integers. Please return an integer. Round down.*/

    public class KataDutyFree
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            double savingsPerBottle = normPrice * (Discount / 100.0);
            int bottlesNeeded = (int)(hol / savingsPerBottle);
            return bottlesNeeded;
        }
    }
    /*Fellow code warrior, we need your help! We seem to have lost one of our sequence elements, and we need your help to retrieve it!

    Our sequence given was supposed to contain all of the integers from 0 to 9 (in no particular order), but one of them seems to be missing.

    Write a function that accepts a sequence of unique integers between 0 and 9 (inclusive), and returns the missing element.

    Examples:
    [0, 5, 1, 3, 2, 9, 7, 6, 4] --> 8
    [9, 2, 4, 5, 7, 0, 8, 6, 1] --> 3*/

    public static class KataGetMissing
    {
        public static int GetMissingElement(int[] superImportantArray)
        {
            int expectedSum = 45;
            int actualSum = 0;

            foreach (int num in superImportantArray)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }
    }

    /*Complete the function which converts a binary number (given as a string) to a decimal number.*/

    public class BinToDec
    {
        public int binToDec(string s)
        {
            int decimalValue = 0;
            int baseValue = 1;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1')
                {
                    decimalValue += baseValue;
                }
                baseValue *= 2;
            }

            return decimalValue;
        }
    }


    /*In this kata you will create a function that takes in a list and returns a list with the reverse order.

    Examples (Input -> Output)
    * [1, 2, 3, 4]  -> [4, 3, 2, 1]
    * [9, 2, 0, 7]  -> [7, 0, 2, 9]*/
    public class KataRevrs
    {
        public static List<int> ReverseList(List<int> list)
        {
            List<int> reversedList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }
            return reversedList;
        }
    }

    /*n and m are natural numbers (positive integers)
    m is excluded from the multiples
    Examples

    Kata.SumMul(2, 9)   => 2 + 4 + 6 + 8 = 20
    Kata.SumMul(3, 13)  => 3 + 6 + 9 + 12 = 30
    Kata.SumMul(4, 123) => 4 + 8 + 12 + ... = 1860
    Kata.SumMul(4, 1)   // throws ArgumentException
    Kata.SumMul(0, 20)  // throws ArgumentException*/

    public class KataSumMul
    {
        public static int SumMul(int n, int m)
        {
            if (n <= 0 || m <= 0 || m <= n)
                throw new ArgumentException("n and m must be positive integers and m must be greater than n");

            int sum = 0;
            for (int i = n; i < m; i += n)
            {
                sum += i;
            }

            return sum;
        }
    }


    /*Mr. Scrooge has a sum of money 'P' that he wants to invest. Before he does, he wants to know how many years 'Y' this sum 'P' has to be kept in the bank in order for it to amount to a desired sum of money 'D'.

    The sum is kept for 'Y' years in the bank where interest 'I' is paid yearly. After paying taxes 'T' for the year the new sum is re-invested.

    Note to Tax: not the invested principal is taxed, but only the year's accrued interest

    Example:

      Let P be the Principal = 1000.00      
      Let I be the Interest Rate = 0.05      
      Let T be the Tax Rate = 0.18      
      Let D be the Desired Sum = 1100.00


    After 1st Year -->
      P = 1041.00
    After 2nd Year -->
      P = 1083.86
    After 3rd Year -->
      P = 1128.30
    Thus Mr. Scrooge has to wait for 3 years for the initial principal to amount to the desired sum.

    Your task is to complete the method provided and return the number of years 'Y' as a whole in order for Mr. Scrooge to get the desired sum.

    Assumption: Assume that Desired Principal 'D' is always greater than the initial principal. However it is best to take into consideration that if Desired Principal 'D' is equal to Principal 'P' this should return 0 Years.*/

    public class KataCalcYears
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            if (principal >= desiredPrincipal)
                return 0;

            int years = 0;
            while (principal < desiredPrincipal)
            {
                double interestEarned = principal * interest;
                double interestAfterTax = interestEarned * (1 - tax);
                principal += interestAfterTax;
                years++;
            }

            return years;
        }
    }


    /*An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

    Example: (Input --> Output)

    "Dermatoglyphics" --> true
    "aba" --> false
    "moOse" --> false (ignore letter case*/

    public class KataIsIsogram
    {
        public static bool IsIsogram(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            str = str.ToLower();
            var charSet = new HashSet<char>();

            foreach (char c in str)
            {
                if (charSet.Contains(c))
                    return false;
                charSet.Add(c);
            }

            return true;
        }
    }

    /*In this simple exercise, you will build a program that takes a value, integer , and returns a list of its multiples up to another value, limit . If limit is a multiple of integer, it should be included as well. There will only ever be positive integers passed into the function, not consisting of 0. The limit will always be higher than the base.

    For example, if the parameters passed are (2, 6), the function should return [2, 4, 6] as 2, 4, and 6 are the multiples of 2 up to 6.*/


    public class KataFindMultiples
    {
        public static List<int> FindMultiples(int integer, int limit)
        {
            List<int> multiples = new List<int>();
            for (int i = integer; i <= limit; i += integer)
            {
                multiples.Add(i);
            }
            return multiples;
        }
    }

    /*Your boss decided to save money by purchasing some cut-rate optical character recognition software for scanning in the text of old novels to your database. At first it seems to capture words okay, but you quickly notice that it throws in a lot of numbers at random places in the text.

    Examples (input -> output)
    '! !'                 -> '! !'
    '123456789'           -> ''
    'This looks5 grea8t!' -> 'This looks great!'
    Your harried co-workers are looking to you for a solution to take this garbled text and remove all of the numbers.
    Your program will take in a string and clean out all numeric characters, and return a string with spacing and special
    characters ~#$%^&!@*():;"'.,? all intact.*/

    public class KataStringClean
    {
        public static string StringClean(string s)
        {
            return new string(s.Where(c => !char.IsDigit(c)).ToArray());
        }
    }

    /*Write a function named setAlarm/set_alarm/set-alarm/setalarm (depending on language) which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.

    The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise. Examples:

    employed | vacation 
    true     | true     => false
    true     | false    => true
    false    | true     => false
    false    | false    => false*/

    public class KataSetAlarm
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            return employed && !vacation;
        }
    }
    /*Write a function that returns the total surface area and volume of a box as an array: [area, volume]*/
    public class KataGet_SIZE
    {
        public static int[] Get_size(int w, int h, int d)
        {
            int surfaceArea = 2 * (w * h + h * d + d * w);
            int volume = w * h * d;
            return new int[] { surfaceArea, volume };
        }
    }

    /*Create a function called shortcut to remove the lowercase vowels (a, e, i, o, u ) in a given string.

    Examples

    "hello"     -->  "hll"
    "codewars"  -->  "cdwrs"
    "goodbye"   -->  "gdby"
    "HELLO"     -->  "HELLO"*/

    public class KataShortcut
    {
        public static string Shortcut(string input)
        {
            string vowels = "aeiou";
            return new string(input.Where(c => !vowels.Contains(c)).ToArray());
        }

        /*Your function takes two arguments:

        current father's age (years)
        current age of his son (years)
        Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old). The answer is always greater or equal to 0, no matter if it was in the past or it is in the future.
        */

        public class TwiceAsOldSolution
        {
            public static int TwiceAsOld(int dadYears, int sonYears)
            {
                return Math.Abs(dadYears - 2 * sonYears);
            }
        }

        /*Implement a pseudo-encryption algorithm which given a string S and an integer N concatenates all the odd-indexed characters of S with all the even-indexed characters of S, this process should be repeated N times.

        Examples:

        encrypt("012345", 1)  =>  "135024"
        encrypt("012345", 2)  =>  "135024"  ->  "304152"
        encrypt("012345", 3)  =>  "135024"  ->  "304152"  ->  "012345"

        encrypt("01234", 1)  =>  "13024"
        encrypt("01234", 2)  =>  "13024"  ->  "32104"
        encrypt("01234", 3)  =>  "13024"  ->  "32104"  ->  "20314"
        Together with the encryption function, you should also implement a decryption function which reverses the process.

        If the string S is an empty value or the integer N is not positive, return the first argument without changes.*/

        public class Kata
        {
            public static string Encrypt(string text, int n)
            {
                if (string.IsNullOrEmpty(text) || n <= 0)
                    return text;

                for (int i = 0; i < n; i++)
                {
                    var oddChars = new StringBuilder();
                    var evenChars = new StringBuilder();

                    for (int j = 0; j < text.Length; j++)
                    {
                        if (j % 2 == 0)
                            evenChars.Append(text[j]);
                        else
                            oddChars.Append(text[j]);
                    }

                    text = oddChars.ToString() + evenChars.ToString();
                }

                return text;
            }

            public static string Decrypt(string encryptedText, int n)
            {
                if (string.IsNullOrEmpty(encryptedText) || n <= 0)
                    return encryptedText;

                int halfLength = encryptedText.Length / 2;

                for (int i = 0; i < n; i++)
                {
                    var decrypted = new StringBuilder();

                    for (int j = 0; j < halfLength; j++)
                    {
                        decrypted.Append(encryptedText[halfLength + j]);
                        if (j < halfLength || encryptedText.Length % 2 == 0)
                            decrypted.Append(encryptedText[j]);
                    }

                    if (encryptedText.Length % 2 != 0)
                        decrypted.Append(encryptedText[encryptedText.Length - 1]);

                    encryptedText = decrypted.ToString();
                }

                return encryptedText;
            }
        }
        /*Complete the function that receives as input a string, and produces outputs according to the following table:

        Input	Output
        "Jabroni"	"Patron Tequila"
        "School Counselor"	"Anything with Alcohol"
        "Programmer"	"Hipster Craft Beer"
        "Bike Gang Member"	"Moonshine"
        "Politician"	"Your tax dollars"
        "Rapper"	"Cristal"
        anything else	"Beer"
        Note: anything else is the default case: if the input to the function is not any of the values in the table, then the return value should be "Beer".

        Make sure you cover the cases where certain words do not show up with correct capitalization. For example, the input*/

        public class KataGetDrink
        {
            public static string GetDrinkByProfession(string p)
            {
                switch (p.ToLower())
                {
                    case "jabroni":
                        return "Patron Tequila";
                    case "school counselor":
                        return "Anything with Alcohol";
                    case "programmer":
                        return "Hipster Craft Beer";
                    case "bike gang member":
                        return "Moonshine";
                    case "politician":
                        return "Your tax dollars";
                    case "rapper":
                        return "Cristal";
                    default:
                        return "Beer";
                }
            }
        }

        /*Inspired by the development team at Vooza, write the function that

        accepts the name of a programmer, and
        returns the number of lightsabers owned by that person.
        The only person who owns lightsabers is Zach, by the way. He owns 18, which is an awesome number of lightsabers. Anyone else owns 0.

        Note: your function should have a default parameter.

        For example(Input --> Output):

        "anyone else" --> 0
        "Zach" --> 18*/

        public class KataZach
        {
            public static int HowManyLightsabersDoYouOwn(string name)
            {
                return name == "Zach" ? 18 : 0;
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

        public class KataFindDifference
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
        public class KataIsLetter
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
    }
}


