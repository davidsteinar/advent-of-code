using System;
using System.Collections.Generic;
using AdventOfCode;
using AdventOfCode.Data;
using Xunit;

namespace AdventOfCode.Tests{
    public class DataHandlerTest{

        [Fact]
        public void TestDay1(){
            //
            var dataHandler = new DataHandler();
            string pathToData = @"../../../Data/day1.txt";

            //
            (int[] data, HashSet<int>  dataset) = dataHandler.ReadDataDay1(pathToData);
            var nRows = data.Length;

            //
            Assert.Equal(expected:6, actual:nRows);
        }
    }
}