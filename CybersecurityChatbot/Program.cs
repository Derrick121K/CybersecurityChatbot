using CybersecurityChatbot;

namespace CybersecurityChatbot
{
    // Entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Set console title
            Console.Title = "Cybersecurity Chatbot";

            // Set console window size
            Console.SetWindowSize(100, 40);

            // Create chatbot instance
            Chatbot chatbot = new Chatbot();

            // Start the chatbot
            chatbot.Start();

            // Wait for user before closing program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}