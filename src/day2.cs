using System.Collections.Generic;
using System;
using System.Linq;

namespace adventofcode
{
    class Day2
    {

        private string pathToData = @"./data/day2.txt";
        private int D;
        private int[,] rangeArray;
        private char[] keyArray;
        private string[] passwordArray;

        public Day2()
        {
            this.readData();
        }

        private void readData()
        {
            string[] lines = System.IO.File.ReadAllLines(this.pathToData);
            int D = lines.Length;
            int[,] rangeArray = new int[D, 2];
            char[] keyArray = new char[D];
            string[] passwordArray = new string[D];

            for (int l = 0; l < D; l++)
            {
                var splitLine = lines[l].Split(" ");
                var range = splitLine[0].Split("-");
                rangeArray[l, 0] = int.Parse(range[0]);
                rangeArray[l, 1] = int.Parse(range[1]);

                keyArray[l] = splitLine[1][0];

                passwordArray[l] = splitLine[2];
            };

            this.D = D;
            this.rangeArray = rangeArray;
            this.keyArray = keyArray;
            this.passwordArray = passwordArray;
        }

        public int solvePart1()
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

        public int solvePart2()
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