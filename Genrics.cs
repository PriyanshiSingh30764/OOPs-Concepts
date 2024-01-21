
using System;
public class calculator
{
    public static bool AreEquals<T>(T value1 , T value2){
        return value1.Equals(value2);

    }

    public static void Main()
    {
        bool equal = calculator.AreEquals<int>(4 ,4);
        bool equal1 = calculator.AreEquals("Hello" ,"World!!");
        Console.WriteLine(equal + " " + equal1);
    }
}