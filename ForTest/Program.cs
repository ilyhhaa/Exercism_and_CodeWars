
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

    }
}
/*
 Given an input of an array of digits, return the array with each digit incremented by its position in the array: the first digit will be incremented by 1, the second digit by 2, etc. Make sure to start counting your positions from 1 ( and not 0 ).

Your result can only contain single digit numbers, so if adding a digit with its position gives you a multiple-digit number, only the last digit of the number should be returned.

Notes:
return an empty array if your array is empty
arrays will only contain numbers so don't worry about checking that
Examples:
[1, 2, 3]  -->  [2, 4, 6]   #  [1+1, 2+2, 3+3]

[4, 6, 9, 1, 3]  -->  [5, 8, 2, 5, 8]  #  [4+1, 6+2, 9+3, 1+4, 3+5]
                                       #  9+3 = 12  -->  2
 */

public static class KataIncrementer
{
    public static int[] Incrementer(int[] numbers)
    {
        return numbers.Select((n, i) => (n + i + 1) % 10).ToArray();
    }
}


/*
 Have you heard about the myth that if you fold a paper enough times, you can reach the moon with it? Sure you have, but exactly how many? Maybe it's time to write a program to figure it out.

You know that a piece of paper has a thickness of 0.0001m. Given distance in units of meters, calculate how many times you have to fold the paper to make the paper reach this distance.
(If you're not familiar with the concept of folding a paper: Each fold doubles its total thickness.)

Note: Of course you can't do half a fold. You should know what this means ;P

Also, if somebody is giving you a negative distance, it's clearly bogus and you should yell at them by returning null (or whatever equivalent in your language). In Shell please return None. In C and COBOL please return -1.
*/

public class KataFoldTo
{
    public static int? FoldTo(double distance)
    {

        if (distance < 0)
        {
            return null;
        }

        const double initialThickness = 0.0001;
        int folds = 0;
        double currentThickness = initialThickness;

        while (currentThickness < distance)
        {
            currentThickness *= 2;
            folds++;
        }

        return folds;

    }
}

/*
 Create a function that takes a number as an argument and returns a grade based on that number.

Score	Grade
Anything greater than 1 or less than 0.6	"F"
0.9 or greater	"A"
0.8 or greater	"B"
0.7 or greater	"C"
0.6 or greater	"D"
Examples:

grader(0)   should be "F"
grader(1.1) should be "F"
grader(0.9) should be "A"
grader(0.8) should be "B"
grader(0.7) should be "C"
grader(0.6) should be "D"
 */

public class KataGrader
{
    public static char Grader(double score)
    {
        switch (score)
        {
            case var _ when score > 1 || score < 0.6:
                return 'F';
            case var _ when score >= 0.9:
                return 'A';
            case var _ when score >= 0.8:
                return 'B';
            case var _ when score >= 0.7:
                return 'C';
            case var _ when score >= 0.6:
                return 'D';
            default:
                return 'F';
        }
    }
}


/*
 We want to know the index of the vowels in a given word, for example, there are two vowels in the word super (the second and fourth letters).

So given a string "super", we should return a list of [2, 4].

Some examples:
Mmmm  => []
Super => [2,4]
Apple => [1,5]
YoMama -> [1,2,4,6]
 */

public class KataVowelIndices
{
    public static int[] VowelIndices(string word)
    {
        HashSet<char> vowelSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

        List<int> vowelIndexList = new List<int>();

        for (int i = 0; i < word.Length; i++)
        {
            if (vowelSet.Contains(word[i]))
            {
                vowelIndexList.Add(i + 1);
            }
        }
        return vowelIndexList.ToArray();
    }
}


/*
 My friend John likes to go to the cinema. He can choose between system A and system B.

System A : he buys a ticket (15 dollars) every time
System B : he buys a card (500 dollars) and a first ticket for 0.90 times the ticket price, 
then for each additional ticket he pays 0.90 times the price paid for the previous ticket.
Example:
If John goes to the cinema 3 times:

System A : 15 * 3 = 45
System B : 500 + 15 * 0.90 + (15 * 0.90) * 0.90 + (15 * 0.90 * 0.90) * 0.90 ( = 536.5849999999999, no rounding for each ticket)
John wants to know how many times he must go to the cinema so that the final result of System B, when rounded up to the next dollar, will be cheaper than System A.

The function movie has 3 parameters: card (price of the card), ticket (normal price of a ticket), perc (fraction of what he paid for the previous ticket) and returns the first n such that

ceil(price of System B) < price of System A.
More examples:
movie(500, 15, 0.9) should return 43 
    (with card the total price is 634, with tickets 645)
movie(100, 10, 0.95) should return 24 
    (with card the total price is 235, with tickets 240)
 */

