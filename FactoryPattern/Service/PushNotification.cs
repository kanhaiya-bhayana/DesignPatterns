namespace FactoryPattern.Services;

public class PushNotification : INotification
{
    public void Notify(string message)
        => Console.WriteLine($"Sending PushNotification: {message}");
}