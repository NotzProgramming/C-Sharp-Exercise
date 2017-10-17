using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide
             * two methods: Start and Stop. We call the start method first, and the stop method next. Then we ask the
             * stopwatch about the duration between start and stop. Duration should be a value in TimeSpan. Display
             * the duration on the console. We should also be able to use a stopwatch multiple times. So we may start
             * and stop it and then start and stop it again. Make sure the duration value each time is calculated properly.
             * We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start 
             * time). So the class should throw an InvalidOperationException if its started twice. */

            var isStart = false;
            var time = new StopWatch();
            while (true)
            {
                Console.WriteLine("Enter 'start' or 'stop' to StopWatch.");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;

                if(input == "start")
                {
                    if (isStart == false)
                    {
                        //start StopWatch
                        isStart = true;
                        time.SetStartTime = DateTime.Now.TimeOfDay;
                    }
                    else
                    {
                        throw new InvalidOperationException("StopWatch is already started.");
                    }
                }
                else if (input == "stop")
                {
                    if (isStart == true)
                    {
                        //stop StopWatch
                        isStart = false;
                        time.SetStopTime = DateTime.Now.TimeOfDay;
                        Console.WriteLine("The result is {0}.",time.interval());
                    }
                    else
                    {
                        throw new InvalidOperationException("StopWatch is already stopped.");
                    }
                }

            }
        }
    }
    
    public class StopWatch
    {

        public TimeSpan SetStartTime 
        {
            set { _startTime = value; }
        }
        public TimeSpan SetStopTime
        {
            set { _stopTime = value; }
        }

        private TimeSpan _startTime;
        private TimeSpan _stopTime;
        
        public TimeSpan interval()
        {
            var time = new TimeSpan();
            time = _stopTime - _startTime;
            
            return time;
        }
    }
}
