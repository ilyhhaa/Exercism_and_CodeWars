
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

    }
}
public class Revrot 
{
    public static string RevRot(string strng, int sz)
    {
        
        if (string.IsNullOrEmpty(strng) || sz <= 0 || sz > strng.Length)
            return ""; 
        
       
        int chunkCount = strng.Length / sz;
        int resultLength = chunkCount * sz; 
        
        return String.Create(resultLength, (strng, sz), (span, state) =>
        {
            int targetIndex = 0; 
            
            
            for (int i = 0; i < state.strng.Length - state.sz + 1; i += state.sz)
            {
                
                int sum = 0;
                for (int j = i; j < i + state.sz; j++)
                    sum += state.strng[j] - '0';
                
              
                if (sum % 2 == 0)
                {
                  
                    for (int j = i + state.sz - 1; j >= i; j--)
                        span[targetIndex++] = state.strng[j];
                }
                else
                {
                    
                    for (int j = i + 1; j < i + state.sz; j++)
                        span[targetIndex++] = state.strng[j];
                    span[targetIndex++] = state.strng[i];
                }
            }
        });
    }
}


public class KataSPLIT
{
    public static string SplitInParts(string s, int partLength)
    {
        int spaces = (s.Length - 1) / partLength;
        int totalLength = s.Length + spaces;
        
        return String.Create(totalLength, (s, partLength), (span, state) =>
        {
            int sourceIndex = 0;
            int targetIndex = 0;
            int charsInPart = 0;
            
            while (sourceIndex < state.s.Length)
            {
                span[targetIndex++] = state.s[sourceIndex++];
                charsInPart++;
                
                if (charsInPart == state.partLength && sourceIndex < state.s.Length)
                {
                    span[targetIndex++] = ' ';
                    charsInPart = 0;
                }
            }
        });
    }
}


public class Thirteen 
{
    private static readonly int[] r = { 1, 10, 9, 12, 3, 4 };
    
    public static long Thirt(long n)
    {
        while (true)
        {
            long sum = 0;
            long temp = n;
            int i = 0;
            
            while (temp > 0)
            {
                sum += (temp % 10) * r[i % 6];
                temp /= 10;
                i++;
            }
            
            if (sum == n) return sum;
            n = sum;
        }
    }
}

/*
Task

Given a list of positive integers, determine the minimum non-negative integer that needs to be inserted so that the sum of all elements becomes a prime number.

Notes

The list will always have at least 2 elements.
All elements will be positive integers (n > 0).
The list may contain duplicate values.
The new sum must be the closest prime number that is greater than or equal to the current sum.
*/

class ConvertToPrime
	{
		public static int MinimumNumber(int[] numbers)
{
    
    int sum = numbers.Sum();
    
    int target = sum;
    while (!IsPrime(target))
    {
        target++; 
    }
    
   
    return target - sum;
}


private static bool IsPrime(int number)
{
    
    if (number <= 1) return false;
    
    
    if (number == 2) return true;
    
    
    if (number % 2 == 0) return false;
    
    
    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0) return false; 
    }
    
    return true; 
}
	}
}


/*
The vowel substrings in the word codewarriors are o,e,a,io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.
*/
public static class LongestVowelChain
{
  public static int Solve(string str)
{
    int currentLength = 0; 
    int maxLength = 0;     
    string vowels = "aeiou"; 

    
    foreach (char c in str)
    {
        
        if (vowels.Contains(c))
        {
            currentLength++;
        }
        else
        {
            
            currentLength = 0;
        }

        
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
        }
    }

    return maxLength; 
}
}

class MergeSort
{
    static void Merge(int[] a, int l, int m, int r)
    {
        int i, j, k;

        int n1 = m - l + 1;
        int n2 = r - m;

        int[] left = new int[n1 + 1];
        int[] right = new int[n2 + 1];

        for (i = 0; i < n1; i++)
        {
            left[i] = a[l + i];
        }

        for (j = 1; j <= n2; j++)
        {
            right[j - 1] = a[m + j];
        }

        left[n1] = int.MaxValue;
        right[n2] = int.MaxValue;

        i = 0;
        j = 0;

        for (k = l; k <= r; k++)
        {
            if (left[i] < right[j])
            {
                a[k] = left[i];
                i = i + 1;
            }
            else
            {
                a[k] = right[j];
                j = j + 1;
            }
        }
    }
}

