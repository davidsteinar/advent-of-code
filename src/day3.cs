using System;
using System.Collections.Generic;
using adventofcode.Data;

namespace adventofcode{
    class Day3{

        string pathToData = @"./data/day3.txt";
        private int Dx;
        private int Dy;
        private char[,] data;
        private DataHandler _dataHandler;


        public Day3(DataHandler dataHandler){
            this._dataHandler = dataHandler;
        }

        public void ReadData(){
            this.data = this._dataHandler.readDataDay3(this.pathToData);
            this.Dy = data.GetLength(0);
            this.Dx = data.GetLength(1);
        }

        public int solvePart1(int XStep, int YStep){
            int nTrees = 0;
            int x = 0;
            int y = 0;

            while (x < this.Dx && y < this.Dy){
                var pointValue =  this.data[y,x];
                if (pointValue == "#"[0]){
                    nTrees += 1;
                }
                x += XStep;
                y += YStep;
            }

            return nTrees;
        }

        public long solvePart2(){
            int[,] steps = new int[,] 
                           {{1, 1},
                            {3, 1},
                            {5, 1},
                            {7, 1},
                            {1, 2}};

            long mult = 1;
            for (int i = 0; i < steps.GetLength(0); i++){
                int XStep = steps[i,0];
                int YStep = steps[i,1];
                int nTrees = this.solvePart1(XStep, YStep);
                mult = mult*nTrees;
                }
            return mult;
         }
    }
}