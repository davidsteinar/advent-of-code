using System;
using System.Collections.Generic;
using System.Diagnostics;
using AdventOfCode.Data;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var dataHandler = new DataHandler();
            var selectedDay = new Day1(dataHandler);
            selectedDay.ReadData();
            var answerPart1 = selectedDay.SolvePart1();
            Console.WriteLine($"Answer to part 1: {answerPart1}");
            var answerPart2 = selectedDay.SolvePart2();
            Console.WriteLine($"Answer to part 2: {answerPart2}");
            stopWatch.Stop();
            Console.WriteLine($"Milliseconds: {stopWatch.ElapsedMilliseconds}");
        }
    }
}