public class MovieC
{

    public static int Movie(int card, int ticket, double perc)
    {
        int visits = 0;
        double totalCostA = 0;
        double totalCostB = card;
        double currentTicketPrice = ticket;

        while (Math.Ceiling(totalCostB) >= totalCostA)
        {
            visits++;
            totalCostA += ticket;
            currentTicketPrice *= perc;
            totalCostB += currentTicketPrice;
        }

        return visits;
    }
}

/*
 The Western Suburbs Croquet Club has two categories of membership, Senior and Open. They would like your help with an application form that will tell prospective members which category they will be placed.

To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.

Input
Input will consist of a list of pairs. Each pair contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.

Output
Output will consist of a list of string values (in Haskell and C: Open or Senior) stating whether the respective member is to be placed in the senior or open category.

Example
input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]
 */

public class KataOpenOrSenior
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        List<string> categories = new List<string>();

        foreach (var member in data)
        {
            int age = member[0];
            int handicap = member[1];

            if (age >= 55 && handicap > 7)
            {
                categories.Add("Senior");
            }
            else
            {
                categories.Add("Open");
            }
        }

        return categories;
    }
}


/*
 In this kata you will have to write a function that takes litres and pricePerLitre (in dollar) as arguments.

Purchases of 2 or more litres get a discount of 5 cents per litre, purchases of 4 or more litres get a discount of 10 cents per litre, and so on every two litres, up to a maximum discount of 25 cents per litre. But total discount per litre cannot be more than 25 cents. Return the total cost rounded to 2 decimal places. Also you can guess that there will not be negative or non-numeric inputs.

Good Luck!
 */

public class KataFuelPrice
{
    public static double FuelPrice(double litres, double pricePerLitre)
    {
        double discountPerLitre = Math.Min((int)(litres / 2) * 0.05, 0.25);
        double discountedPricePerLitre = pricePerLitre - discountPerLitre;
        double totalCost = litres * discountedPricePerLitre;
        return Math.Round(totalCost, 2);
    }
}


/*
 Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.

You need to consider the following ratings:

Terrible: tip 0%
Poor: tip 5%
Good: tip 10%
Great: tip 15%
Excellent: tip 20%
The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:

"Rating not recognised" in Javascript, Python and Ruby...
...or null in Java
...or -1 in C#
Because you're a nice person, you always round up the tip, regardless of the service.
 */

public class KataCalculateTip
{
    public static int CalculateTip(double amount, string rating) =>
      rating.ToLower() switch
      {
          "terrible" => 0,
          "poor" => (int)Math.Ceiling(amount * 0.05),
          "good" => (int)Math.Ceiling(amount * 0.1),
          "great" => (int)Math.Ceiling(amount * 0.15),
          "excellent" => (int)Math.Ceiling(amount * 0.2),
          _ => -1,
      };
}

/*
 Introduction and warm-up (highly recommended): Playing With Lists/Arrays Series

Task
Given an array/list of integers, find the Nth smallest element in the array.

Notes
Array/list size is at least 3.
Array/list's numbers could be a mixture of positives , negatives and zeros.
Repetition in array/list's numbers could occur, so don't remove duplications.
Input >> Output Examples
arr=[3,1,2]            n=2    ==> return 2 
arr=[15,20,7,10,4,3]   n=3    ==> return 7 
arr=[2,169,13,-5,0,-1] n=4    ==> return 2 
arr=[2,1,3,3,1,2],     n=3    ==> return 2 
 */

class KataNthSmallest
{
    public static int NthSmallest(int[] arr, int pos)
    {
        Array.Sort(arr);
        return arr[pos - 1];
    }
}


/*
 I will give you an integer. Give me back a shape that is as long and wide as the integer. The integer will be a whole number between 1 and 50.

Example
n = 3, so I expect a 3x3 square back just like below as a string:

+++
+++
+++
 */

public static class KataGenerateShape
{
    public static string GenerateShape(int n)
    {
        return string.Join("\n", Enumerable.Repeat(new string('+', n), n));
    }
}

//Write function alternateCase which switch every letter in string from upper to lower and from lower to upper. E.g: Hello World -> hELLO wORLD

