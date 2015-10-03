namespace ExtensionMethods
{
    using System;
    using System.Diagnostics;

    class Timer
    {
        public delegate void DelegateExample(string message, int seconds);

        public static void TimerInstance(string message, int seconds)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            while (true)
            {
                if (stopWatch.ElapsedMilliseconds == seconds * 1000)
                {
                    Console.WriteLine(message);
                    stopWatch.Restart();
                }
            }
        }

        static void Main()
        {
            DelegateExample timer = new DelegateExample(TimerInstance);
            timer("This delegate is running at every 2 seconds", 2);
        }
    }
}