using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Data{
    public class DataHandler{
        private string[] ReadTxtFile(string path){
            return System.IO.File.ReadAllLines(path);
        }

        public (int[], HashSet<int>) ReadDataDay1(string pathToData)
        {
            string[] lines = ReadTxtFile(pathToData);
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

        public (int[,], char[], string[]) ReadDataDay2(string pathToData)
        {
            string[] lines = ReadTxtFile(pathToData);
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

            return (rangeArray, keyArray, passwordArray);
        }

        public char[,] ReadDataDay3(string pathToData){
            string[] lines = ReadTxtFile(pathToData);
            int Y = lines.Length;
            int X = lines[0].Length;
            int repeated = 100;
            var data = new char[Y,X*repeated];

            for (int i=0; i < Y; i++){
                var row = lines[i].ToCharArray();
                char[] repeatedRow = new List<char>()
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .Concat(row)
                    .ToArray();

                for(int r = 0; r < X * repeated; r++){
                    data[i,r] = repeatedRow[r];
                }
            }
            return data;
        }
    }
}