public static class KataAlternateCase
{
    public static string alternateCase(string s)
    {
        return new string(s.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
    }
}


/*
 Strong number is a number with the sum of the factorial of its digits is equal to the number itself.

For example, 145 is strong, because 1! + 4! + 5! = 1 + 24 + 120 = 145.

Task
Given a positive number, find if it is strong or not, and return either "STRONG!!!!" or "Not Strong !!".

Examples
1 is a strong number, because 1! = 1, so return "STRONG!!!!".
123 is not a strong number, because 1! + 2! + 3! = 9 is not equal to 123, so return "Not Strong !!".
145 is a strong number, because 1! + 4! + 5! = 1 + 24 + 120 = 145, so return "STRONG!!!!".
150 is not a strong number, because 1! + 5! + 0! = 122 is not equal to 150, so return "Not Strong !!".
 */
class KataStrongNumber
{
    public static string StrongNumber(int number)
    {
        int sumOfFactorials = number
             .ToString()
             .Select(digit => Factorial(int.Parse(digit.ToString())))
             .Sum();

        return sumOfFactorials == number ? "STRONG!!!!" : "Not Strong !!";
    }

    private static int Factorial(int n)
    {
        return n <= 1 ? 1 : Enumerable.Range(1, n).Aggregate((a, b) => a * b);
    }


