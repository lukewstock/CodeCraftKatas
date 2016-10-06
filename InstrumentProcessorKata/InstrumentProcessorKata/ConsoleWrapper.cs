using System;

namespace InstrumentProcessorKata
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}