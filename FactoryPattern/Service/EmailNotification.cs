namespace FactoryPattern.Services;

public class EmailNotification : INotification
{
    public void Notify(string message)
        => Console.WriteLine($"Sending {typeof(EmailNotification).Name} {message}");


}