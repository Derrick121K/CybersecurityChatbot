namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Chatbot bot = new Chatbot();
            bot.Start();
            Console.Title = "Cybersecurity Chatbot";
            Console.WriteLine("Cybersecurity Chatbot Starting...");
            AudioPlayer audio = new AudioPlayer();
            audio.PlayGreeting();
        }
    }
}