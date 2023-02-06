namespace Chat.Tests;

using Chat.Implementation;
using System.Linq;

public class ChatTests
{
    [Fact]
    public void Initialize()
    {
        var sut = new ChatController();

        Assert.NotNull(sut);
    }

    [Fact]
    public void Empty_list_is_returned_if_no_chat_messages_are_available()
    {
        var sut = new ChatController();

        var messages = sut.GetMessages();

        Assert.True(messages.Any(x => x.Text == "Hallo Welt"));
    }
}