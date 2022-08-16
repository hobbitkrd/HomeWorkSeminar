using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson4
{
    internal class HomeWorkLesson4
    {
        public int MyPow(int A, int B)
        {
            var newA = A * A;
            for (int i = 1; i < B - 1; i++) newA *= A;
            return newA;
        }
        public int NumSum(int num)
        {
            var charnun = num.ToString()
                            .ToCharArray();
            var result = 0;
            foreach (int n in charnun) result += n;
            return result;
        }
        public int[] GenerateRandArray(int maxValue, int minValue = 0, int leght= 8)
        { 
            var rand = new Random();
            var randArray = new int[leght];
            for (int el=0;el< leght;el++) randArray[el] = rand.Next(minValue,maxValue);
            return randArray;
        }

        public int BinaryToInt(int binary)
        {
            return Convert.ToInt32(binary.ToString(),2);
        }
        public string UnivConvert(float num)
        {
            var splited = num.ToString().Split(",");
            return Convert.ToString(int.Parse(splited[0]),int.Parse(splited[1]));

        }
    }
}
