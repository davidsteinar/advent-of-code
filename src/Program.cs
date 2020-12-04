using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace adventofcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var selectedDay = new Day3();
            Console.WriteLine(selectedDay.solvePart1());
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }
    }
}
