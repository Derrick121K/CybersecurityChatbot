namespace CybersecurityChatbot;

// Handles user data and validation
public class User
{
    public string Name { get; set; }           // User's name
    public bool IsAuthenticated { get; set; }  // Indicates if user is valid

    public User()
    {
        Name = string.Empty;
        IsAuthenticated = false;
    }

    // Prompts user to enter their name
    public void GetUserInfo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n[?] Enter your name: ");
        Console.ResetColor();

        string? input = Console.ReadLine();
        Name = input ?? string.Empty;

        // Ensure name is not empty
        while (string.IsNullOrWhiteSpace(Name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[!] Name cannot be empty. Please enter your name: ");
            Console.ResetColor();

            input = Console.ReadLine();
            Name = input ?? string.Empty;
        }

        IsAuthenticated = true;
    }
}