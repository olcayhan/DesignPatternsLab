namespace BehavioralPatterns.Observer;

public class Subscriber : ISubscriber
{
    public string UserName { get; private set; }
    
    public string LastNotification { get; private set; } = string.Empty;

    public Subscriber(string userName)
    {
        UserName = userName;
    }

    public void Update(string videoTitle)
    {
        LastNotification = $"Hey {UserName}, new video uploaded: {videoTitle}";
        Console.WriteLine(LastNotification);
    }
}