using System;
using System.Collections.Generic;

namespace adventofcode{
    class Day3{
        private string pathToData = @"./data/day3.txt";
        private int X;
        private int Y;
        private List<char[]> data;


        public Day3(){
            this.readData();
        }

        private void readData(){
            string[] lines = System.IO.File.ReadAllLines(this.pathToData);
            this.Y = lines.Length;
            var data = new List<char[]>();

            for (int i=0; i < this.Y; i++){
                data.Add(lines[i].ToCharArray());
            }

            this.X = data[0].Length;

            this.data = data;
        }

        public int solvePart1(){
            int nTrees = 0;
            int rightStep = 3;
            int downStep = 1;
            
            int x = 0;
            int y = 0;

            while (x <= this.X && y <= this.Y){
                var pointValue =  this.data[y][x];
                if (pointValue == "#"[0]){
                    nTrees += 1;
                }
                x += rightStep;
                y += downStep;
            }

            return nTrees;
        }
    }
}