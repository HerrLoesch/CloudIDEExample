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

    [Fact]
    public void todays_date_is_returned_if_no_date_is_available()
    {
        var sut = new ChatController();

        var date = sut.GetDate();

        Assert.True(date.Any(x => x.Date == "20/03/2022 10:10"));

    }

    [Fact]
    public void annonymus_is_returned_if_no_user_name()
    {
        var sut = new ChatController();

        var userName = sut.GetUserName();

        Assert.True(userName.Any(x => x.UserName == "Annonymus"));
    }
}