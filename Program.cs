using System.Diagnostics;

namespace TimerAlert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Timer-Alert App");
            TimerOperations timerOperations = new();
            timerOperations.Timer();
            
            Console.ReadLine();
        }
    }
}
