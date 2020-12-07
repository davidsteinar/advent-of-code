using System.Collections.Generic;
using System;
using AdventOfCode.Data;

namespace AdventOfCode
{
    public class Day1
    {
        public string pathToData = @"./data/day1.txt";
        private int[] data;
        private HashSet<int> dataset;

        private readonly DataHandler _dataHandler;


        public Day1(DataHandler dataHandler){
            this._dataHandler = dataHandler;
        }

        public void ReadData()
        {
            (this.data, this.dataset) = this._dataHandler.ReadDataDay1(this.pathToData);
        }

        public int SolvePart1()
        {
            foreach (int d in this.data)
            {
                int remains = 2020 - d;
                if (this.dataset.Contains(remains))
                {
                    return d * remains;
                }
            }
            return 0;
        }

        public int SolvePart2()
        {
            foreach (int d in this.data)
            {
                foreach (int dd in this.data)
                {
                    int remains = 2020 - d - dd;
                    if (this.dataset.Contains(remains))
                    {
                        return d * dd * remains;
                    }
                }
            }
            return 0;
        }
    }
}