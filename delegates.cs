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
       dele1 DeleObj = new dele1();
       Mydelegate md = new Mydelegate(Deleobj.dele1F);
    }
}
}