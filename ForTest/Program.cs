using ForTest.DifferenceOfSquares;
using ForTest.Interest_is_Interesting;
using System.Security.Cryptography.X509Certificates;


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