class QckSort
{
    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            { i++; Swap(array, i, j); }
        }

        Swap(array, i + 1, right);

        return i + 1;
    }
    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }


    //BubbleSort
    class BubbleSort
    {
        static void BubbleSorting(int[] array)
        {
            bool swapped;
            int n = array.Length;

            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
        }

    }


    /*
     Imagine you are creating a game where the user has to guess the correct number. But there is a limit of how many guesses the user can do.

    If the user tries to guess more than the limit, the function should throw an error.
    If the user guess is right it should return true.
    If the user guess is wrong it should return false and lose a life.
    Can you finish the game so all the rules are met?
     */

    public class Guesser
    {
        private int number;
        private int lives;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives <= 0)
            {
                throw new InvalidOperationException("No lives left. Game over!");
            }

            if (n == number)
            {
                return true;
            }
            else
            {
                lives--;
                return false;
            }
        }
    }


    /*
     Given 2 strings, a and b, return a string of the form: shorter+reverse(longer)+shorter.

    In other words, the shortest string has to be put as prefix and as suffix of the reverse of the longest.

    Strings a and b may be empty, but not null (In C# strings may also be null. Treat them as if they are empty.).
    If a and b have the same length treat a as the longer producing b+reverse(a)+b
     */

    /*
      public static string ShorterReverseLonger(string a, string b)
      {
        a ??= "";
        b ??= "";
        return b.Length > a.Length ? a + string.Concat(b.Reverse()) + a : b + string.Concat(a.Reverse()) + b;
      }
     */
    public class ReverseLonger
    {
        public static string ShorterReverseLonger(string a, string b)
        {
            if (a == null) a = "";
            if (b == null) b = "";

            string shorter = a.Length < b.Length ? a : b;
            string longer = a.Length >= b.Length ? a : b;

            char[] longerArray = longer.ToCharArray();
            Array.Reverse(longerArray);
            string reversedLonger = new string(longerArray);

            return shorter + reversedLonger + shorter;
        }
    }


    /*
     A sequence or a series, in mathematics, is a string of objects, like numbers, that follow a particular pattern. The individual elements in a sequence are called terms. A simple example is 3, 6, 9, 12, 15, 18, 21, ..., where the pattern is: "add 3 to the previous term".

    In this kata, we will be using a more complicated sequence: 0, 1, 3, 6, 10, 15, 21, 28, ... This sequence is generated with the pattern: "the nth term is the sum of numbers from 0 to n, inclusive".

    [ 0,  1,    3,      6,   ...]
      0  0+1  0+1+2  0+1+2+3
    Your Task
    Complete the function that takes an integer n and returns a list/array of length abs(n) + 1 of the arithmetic series explained above. Whenn < 0 return the sequence with negative terms.

    Examples
     5  -->  [0,  1,  3,  6,  10,  15]
    -5  -->  [0, -1, -3, -6, -10, -15]
     7  -->  [0,  1,  3,  6,  10,  15,  21,  28]
     */

    public class SequenceSum
    {
        public static int[] SumOfN(int n)
        {
            int absN = Math.Abs(n);
            int[] result = new int[absN + 1];
            int sum = 0;

            for (int i = 0; i <= absN; i++)
            {
                sum += i;
                result[i] = sum * (n < 0 ? -1 : 1);
            }

            return result;


            //return Enumerable.Range(0, n + 1).Select(x => x * (x + 1) / 2).ToArray();
        }
    }


    //Get ASCII value of a character.
    public static class KataGetASCII
    {
        public static int GetASCII(char c)
        {
            return (int)c;
        }
    }

    /*
     Write a function that takes an integer num (num >= 0) and inserts dashes ('-') between each two odd digits in num.

    Examples
    454793 ---> "4547-9-3"
         0 ---> "0"
         1 ---> "1"
    13579  ---> "1-3-5-7-9"
     86420 ---> "86420"
     */
    public class KataInsertDash
    {
        public static string InsertDash(int num)
        {
            var numStr = num.ToString();
            var result = new StringBuilder();

            for (int i = 0; i < numStr.Length; i++)
            {
                result.Append(numStr[i]);
                if (i < numStr.Length - 1 && (numStr[i] - '0') % 2 != 0 && (numStr[i + 1] - '0') % 2 != 0)
                {
                    result.Append('-');
                }
            }

            return result.ToString();
        }
    }


    /*
     You are given a list of unique integers arr, and two integers a and b. Your task is to find out whether or not a and b appear consecutively in arr, and return a boolean value (True if a and b are consecutive, False otherwise).

    It is guaranteed that a and b are both present in arr.
     */

    public static class KataConsecutive
    {
        public static bool Consecutive(int[] arr, int a, int b)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] == a && arr[i + 1] == b) || (arr[i] == b && arr[i + 1] == a))
                {
                    return true;
                }
            }
            return false;
        }
    }

    /*
     Write a function that returns the number of occurrences of an element in an array.

    Examples
    var sample = { 1, 0, 2, 2, 3 };
    NumberOfOccurrences(0, sample) == 1;
    NumberOfOccurrences(4, sample) == 0;
    NumberOfOccurrences(2, sample) == 2;
    NumberOfOccurrences(3, sample) == 1;
     */
    public class OccurrencesKata
    {
        public static int NumberOfOccurrences(int x, int[] xs)
        {
            int count = 0;
            foreach (int item in xs)
            {
                if (item == x)
                {
                    count++;
                }
            }
            return count;
        }

        /*
         public class OccurrencesKata
    {
        public static int NumberOfOccurrences(int x, int[] xs)
      {
        return xs.Count(el => el == x);
      }
    }
         */
    }



    /*
     Input:

    a string strng
    an array of strings arr
    Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):

    a boolean true if all rotations of strng are included in arr
    false otherwise
    Examples:
    contain_all_rots(
      "bsjq", ["bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"]) -> true

    contain_all_rots(
      "Ajylvpy", ["Ajylvpy", "ylvpyAj", "jylvpyA", "lvpyAjy", "pyAjylv", "vpyAjyl", "ipywee"]) -> false)
    Note:
    Though not correct in a mathematical sense

    we will consider that there are no rotations of strng == ""
    and for any array arr: contain_all_rots("", arr) --> true
     */

    public class Rotations
    {
        public static bool ContainAllRots(string strng, List<string> arr)
        {
            if (strng == "")
                return true;

            for (int i = 0; i < strng.Length; i++)
            {
                string rotation = strng.Substring(i) + strng.Substring(0, i);
                if (!arr.Contains(rotation))
                    return false;
            }
            return true;
        }

        /*
         public static bool ContainAllRots(string s, List<string> arr)
      {
        return !s.Where((c, i) => !arr.Contains((s + s).Substring(i, s.Length))).Any();
      }
         */
    }


    /*
     The accounts of the "Fat to Fit Club (FFC)" association are supervised by John as a volunteered accountant. The association is funded through financial donations from generous benefactors. John has a list of the first n donations: [14, 30, 5, 7, 9, 11, 15] He wants to know how much the next benefactor should give to the association so that the average of the first n + 1 donations should reach an average of 30. After doing the math he found 149. He thinks that he could have made a mistake.

    if dons = [14, 30, 5, 7, 9, 11, 15] then new_avg(dons, 30) --> 149

    Could you help him?

    Task
    The function new_avg(arr, navg) should return the expected donation (rounded up to the next integer) that will permit to reach the average navg.

    Should the last donation be a non positive number (<= 0) John wants us:

    to return:

    Nothing in Haskell, Elm
    None in F#, Ocaml, Rust, Scala
    -1 in C, D, Fortran, Nim, PowerShell, Go, Pascal, Prolog, Lua, Perl, Erlang
    or to throw an error (some examples for such a case):

    IllegalArgumentException() in Clojure, Java, Kotlin
    ArgumentException() in C#
    echo ERROR in Shell
    argument-error in Racket
    std::invalid_argument in C++
    ValueError in Python
    So, he will clearly see that his expectations are not great enough. In "Sample Tests" you can see what to return.

    Notes:
    all donations and navg are numbers (integers or floats), arr can be empty.
    See examples below and "Sample Tests" to see which return is to be done.
    new_avg([14, 30, 5, 7, 9, 11, 15], 92) should return 645
    new_avg([14, 30, 5, 7, 9, 11, 15], 2) 
    should raise an error (ValueError or invalid_argument or argument-error or DomainError or ... ) 
    or return `-1` or ERROR or Nothing or None depending on the language.
     */

    /*
       public static long NewAvg(double[] arr, double navg)
      {
        var don = (arr.Length + 1) * navg - arr.Sum();
        return don > 0 ? (long) Math.Ceiling(don) : throw new ArgumentException();
      }
     */

    public class NewAverage
    {
        public static long NewAvg(double[] arr, double navg)
        {
            double currentSum = arr.Sum();
            double requiredSum = navg * (arr.Length + 1);
            double nextDonation = requiredSum - currentSum;

            if (nextDonation <= 0)
            {
                throw new ArgumentException("Expected donation is not positive.");
            }

            return (long)Math.Ceiling(nextDonation);
        }
    }


    /*
     Complete the solution so that it takes the object (JavaScript/CoffeeScript) or hash (ruby) passed in and generates a human readable string from its key/value pairs.

    The format should be "KEY = VALUE". Each key/value pair should be separated by a comma except for the last pair.

    Example:

    Kata.StringifyDict(new Dictionary<char, int> {{'a', 1}, {'b', 2}}) => "a = 1,b = 2";
     */

    public static class KataStringifyDict
    {
        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            return string.Join(",", hash.Select(kv => $"{kv.Key} = {kv.Value}"));
        }
    }



    /*
     Every now and then people in the office moves teams or departments. Depending what people are doing with their time they can become more or less boring. Time to assess the current team.

    You will be provided with an object(staff) containing the staff names as keys, and the department they work in as values.

    Each department has a different boredom assessment score, as follows:

    accounts = 1
    finance = 2
    canteen = 10
    regulation = 3
    trading = 6
    change = 6
    IS = 8
    retail = 5
    cleaning = 4
    pissing about = 25

    Depending on the cumulative score of the team, return the appropriate sentiment:

    <=80: 'kill me now'
    < 100 & > 80: 'i can handle this'
    100 or over: 'party time!!'
     */


    /*
     public class Kata
    {
      public static string Boredom(Dictionary<string, string> staff)
      {
        var score = staff.Sum(x => x.Value switch
        {
            "accounts" => 1,
            "finance" => 2,
            "canteen" => 10,
            "regulation" => 3,
            "trading" => 6,
            "change" => 6,
            "IS" => 8,
            "retail" => 5,
            "cleaning" => 4,
            "pissing about" => 25,
            _ => 0
        });

        return score >= 100 ? "party time!!" : score <= 80 ? "kill me now" : "i can handle this";
      }
    }
     */
    public class KataBoredom
    {
        public static string Boredom(Dictionary<string, string> staff)
        {
            var boredomScores = new Dictionary<string, int>
        {
            { "accounts", 1 }, { "finance", 2 }, { "canteen", 10 }, { "regulation", 3 }, { "trading", 6 },
            { "change", 6 }, { "IS", 8 }, { "retail", 5 }, { "cleaning", 4 }, { "pissing about", 25 }
        };

            int totalScore = staff.Values.Sum(department => boredomScores.GetValueOrDefault(department, 0));

            return totalScore switch
            {
                <= 80 => "kill me now",
                < 100 => "i can handle this",
                _ => "party time!!"
            };
        }
    }

    /*
     Create a function that returns the average of an array of numbers ("scores"), rounded to the nearest whole number. You are not allowed to use any loops (including for, for/in, while, and do/while loops).

    The array will never be empty.
     */
    public class KataAverage
    {
        public static int Average(int[] scores)
        {
            return (int)Math.Round(scores.Average());
        }
    }


    /*
     In this kata, we will make a function to test whether a period is late.

    Our function will take three parameters:

    last - The Date object with the date of the last period

    today - The Date object with the date of the check

    cycleLength - Integer representing the length of the cycle in days

    Return true if the number of days passed from last to today is greater than cycleLength. Otherwise, return false.
     */
    public static class KataPeriodIsLate
    {
        public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength)
        {
            int daysPassed = (today - last).Days;
            return daysPassed > cycleLength;
        }
    }


    /*
     Complete the solution so that it returns a formatted string. The return value should equal "Value is VALUE" where value is a 5 digit padded number.

    Example:

    solution(5); // should return "Value is 00005"
     */

    public class PaddedNumbers
    {
        public static string Solution(int value)
        {
            string paddedValue = value.ToString("D5");
            return $"Value is {paddedValue}";
        }
    }


    /*
     You received a whatsup message from an unknown number. Could it be from that girl/boy with a foreign accent you met yesterday evening?

    Write a simple function to check if the string contains the word hallo in different languages.

    These are the languages of the possible people you met the night before:

    hello - english
    ciao - italian
    salut - french
    hallo - german
    hola - spanish
    ahoj - czech republic
    czesc - polish
    Notes

    you can assume the input is a string.
    to keep this a beginner exercise you don't need to check if the greeting is a subset of word (Hallowen can pass the test)
    function should be case insensitive to pass the tests
     */
    public static class GreetingValidator
    {
        public static bool Validate_hello(string greetings)
        {
            string lowerGreetings = greetings.ToLower();

            string[] greetingsList = { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };

            foreach (var greeting in greetingsList)
            {
                if (lowerGreetings.Contains(greeting))
                {
                    return true;
                }
            }
            return false;
        }
    }





    /*
    In this exercise, a string is passed to a method and a new string has to be returned with the first character of each word in the string.

    For example:

    "This Is A Test" ==> "TIAT"
    Strings will only contain letters and spaces, with exactly 1 space between words, and no leading/trailing spaces.
    */
    public static class StringHelper
    {
        public static string MakeString(string s)
        {
            return string.Concat(GetFirstCharacters(s));
        }

        private static IEnumerable<char> GetFirstCharacters(string s)
        {
            var words = s.Split(' ');

            return words.Select(word => word[0]);
        }

        //return string.Join("", s.Split(' ').Select(x => x[0]));
    }

    // Example usage
    // Console.WriteLine(StringHelper.MakeString("This Is A Test")); // Output: "TIAT"


    /*
     Create a public class called Cube without a constructor which gets one single private integer variable Side, a getter GetSide() and a setter SetSide(int num) method for this property. Actually, getter and setter methods are not the common way to write this code in C#. In the next kata of this series, we gonna refactor the code and make it a bit more professional...

    Notes:

    There's no need to check for negative values!
    initialise the side to 0.
     */

    public class Cube
    {
        private int side = 0;

        public int GetSide()
        {
            return side;
        }
        public void SetSide(int num)
        {
            side = num;
        }
    }


    /*
     * Write a function that removes every lone 9 that is inbetween 7s.

    "79712312" --> "7712312"
    "79797"    --> "777"
     */
    public static class StringHelper1
    {
        public static string SevenAteNine(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)

            {
                if (IsLoneNine(str, i))
                {
                    continue;
                }
                result.Append(str[i]);
            }
            return result.ToString();
        }
        private static bool IsLoneNine(string str, int index)
        {
            return str[index] == '9' && index > 0 && index < str.Length - 1 && str[index - 1] == '7' && str[index + 1] == '7';
        }

        /*
         public static string SevenAteNine(string str)
      {
        return Regex.Replace(str, @"(?<=7)9(?=7)", "");
      }
         */
    }

    /*
     The word i18n is a common abbreviation of internationalization in the developer community, used instead of typing the whole word and trying to spell it correctly. Similarly, a11y is an abbreviation of accessibility.

    Write a function that takes a string and turns any and all "words" (see below) within that string of length 4 or greater into an abbreviation, following these rules:

    A "word" is a sequence of alphabetical characters. By this definition, any other character like a space or hyphen (eg. "elephant-ride") will split up a series of letters into two words (eg. "elephant" and "ride").
    The abbreviated version of the word should have the first letter, then the number of removed characters, then the last letter (eg. "elephant ride" => "e6t r2e").
    Example
    abbreviate("elephant-rides are really fun!")
    //          ^^^^^^^^*^^^^^*^^^*^^^^^^*^^^*
    // words (^):   "elephant" "rides" "are" "really" "fun"
    //                123456     123     1     1234     1
    // ignore short words:               X              X

    // abbreviate:    "e6t"     "r3s"  "are"  "r4y"   "fun"
    // all non-word characters (*) remain in place
    //                     "-"      " "    " "     " "     "!"
    === "e6t-r3s are r4y fun!"
     */

    public static class AbbreviationHelper
    {
        public static string Abbreviate(string input)
        {
            StringBuilder result = new StringBuilder();

            int wordStartIndex = -1;

            for (int i = 0; i <= input.Length; i++)
            {
                if (IsLetterAt(input, i))
                {
                    wordStartIndex = wordStartIndex == -1 ? i : wordStartIndex;
                }
                else
                {
                    if (wordStartIndex != -1)
                    {
                        AppendWordOrAbbreviation(input, result, wordStartIndex, i);
                        wordStartIndex = -1;
                    }
                    if (i < input.Length)
                    { result.Append(input[i]); }
                }
            }

            return result.ToString();
        }
        private static bool IsLetterAt(string input, int index)
        {
            return index < input.Length && char.IsLetter(input[index]);
        }
        private static void AppendWordOrAbbreviation(string input, StringBuilder result, int start, int end)
        {
            int wordLength = end - start; if (wordLength > 3)
            {
                result.Append(input[start]);
                result.Append(wordLength - 2);
                result.Append(input[end - 1]);
            }
            else
            {
                result.Append(input, start, wordLength);
            }
        }
    }


    /*
     A number is a Special Number if it’s digits only consist 0, 1, 2, 3, 4 or 5

    Given a number determine if it special number or not .

    Warm-up (Highly recommended)
    Playing With Numbers Series
    Notes
    The number passed will be positive (N > 0) .

    All single-digit numbers within the interval [1:5] are considered as special number.

    Input >> Output Examples
    specialNumber(2) ==> return "Special!!"
    Explanation:
    It's a single-digit number within the interval [1:5] .

    specialNumber(9) ==> return "NOT!!"
    Explanation:
    Although, it's a single-digit number but Outside the interval [1:5] .

    specialNumber(23) ==> return "Special!!"
    Explanation:
    All the number's digits formed from the interval [0:5] digits .

    specialNumber(39) ==> return "NOT!!"
    Explanation:
    Although, there is a digit (3) Within the interval But the second digit is not (Must be ALL The Number's Digits ) .

    specialNumber(59) ==> return "NOT!!"
    Explanation:
    Although, there is a digit (5) Within the interval But the second digit is not (Must be ALL The Number's Digits ) .

    specialNumber(513) ==> return "Special!!"
    specialNumber(709) ==> return "NOT!!"
     */

    class KataSpecialNumber
    {
        public static string SpecialNumber(int number)
        {
            string numberStr = number.ToString();
            foreach (char digit in numberStr)
            {
                if (!"012345".Contains(digit))
                {
                    return "NOT!!";
                }
            }
            return "Special!!";

            //public static string SpecialNumber(int number) => Regex.IsMatch(number.ToString(), "[^0-5]") ? "NOT!!" : "Special!!";
        }
    }


    /*
     Build Tower
    Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

    For example, a tower with 3 floors looks like this:

    [
      "  *  ",
      " *** ", 
      "*****"
    ]
    And a tower with 6 floors looks like this:

    [
      "     *     ", 
      "    ***    ", 
      "   *****   ", 
      "  *******  ", 
      " ********* ", 
      "***********"
    ]

    //return Enumerable.Range(1, nFloors).Select(i => string.Format("{0}{1}{0}", i == nFloors ? "" : new string(' ', nFloors - i), new string('*', 2 * i - 1))).ToArray();
     */
    public class Kata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];
            int width = nFloors * 2 - 1; for (int i = 0; i < nFloors; i++)
            {
                int stars = i * 2 + 1; int spaces = (width - stars) / 2;
                tower[i] = new string(' ', spaces) + new string('*', stars) + new string(' ', spaces);
            }

            return tower;
        }
    }

    /*
     Define a method/function that removes from a given array of integers all the values contained in a second array.

    Examples (input -> output):
    * [1, 1, 2, 3, 1, 2, 3, 4], [1, 3] -> [2, 2, 4]
    * [1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8], [1, 3, 4, 2] -> [5, 6, 7, 8]
    * [8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2, 3], [2, 4, 3] -> [8, 7, 6, 5, 1]
     */
    public class KataRemoveRemoveRemove
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            HashSet<int> valuesSet = new HashSet<int>(valuesList);

            return integerList.Where(x => !valuesSet.Contains(x)).ToArray();
        }
    }

    /*

     Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

    Your task is to write a function maskify, which changes all but the last four characters into '#'.

    Examples (input --> output):
    "4556364607935616" --> "############5616"
         "64607935616" -->      "#######5616"
                   "1" -->                "1"
                    "" -->                 ""

    // "What was the name of your first pet?"
    "Skippy" --> "##ippy"
    "Nananananananananananananananana Batman!" --> "####################################man!"
     */

    public static class KataMaskify
    {

        public static string Maskify(string cc)
        {
            if (cc.Length <= 4)
            {
                return cc;
            }

            int maskedLength = cc.Length - 4;
            string masked = new string('#', maskedLength);
            string lastFour = cc.Substring(cc.Length - 4);
            return masked + lastFour;

        }
    }


    /*
     This Kata is intended as a small challenge for my students

    All Star Code Challenge #22

    Create a function that takes an integer argument of seconds and converts the value into a string describing how many hours and minutes comprise that many seconds.

    Any remaining seconds left over are ignored.

    Note:
    The string output needs to be in the specific form - "X hour(s) and X minute(s)"

    For example:

    3600 --> "1 hour(s) and 0 minute(s)"
    3601 --> "1 hour(s) and 0 minute(s)"
    3500 --> "0 hour(s) and 58 minute(s)"
    323500 --> "89 hour(s) and 51 minute(s)"
     */

    public static class KataExecute
    {
        public static double? Execute(double num1, char op, double num2)
        {
            return op switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' when num2 != 0 => num1 / num2,
                '/' => null,
                _ => throw new ArgumentException("Invalid operator"),
            };
        }



        public static class KataToTime
        {
            public static string ToTime(int seconds)
            {
                int hours = seconds / 3600;
                int minutes = (seconds % 3600) / 60;
                return $"{hours} hour(s) and {minutes} minute(s)";
            }
        }

        /*
         Write a function that returns the number of arguments it received.

        args_count() --> 0
        args_count('a') --> 1
        args_count('a', 'b') --> 2
         */

        public static class KataCountArgs
        {
            public static int CountArgs(params object[] args)
            {
                return args.Length;
            }
        }


        /*
         Your car is old, it breaks easily. The shock absorbers are gone and you think it can handle about 15 more bumps before it dies totally.

        Unfortunately for you, your drive is very bumpy! Given a string showing either flat road (_) or bumps (n). If you are able to reach home safely by encountering 15 bumps or less, return Woohoo!, otherwise return Car Dead
         */
        class KataBump
        {
            public static string Bump(string input)
            {
                int bumpCount = input.Count(c => c == 'n'); return bumpCount <= 15 ? "Woohoo!" : "Car Dead";
            }
        }

        /*
         Enjoying your holiday, you head out on a scuba diving trip! Disaster!! The boat has caught fire!! You will be provided a string that lists many boat related items. If any of these items are "Fire" you must spring into action. Change any instance of "Fire" into "~~". Then return the string. Go to work!
         */
        public class KataFireFight
        {
            public static string FireFight(string s)
            {
                return s.Replace("Fire", "~~");
            }
        }

        /*
         Implement a function that takes two numbers m and n and returns an array of the first m multiples of the real number n. Assume that m is a positive integer.

        Ex.

        (3, 5.0) --> [5.0, 10.0, 15.0]
         */

        public class KataMult
        {
            public static double[] Multiples(int m, double n)
            {
                return Enumerable.Range(1, m).Select(i => n * i).ToArray();
            }
        }

        /*
         Arrow style Functions
        Come here to practice the Arrow style functions Not much else to say good luck!
        Details
        You will be given an array of numbers which can be used using the String.fromCharCode() (JS), Tools.FromCharCode() (C#) method to convert the number to a character. It is recommended to map over the array of numbers and convert each number to the corresponding ascii character.

        Examples
        These are example of how to convert a number to an ascii Character:
        Javascript => String.fromCharCode(97) // a
        C# => Tools.FromCharCode(97) // a
         */

        public class KataArrowFunc
        {
            public static string ArrowFunc(int[] arr)
            {
                return new string(Array.ConvertAll(arr, Convert.ToChar));
            }
        }

        /*
         Given a string of words (x), you need to return an array of the words, sorted alphabetically by the final character in each.

        If two words have the same last letter, the returned array should show them in the order they appeared in the given string.

        All inputs will be valid.
         */

        public static class KataLast
        {
            public static string[] Last(string x)
            {
                return x.Split(' ').OrderBy(word => word.Last()).ToArray();
            }
        }


        /*
         Let us begin with an example:

        Take a number: 56789. Rotate left, you get 67895.

        Keep the first digit in place and rotate left the other digits: 68957.

        Keep the first two digits in place and rotate the other ones: 68579.

        Keep the first three digits and rotate left the rest: 68597. Now it is over since keeping the first four it remains only one digit which rotated is itself.

        You have the following sequence of numbers:

        56789 -> 67895 -> 68957 -> 68579 -> 68597

        and you must return the greatest: 68957.

        Task
        Write function max_rot(n) which given a positive integer n returns the maximum number you got doing rotations similar to the above example.

        So max_rot (or maxRot or ... depending on the language) is such as:

        max_rot(56789) should return 68957

        max_rot(38458215) should return 85821534
         */

        public class MaxRotate
        {

            public static long MaxRot(long n)
            {
                string numStr = n.ToString(); long maxVal = n;
                for (int i = 0; i < numStr.Length - 1; i++)
                {
                    numStr = numStr.Substring(0, i) + numStr.Substring(i + 1) + numStr[i];

                    long rotatedVal = long.Parse(numStr);

                    if (rotatedVal > maxVal) { maxVal = rotatedVal; }
                }

                return maxVal;
            }
        }

        /*
         Just a simple sorting usage. Create a function that returns the elements of the input-array / list sorted in lexicographical order.
         */
        public class KataSortMe
        {
            public static string[] SortMe(string[] names)
            {
                Array.Sort(names);
                return names;
            }
        }

        /*
         In this kata, your job is to return the two distinct highest values in a list. If there're less than 2 unique values, return as many of them, as possible.

        The result should also be ordered from highest to lowest.

        Examples:

        [4, 10, 10, 9]  =>  [10, 9]
        [1, 1, 1]  =>  [1]
        []  =>  []
         */

        public static class KataTwoHighest
        {
            public static int[] TwoHighest(int[] arr)
            {
                return arr.Distinct().OrderByDescending(x => x).Take(2).ToArray();
            }
        }

        /*
         You must implement a function that returns the difference between the largest and the smallest value in a given list / array (lst) received as the parameter.

        lst contains integers, that means it may contain some negative numbers
        if lst is empty or contains a single element, return 0
        lst is not sorted
        [1, 2, 3, 4]   //  returns 3 because 4 -   1  == 3
        [1, 2, 3, -4]  //  returns 7 because 3 - (-4) == 7
         */
        public class Kata
        {
            public static int MaxDiff(int[] lst)
            {
                if (lst == null || lst.Length < 2)
                {
                    return 0;
                }

                int max = lst.Max();
                int min = lst.Min();

                return max - min;
            }
        }

        /*
         The number n is Evil if it has an even number of 1's in its binary representation.
        The first few Evil numbers: 3, 5, 6, 9, 10, 12, 15, 17, 18, 20

        The number n is Odious if it has an odd number of 1's in its binary representation.
        The first few Odious numbers: 1, 2, 4, 7, 8, 11, 13, 14, 16, 19

        You have to write a function that determine if a number is Evil of Odious, function should return "It's Evil!" in case of evil number and "It's Odious!" in case of odious number.

        good luck :)
         */
        public class KataEvil
        {
            public static string Evil(int n)
            {
                int countOfOnes = Convert.ToString(n, 2).Count(c => c == '1');

                return countOfOnes % 2 == 0 ? "It's Evil!" : "It's Odious!";
            }
        }

        /*
         This kata is the first of a sequence of four about "Squared Strings".

        You are given a string of n lines, each substring being n characters long: For example:

        s = "abcd\nefgh\nijkl\nmnop"

        We will study some transformations of this square of strings.

        Vertical mirror: vert_mirror (or vertMirror or vert-mirror)
        vert_mirror(s) => "dcba\nhgfe\nlkji\nponm"
        Horizontal mirror: hor_mirror (or horMirror or hor-mirror)
         hor_mirror(s) => "mnop\nijkl\nefgh\nabcd"
        or printed:

        vertical mirror   |horizontal mirror   
        abcd --> dcba     |abcd --> mnop 
        efgh     hgfe     |efgh     ijkl 
        ijkl     lkji     |ijkl     efgh 
        mnop     ponm     |mnop     abcd 
        Task:
        Write these two functions
        and

        high-order function oper(fct, s) where

        fct is the function of one variable f to apply to the string s (fct will be one of vertMirror, horMirror)

        Examples:
        s = "abcd\nefgh\nijkl\nmnop"
        oper(vert_mirror, s) => "dcba\nhgfe\nlkji\nponm"
        oper(hor_mirror, s) => "mnop\nijkl\nefgh\nabcd"
        Note:
        The form of the parameter fct in oper changes according to the language. You can see each form according to the language in "Sample Tests".
         */

        public class Opstrings
        {
            public static string VertMirror(string strng)
            {
                return string.Join("\n", strng.Split('\n').Select(s => new string(s.Reverse().ToArray())));
            }

            public static string HorMirror(string strng)
            {
                return string.Join("\n", strng.Split('\n').Reverse());
            }

            public static string Oper(Func<string, string> fct, string s)
            {
                return fct(s);
            }
        }

        /*
         A stream of data is received and needs to be reversed.

        Each segment is 8 bits long, meaning the order of these segments needs to be reversed, for example:

        11111111  00000000  00001111  10101010
         (byte1)   (byte2)   (byte3)   (byte4)
        should become:

        10101010  00001111  00000000  11111111
         (byte4)   (byte3)   (byte2)   (byte1)
        The total number of bits will always be a multiple of 8.

        The data is given in an array as such:

        [1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0]
        Note: In the C and NASM languages you are given the third parameter which is the number of segment blocks.
         */



        public class KataDataReverse
        {
            public static int[] DataReverse(int[] data)
            {
                int segmentLength = 8;
                int[] reversedData = new int[data.Length];

                for (int i = 0; i < data.Length; i += segmentLength)
                {
                    Array.Copy(data, data.Length - segmentLength - i, reversedData, i, segmentLength);
                }

                return reversedData;

                /*
                 public static int[] DataReverse(int[] data) =>
               Enumerable.Range(0,data.Length/8)
                 .Select(i => data
                   .Skip(i*8)
                   .Take(8))
                 .Reverse()
                 .SelectMany(i => i)
                 .ToArray();
                 */

            }

            /*
             Given a string "abc" and assuming that each letter in the string has a value equal to its position in the alphabet, our string will have a value of 1 + 2 + 3 = 6. This means that: a = 1, b = 2, c = 3 ... z = 26.

            You will be given a list of strings and your task will be to return the values of the strings as explained above multiplied by the position of that string in the list. For our purpose, position begins with 1.

            ["abc", "abc abc"] should return [6, 24] because of [ 6 * 1, 12 * 2 ]. Note how spaces are ignored.

            "abc" has a value of 6, while "abc abc" has a value of 12. Now, the value at position 1 is multiplied by 1 while the value at position 2 is multiplied by 2.

            Input will only contain lowercase characters and spaces.

            Good luck!
             */

            public class KataWordValue
            {
                public static int[] WordValue(string[] a)
                {
                    int[] result = new int[a.Length];

                    for (int i = 0; i < a.Length; i++)
                    {
                        int value = a[i]
                            .Replace(" ", "")
                            .Sum(c => c - 'a' + 1);

                        result[i] = value * (i + 1);
                    }
                    return result;
                }
            }

            /*
             You have stumbled across the divine pleasure that is owning a dog and a garden. Now time to pick up all the cr@p! :D

            Given a 2D array to represent your garden, you must find and collect all of the dog cr@p - represented by '@'.

            You will also be given the number of bags you have access to (bags), and the capactity of a bag (cap). If there are no bags then you can't pick anything up, so you can ignore cap.

            You need to find out if you have enough capacity to collect all the cr@p and make your garden clean again.

            If you do, return 'Clean', else return 'Cr@p'.

            Watch out though - if your dog is out there ('D'), he gets very touchy about being watched. If he is there you need to return 'Dog!!'.

            For example:

            bags = 2
            cap = 2
            x (or garden) =
            [[ _ , _ , _ , _ , _ , _ ],
             [ _ , _ , _ , _ , @ , _ ],
             [ @ , _ , _ , _ , _ , _ ]]
            returns 'Clean'
             */

            public class KataCrap
            {
                public static string Crap(char[,] x, int bags, int cap)
                {

                    int totalCapacity = bags * cap;
                    int crapCount = 0;

                    for (int i = 0; i < x.GetLength(0); i++)
                    {
                        for (int j = 0; j < x.GetLength(1); j++)
                        {
                            if (x[i, j] == 'D')
                            {
                                return "Dog!!";
                            }
                            else if (x[i, j] == '@')
                            {
                                crapCount++;
                            }
                        }
                    }

                    return crapCount <= totalCapacity ? "Clean" : "Cr@p";
                }
            }

            /*
             Your task is to write a function toLeetSpeak that converts a regular english sentence to Leetspeak.

            More about LeetSpeak You can read at wiki -> https://en.wikipedia.org/wiki/Leet

            Consider only uppercase letters (no lowercase letters, no numbers) and spaces.

            For example:

            toLeetSpeak("LEET") returns "1337"
            In this kata we use a simple LeetSpeak dialect. Use this alphabet:

            {
              A : '@',
              B : '8',
              C : '(',
              D : 'D',
              E : '3',
              F : 'F',
              G : '6',
              H : '#',
              I : '!',
              J : 'J',
              K : 'K',
              L : '1',
              M : 'M',
              N : 'N',
              O : '0',
              P : 'P',
              Q : 'Q',
              R : 'R',
              S : '$',
              T : '7',
              U : 'U',
              V : 'V',
              W : 'W',
              X : 'X',
              Y : 'Y',
              Z : '2'
            }
             */

            public class KataToLeetSpeak
            {
                public static string ToLeetSpeak(string str)
                {
                    var leetAlphabet = new Dictionary<char, char>
                    {
                        ['A'] = '@',
                        ['B'] = '8',
                        ['C'] = '(',
                        ['D'] = 'D',
                        ['E'] = '3',
                        ['F'] = 'F',
                        ['G'] = '6',
                        ['H'] = '#',
                        ['I'] = '!',
                        ['J'] = 'J',
                        ['K'] = 'K',
                        ['L'] = '1',
                        ['M'] = 'M',
                        ['N'] = 'N',
                        ['O'] = '0',
                        ['P'] = 'P',
                        ['Q'] = 'Q',
                        ['R'] = 'R',
                        ['S'] = '$',
                        ['T'] = '7',
                        ['U'] = 'U',
                        ['V'] = 'V',
                        ['W'] = 'W',
                        ['X'] = 'X',
                        ['Y'] = 'Y',
                        ['Z'] = '2'
                    };

                    return string.Concat(str.Select(c => leetAlphabet.ContainsKey(c) ? leetAlphabet[c] : c));
                }
            }


            /*
             Task
            You've just moved into a perfectly straight street with exactly n identical houses on either side of the road. Naturally, you would like to find out the house number of the people on the other side of the street. The street looks something like this:

            Street
            1|   |6
            3|   |4
            5|   |2
              you
            Evens increase on the right; odds decrease on the left. House numbers start at 1 and increase without gaps. When n = 3, 1 is opposite 6, 3 opposite 4, and 5 opposite 2.

            Example (address, n --> output)
            Given your house number address and length of street n, give the house number on the opposite side of the street.

            1, 3 --> 6
            3, 3 --> 4
            2, 3 --> 5
            3, 5 --> 8
            Note about errors
            If you are timing out, running out of memory, or get any kind of "error", read on. Both n and address could get upto 500 billion with over 200 random tests. If you try to store the addresses of 500 billion houses in a list then you will run out of memory and the tests will crash. This is not a kata problem so please don't post an issue. Similarly if the tests don't complete within 12 seconds then you also fail.

            To solve this, you need to think of a way to do the kata without making massive lists or huge for loops. Read the discourse for some inspiration :)
             */
            public class CodeWars
            {
                public static long OverTheRoad(long address, long n)
                {
                    return 2 * n + 1 - address;

                }
            }

            /*
             Scenario
            Now that the competition gets tough it will Sort out the men from the boys .

            Men are the Even numbers and Boys are the odd!alt!alt

            Task
            Given an array/list [] of n integers , Separate The even numbers from the odds , or Separate the men from the boys!alt!alt

            Notes
            Return an array/list where Even numbers come first then odds

            Since , Men are stronger than Boys , Then Even numbers in ascending order While odds in descending .

            Array/list size is at least 4 .

            Array/list numbers could be a mixture of positives , negatives .

            Have no fear , It is guaranteed that no Zeroes will exists .!alt

            Repetition of numbers in the array/list could occur , So (duplications are not included when separating).

            Input >> Output Examples:
            menFromBoys ({7, 3 , 14 , 17}) ==> return ({14, 17, 7, 3}) 
            Explanation:
            Since , { 14 } is the even number here , So it came first , then the odds in descending order {17 , 7 , 3} .

            menFromBoys ({-94, -99 , -100 , -99 , -96 , -99 }) ==> return ({-100 , -96 , -94 , -99})
            Explanation:
            Since , { -100, -96 , -94 } is the even numbers here , So it came first in *ascending order *, then the odds in descending order { -99 }

            Since , (Duplications are not included when separating) , then you can see only one (-99) was appeared in the final array/list .

            menFromBoys ({49 , 818 , -282 , 900 , 928 , 281 , -282 , -1 }) ==> return ({-282 , 818 , 900 , 928 , 281 , 49 , -1})
            Explanation:
            Since , {-282 , 818 , 900 , 928 } is the even numbers here , So it came first in ascending order , then the odds in descending order { 281 , 49 , -1 }

            Since , (Duplications are not included when separating) , then you can see only one (-282) was appeared in the final array/list .
             */

            public class KataMenFromBoys
            {
                public static int[] MenFromBoys(int[] a)
                {
                    var evens = a.Distinct().Where(x => x % 2 == 0).OrderBy(x => x);
                    var odds = a.Distinct().Where(x => x % 2 != 0).OrderByDescending(x => x);
                    return evens.Concat(odds).ToArray();
                }
            }

            /*
             We need to write some code to return the original price of a product, the return type must be of type decimal and the number must be rounded to two decimal places.

            We will be given the sale price (discounted price), and the sale percentage, our job is to figure out the original price.

            For example:
            Given an item at $75 sale price after applying a 25% discount, the function should return the original price of that item before applying the sale percentage, which is ($100.00) of course, rounded to two decimal places.

            DiscoverOriginalPrice(75, 25) => 100.00M where 75 is the sale price (discounted price), 25 is the sale percentage and 100 is the original price
             */

            public static class KataDiscoverOriginalPrice
            {
                public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
                {
                    decimal originalPrice = discountedPrice / (1 - salePercentage / 100);
                    return Math.Round(originalPrice, 2);
                }
            }

            /*
             Write a class Block that creates a block (Duh..)

            Requirements
            The constructor should take an array as an argument, this will contain 3 integers of the form [width, length, height] from which the Block should be created.

            Define these methods:

            `GetWidth()` return the width of the `Block`

            `GetLength()` return the length of the `Block`

            `GetHeight()` return the height of the `Block`

            `GetVolume()` return the volume of the `Block`

            `GetSurfaceArea()` return the surface area of the `Block`
            Examples
                Block b = new Block(new int[]{2,4,6}) -> creates a `Block` object with a width of `2` a length of `4` and a height of `6`
                b.GetWidth() // -> 2

                b.GetLength() // -> 4

                b.GetHeight() // -> 6

                b.GetVolume() // -> 48

                b.GetSurfaceArea() // -> 88
            Note: no error checking is needed

            Any feedback would be much appreciated
             */
            class Block
            {

                private int width;
                private int length;
                private int height;

                public Block(int[] dimensions)
                {
                    if (dimensions.Length != 3)
                    {
                        throw new ArgumentException("Array must contain exactly 3 integers.");
                    }

                    this.width = dimensions[0];
                    this.length = dimensions[1];
                    this.height = dimensions[2];
                }

                public int GetWidth() => this.width;
                public int GetLength() => this.length;
                public int GetHeight() => this.height;

                public int GetVolume() => this.width * this.length * this.height;

                public int GetSurfaceArea() => 2 * (this.width * this.length + this.length * this.height + this.height * this.width);
            }


            /*
             Find the difference between the square of the sum of the first n natural numbers (1 <= n <= 100) and the sum of their squares.

            Example
            For example, when n = 10:

            The square of the sum of the numbers is:

            (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10)² = 55² = 3025
            The sum of the squares of the numbers is:

            1² + 2² + 3² + 4² + 5² + 6² + 7² + 8² + 9² + 10² = 385
            Hence the difference between square of the sum of the first ten natural numbers and the sum of the squares of those numbers is: 3025 - 385 = 2640
             */
            public class KataDifferenceOfSquares
            {
                public static int DifferenceOfSquares(int n)
                {
                    int sumOfNumbers = n * (n + 1) / 2;
                    int sumOfSquares = n * (n + 1) * (2 * n + 1) / 6;

                    int squareOfSum = sumOfNumbers * sumOfNumbers;

                    return squareOfSum - sumOfSquares;

                    //return n * (n + 1) * (3 * n * n - n - 2) / 12;
                }
            }

            /*
             Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

            For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)

            Example #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)

            Note: The function accepts an integer and returns an integer.

            Happy Coding!
             */

            public class KataSquareDigits
            {
                public static int SquareDigits(int n)
                {
                    string result = string.Concat(n.ToString().Select(digit => (int)Math.Pow(digit - '0', 2)));
                    return int.Parse(result);
                }
            }


            /*Friday 13th or Black Friday is considered as unlucky day. Calculate how many unlucky days are in the given year.

            Find the number of Friday 13th in the given year.

            Input: Year in Gregorian calendar as integer.

            Output: Number of Black Fridays in the year as an integer.

            Examples:

            unluckyDays(2015) == 3
            unluckyDays(1986) == 1*/

            public class KataUnluckyDays
            {
                public static int UnluckyDays(int year)
                {
                    return Enumerable.Range(1, 12)
                        .Count(month => new DateTime(year, month, 13).DayOfWeek == DayOfWeek.Friday);
                }
            }

            /*
             Write a function

            Vowel2Index(string s)
            that takes in a string and replaces all the vowels [a,e,i,o,u] with their respective positions within that string.
            E.g:

            Kata.Vowel2Index("this is my string") == "th3s 6s my str15ng"
            Kata.Vowel2Index("Codewars is the best site in the world") == "C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld"
            Your function should be case insensitive to the vowels.
             */

            public class KataVowel2Index
            {
                public static string Vowel2Index(string str)
                {
                    string vowels = "aeiouAEIOU";
                    var result = new System.Text.StringBuilder();

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (vowels.IndexOf(str[i]) >= 0)
                        {
                            result.Append(i + 1);
                        }
                        else
                        {
                            result.Append(str[i]);
                        }
                    }

                    return result.ToString();

                    /*public static string Vowel2Index(string str)
                    {
                        return Regex.Replace(str, "[aeiou]", x => (x.Index + 1).ToString());
                    }*/
                }
            }

            /*
             Definition
            Jumping number is the number that All adjacent digits in it differ by 1.

            Task
            Given a number, Find if it is Jumping or not .

            Warm-up (Highly recommended)
            Playing With Numbers Series
            Notes
            Number passed is always Positive .

            Return the result as String .

            The difference between ‘9’ and ‘0’ is not considered as 1 .

            All single digit numbers are considered as Jumping numbers.

            Input >> Output Examples
            jumpingNumber(9) ==> return "Jumping!!"
            Explanation:
            It's single-digit number
            jumpingNumber(79) ==> return "Not!!"
            Explanation:
            Adjacent digits don't differ by 1
            jumpingNumber(23) ==> return "Jumping!!"
            Explanation:
            Adjacent digits differ by 1
            jumpingNumber(556847) ==> return "Not!!"
            Explanation:
            Adjacent digits don't differ by 1
            jumpingNumber(4343456) ==> return "Jumping!!"
            Explanation:
            Adjacent digits differ by 1
            jumpingNumber(89098) ==> return "Not!!"
            Explanation:
            Adjacent digits don't differ by 1
            jumpingNumber(32) ==> return "Jumping!!"
            Explanation:
            Adjacent digits differ by 1
             */

            /*
             public static string JumpingNumber(int n)
                {
                    return n < 10 ? "Jumping!!" : Math.Abs(n%10 - (n/10)%10) != 1 ? "Not!!" : JumpingNumber(n/10);
                }
             */

            public class KataJumpingNumber
            {
                public static string JumpingNumber(int number)
                {
                    string numStr = number.ToString();

                    if (numStr.Length == 1) return "Jumping!!";

                    for (int i = 0; i < numStr.Length - 1; i++)
                    {
                        if (Math.Abs(numStr[i] - numStr[i + 1]) != 1) return "Not!!";
                    }

                    return "Jumping!!";
                }
            }

            /*
             To complete this Kata you need to make a function multiplyAll/multiply_all which takes an array of integers as an argument. This function must return another function, which takes a single integer as an argument and returns a new array.

            The returned array should consist of each of the elements from the first array multiplied by the integer.

            Example:

            multiplyAll([1, 2, 3])(2) = [2, 4, 6];
            You must not mutate the original array.

            Here's a nice Youtube video about currying, which might help you if this is new to you.
             */

            public static class KataMultiplyAll
            {
                public static Func<int, int[]> MultiplyAll(int[] array)
                {
                    return multiplier => array.Select(num => num * multiplier).ToArray();
                }
            }


            /*
             Task
            Given an array/list [] of integers , Construct a product array Of same size Such That prod[i] is equal to The Product of all the elements of Arr[] except Arr[i].

            Notes
            Array/list size is at least 2 .

            Array/list's numbers Will be only Positives

            Repetition of numbers in the array/list could occur.

            Input >> Output Examples
            productArray ({12,20}) ==>  return {20,12}
            Explanation:
            The first element in prod [] array 20 is the product of all array's elements except the first element

            The second element 12 is the product of all array's elements except the second element .

            productArray ({1,5,2}) ==> return {10,2,5}
            Explanation:
            The first element 10 is the product of all array's elements except the first element 1

            The second element 2 is the product of all array's elements except the second element 5

            The Third element 5 is the product of all array's elements except the Third element 2.

            productArray ({10,3,5,6,2}) return ==> {180,600,360,300,900}
            Explanation:
            The first element 180 is the product of all array's elements except the first element 10

            The second element 600 is the product of all array's elements except the second element 3

            The Third element 360 is the product of all array's elements except the third element 5

            The Fourth element 300 is the product of all array's elements except the fourth element 6

            Finally ,The Fifth element 900 is the product of all array's elements except the fifth element 2
             */

            class KataProductArray
            {
                public static int[] ProductArray(int[] array)
                {
                    int n = array.Length;
                    int[] result = new int[n];

                    int leftProduct = 1;
                    for (int i = 0; i < n; i++)
                    {
                        result[i] = leftProduct;
                        leftProduct *= array[i];
                    }

                    int rightProduct = 1;
                    for (int i = n - 1; i >= 0; i--)
                    {
                        result[i] *= rightProduct;
                        rightProduct *= array[i];
                    }

                    return result;
                }
            }


            /*
             You will be given a string (x) featuring a cat 'C' and a mouse 'm'. The rest of the string will be made up of '.'.

            You need to find out if the cat can catch the mouse from it's current position. The cat can jump over three characters. So:

            C.....m returns 'Escaped!' <-- more than three characters between

            C...m returns 'Caught!' <-- as there are three characters between the two, the cat can jump.
             */

            public class KataCatMouse
            {
                public static string CatMouse(string x)
                {
                    int catIndex = x.IndexOf('C');
                    int mouseIndex = x.IndexOf('m');

                    if (Math.Abs(mouseIndex - catIndex) <= 4)
                    {
                        return "Caught!";
                    }
                    else
                    {
                        return "Escaped!";
                    }
                }
            }

            /*
             The longest street in the world, MAX_STREET, is crossed by many other streets and driven by many drivers. Determine how many streets each driver crosses.

            Inputs
            (1) A list (or array, depending on language) of streets that intersect MAX_STREET. (2) A list (or array, depending on language) of drivers. Each driver is represented by a pair of streets. The first element of the pair is the street where they enter MAX_STREET; the second is the street they exit. The driver crosses all the streets between those two streets.

            Output
            A list (or array, depending on language) showing how many streets each driver crosses.

            Example
            CountStreets(new string[] {"first", "second", "third", "fourth", "fifth", "sixth", "seventh"},
                          new string[] {new string[] {"first", "second"}, new string[] {"second", "seventh"}, new string[] {"sixth", "fourth"}}) should return new string[] {0,4,1}.

            Details:
            (1) Each street name is a non-empty word of no more than 10 letters. There are no duplicate street names.

            (2) The entry and exit streets for each driver are distinct. They are guaranteed to come from the list of streets.

            (3) The number of streets n satisfies 2 ≤ n ≤ 105. The number of drivers d satisfies 1 ≤ d ≤ 105. So efficiency is important.

            Source: International Collegiate Programming Contest, North Central North American Regional, 2022
             */
            public class HowManyStreets
            {
                public static int[] CountStreets(string[] streets, string[][] drivers)
                {
                    var streetIndices = new Dictionary<string, int>();
                    for (int i = 0; i < streets.Length; i++)
                    {
                        streetIndices[streets[i]] = i;
                    }

                    var result = new int[drivers.Length];

                    for (int i = 0; i < drivers.Length; i++)
                    {
                        int entryIndex = streetIndices[drivers[i][0]];
                        int exitIndex = streetIndices[drivers[i][1]];
                        result[i] = Math.Abs(exitIndex - entryIndex) - 1;
                    }

                    return result;
                }
            }


            /*
             You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.

            The returned value must be a string, and have "***" between each of its letters.

            You should not remove or add elements from/to the array.
             */

            public class KataTwoSort
            {
                public static string TwoSort(string[] s)
                {
                    Array.Sort(s, StringComparer.Ordinal);
                    string first = s[0];
                    return string.Join("***", first.ToCharArray());
                }
            }


            /*
             Write a function to get the first element(s) of a sequence. Passing a parameter n (default=1) will return the first n element(s) of the sequence.

            If n == 0 return an empty sequence []

            Examples
            var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
            Kata.TakeFirstElements(arr); //=> new object[] { 'a' }
            Kata.TakeFirstElements(arr, 2);// => new object[] { 'a', 'b' }
            Kata.TakeFirstElements(arr, 3); //=> new object[] { 'a', 'b', 'c' }
            Kata.TakeFirstElements(arr, 0); //=> new object[] { }
             */

            public class KataTakeFirstElements
            {
                public static object[] TakeFirstElements(object[] array, int n = 1)
                {
                    if (n == 0)
                    {
                        return new object[0];
                    }

                    if (n > array.Length)
                    {
                        n = array.Length;
                    }

                    object[] result = new object[n];
                    Array.Copy(array, result, n);
                    return result;
                }
            }

            /*
             Given an array with exactly 5 strings "a", "b" or "c" (chars in Java, characters in Fortran, Chars in Haskell), check if the array contains three and two of the same values.

            Examples
            ["a", "a", "a", "b", "b"] ==> true  // 3x "a" and 2x "b"
            ["a", "b", "c", "b", "c"] ==> false // 1x "a", 2x "b" and 2x "c"
            ["a", "a", "a", "a", "a"] ==> false // 5x "a"
             */

            public class KataCheckThreeAndTwo
            {
                public static bool CheckThreeAndTwo(string[] array)
                {
                    var counts = array.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
                    return counts.Values.Contains(3) && counts.Values.Contains(2);
                }
            }

            /*
             Task
            Given an array/list [] of n integers , find maximum triplet sum in the array Without duplications .

            Notes :
            Array/list size is at least 3 .

            Array/list numbers could be a mixture of positives , negatives and zeros .

            Repetition of numbers in the array/list could occur , So (duplications are not included when summing).

            Input >> Output Examples
            1- maxTriSum ({3,2,6,8,2,3}) ==> return (17)
            Explanation:
            As the triplet that maximize the sum {6,8,3} in order , their sum is (17)

            Note : duplications are not included when summing , (i.e) the numbers added only once .

            2- maxTriSum ({2,1,8,0,6,4,8,6,2,4}) ==> return (18)
            Explanation:
            As the triplet that maximize the sum {8, 6, 4} in order , their sum is (18) ,

            Note : duplications are not included when summing , (i.e) the numbers added only once .

            3- maxTriSum ({-7,12,-7,29,-5,0,-7,0,0,29}) ==> return (41)
            Explanation:
            As the triplet that maximize the sum {12 , 29 , 0} in order , their sum is (41) ,

            Note : duplications are not included when summing , (i.e) the numbers added only once .
             */

            public class KataMaxTriSum
            {
                public static int MaxTriSum(int[] a)
                {
                    int[] distinctSortedArray = a.Distinct().OrderByDescending(num => num).ToArray();
                    int maxTripletSum = distinctSortedArray.Take(3).Sum();

                    return maxTripletSum;
                }
            }

            /*
             Happy Holidays fellow Code Warriors!
            Santa's senior gift organizer Elf developed a way to represent up to 26 gifts by assigning a unique alphabetical character to each gift. After each gift was assigned a character, the gift organizer Elf then joined the characters to form the gift ordering code.

            Santa asked his organizer to order the characters in alphabetical order, but the Elf fell asleep from consuming too much hot chocolate and candy canes! Can you help him out?

            Sort the Gift Code
            Write a function called sortGiftCode/sort_gift_code/SortGiftCode that accepts a string containing up to 26 unique alphabetical characters, and returns a string containing the same characters in alphabetical order.

            Examples (Input -- => Output):
            "abcdef"                      -- => "abcdef"
            "pqksuvy"                     -- => "kpqsuvy"
            "zyxwvutsrqponmlkjihgfedcba"  -- => "abcdefghijklmnopqrstuvwxyz"
             */

            public class KataSortGiftCode
            {
                public static string SortGiftCode(string code)
                {
                    char[] characters = code.ToCharArray();
                    Array.Sort(characters);
                    return new string(characters);
                }
            }

            /*
             Given a string s, write a method (function) that will return true if its a valid single integer or floating number or false if its not.

            Valid examples, should return true:

            isDigit("3")
            isDigit("  3  ")
            isDigit("-3.23")
            should return false:

            isDigit("3-4")
            isDigit("  3   5")
            isDigit("3 5")
            isDigit("zero")
             */

            public class CodeWarsIsDigit
            {
                public static bool IsDigit(string s)
                {
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        return false;
                    }

                    s = s.Trim();

                    double number;
                    return double.TryParse(s, out number);
                }
            }


            /*
             Your task in this kata is to implement a function that calculates the sum of the integers inside a string. For example, in the string "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog", the sum of the integers is 3635.

            Note: only positive integers will be tested.
             */

            public class KataSumOfIntegersInString
            {
                public static int SumOfIntegersInString(string s)
                {
                    var matches = Regex.Matches(s, @"\d+");
                    int sum = 0;

                    foreach (Match match in matches)
                    {
                        sum += int.Parse(match.Value);
                    }

                    return sum;
                }
            }

            /*
             Description:
            Remove n exclamation marks in the sentence from left to right. n is positive integer.

            Examples
            remove("Hi!",1) === "Hi"
            remove("Hi!",100) === "Hi"
            remove("Hi!!!",1) === "Hi!!"
            remove("Hi!!!",100) === "Hi"
            remove("!Hi",1) === "Hi"
            remove("!Hi!",1) === "Hi!"
            remove("!Hi!",100) === "Hi"
            remove("!!!Hi !!hi!!! !hi",1) === "!!Hi !!hi!!! !hi"
            remove("!!!Hi !!hi!!! !hi",3) === "Hi !!hi!!! !hi"
            remove("!!!Hi !!hi!!! !hi",5) === "Hi hi!!! !hi"
            remove("!!!Hi !!hi!!! !hi",100) === "Hi hi hi"
             */

            public class KataRemove
            {
                public static string Remove(string s, int n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        int index = s.IndexOf('!');
                        if (index == -1)
                        {
                            break;
                        }
                        s = s.Remove(index, 1);
                    }
                    return s;

                }
            }


            /*
            Your Task
            Given an array of Boolean values and a logical operator, return a Boolean result based on sequentially applying the operator to the values in the array.

            Examples
            booleans = [True, True, False], operator = "AND"
            True AND True -> True
            True AND False -> False
            return False
            booleans = [True, True, False], operator = "OR"
            True OR True -> True
            True OR False -> True
            return True
            booleans = [True, True, False], operator = "XOR"
            True XOR True -> False
            False XOR False -> False
            return False
            Input
            an array of Boolean values (1 <= array_length <= 50)
            a string specifying a logical operator: "AND", "OR", "XOR"
            */

            public class KataLogicalCalc
            {
                public static bool LogicalCalc(bool[] array, string op)
                {
                    bool result = array[0];

                    for (int i = 1; i < array.Length; i++)
                    {
                        switch (op)
                        {
                            case "AND":
                                result = result && array[i];
                                break;
                            case "OR":
                                result = result || array[i];
                                break;
                            case "XOR":
                                result = result ^ array[i];
                                break;
                        }
                    }

                    return result;
                }
            }

            /*
             Given a point in a Euclidean plane (x and y), return the quadrant the point exists in: 1, 2, 3 or 4 (integer). x and y are non-zero integers, therefore the given point never lies on the axes.

            Examples
            (1, 2)     => 1
            (3, 5)     => 1
            (-10, 100) => 2
            (-1, -9)   => 3
            (19, -56)  => 4
            Reference
            QuadrantsQuadrants
            There are four quadrants:

            First quadrant, the quadrant in the top-right, contains all points with positive X and Y
            Second quadrant, the quadrant in the top-left, contains all points with negative X, but positive Y
            Third quadrant, the quadrant in the bottom-left, contains all points with negative X and Y
            Fourth quadrant, the quadrant in the bottom-right, contains all points with positive X, but negative Y
            More on quadrants: Quadrant (plane geometry) - Wikipedia
             */

            public static class KataQuadrant
            {
                public static int Quadrant(int x, int y)
                {
                    if (x > 0 && y > 0)
                        return 1;
                    else if (x < 0 && y > 0)
                        return 2;
                    else if (x < 0 && y < 0)
                        return 3;
                    else
                        return 4;
                }
            }

            /*
             Given an array of numbers (in string format), you must return a string. The numbers correspond to the letters of the alphabet in reverse order: a=26, z=1 etc. You should also account for '!', '?' and ' ' that are represented by '27', '28' and '29' respectively.

            All inputs will be valid.
             */
            public class KataSwitcher
            {
                public static string Switcher(string[] x)
                {
                    var dictionary = new Dictionary<string, char>
                    {
                        ["1"] = 'z',
                        ["2"] = 'y',
                        ["3"] = 'x',
                        ["4"] = 'w',
                        ["5"] = 'v',
                        ["6"] = 'u',
                        ["7"] = 't',
                        ["8"] = 's',
                        ["9"] = 'r',
                        ["10"] = 'q',
                        ["11"] = 'p',
                        ["12"] = 'o',
                        ["13"] = 'n',
                        ["14"] = 'm',
                        ["15"] = 'l',
                        ["16"] = 'k',
                        ["17"] = 'j',
                        ["18"] = 'i',
                        ["19"] = 'h',
                        ["20"] = 'g',
                        ["21"] = 'f',
                        ["22"] = 'e',
                        ["23"] = 'd',
                        ["24"] = 'c',
                        ["25"] = 'b',
                        ["26"] = 'a',
                        ["27"] = '!',
                        ["28"] = '?',
                        ["29"] = ' '
                    };

                    return new string(x.Select(num => dictionary[num]).ToArray());

                    /*
                     public static string Switcher(string[] x)
                {
                    var alphabet = "zyxwvutsrqponmlkjihgfedcba!? ";
                    var res = string.Empty;
                    foreach (var a in x)
                    {
                        res += alphabet[int.Parse(a)-1];
                    }

                    return res;
                }
                     */
                }
            }

            /*
             The medians of a triangle are the segments that unit the vertices with the midpoint of their opposite sides. The three medians of a triangle intersect at the same point, called the barycenter or the centroid. Given a triangle, defined by the cartesian coordinates of its vertices we need to localize its barycenter or centroid.

            The function bar_triang() or barTriang or bar-triang, receives the coordinates of the three vertices A, B and C  as three different arguments and outputs the coordinates of the barycenter O in an array [xO, yO]

            This is how our asked function should work: the result of the coordinates should be expressed up to four decimals, (rounded result).

            You know that the coordinates of the barycenter are given by the following formulas.

            source: imgur.com

            For additional information about this important point of a triangle see at: (https://en.wikipedia.org/wiki/Centroid)

            Let's see some cases:

            bar_triang([4, 6], [12, 4], [10, 10]) ------> [8.6667, 6.6667]

            bar_triang([4, 2], [12, 2], [6, 10] ------> [7.3333, 4.6667]
            The given points form a real or a degenerate triangle but in each case the above formulas can be used.
             */

            public class Barycenter
            {
                public static double[] BarTriang(double[] x, double[] y, double[] z)
                {
                    double xO = Math.Round((x[0] + y[0] + z[0]) / 3, 4);
                    double yO = Math.Round((x[1] + y[1] + z[1]) / 3, 4);

                    return new double[] { xO, yO };
                }
            }


            /*
             Task
            Given a number, Find if it is Disarium or not .

            Warm-up (Highly recommended)
            Playing With Numbers Series
            Notes
            Number passed is always Positive .
            Return the result as String
            Input >> Output Examples
            disariumNumber(89) ==> return "Disarium !!"
            Explanation:
            Since , 81 + 92 = 89 , thus output is "Disarium !!"
            disariumNumber(564) ==> return "Not !!"
            Explanation:
            Since , 51 + 62 + 43 = 105 != 564 , thus output is "Not !!"
             */

            class KataDisariumNumber
            {
                public static string DisariumNumber(int number)
                {
                    string numStr = number.ToString();
                    int sum = (int)numStr.Select((digit, index) => Math.Pow(char.GetNumericValue(digit), index + 1)).Sum();

                    return sum == number ? "Disarium !!" : "Not !!";
                }
            }


            /*
             This series of katas will introduce you to basics of doing geometry with computers.

            Point objects have fields X and Y.

            Write a function calculating distance between Point a and Point b.

            Input coordinates fit in range 
            −
            50
            ⩽
            x
            ,
            y
            ⩽
            50
            −50⩽x,y⩽50. Tests compare expected result and actual answer with tolerance of 1e-6.


             */
            public class KataDistanceBetweenPoints
            {
                public static double DistanceBetweenPoints(Point a, Point b)
                {
                    double deltaX = b.X - a.X;
                    double deltaY = b.Y - a.Y;
                    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                }
            }

            /*
             Nathan loves cycling.

            Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.

            You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.

            For example:

            time = 3 ----> litres = 1

            time = 6.7---> litres = 3

            time = 11.8--> litres = 5
             */

            public class KataLitres
            {
                public static int Litres(double time)
                {
                    return (int)(time * 0.5);
                }
            }

            /*
             Create a function add(n)/Add(n) which returns a function that always adds n to any number

            Note for Java: the return type and methods have not been provided to make it a bit more challenging.

            Func<double, double> AddOne = Kata.Add(1);
            AddOne(3) => 4
             */

            public static class KataAdd
            {
                public static Func<double, double> Add(double n)
                {
                    return x => x + n;
                }
            }

            //

            public class KataCalc2
            {
                public static int Calc(string s)
                {
                    return string.Concat(s.Select(x => (int)x)).Count(x => x == '7') * 6;
                }
            }

            /*
             Given a string, turn each character into its ASCII character code and join them together to create a number - let's call this number total1:

            'ABC' --> 'A' = 65, 'B' = 66, 'C' = 67 --> 656667
            Then replace any incidence of the number 7 with the number 1, and call this number 'total2':

            total1 = 656667
                          ^
            total2 = 656661
                          ^
            Then return the difference between the sum of the digits in total1 and total2:

              (6 + 5 + 6 + 6 + 6 + 7)
            - (6 + 5 + 6 + 6 + 6 + 1)
            -------------------------
                                   6
             */

            public class KataCalc
            {
                public static Int32 Calc(String s)
                {
                    string total1 = string.Concat(s.Select(c => ((int)c).ToString()));

                    string total2 = total1.Replace('7', '1');

                    int sumTotal1 = total1.Sum(c => c - '0');
                    int sumTotal2 = total2.Sum(c => c - '0');

                    return sumTotal1 - sumTotal2;
                }
            }

            /*
             Given a string and an array of integers representing indices, capitalize all letters at the given indices.

            For example:

            capitalize("abcdef",[1,2,5]) = "aBCdeF"
            capitalize("abcdef",[1,2,5,100]) = "aBCdeF". There is no index 100.
            The input will be a lowercase string with no spaces and an array of digits.

            Good luck!

             */

            public static class KataCapitalize
            {
                public static string Capitalize(string s, List<int> idxs)
                {
                    var chars = s.ToCharArray();

                    foreach (int idx in idxs)
                    {
                        if (idx >= 0 && idx < chars.Length)
                        {
                            chars[idx] = char.ToUpper(chars[idx]);
                        }
                    }

                    return new string(chars);
                }
            }



            /*
             An NBA game runs 48 minutes (Four 12 minute quarters). Players do not typically play the full game, subbing in and out as necessary. Your job is to extrapolate a player's points per game if they played the full 48 minutes.

            Write a function that takes two arguments, ppg (points per game) and mpg (minutes per game) and returns a straight extrapolation of ppg per 48 minutes rounded to the nearest tenth. Return 0 if 0.

            Examples:

            Kata.NbaExtrap(12, 20) => 28.8
            Kata.NbaExtrap(10, 10) => 48
            Kata.NbaExtrap(5, 17)  => 14.1
            Kata.NbaExtrap(0, 0)   => 0
             */

            public class KataNbaExtrap
            {
                public static double NbaExtrap(double ppg, double mpg) => mpg == 0 ? 0 : Math.Round(48.0 / mpg * ppg, 1);
            }


            /*
             Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.

            Examples
            "312" should return "333122"
            "102269" should return "12222666666999999999"
             */

            public class Digits
            {
                public static string Explode(string s)
                {
                    return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));
                }
            }


            //Complete the function which converts hex number (given as a string) to a decimal number.

            public class KataHexToDec
            {
                public static int HexToDec(string hexString)
                {
                    return Convert.ToInt32(hexString.TrimStart('-'), 16) * (hexString[0] == '-' ? -1 : 1);
                }
            }


            //Write function parseFloat which takes an input and returns a number or Nothing if conversion is not possible.
            public class KataParseF
            {
                public static double? ParseF(object s = null)
                {
                    if (s == null)
                    {
                        return null;
                    }

                    if (double.TryParse(s.ToString(), out double result))
                    {
                        return result;
                    }

                    return null;
                }
            }

            /*
             Write a function that can return the smallest value of an array or the index of that value. The function's 2nd parameter will tell whether it should return the value or the index.

            Assume the first parameter will always be an array filled with at least 1 number and no duplicates. Assume the second parameter will be a string holding one of two values: 'value' and 'index'.

            min([1,2,3,4,5], 'value') // => 1
            min([1,2,3,4,5], 'index') // => 0
             */

            public class KataFindSmallest
            {
                public static int FindSmallest(int[] numbers, string toReturn)
                {
                    if (numbers == null || numbers.Length == 0)
                    {
                        throw new ArgumentException("The array must contain at least one element.");
                    }

                    int minIndex = 0;

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] < numbers[minIndex])
                        {
                            minIndex = i;
                        }
                    }

                    return toReturn == "value" ? numbers[minIndex] : minIndex;
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

            public class KataDigit
            {
                public bool DigitDigit(string s)
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

            public class KataRemove3
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
        }
    }
}
