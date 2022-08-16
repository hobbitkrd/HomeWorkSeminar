using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HomeWorkSeminar.Lesson3
{

    internal class HomeWorkLesson3
    {
        public struct Point3d
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
            public Point3d(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }

        }
        public bool isPallindromI(int numLikeInt)
        {
            int tempNum = numLikeInt;
            int workNum = 0;
            while (numLikeInt > 0)
            {
                int dig = numLikeInt % 10;
                workNum = workNum * 10 + dig;
                numLikeInt = numLikeInt / 10;
            }
            return workNum == tempNum ? true : false;
        }
        public bool isPallindromS(int numToString)
        {
            var tempNum = numToString.ToString();
            return tempNum.SequenceEqual(tempNum.Reverse());
        }
        public float TwoPointDistance(Point3d pointOne, Point3d pointTwo)
        {
            return MathF.Sqrt(
                        MathF.Pow((pointTwo.X - pointOne.X), 2) +
                        MathF.Pow((pointTwo.Y - pointOne.Y), 2) +
                        MathF.Pow((pointTwo.Z - pointOne.Z), 2));
            //D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
        }
        public string CoubTable(int num)
        {
            var temp = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                temp.Add(i*i*i);
            }
            return string.Join(",", temp);
        }
    }
}
