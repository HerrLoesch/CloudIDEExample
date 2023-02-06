namespace Chat.Implementation.Data;

public class ChatMessage
{
    public ChatMessage(string text)
    {
        this.Text = text;
    }

    public string Text {get; set;}
}