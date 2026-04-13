namespace CybersecurityChatbot;

public class Chatbot
{

    private User user = new User();

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"
   CYBERSECURITY CHATBOT
=============================
        ");
        Console.WriteLine("       !*!");
        Console.WriteLine("      !***!");
        Console.WriteLine("     !*****!");
        Console.WriteLine("    !*******!");
        Console.WriteLine("   !*********!");
        Console.WriteLine("  !***********!");
        Console.WriteLine(" !*************!");
        Console.WriteLine("!***************!");

        Console.ResetColor();
        Console.WriteLine("Welcome!");
        user.GetUserInfo();
        Console.WriteLine($"Hello {user.Name}!");
    }

    

  
}