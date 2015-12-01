﻿using System;

namespace McGee_III
{
    public class Floor
    {
        Random rnd = new Random();

        // Properties
        public Tile[,] Room;
        public int Level;
        public int Size;
        public bool DoorSpawn = false;
        public bool KeySpawn = false;

        // DEBUG
        public void printTiles()
        {
            Console.WriteLine();
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    Console.WriteLine(Room[x, y].Descripion);
                }
            }
        }

        // Constructor
        public Floor(int level)
        {
            Level = level;
            Size = Level * 2 + 1;
            Room = new Tile[Size, Size];
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    Room[x, y] = new Tile(x, y, rnd.Next(1000));
                }
            }
        }
    }
}
