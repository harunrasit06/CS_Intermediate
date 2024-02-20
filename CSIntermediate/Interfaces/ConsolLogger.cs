using System;

namespace CSIntermediate.Interfaces
{
    public class ConsolLogger : ILogger
    {
        public void LogError(string message) {
        Console.ForegroundColor = ConsoleColor.Green;   
        Console.WriteLine(message);}

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(message);
            
        }
    }
}
