using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson8
{
    internal class HomeWorkLesson8
    {
        public int[,] DataToSort2nd { get; set; }
        public int[,,] DataToSort3nd { get; set; }
        public HomeWorkLesson8(int column, int row)
        {
            DataToSort2nd = GenRandom(column, row);
        }
        public HomeWorkLesson8(int column, int secondColumn, int row)
        {
            DataToSort3nd = GenRandom3nd(column, secondColumn, row);
        }


        /// <summary>
        /// False - от меньшего, True - от большего
        /// </summary>
        /// <param name="order"></param>
        public void BubleSortTwoND(bool order = false)
        {
            for (int i = 0; i < DataToSort2nd.GetLength(0); i++)
            {
                for (int j = 0; j < DataToSort2nd.GetLength(1) - 1; j++)
                {
                    for (int z = 0; z < DataToSort2nd.GetLength(1) - 1; z++)
                    {
                       if (order && DataToSort2nd[i, z] > DataToSort2nd[i, z + 1]) Swaper(i, z);
                       else if(!order && DataToSort2nd[i, z] < DataToSort2nd[i, z + 1]) Swaper(i, z);
                    }
                }
            }

        }
        public int MinSimLine()
        {
            int tempMinSum = 0;
            var sumLine = ElementSumInLine(0);
            for (int i = 1; i < DataToSort2nd.GetLength(0); i++)
            {
                int tempSumLine = ElementSumInLine(i);
                if (sumLine > tempSumLine)
                {
                    sumLine = tempSumLine;
                    tempMinSum = i;
                }
            }
            return tempMinSum;


        }
        public List<string> Print3ndArray()
        {
            var result = new List<string>();
            for (int i = 0; i < DataToSort3nd.GetLength(0); i++)
            {
                for (int j = 0; j < DataToSort3nd.GetLength(1); j++)
                {
                    for (int k = 0; k < DataToSort3nd.GetLength(2); k++)
                    {
                        result.Add($"{DataToSort3nd[i, j, k]} ({i},{j},{k}) ");
                    }
                }
            }
            return result;
        }

        public void MultiplyMatrix(int[,] firstMart, int[,] secomdMart)
        {
            var resultMart = new int[firstMart.GetLength(0), secomdMart.GetLength(1)];

            for (int i = 0; i < resultMart.GetLength(0); i++)
            {
                for (int j = 0; j < resultMart.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < firstMart.GetLength(1); k++)
                    {
                        sum += firstMart[i, k] * secomdMart[k, j];
                    }
                    resultMart[i, j] = sum;
                }
            }
        }




        private void Swaper(int i,int z)
        {
            int temp = 0;
            temp = DataToSort2nd[i, z];
            DataToSort2nd[i, z] = DataToSort2nd[i, z + 1];
            DataToSort2nd[i, z + 1] = temp;

        }
        private int[,,] GenRandom3nd(int m, int x, int z)
        {
            var rnd = new Random();
            var temple = new int[m, x,z];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    for(int k = 0; k < z; k++)
                        temple[i, j,k] = rnd.Next(0, 1000);

                }
                    
            }
            return temple;

        }
        private int[,] GenRandom(int m, int x)
        {
            var rnd = new Random();
            var temple = new int[m, x];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < x; j++)
                    temple[i, j] = rnd.Next(-100, 100);
            }
            return temple;
        }
        private int ElementSumInLine(int i)
        {
            int sum = DataToSort2nd[i, 0];
            for (int j = 1; j < DataToSort2nd.GetLength(1); j++)
            {
                sum += DataToSort2nd[i, j];
            }
            return sum;
        }

    }
}
