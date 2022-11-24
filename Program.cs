using System.Diagnostics;

namespace TimerAlert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimerOperations timerOperations = new();
            timerOperations.Timer();
            
            Console.ReadLine();
        }
    }
}
