using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson6
{
    internal class HomeWorkLesson6
    {
        public int OverZero(string numArray)
        {
            int count = 0;
            var workArray = numArray.Split(' ')
                .Select(int.Parse)
                .ToArray();
            foreach (var item in workArray) if (item > 0) count++;
            return count;

        }
        public float[] IntersectionPoint(Point p1, Point p2)
        {
            float iPoint1 = -1*((float)(p2.X - p2.Y)/(float)(p1.X-p1.Y));
            float iPoint2 = p1.Y * iPoint1 + p2.Y;
            return new float[] { iPoint1, iPoint2 };
        }
    }
}
