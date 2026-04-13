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

       

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine()?.ToLower() ?? "";

            Console.WriteLine(GetResponse(input));

            if (input == "exit") break;
        }
    }

    private string GetResponse(string input)
    {
        if (input.Contains("password"))
            return "Use strong passwords!";
        else if (input.Contains("phishing"))
            return "Don't click suspicious links!";
        else if (input == "help")
            return "Ask about cybersecurity topics!";
        else if (input == "exit")
            return "Goodbye!";
        else
            return "I don't understand.";
    }

    

  
}