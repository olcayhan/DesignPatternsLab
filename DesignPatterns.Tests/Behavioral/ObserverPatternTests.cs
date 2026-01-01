using BehavioralPatterns.Observer;
using Xunit;

namespace DesignPatterns.Tests.Behavioral;

public class ObserverPatternTests
{
    [Fact]
    public void Subscribers_Should_Receive_Notification_When_Video_Uploaded()
    {
        var channel = new YoutubeChannel("Code with Olcay");
        var user1 = new Subscriber("Ahmet");
        var user2 = new Subscriber("Mehmet");
        
        channel.Subscribe(user1);
        channel.Subscribe(user2);
        
        string videoTitle = "Design Patterns in C#";
        channel.UploadVideo(videoTitle);
        
        Assert.Contains("Ahmet", user1.LastNotification);
        Assert.Contains(videoTitle, user1.LastNotification);
        
        Assert.Contains("Mehmet", user2.LastNotification);
        Assert.Contains(videoTitle, user2.LastNotification);
    }

    [Fact]
    public void Unsubscribed_User_Should_Not_Receive_Notification()
    {
        var channel = new YoutubeChannel("Tech Daily");
        var user1 = new Subscriber("Ayşe");
        
        channel.Subscribe(user1);
        channel.Unsubscribe(user1);
        
        channel.UploadVideo("Unboxing iPhone 16");
        
        Assert.Equal(string.Empty, user1.LastNotification);
    }
}