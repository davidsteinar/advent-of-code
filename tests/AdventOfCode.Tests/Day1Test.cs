using System.Reflection;
using System;
using Xunit;
using AdventOfCode;
using AdventOfCode.Data;

namespace AdventOfCode.Tests
{
    public class Day1Test
    {
        private Day1 day; 
        public Day1Test()
        {
            var dataHandler = new DataHandler();
            this.day = new Day1(dataHandler);
            this.day.pathToData = @"../../../Data/day1.txt";
            this.day.ReadData();
        }

        [Fact]
        public void Test_SolvePart1(){
            var actual = day.SolvePart1();
            var expected = 514579;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_SolvePart2(){
            var actual = day.SolvePart2();
            var expected = 241861950;
            Assert.Equal(expected, actual);
        }
    }
}
