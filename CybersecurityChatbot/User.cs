namespace CybersecurityChatbot;

public class User
{
    public string Name { get; set; } = "";

    public void GetUserInfo()
    {
        Console.Write("Enter your name: ");
        Name = Console.ReadLine() ?? "";
    }
}