using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson7
{
    internal static class ArrayExtention
    {
        public static double isIncludet(this double[,] mX,int xPos, int yPos)
        {


            if (mX == null || mX.GetLength(0)-1 < xPos|| mX.GetLength(1) - 1 < yPos) return 0;
            else return mX[xPos, yPos];
        }
    }
}
