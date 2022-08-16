
using HomeWorkSeminar.Lesson2;
using HomeWorkSeminar.Lesson3;
using HomeWorkSeminar.Lesson4;

#region HWL2
var hwl2 = new HomeWorkLesson2();
var allFunc = new string[3] { hwl2.SecondNum(367), hwl2.TNum(3232), hwl2.isWeekend(6) };
Console.WriteLine(string.Join("\n", allFunc));
#endregion
#region HWL3

var hwl3 = new HomeWorkLesson3();
var allFuncL3 = new string[]
{
    hwl3.isPallindromS(16461).ToString(),
    hwl3.isPallindromI(16416).ToString(),
    hwl3.TwoPointDistance(new HomeWorkLesson3.Point3d(3,6,8),new HomeWorkLesson3.Point3d(2,4,-3)).ToString(),
    hwl3.CoubTable(5)
};
Console.WriteLine(string.Join("\n", allFuncL3));
#endregion
#region HWL4
var hwl4 = new HomeWorkLesson4();
var allFuncL4 = new string[]
{
    hwl4.MyPow(2, 4).ToString(),
    hwl4.NumSum(9012).ToString(),
    string.Join(" ", hwl4.GenerateRandArray(100)),
    string.Join(" ", hwl4.GenerateRandArray(2, 0, 10)),
    hwl4.UnivConvert(10.8f),
    hwl4.BinaryToInt(1010).ToString(),
};
Console.WriteLine(string.Join("\n", allFuncL4));
#endregion

Console.ReadLine();

