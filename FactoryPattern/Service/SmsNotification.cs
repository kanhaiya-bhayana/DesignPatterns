namespace FactoryPattern.Services;

public class SmsNotification : INotification
{
    public void Notify(string message)
        => Console.WriteLine($"Sending {typeof(SmsNotification).Name} notification: {message}");
}
