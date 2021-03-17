using System;
using System.Collections.Generic;
using System.Text;

namespace HuntTheWumpusConsole
{
    class Map
    {
        public Map(int size)
        {
            Random randNum = new Random();
            mapGrid = new int[size, size];
            mapSize = size;
            //Assign Values One Row at a Time
            for(int i = 0; i<size; i++)
            {
                for(int k = 0; k<size; k++)
                {
                    mapGrid[i,k] = randNum.Next(1, 5);
                }
            }
        }

        public void DisplayMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int k = 0; k < mapSize; k++)
                {
                    Console.Write(mapGrid[i,k]);
                }
                Console.WriteLine();
            }
        }

        //1 Normal
        //2 Pit
        //3 Blood
        //4 Wumpus

        public int[,] mapGrid { get; set; }
        public int mapSize { get; set; }
        //int[,] lala = new int[3,5];
    }
}
