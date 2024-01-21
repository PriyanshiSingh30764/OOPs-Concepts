public delegate void MyEventHandler();

public class Publisher
{
    public event MyEventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke();
    }
}

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {   
        // "Hey, when `MyEvent` is raised, call my `HandleEvent` method."
        publisher.MyEvent += HandleEvent;
    }

    private void HandleEvent()
    {
        Console.WriteLine("Event was raised and handled.");
    }
}

public class Program
{
    public static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        subscriber.Subscribe(publisher);
        publisher.RaiseEvent();
    }
}
