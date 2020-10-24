using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticePaths
{
    class Program
    {
        static void Main(string[] args)
        {

            // You can only move to the right and down
            // How many paths are there in a 20x20 lattice?

            //Check row by row - 

            int[,] lattice = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // So if the path took a turn, come back to the original spot and keep doing until the path didn't turn
            // add one to count once path reaches [20,20]

            //int[,] traveler = new int[,] { { 0 }, { 0 } };
            int[] traveler = new int[] { 0, 0 };

            //store where traveler has been?

            // if traveler did not previously go down/right at x,y coord, then go back
            //given m x n matrix
            //go all the way down, then all the way right
            //go down to m - 1, then over one, then down one, then all the way over
            //go down to m - 1, then over two, then down one, then all the way over
            //repeat until you go down to m - 1, then over n, then down one
            //go down to m - 2, then over one, then down two, then all the way over
            //go down to m - 2, then over one, then down one, then repeat previous cycle for m - 1
            //go down to m - 2, then over two, then down one, then repeat previous cycle for 



            int count = 1;
            int rowsItsBeenThrough = 1;
            int colsItsBeenThrough = 1;

            for (int row = 2; row >= 0; row--)
            {

                for (int col = 0; col <= 2; col++)
                {

                }

            }








            //(int, int) traveler = (0,0);

            //int count = 0;

            //for (int m = 0; m <= 2; m++)
            //{
            //    traveler[1] = m;
            //    if (traveler[1] == 2)
            //    {
            //        for (int n = 0; n <= 2; n++)
            //        {
            //            traveler[0] = n;
            //        }

            //        if (traveler[0] == 2 && traveler[0] == 2)
            //        {
            //            count = count + 1;
            //        }

            //    }
            //}

        }

    }
}
