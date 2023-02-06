namespace Chat.Tests;

using Chat.Implementation;

public class ChatTests
{
    [Fact]
    public void Initialize()
    {
        var sut = new ChatController();

        Assert.NotNull(sut);
    }
}