    /*
         if(number==1 || number==2 || number==145)
          return "STRONG!!!!";
          return "Not Strong !!";
         */
}

/*
 Task
Given a number, Find if it is Tidy or not .

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
Number passed is always Positive .

Return the result as a Boolean

Input >> Output Examples
tidyNumber (12) ==> return (true)
Explanation:
The number's digits { 1 , 2 } are in non-Decreasing Order (i.e) 1 <= 2 .

tidyNumber (32) ==> return (false)
Explanation:
The Number's Digits { 3, 2} are not in non-Decreasing Order (i.e) 3 > 2 .

tidyNumber (1024) ==> return (false)
Explanation:
The Number's Digits {1 , 0, 2, 4} are not in non-Decreasing Order as 0 <= 1 .

tidyNumber (13579) ==> return (true)
Explanation:
The number's digits {1 , 3, 5, 7, 9} are in non-Decreasing Order .

tidyNumber (2335) ==> return (true)
Explanation:
The number's digits {2 , 3, 3, 5} are in non-Decreasing Order , Note 3 <= 3
 */

class KataTidyNumber
{
    public static bool TidyNumber(int n)
    {
        string numStr = n.ToString();

        for (int i = 0; i < numStr.Length - 1; i++)
        {
            if (numStr[i] > numStr[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}

/*
 Task
Given a number determine if it Automorphic or not .

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
The number passed to the function is positive
Input >> Output Examples
autoMorphic (25) -->> return "Automorphic" 
Explanation:
25 squared is 625 , Ends with the same number's digits which are 25 .

autoMorphic (13) -->> return "Not!!"
Explanation:
13 squared is 169 , Not ending with the same number's digits which are 69 .

autoMorphic (76) -->> return "Automorphic"
Explanation:
76 squared is 5776 , Ends with the same number's digits which are 76 .

autoMorphic (225) -->> return "Not!!"
Explanation:
225 squared is 50625 , Not ending with the same number's digits which are 225 .

autoMorphic (625) -->> return "Automorphic"
Explanation:
625 squared is 390625 , Ends with the same number's digits which are 625 .

autoMorphic (1) -->> return "Automorphic"
Explanation:
1 squared is 1 , Ends with the same number's digits which are 1 .

autoMorphic (6) -->> return "Automorphic"
Explanation:
6 squared is 36 , Ends with the same number's digits which are 6
 */

class KataAutomorphic
{
    public static string Automorphic(int n)
    {
        int square = n * n;
        string nStr = n.ToString();
        string squareStr = square.ToString();
        if (squareStr.EndsWith(nStr))
        {
            return "Automorphic";
        }
        else
        {
            return "Not!!";
        }
    }
}

/*
 Remove all exclamation marks from sentence but ensure a exclamation mark at the end of string. For a beginner kata, you can assume that the input data is always a non empty string, no need to verify it.

Examples
"Hi!"     ---> "Hi!"
"Hi!!!"   ---> "Hi!"
"!Hi"     ---> "Hi!"
"!Hi!"    ---> "Hi!"
"Hi! Hi!" ---> "Hi Hi!"
"Hi"      ---> "Hi!"
 */

public class KataRemoveSReplace
{
    public static string Remove(string s)
    {
        string result = s.Replace("!", "");
        return result + "!";
    }
}


/*All of the animals are having a feast! Each animal is bringing one dish. There is just one rule: the dish must start and end with the same letters as the animal's name. For example, the great blue heron is bringing garlic naan and the chickadee is bringing chocolate cake.

Write a function feast that takes the animal's name and dish as arguments and returns true or false to indicate whether the beast is allowed to bring the dish to the feast.

Assume that beast and dish are always lowercase strings, and that each has at least two letters. beast and dish may contain hyphens and spaces, but these will not appear at the beginning or end of the string. They will not contain numerals.*/

public class KataFeast
{
    public static bool Feast(string beast, string dish)
    {
        return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
    }
}

/*
 Implement String#digit? (in Java StringUtils.isDigit(String)), which should return true if given object is a digit (0-9), false otherwise.
 */

public static class KataDigit
{
    public static bool Digit(this string s)
    {
        return Regex.IsMatch(s, @"^\d\z");
    }
}

/*Time to test your basic knowledge in functions! Return the odds from a list:

[1, 2, 3, 4, 5]  -->  [1, 3, 5]
[2, 4, 6]        -->  []*/

public static class Kata
{
    public static List<int> Odds(List<int> values) => values.Where(v => v % 2 != 0).ToList();

}

/*
Find the number with the most digits.

If two numbers in the argument array have the same number of digits, return the first one in the array.
*/

public class KataFindLongest
{
    public static int FindLongest(int[] number)
    {
        if (number == null || number.Length == 0)
        {
            throw new ArgumentException("The array must not be null or empty.");
        }

        return number.OrderByDescending(num => num.ToString().Length).First();
    }
}

/*
 You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z. Let x be any string in the first array and y be any string in the second array.

Find max(abs(length(x) − length(y)))

If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).

Example:
a1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
a2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
mxdiflg(a1, a2) --> 13
Bash note:
input : 2 strings with substrings separated by ,
output: number as a string
 */
public class MaxDiffLength
{
    public static int Mxdiflg(string[] a1, string[] a2)
    {
        switch (a1.Length == 0 || a2.Length == 0)
        {
            case true:
                return -1;
            case false:
                int maxLenA1 = a1.Max(s => s.Length);
                int minLenA1 = a1.Min(s => s.Length);
                int maxLenA2 = a2.Max(s => s.Length);
                int minLenA2 = a2.Min(s => s.Length);

                int maxDiff1 = Math.Abs(maxLenA1 - minLenA2);
                int maxDiff2 = Math.Abs(maxLenA2 - minLenA1);

                return Math.Max(maxDiff1, maxDiff2);
        }
    }
}
/*
In this first kata in the series, you need to define a Hero class to be used in a terminal game. The hero should have the following attributes:

attribute	type	value
Name	string	user argument or "Hero"
Position	string	"00"
Health	float	100
Damage	float	5
Experience	int	0
*/

public class Hero
{
    public string Name { get; set; }
    public string Position { get; set; }
    public float Health { get; set; }
    public float Damage { get; set; }
    public int Experience { get; set; }

    public Hero(string name = "Hero")
    {
        Name = name;
        Position = "00";
        Health = 100f;
        Damage = 5f;
        Experience = 0;
    }
}

/*
 A number m of the form 10x + y is divisible by 7 if and only if x − 2y is divisible by 7. In other words, subtract twice the last digit from the number formed by the remaining digits. Continue to do this until a number known to be divisible by 7 is obtained; you can stop when this number has at most 2 digits because you are supposed to know if a number of at most 2 digits is divisible by 7 or not.

The original number is divisible by 7 if and only if the last number obtained using this procedure is divisible by 7.

Examples:
1 - m = 371 -> 37 − (2×1) -> 37 − 2 = 35 ; thus, since 35 is divisible by 7, 371 is divisible by 7.

The number of steps to get the result is 1.

2 - m = 1603 -> 160 - (2 x 3) -> 154 -> 15 - 8 = 7 and 7 is divisible by 7.

3 - m = 372 -> 37 − (2×2) -> 37 − 4 = 33 ; thus, since 33 is not divisible by 7, 372 is not divisible by 7.

4 - m = 477557101->47755708->4775554->477547->47740->4774->469->28 and 28 is divisible by 7, so is 477557101. The number of steps is 7.

Task:
Your task is to return to the function seven(m) (m integer >= 0) an array (or a pair, depending on the language) of numbers, the first being the last number m with at most 2 digits obtained by your function (this last m will be divisible or not by 7), the second one being the number of steps to get the result.

Forth Note:
Return on the stack number-of-steps, last-number-m-with-at-most-2-digits 

Examples:
seven(371) should return [35, 1]
seven(1603) should return [7, 2]
seven(477557101) should return [28, 7]
 */
public class DivSeven
{
    public static long[] Seven(long m)
    {
        int steps = 0;
        while (m >= 100)
        {
            long lastDigit = m % 10;
            m = m / 10 - 2 * lastDigit;
            steps++;
        }
        return new long[] { m, steps };
    }
}


/*
 The first input array is the key to the correct answers to an exam, like ["a", "a", "b", "d"]. The second one contains a student's submitted answers.

The two arrays are not empty and are the same length. Return the score for this array of answers, giving +4 for each correct answer, -1 for each incorrect answer, and +0 for each blank answer, represented as an empty string (in C the space character is used).

If the score < 0, return 0.

For example:

    Correct answer    |    Student's answer   |   Result         
 ---------------------|-----------------------|-----------
 ["a", "a", "b", "b"]   ["a", "c", "b", "d"]  →     6
 ["a", "a", "c", "b"]   ["a", "a", "b", "" ]  →     7
 ["a", "a", "b", "c"]   ["a", "a", "b", "c"]  →     16
 ["b", "c", "b", "a"]   ["" , "a", "a", "c"]  →     0
 */
public static class KataCheckExam
{
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int score = arr1.Zip(arr2, (correct, answer) =>
       answer == "" ? 0 : answer == correct ? 4 : -1).Sum();

        return Math.Max(score, 0);
    }
}

/*
 * An AI has infected a text with a character!!

This text is now fully mutated to this character.

If the text or the character are empty, return an empty string.
There will never be a case when both are empty as nothing is going on!!

Note: The character is a string of length 1 or an empty string.

Example
text before = "abc"
character   = "z"
text after  = "zzz"
 */


public class KataContamination
{
    public static string Contamination(string text, string character)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(character))
        {
            return string.Empty;
        }
        return new string(character[0], text.Length);
    }
}

/*This is a beginner friendly kata especially for UFC/MMA fans.

It's a fight between the two legends: Conor McGregor vs George Saint Pierre in Madison Square Garden. Only one fighter will remain standing, and after the fight in an interview with Joe Rogan the winner will make his legendary statement. It's your job to return the right statement depending on the winner!

If the winner is George Saint Pierre he will obviously say:

"I am not impressed by your performance."
If the winner is Conor McGregor he will most undoubtedly say:

"I'd like to take this chance to apologize.. To absolutely NOBODY!"
Good Luck!

Note
The given name may varies in casing, eg., it can be "George Saint Pierre" or "geOrGe saiNT pieRRE". Your solution should treat both as the same thing (case-insensitive).*/
public static class KataQuote
{
    public static string Quote(string fighter)
    {
        return fighter.ToLower() == "conor mcgregor" ? @"I'd like to take this chance to apologize.. To absolutely NOBODY!" : @"I am not impressed by your performance.";
    }
}

/*Filter the number
Oh, no! The number has been mixed up with the text. Your goal is to retrieve the number from the text, can you return the number back to its original state?

Task
Your task is to return a number from a string.

Details
You will be given a string of numbers and letters mixed up, you have to return all the numbers in that string in the order they occur.*/

public class KataFilterString
{
    public static int FilterString(string s) 
    {
        string result = new string(s.Where(char.IsDigit).ToArray());
        return int.Parse(result);
    }
}


/*There is a war and nobody knows - the alphabet war!
There are two groups of hostile letters. The tension between left side letters and right side letters was too high and the war began.

Task
Write a function that accepts fight string consists of only small letters and return who wins the fight. When the left side wins return Left side wins!, when the right side wins return Right side wins!, in other case return Let's fight again!.

The left side letters and their power:

 w - 4
 p - 3
 b - 2
 s - 1
The right side letters and their power:

 m - 4
 q - 3
 d - 2
 z - 1
The other letters don't have power and are only victims.

Example
AlphabetWar("z");        //=> Right side wins!
AlphabetWar("zdqmwpbs"); //=> Let's fight again!
AlphabetWar("zzzzs");    //=> Right side wins!
AlphabetWar("wwwwwwz");  //=> Left side wins!*/

public class KataAlphabetWar
{
    public static string AlphabetWar(string fight)
    {
        var numVal = new Dictionary<char, int>()
      {
          {'w', 4 },
          {'p', 3 },
          {'b', 2 },
          {'s', 1 },
          {'m', -4 },
          {'q', -3 },
          {'d', -2 },
          {'z', -1 }
      };

        int score = 0;

        foreach (var letter in fight)
        {
            if (numVal.ContainsKey(letter))
                score += numVal[letter];
        }

        if (score > 0)
            return "Left side wins!";
        else if (score == 0)
            return "Let's fight again!";
        else
            return "Right side wins!";
    }
}


/*You'll be given a string, and have to return the sum of all characters as an int. The function should be able to handle all printable ASCII characters.

Examples:

uniTotal("a") == 97
uniTotal("aaa") == 291*/

public class KataUniTotal
{
    public static int UniTotal(string str)
    {
        int sum = 0;
        foreach (char c in str)
        {
            sum += (int)c;
        }
        return sum;
    }
}

/*We want to generate a function that computes the series starting from 0 and ending until the given number.

Example:
Input:

> 6
Output:

0+1+2+3+4+5+6 = 21

Input:

> -15
Output:

-15<0

Input:

> 0
Output:

0=0*/

public class SequenceSum
{
    public static string ShowSequence(int n)
    {
        if (n < 0) return $"{n}<0";
        if (n == 0) return "0=0";

        IEnumerable<int> sequence = Enumerable.Range(0, n + 1);

        return $"{String.Join("+", sequence)} = {sequence.Sum()}";
    }
}


/*You might know some pretty large perfect squares. But what about the NEXT one?

Complete the findNextSquare method that finds the next integral perfect square after the one passed as a parameter. Recall that an integral perfect square is an integer n such that sqrt(n) is also an integer.

If the argument is itself not a perfect square then return either -1 or an empty value like None or null, depending on your language. You may assume the argument is non-negative.

Examples ( Input --> Output )
121 --> 144
625 --> 676
114 --> -1  #  because 114 is not a perfect square*/

public class KataFindNextSquare
{
    public static long FindNextSquare(long num)
    {
        long sqrt = (long)Math.Sqrt(num);
        if (sqrt * sqrt == num)
        {
            long nextSquare = (sqrt + 1) * (sqrt + 1);
            return nextSquare;
        }
        return -1;
    }
}

/*You and a friend have decided to play a game to drill your statistical intuitions. The game works like this:

You have a bunch of red and blue marbles. To start the game you grab a handful of marbles of each color and put them into the bag, keeping track of how many of each color go in. You take turns reaching into the bag, guessing a color, and then pulling one marble out. You get a point if you guessed correctly. The trick is you only have three seconds to make your guess, so you have to think quickly.

You've decided to write a function, guessBlue() to help automatically calculate whether you should guess "blue" or "red". The function should take four arguments:

the number of blue marbles you put in the bag to start
the number of red marbles you put in the bag to start
the number of blue marbles pulled out so far (always lower than the starting number of blue marbles)
the number of red marbles pulled out so far (always lower than the starting number of red marbles)
guessBlue() should return the probability of drawing a blue marble, expressed as a float. For example, guessBlue(5, 5, 2, 3) should return 0.6.*/
public static class BlueAndRedMarbles
{
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
        uint remainingBlue = blueStart - bluePulled;
        uint remainingRed = redStart - redPulled;
        uint totalRemaining = remainingBlue + remainingRed;

