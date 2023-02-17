namespace Chat.Implementation;

using Chat.Implementation.Data;

public class ChatController
{
    public IEnumerable<ChatMessage> GetMessages()
    {
        return new List<ChatMessage> { new ChatMessage("Hallo Welt")};
    }
    public IEnumerable<ChatMessageDate> GetDate()
    {
        return new List<ChatMessageDate> {new ChatMessageDate(DateTime.Now.ToString("MM/dd/yyyy HH:mm"))};
    }
  
}