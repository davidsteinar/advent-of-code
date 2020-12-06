using System.Collections.Generic;
using System;
using System.Linq;
using AdventOfCode.Data;

namespace AdventOfCode
{
    public class Day2
    {
        public string pathToData = @"./data/day2.txt";
        private int[,] rangeArray;
        private char[] keyArray;
        private string[] passwordArray;
        private int D;
        private DataHandler _dataHandler;
        public Day2(DataHandler dataHandler){
            this._dataHandler = dataHandler;
        }

        public void ReadData()
        {
            (this.rangeArray, this.keyArray, this.passwordArray) = this._dataHandler.readDataDay2(this.pathToData);
            this.D = this.keyArray.Length;
        }

        public int SolvePart1()
        {
            int totalMatches = 0;
            for (int i = 0; i < this.D; i++)
            {
                var key = this.keyArray[i];
                int count = this.passwordArray[i].Count(f => (f == key));
                int low = this.rangeArray[i, 0];
                int high = this.rangeArray[i, 1];
                if (count >= low && count <= high)
                {
                    totalMatches += 1;
                }
            }
            return totalMatches;
        }

        public int SolvePart2()
        {
            int totalMatches = 0;
            for (int i = 0; i < this.D; i++)
            {
                char key = this.keyArray[i];
                string password = this.passwordArray[i];
                int first = this.rangeArray[i, 0] - 1;
                int second = this.rangeArray[i, 1] - 1;
                int nMatches = 0;
                
                if (password[first] == key)
                {
                    nMatches += 1;
                }
                if (password[second] == key)
                {
                    nMatches += 1;
                }

                if (nMatches == 1)
                {
                    totalMatches += 1;
                }
            }
            return totalMatches;
        }
    }
}