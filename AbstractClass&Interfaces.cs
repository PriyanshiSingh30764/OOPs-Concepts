// Abstract class with an abstract method
public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method
}

// Concrete class must override the abstract method
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// Interface with a method
public interface IMovable
{
    void Move(); // Interface method
}

// Class implementing the interface must provide an implementation for all interface methods
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("The car is moving.");
    }
}

// Usage
class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.MakeSound(); // Outputs: Woof!

        Car car = new Car();
        car.Move(); // Outputs: The car is moving.
    }
}