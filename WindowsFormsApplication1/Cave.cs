using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WumpusTest
{

    public class Cave
    {
        private int[,] caveRooms = new int[30, 6]; // caveRoom[i,j] where i is the cave number (minus one due to arrays starting at 0) and j is the caves it's connected to
        private String[] readFile; // Each slot is 1 line from the txt file (aka 1 caves worth of connections). The .txt starts from the top of the cave and goes clockwise.

        public Cave(int caveNumber)
        {
            // Set readFile to the file correlating with the chosen cave
            if (caveNumber == 1)
            {
                readFile = File.ReadAllLines(@"C:\Users\lauri_000\Desktop\TextFiles\CaveOne.txt");
                //readFile = File.ReadAllLines(@"C:\Users\cleung\Desktop\WindowsFormsApplication1_v9\WindowsFormsApplication1\WindowsFormsApplication1\CaveOne.txt");
            }
            else if (caveNumber == 2)
            {
                readFile = File.ReadAllLines(@"C:\Users\lauri_000\Desktop\TextFiles\CaveTwo.txt");
                //readFile = File.ReadAllLines(@"C:\Users\cleung\Desktop\WindowsFormsApplication1_v9\WindowsFormsApplication1\WindowsFormsApplication1\CaveTwo.txt");
            }
            else if (caveNumber == 3)
            {
                readFile = File.ReadAllLines(@"C:\Users\lauri_000\Desktop\TextFiles\CaveThree.txt");
                //readFile = File.ReadAllLines(@"C:\Users\cleung\Desktop\WindowsFormsApplication1_v9\WindowsFormsApplication1\WindowsFormsApplication1\CaveThree.txt");
            }
            else if (caveNumber == 4)
            {
                readFile = File.ReadAllLines(@"C:\Users\lauri_000\Desktop\TextFiles\CaveFour.txt");
                //readFile = File.ReadAllLines(@"C:\Users\cleung\Desktop\WindowsFormsApplication1_v9\WindowsFormsApplication1\WindowsFormsApplication1\CaveFour.txt");
            }
            else 
            {
                readFile = File.ReadAllLines(@"C:\Users\lauri_000\Desktop\TextFiles\CaveFive.txt");
                //readFile = File.ReadAllLines(@"C:\Users\cleung\Desktop\WindowsFormsApplication1_v9\WindowsFormsApplication1\WindowsFormsApplication1\CaveFive.txt");
            }

            /* 
             * A loop that fills tempTunnel with the current line from readFile, which is split up and converted into ints.
             * The values are then added to caveRooms.
             */
            for (int i = 0; i < readFile.Length; i++)
            {
                int[] tempTunnel = readFile[i].Split(',').Select(int.Parse).ToArray(); // Takes one line from readFile, splits it up, and turns those split numbers into ints
                for (int j = 0; j < tempTunnel.Length; j++)
                {
                    caveRooms[i, j] = tempTunnel[j];
                }
            }
        }

        // Takes the number of the current cave, and returns a list of all the caves connected to it
        public int[] returnConnectedCaves(int currentCave)
        {
            // Connections contains 0s for every wall and a number for every tunnel
            int[] connections = new int[6];
            for (int i = 0; i < 6; i++)
            {
                connections[i] = caveRooms[currentCave - 1, i]; // Minus 1 due to the index being messed up from arrays starting at 0
            }
            return connections;
        }

        // Returns a 2d array of all the cave rooms
        public int[,] getAllRooms()
        {
            return caveRooms;
        }

        public Boolean isConnected(int caveOne, int caveTwo)
        {
            for (int i = 0; i < 6; i++)
            {
                if (caveRooms[caveOne - 1, i] == caveTwo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

