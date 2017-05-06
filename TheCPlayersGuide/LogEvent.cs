using System;
using System.IO;

namespace TheCPlayersGuide
{
    public class LogEvent
    {
        public static void Main_(string[] args)
        {
            LogEventHandler logHandlers = LogToConsole; // General way to add method in delegate.
            logHandlers += LogToFile; //Adding method to delegate (Delegate chaining).
/*
            logHandlers -= LogToFile; // Removing method from delegate chain.
*/
        }

        private string Text { get; }
        public LogEvent(string text)
        {
            Text = text;
        }

        private static void LogToConsole(LogEvent logEvent)
        {
            Console.WriteLine(logEvent.Text);
        }
        private static void LogToFile(LogEvent logEvent)
        {
            File.AppendAllText("log.txt", logEvent.Text + "\n");
        }
    }
}