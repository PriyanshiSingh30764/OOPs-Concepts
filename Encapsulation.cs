using System;

public class Vehicle
{
    // Private field - only accessible within this class
    private string vehicleIdentificationNumber;

    // Protected field - accessible within this class and derived classes
    protected int wheels;

    // Internal field - accessible within the same assembly
    internal string licensePlate;

    // Protected internal field - accessible within the assembly and by derived classes
    protected internal string registrationNumber;

    // Private protected field - accessible within the class and derived classes in the same assembly
    private protected string engineSerialNumber;

    // Public property - accessible from anywhere
    public string Model { get; set; }

    // Constructor
    public Vehicle(string vin)
    {
        vehicleIdentificationNumber = vin;
    }

    // Public method to display information
    public void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}");
        // Can access all fields here because it's within the class
        Console.WriteLine($"VIN: {vehicleIdentificationNumber}");
    }

    // Private method - only accessible within this class
    private void SetEngineSerialNumber(string serial)
    {
        engineSerialNumber = serial;
    }

    // Protected method - accessible within this class and derived classes
    protected void SetWheels(int numberOfWheels)
    {
        wheels = numberOfWheels;
    }
}

// Derived class
public class Car : Vehicle
{
    public Car(string vin) : base(vin)
    {
        // Can access protected fields and methods
        SetWheels(4);
    }

    public void DisplayCarInfo()
    {
        // Can access protected internal and private protected members
        registrationNumber = "123ABC";
        engineSerialNumber = "XYZ789";
    }
}