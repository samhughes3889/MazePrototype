using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePrototype
{
    class Program
    {
        string[] maze;

        private void Main()
        {
            maze = new string[]
                {"■@■■■■■■■■■■■■■■", //0
                 "■              ■", //1
                 "■              ■", //2
                 "■              ■", //3
                 "■              ■", //4
                 "■              ■", //5
                 "■              ■", //6
                 "■              ■", //7
                 "■              ■", //8
                 "■              ■", //9
                 "■              ■", //10
                 "■              ■", //11
                 "■              ■", //12
                 "■              ■", //13
                 "■              ■", //14
                 "■■■■■■■■■■■■■■!■"};//15
                //0123456789012345
                //0         1

            ResetMaze();

            Program n = new Program();

            PrintMaze();

            bool IsPathConstructed = false;
            int[] genpos = new int[2];
            int RndNo = 0;

            do
            {
                if (genpos[0] == 14 && genpos[1] == 14)
                {
                    IsPathConstructed = true;
                }

                RndNo = n.GenerateRnd(RndNo);

                if (RndNo == 0)
                {

                }
                else if (RndNo == 1)
                {

                }
                else if (RndNo == 2)
                {

                }
                else if (RndNo == 3)
                {

                };

            } while (IsPathConstructed == false);


            Console.ReadLine();
        }

        private int GenerateRnd(int test)
        {
            Random randomgen = new Random(test);
            return randomgen.Next(0, 4);
        }

        private void PrintMaze()
        {
            for (int i = 0; i < maze.Length; i++)
            {
                Console.WriteLine(maze[i]);
            }
        }

        private void ResetMaze()
        {
            maze = new string[]
                {"■ @ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■", //0
                 "■                             ■", //1
                 "■                             ■", //2
                 "■                             ■", //3
                 "■                             ■", //4
                 "■                             ■", //5
                 "■                             ■", //6
                 "■                             ■", //7
                 "■                             ■", //8
                 "■                             ■", //9
                 "■                             ■", //10
                 "■                             ■", //11
                 "■                             ■", //12
                 "■                             ■", //13
                 "■                             ■", //14
                 "■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ! ■"};//15
                //0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5
                //0                   1

        }
    }
}
