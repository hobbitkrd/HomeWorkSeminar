using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson5;

internal class HomeWorkLesson5
{
    public HomeWorkLesson5()
    {
        GenRandArray();
    }
    private int[] randArray { get; set; }
    public int evenNumCount(int[] yourArray)
    {
        int count = 0;
        foreach (var el in yourArray)
        {
            count += el % 2 == 0 ? 1 : 0;
        }
        return count;
    }
    public int evenNumCount()
    {
        int count = 0;
        foreach (var el in randArray)
        {
            count += el % 2 == 0 ? 1 : 0;
        }
        return count;

    }
    public int evenPosition()
    {
        int evenPosSum = 0;
        for (int i = 0; i < randArray.Length; i++)
        {
            if (i != 0 && i % 2 == 0) evenPosSum += randArray[i];
        }
        return evenPosSum;
    }
    public int MinMax()
    {
        randArray = randArray
            .OrderBy(x => x)
            .ToArray();
        return randArray.Last() - randArray[0];
    }


    private void GenRandArray()
    {
        var rand = new Random();
        randArray = new int[20];
        for (int i = 0; i < randArray.Length; i++)
        {
            randArray[i] = rand.Next(100, 999);
        }

    }
}
