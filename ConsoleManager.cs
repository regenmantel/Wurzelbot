using System;
using System.Runtime.InteropServices;

public static class ConsoleManager
{
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool FreeConsole();

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool SetConsoleTitle(string lpConsoleTitle);

    private static bool consoleEnabled = false;

    public static void EnableConsole()
    {
        if (!consoleEnabled)
        {
            AllocConsole();
            consoleEnabled = true;
        }
    }

    public static void DisableConsole()
    {
        if (consoleEnabled)
        {
            FreeConsole();
            consoleEnabled = false;
        }
    }

    public static void Log(string message)
    {
        if (consoleEnabled)
        {
            SetConsoleTitle("WurzelBot");
            Console.WriteLine(message);
        }
        else
        {
            string logFilePath = "log.txt";
            File.AppendAllText(logFilePath, $"{DateTime.Now} - {message}\n");
        }
    }
}
