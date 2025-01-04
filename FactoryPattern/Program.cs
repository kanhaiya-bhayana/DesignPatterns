using FactoryPattern.Factory;
using FactoryPattern.Services;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entet notification type (Email, SMS, Push): ");
        string notificationType = Console.ReadLine();

        try
        {
            INotification notification = NotificationFactory.GetNotification(notificationType);
            
            string message = "This is your notification message!";
            
            notification.Notify(message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}