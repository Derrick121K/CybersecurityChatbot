using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace CybersecurityChatbot;

// Handles audio playback functionality
public class AudioPlayer
{
    // Import Windows API for sound playback
    [DllImport("winmm.dll", SetLastError = true)]
    static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);

    private const uint SND_FILENAME = 0x00020000; // Play from file
    private const uint SND_ASYNC = 0x0001;        // Play asynchronously
    private const uint SND_SYNC = 0x0000;         // Play synchronously

    // Plays greeting sound if available
    public void PlayGreeting()
    {
        try
        {
            // Possible file locations
            string[] possiblePaths = new[]
            {
                "greeting.wav",
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greeting.wav")
            };

            string? wavPath = null;

            // Check for existing file
            foreach (var path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    wavPath = path;
                    break;
                }
            }

            if (wavPath != null)
            {
                // Play sound
                bool result = PlaySound(wavPath, IntPtr.Zero, SND_FILENAME | SND_ASYNC);

                if (result)
                {
                    System.Threading.Thread.Sleep(2000); // Allow sound to start
                }
                else
                {
                    Console.WriteLine("[Audio file found but couldn't play]");
                }
            }
            else
            {
                // Fallback message if no file found
                Console.WriteLine("[🎵 Voice greeting would play here: 'Welcome to Cybersecurity Chatbot']");
            }
        }
        catch (Exception ex)
        {
            // Handle errors
            Console.WriteLine($"[Audio not available: {ex.Message}]");
        }
    }
}