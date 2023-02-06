namespace Chat.Implementation;

using Chat.Implementation.Data;

public class ChatController
{
    public IEnumerable<ChatMessage> GetMessages()
    {
        return new List<ChatMessage> { new ChatMessage("Hallo Welt")};
    }
}