        return (double)remainingBlue / totalRemaining;
    }
}


/*Your task is to create a function that does four basic mathematical operations.

The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.

Examples(Operator, value1, value2) --> output
('+', 4, 7) --> 11
('-', 15, 18) --> -3
('*', 5, 5) --> 25
('/', 49, 7) --> 7*/
public static class KATABASICOP
{
    public static double basicOp(char operation, double value1, double value2)
    {
        switch (operation)
        {
            case '+':
                return value1 + value2;
            case '-':
                return value1 - value2;
            case '*':
                return value1 * value2;
            case '/':
                return value1 / value2;
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
}

/*A balanced number is a number where the sum of digits to the left of the middle digit(s) and the sum of digits to the right of the middle digit(s) are equal.

If the number has an odd number of digits, then there is only one middle digit. (For example, 92645 has one middle digit, 6.) Otherwise, there are two middle digits. (For example, the middle digits of 1301 are 3 and 0.)

The middle digit(s) should not be considered when determining whether a number is balanced or not, e.g. 413023 is a balanced number because the left sum and right sum are both 5.

The task
Given a number, find if it is balanced, and return the string "Balanced" or "Not Balanced" accordingly. The passed number will always be positive.

Examples
7 ==> return "Balanced"
Explanation:
middle digit(s): 7
sum of all digits to the left of the middle digit(s) -> 0
sum of all digits to the right of the middle digit(s) -> 0
0 and 0 are equal, so it's balanced.
295591 ==> return "Not Balanced"
Explanation:
middle digit(s): 55
sum of all digits to the left of the middle digit(s) -> 11
sum of all digits to the right of the middle digit(s) -> 10
11 and 10 are not equal, so it's not balanced.
959 ==> return "Balanced"
Explanation:
middle digit(s): 5
sum of all digits to the left of the middle digit(s) -> 9
sum of all digits to the right of the middle digit(s) -> 9
9 and 9 are equal, so it's balanced.
27102983 ==> return "Not Balanced"
Explanation:
middle digit(s): 02
sum of all digits to the left of the middle digit(s) -> 10
sum of all digits to the right of the middle digit(s) -> 20
10 and 20 are not equal, so it's not balanced.
*/
class KataBalancedNumber
{
    public static string BalancedNumber(int number)
    {
        string numStr = number.ToString();
        int length = numStr.Length;
        int leftSum = 0, rightSum = 0;
        if (length == 1)
        {
            return "Balanced";
        }
        int mid = length / 2;
        if (length % 2 == 0)
        {

            for (int i = 0; i < mid - 1; i++)
            {
                leftSum += numStr[i] - '0';
            }
            for (int i = mid + 1; i < length; i++)
            {
                rightSum += numStr[i] - '0';
            }
        }
        else
        {
            for (int i = 0; i < mid; i++)
            {
                leftSum += numStr[i] - '0';
            }
            for (int i = mid + 1; i < length; i++)
            {
                rightSum += numStr[i] - '0';
            }
        }
        return leftSum == rightSum ? "Balanced" : "Not Balanced";
    }
}

/*Given a mixed array of number and string representations of integers, add up the non-string integers and subtract the total of the string integers.

Return as a number.*/

public class KataDivCon
{
    public static int DivCon(Object[] objArray)
    {
        int sum = 0;

        foreach (var item in objArray)
        {
            if (item is int)
            {
                sum += (int)item;
            }
            else if (item is string)
            {
                if (int.TryParse((string)item, out int num))
                {
                    sum -= num;
                }
            }
        }

        return sum;
    }
}

/*Complete the function that takes two numbers as input, num and nth and return the nth digit of num (counting from right to left).

Note
If num is negative, ignore its sign and treat it as a positive value
If nth is not positive, return -1
Keep in mind that 42 = 00042. This means that findDigit(42, 5) would return 0
Examples(num, nth --> output)
5673, 4 --> 5
129, 2 --> 2
-2825, 3 --> 8
-456, 4 --> 0
0, 20 --> 0
65, 0 --> -1
24, -8 --> -1*/

public class KataFindDigit
{
    public static int FindDigit(int num, int nth)
    {
        if (nth <= 0)
        {
            return -1;
        }
        num = Math.Abs(num);
        string numStr = num.ToString().PadLeft(nth, '0');
        return numStr.Reverse().ElementAt(nth - 1) - '0';

    }
}


/*Complete the function so that it finds the average of the three scores passed to it and returns the letter value associated with that grade.

Numerical Score	Letter Grade
90 <= score <= 100	'A'
80 <= score < 90	'B'
70 <= score < 80	'C'
60 <= score < 70	'D'
0 <= score < 60	'F'
Tested values are all between 0 and 100. Theres is no need to check for negative values or values greater than 100.*/


public class KataGetGrade
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        double average = (s1 + s2 + s3) / 3.0;

        return average switch
        {
            >= 90 => 'A',
            >= 80 => 'B',
            >= 70 => 'C',
            >= 60 => 'D',
            _ => 'F'
        };
  
     }  
}



/*The objective of Duck, duck, goose is to walk in a circle, tapping on each player's head until one is chosen.

Task: Given an array of Player objects (an array of associative arrays in PHP) and an index (1-based), return the name of the chosen Player(name is a property of Player objects, e.g Player.name)

Example:

duck_duck_goose([a, b, c, d], 1) should return a.name
duck_duck_goose([a, b, c, d], 5) should return a.name
duck_duck_goose([a, b, c, d], 4) should return d.name
// PHP only
duck_duck_goose([$a, $b, $c, $d], 1); // => $a["name"]
duck_duck_goose([$a, $b, $c, $d], 5); // => $a["name"]
duck_duck_goose([$a, $b, $c, $d], 4); // => $d["name"]
*/

public class KataDuckDuckGoose
{
    public static string DuckDuckGoose(Player[] players, int goose)
    {
        int index = (goose - 1) % players.Length;
        return players[index].Name;
    }
}
public class Player
{
    public string Name { get; set; }

