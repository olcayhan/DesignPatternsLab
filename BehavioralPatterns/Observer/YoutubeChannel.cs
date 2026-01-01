namespace BehavioralPatterns.Observer;

public class YoutubeChannel
{

    private readonly List<ISubscriber> _subscribers = new();
    
    public string ChannelName { get; private set; }

    public YoutubeChannel(string name)
    {
        ChannelName = name;
    }
    
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }
    
    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }
    
    public void UploadVideo(string title)
    {
        Console.WriteLine($"Channel {ChannelName} uploaded: {title}");
        NotifySubscribers(title);
    }

    private void NotifySubscribers(string videoTitle)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(videoTitle);
        }
    }
}