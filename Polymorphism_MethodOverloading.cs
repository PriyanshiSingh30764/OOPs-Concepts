using System;

class MethodOverLoad
{
    public int Add(int a,int b)
    {
        return a+b;
    }

    public int Add(int a,int b,int c)
    {
        return a+b+c;
    }

    public static void Main()
    {
        MethodOverLoad Obj = new MethodOverLoad();
        int sum1 = Obj.Add(2,5);
       int sum2 = Obj.Add(3,6,8);
       Console.WriteLine(sum1+ " " + sum2);

    }
}
