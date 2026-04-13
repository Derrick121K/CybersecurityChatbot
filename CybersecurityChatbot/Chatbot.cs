using System.Threading;

namespace CybersecurityChatbot;

// Main chatbot class that controls the flow of the application
public class Chatbot
{
    private User currentUser;        // Stores current user information
    private AudioPlayer audioPlayer; // Handles audio playback

    // Constructor initializes user and audio player
    public Chatbot()
    {
        currentUser = new User();
        audioPlayer = new AudioPlayer();
    }

    // Starts the chatbot program
    public void Start()
    {
        // Play voice greeting
        audioPlayer.PlayGreeting();

        // Display ASCII Art logo
        DisplayAsciiArt();

        Thread.Sleep(1000);

        // Display welcome message with typing effect
        TypeWriter("Welcome to the Cybersecurity Chatbot!", 40);
        Thread.Sleep(500);

        // Get user information
        currentUser.GetUserInfo();

        // Clear screen and show personalized greeting
        Console.Clear();
        DisplayBorder();

        TypeWriter($"Hello {currentUser.Name}! I'm your Cybersecurity Assistant.", 40);
        Console.WriteLine();

        TypeWriter("I can help you with cybersecurity questions.", 40);
        Console.WriteLine();

        TypeWriter("Type 'help' to see what I can do, or 'exit' to quit.", 40);
        Console.WriteLine();

        DisplayBorder();

        // Start conversation loop
        StartConversation();
    }

    // Displays ASCII art logo
    private void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        string asciiArt = @"
    ╔═══════════════════════════════════════════╗
    ║     ██████╗██╗   ██╗██████╗ ███████╗██████╗ ║
    ║    ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗║
    ║    ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝║
    ║    ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗║
    ║    ╚██████╗   ██║   ██████╔╝███████╗██║  ██║║
    ║     ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝║
    ║          C Y B E R S E C U R I T Y          ║
    ║                C H A T B O T                ║
    ╚═══════════════════════════════════════════╝
        ";

        Console.WriteLine(asciiArt);
        Console.ResetColor();
    }

    // Displays a border line
    private void DisplayBorder()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(new string('═', 60));
        Console.ResetColor();
    }

    // Simulates typing effect for messages
    private void TypeWriter(string message, int delay)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    // Handles the chat loop
    private void StartConversation()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();

            // Display user prompt
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[{currentUser.Name}]> ");
            Console.ResetColor();

            string? input = Console.ReadLine();

            // Validate user input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[!] Please enter something. I'm here to help!");
                Console.ResetColor();
                continue;
            }

            // Get chatbot response
            string response = GetResponse(input.ToLower());

            // Display chatbot response
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[CyberBot]> ");
            Console.ResetColor();

            TypeWriter(response, 30);

            // Exit conditions
            if (input.ToLower() == "exit" || input.ToLower() == "quit" || input.ToLower() == "bye")
            {
                running = false;
                TypeWriter($"Goodbye {currentUser.Name}! Stay safe online! 🔒", 40);
            }
        }
    }

    // Determines chatbot response based on user input
    private string GetResponse(string input)
    {
        if (input.Contains("how are you"))
        {
            return "I'm just code, but I'm functioning perfectly! Ready to help you with cybersecurity! 🤖";
        }
        else if (input.Contains("purpose") || input.Contains("what do you do"))
        {
            return "My purpose is to educate you about cybersecurity best practices and help you stay safe online!";
        }
        else if (input.Contains("password"))
        {
            return "🔐 TIP: Use strong passwords with at least 12 characters, including uppercase, lowercase, numbers, and symbols. Never reuse passwords across sites!";
        }
        else if (input.Contains("phishing"))
        {
            return "🎣 PHISHING ALERT! Never click suspicious links in emails. Always verify the sender's email address and look for spelling errors.";
        }
        else if (input.Contains("virus") || input.Contains("malware"))
        {
            return "🦠 Keep your antivirus software updated! Run regular scans and avoid downloading files from untrusted sources.";
        }
        else if (input.Contains("2fa") || input.Contains("two factor"))
        {
            return "📱 Enable 2FA everywhere possible! It adds an extra layer of security to your accounts.";
        }
        else if (input.Contains("wifi") || input.Contains("network"))
        {
            return "🌐 Avoid using public WiFi for sensitive transactions. If you must, use a VPN!";
        }
        else if (input.Contains("help"))
        {
            return "I can answer questions about: passwords, phishing, malware, 2FA, WiFi security, and general cybersecurity tips! Type 'exit' to quit.";
        }
        else if (input.Contains("thanks") || input.Contains("thank you"))
        {
            return "You're welcome! Stay vigilant and stay safe online! 🛡️";
        }
        else if (input.Contains("exit") || input.Contains("quit") || input.Contains("bye"))
        {
            return "Thanks for chatting! Remember to always prioritize your cybersecurity!";
        }
        else
        {
            return "I'm not sure about that. Try asking about passwords, phishing, malware, 2FA, or type 'help' for options.";
        }
    }
}