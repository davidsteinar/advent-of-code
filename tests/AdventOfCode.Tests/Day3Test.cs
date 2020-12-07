using System.Reflection;
using System;
using Xunit;
using AdventOfCode;
using AdventOfCode.Data;

namespace AdventOfCode.Tests
{
    public class Day3Test
    {
        private readonly Day3 day; 
        public Day3Test()
        {
            var dataHandler = new DataHandler();
            this.day = new Day3(dataHandler)
            {
                pathToData = @"../../../Data/day3.txt"
            };
            
            this.day.ReadData();
        }

        [Fact]
        public void Test_SolvePart1(){
            var actual = day.SolvePart1();
            var expected = 7;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_SolvePart2(){
            var actual = day.SolvePart2();
            var expected = 336;
            Assert.Equal(expected, actual);
        }
    }
}
