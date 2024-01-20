// Base class
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Breathe()
    {
        Console.WriteLine($"{Name} is breathing.");
    }
}

// Derived class
public class Dog : Animal // Dog inherits from Animal
{
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine($"{Name} the {Breed} barks!");
    }
}

// Usage
class Program
{
    static void Main()
    {
        Dog myDog = new Dog
        {
            Name = "Buddy",
            Age = 3,
            Breed = "Golden Retriever"
        };

        myDog.Breathe(); // Inherited method
        myDog.Bark(); // Dog's own method
    }
}