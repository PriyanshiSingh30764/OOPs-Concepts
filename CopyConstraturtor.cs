public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Default Constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }

    // Static Constructor
    static Person()
    {
        // Initialize static fields or perform actions that need to be done once for the type.
        Console.WriteLine("The Person class has been initialized.");
    }
}

// Usage
class Program
{
    static void Main()
    {
        // Using the default constructor
        Person person1 = new Person();
        Console.WriteLine($"{person1.Name}, {person1.Age}");

        // Using the parameterized constructor
        Person person2 = new Person("Alice", 30);
        Console.WriteLine($"{person2.Name}, {person2.Age}");

        // Using the copy constructor
        Person person3 = new Person(person2);
        Console.WriteLine($"{person3.Name}, {person3.Age}");
    }
}