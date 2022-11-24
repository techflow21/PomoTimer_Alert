using System.Diagnostics;

namespace TimerAlert
{
    internal class TimerOperations
    {
        public void Timer()
        {
            bool isContinued = true;

            while (isContinued)
            {
                Console.WriteLine("Enter a WorkTime duration in minutes: ");
                var workDuration = Console.ReadLine();

                Console.WriteLine("Enter a RestTime duration in minutes: ");
                var restDuration = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(workDuration) >= 1 && Convert.ToInt32(restDuration) >= 1)
                    {
                        int workTimeMillisec = Convert.ToInt32(workDuration) * 60;

                        DateTime startTime = DateTime.Now;
                        Thread.Sleep(workTimeMillisec);

                        for (int i = workTimeMillisec; i >= 0; i--)
                        {
                            Console.WriteLine("Counting down Work Time... {0} Second(s) left", i);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                        Console.WriteLine("Your WorkTime has completed");
                        Console.WriteLine("Now Counting down Rest Time...");

                        int restTimeMillisec = Convert.ToInt32(restDuration) * 60;
                        
                        Thread.Sleep(restTimeMillisec);

                        for (int i = restTimeMillisec; i >= 0; i--)
                        {
                            Console.WriteLine("Counting down Rest Time... {0} Second(s) left", i);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                        Console.WriteLine("Your Rest Time has completed");
                        Console.WriteLine("To Continue, Enter C or Enter S to stop");
                        string? userOption = Console.ReadLine();

                        try
                        {
                            if (userOption.ToLower() == "c")
                            {
                                isContinued = true;
                            }
                            else if (userOption.ToLower() == "s")
                            {
                                isContinued = false;

                                DateTime stopTime = DateTime.Now;

                                TimeSpan span = stopTime.Subtract(startTime);

                                int Secondsdiff = span.Seconds;
                                int Minutesdiff = span.Minutes;
                                int Hoursdiff = span.Hours;

                                Console.WriteLine($"Your Total WorkSession is :{ Hoursdiff.ToString()}:{Minutesdiff.ToString()}:{Secondsdiff.ToString()}");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("You entered an invalid character");
                        }
                    }
                }

                catch
                {
                    Console.WriteLine("The Work-time or Rest-time you entered is invalid");
                } 
            }
        }
    }
}
