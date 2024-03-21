using ForTest.DifferenceOfSquares;
using ForTest.Interest_is_Interesting;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;


internal class Program
{
    private static void Main(string[] args)
    {
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
        if (Battery == 0 || Battery <= 0) //попробовать убрать <=0;
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