    public Player(string name)
    {
        this.Name = name;
    }
}


/*Count the number of occurrences of each character and return it as a (list of tuples) in order of appearance. For empty output return (an empty list).

Consult the solution set-up for the exact data structure implementation depending on your language.

Example:

Kata.OrderedCount("abracadabra") == new List<Tuple<char, int>> () {
  new Tuple<char, int>('a', 5),
  new Tuple<char, int>('b', 2),
  new Tuple<char, int>('r', 2), 
  new Tuple<char, int>('c', 1),
  new Tuple<char, int>('d', 1)
}
*/

public class KataOrderedCount
{
    public static List<Tuple<char, int>> OrderedCount(string input)
    {
        return input.GroupBy(c => c)
             .Select(g => new Tuple<char, int>(g.Key, g.Count()))
             .ToList();
    }
}

/*Finish the uefaEuro2016() function so it return string just like in the examples below:

uefaEuro2016(['Germany', 'Ukraine'],[2, 0]) // "At match Germany - Ukraine, Germany won!"
uefaEuro2016(['Belgium', 'Italy'],[0, 2]) // "At match Belgium - Italy, Italy won!"
uefaEuro2016(['Portugal', 'Iceland'],[1, 1]) // "At match Portugal - Iceland, teams played draw."*/

public class KataUefaEuro2016
{
    public static string UefaEuro2016(string[] teams, int[] scores)
    {
        var result = scores[0] == scores[1] ? "teams played draw." :
                     scores[0] > scores[1] ? $"{teams[0]} won!" : $"{teams[1]} won!";

        return $"At match {teams[0]} - {teams[1]}, {result}";
    }
}

/*You have to write a function that describe Leo:

def leo(oscar):
  pass
if oscar was (integer) 88, you have to return "Leo finally won the oscar! Leo is happy".
if oscar was 86, you have to return "Not even for Wolf of wallstreet?!"
if it was not 88 or 86 (and below 88) you should return "When will you give Leo an Oscar?"
if it was over 88 you should return "Leo got one already!"*/

public static class KataLEO
{
    public static string Leo(int oscar)
    {
        switch (oscar)
        {
            case 88:
                return "Leo finally won the oscar! Leo is happy";
            case 86:
                return "Not even for Wolf of wallstreet?!";
            default:
                if (oscar < 88)
                {
                    return "When will you give Leo an Oscar?";
                }
                else
                {
                    return "Leo got one already!";
                }
        }
    }
}

/*The male gametes or sperm cells in humans and other mammals are heterogametic and contain one of two types of sex chromosomes. They are either X or Y. The female gametes or eggs however, contain only the X sex chromosome and are homogametic.

The sperm cell determines the sex of an individual in this case. If a sperm cell containing an X chromosome fertilizes an egg, the resulting zygote will be XX or female. If the sperm cell contains a Y chromosome, then the resulting zygote will be XY or male.

Determine if the sex of the offspring will be male or female based on the X or Y chromosome present in the male's sperm.

If the sperm contains the X chromosome, return "Congratulations! You're going to have a daughter."; If the sperm contains the Y chromosome, return "Congratulations! You're going to have a son.";

*/

public class KataChromosomeCheck
{
    public static string ChromosomeCheck(string sperm)
    {
        return sperm == "XY" ? "Congratulations! You're going to have a son." : "Congratulations! You're going to have a daughter.";
    }
}

/*Write a function which takes a number and returns the corresponding ASCII char for that value.

Example:

65 --> 'A'
97 --> 'a'
48 --> '0*/

public class KataGetChar
{
    public static char GetChar(int charcode)
    {
        return Convert.ToChar(charcode);
    }
}

/*Color Ghost
Create a class Ghost

Ghost objects are instantiated without any arguments.

Ghost objects are given a random color attribute of "white" or "yellow" or "purple" or "red" when instantiated

ghost = new Ghost();
ghost.color //=> "white" or "yellow" or "purple" or "red"*/

public class Ghost
{
    private static readonly string[] colors = { "white", "yellow", "purple", "red" };
    private static readonly Random random = new Random();

    public string Color { get; private set; }

    public Ghost()
    {
        Color = colors[random.Next(colors.Length)];
    }

    public string GetColor()
    {
        return Color;
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

public class KataHighestRank
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