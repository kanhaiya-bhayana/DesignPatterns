using FactoryPattern.Services;

namespace FactoryPattern.Factory;

public class NotificationFactory
{
    public static INotification GetNotification(string notificationType)
    {
        return notificationType.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            "push" => new PushNotification(),
            _ => throw new ArgumentException("Invalid notification type.")
        };
    }
}