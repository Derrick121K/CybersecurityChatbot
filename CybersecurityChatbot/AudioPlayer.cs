using System;
using System.IO;
using System.Runtime.InteropServices;

namespace CybersecurityChatbot;

public class AudioPlayer
{
    [DllImport("winmm.dll")]
    static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);

    public void PlayGreeting()
    {
        Console.WriteLine("[🎵 Playing greeting sound...]");
    }
}