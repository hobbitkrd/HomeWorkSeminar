using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson7
{
    internal class HomeWorkLesson7
    {
        public double[,] mX { get; set; }
        public void MXArray(int m, int x)
        {
            var rnd = new Random();//поставил сюда для того,чтобы время бралось от каждом вызове метода
            var temple = new double[m, x];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < x; j++)
                    temple[i, j] = rnd.Next(-100, 100) + rnd.NextDouble();
            }
            mX = temple;
        }
        public List<double> Average(int xPos, int yPos)
        {
            var rand = new Random(8);
            var averages = new List<double>();
            var rand2d = new int[xPos, yPos];
            for (int i = 0; i < rand2d.GetLength(0); i++)
            {
                for (int j = 0; j < rand2d.GetLength(1); j++)
                    rand2d[i, j] = rand.Next(int.MinValue, int.MaxValue);
            }
            for (int i = 0; i < rand2d.GetLength(0); i++)
            {
                averages.Add(GetColumn(rand2d, i)
                        .Average());
            }
            return averages;
        }
        private int[] GetColumn(int[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

    }
}
