
using System;
namespace delegates
{
public class Dele1
{
    public void dele1F(){
     Console.WriteLine("dele1 called");
    }


public delegate void Mydelegate();


    public void dele2F(){
        Console.WriteLine("dele2 called");
    }

    public static void Main()
    {
       Dele1 DeleObj = new Dele1();
        Mydelegate md = new Mydelegate(DeleObj.dele1F);
        md+= DeleObj.dele2F;
        md();
    }
}
}