﻿using System.Diagnostics;

namespace TimerAlert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinued = true;

            while (isContinued)
            {
                var totalSessionTime = 0;
                Console.WriteLine("Enter a WorkTime duration in minutes: ");
                var work_duration = Console.ReadLine();

                Console.WriteLine("Enter a RestTime duration in minutes: ");
                var rest_duration = Console.ReadLine();

                if (Convert.ToInt32(work_duration) >= 1 && Convert.ToInt32(rest_duration) >= 1)
                {
                    int work_time_in_sec = Convert.ToInt32(work_duration) * 60;

                    Thread.Sleep(work_time_in_sec);
                    totalSessionTime += work_time_in_sec;
                    for (int i = work_time_in_sec; i >= 0; i--)
                    {
                        Console.WriteLine("Counting down Work Time..{0} Second(s)", i);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    Console.WriteLine("Your WorkTime has completed");
                    Console.WriteLine("Now Counting down Rest Time...");


                    int rest_time_in_sec = Convert.ToInt32(rest_duration) * 60;

                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Thread.Sleep(rest_time_in_sec);
                    totalSessionTime += rest_time_in_sec;

                    for (int i = rest_time_in_sec; i >= 0; i--)
                    {
                        Console.WriteLine("Counting down Rest Time... {0} Second(s)", i);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    Console.WriteLine("Your Rest Time has completed");
                    Console.WriteLine("To Continue, Enter C or Enter S to stop");
                    string? userOption = Console.ReadLine();

                    if (userOption.ToLower() == "c")
                    {
                        isContinued = true;
                    }
                    else if (userOption.ToLower() == "s")
                    {
                        isContinued = false;
                        stopwatch.Stop();
                        TimeSpan time_span = stopwatch.Elapsed;
                        Console.WriteLine("Your Total Session Time is {0:00}:{1:00}:{2:00}", time_span.Hours, time_span.Minutes, time_span.Seconds);
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid character");
                    }

                }
                else
                {
                    Console.WriteLine("The Work Time or Rest time you entered is invalid");
                }
            }

            Console.ReadLine();
        }
    }
}