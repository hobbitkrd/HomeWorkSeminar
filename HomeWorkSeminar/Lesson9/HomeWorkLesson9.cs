using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson9
{
    internal class HomeWorkLesson9
    {
        public List<int> NaturalNumRange(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
                result.Add(i);
            return result;

        }
        public int NaturalNumSum(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
                result.Add(i);
            return result.Sum();

        }
        public int Ack(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return Ack(m - 1, 1);
            else return Ack(m - 1, Ack(m, n - 1));
        }
    }
}
