using System.Reflection;
using System;
using Xunit;
using AdventOfCode;
using AdventOfCode.Data;

namespace AdventOfCode.Tests
{
    public class Day2Test
    {
        private readonly Day2 day; 
        public Day2Test()
        {
            var dataHandler = new DataHandler();
            this.day = new Day2(dataHandler)
            {
                pathToData = @"../../../Data/day2.txt"
            };
            this.day.ReadData();
        }

        [Fact]
        public void Test_SolvePart1(){
            var actual = day.SolvePart1();
            var expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_SolvePart2(){
            var actual = day.SolvePart2();
            var expected = 1;
            Assert.Equal(expected, actual);
        }
    }
}
