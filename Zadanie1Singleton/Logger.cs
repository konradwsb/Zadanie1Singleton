using System;
using System.Collections.Generic;

public class Logger
{
    private static Logger instance;
    private List<string> logMessages;

    private Logger()
    {
        logMessages = new List<string>();
    }

    public static Logger GetInstance()
    {
        if (instance == null)
            instance = new Logger();

            return instance;
    }

    public void LogMessage(string message)
    {
        logMessages.Add($"{DateTime.Now}: {message}");
    }

    public void DisplayLog()
    {
        Console.WriteLine("\nLog messages:");
        foreach (var message in logMessages)
        {
            Console.WriteLine(message);
        }
        if(logMessages.Count == 0)
            Console.WriteLine(" -- brak -- ");
    }
}
