public class Animal
{
    // Virtual method in the base class
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Overriding method in the subclass
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    // Overriding method in the subclass
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.Speak(); // Output: The animal makes a sound.
        myDog.Speak();    // Output: The dog barks.
        myCat.Speak();    // Output: The cat meows.
    }
}

