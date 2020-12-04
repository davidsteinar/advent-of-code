using System.Collections.Generic;
using System;

namespace adventofcode
{
    class Day1
    {
        private (int[], HashSet<int>) readData(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            int D = lines.Length;
            int[] data = new int[D];
            HashSet<int> dataset = new HashSet<int>();

            for (int l = 0; l < D; l++)
            {
                int i = int.Parse(lines[l]);
                data[l] = i;
                dataset.Add(i);
            };

            return (data, dataset);
        }

        public int solve()
        {
            (var data, var dataset) = this.readData(@"./data/day1.txt");

            foreach (int d in data)
            {
                int remains = 2020 - d;
                if (dataset.Contains(remains))
                {
                    return d * remains;
                }
            }
            return 0;
        }

        public int solve2()
        {
            (var data, var dataset) = this.readData(@"./data/day1.txt");

            foreach (int d in data)
            {
                foreach (int dd in data)
                {
                    int remains = 2020 - d - dd;
                    if (dataset.Contains(remains))
                    {
                        return d * dd * remains;
                    }
                }
            }
            return 0;
        }

    }

}