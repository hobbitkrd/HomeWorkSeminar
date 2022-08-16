
using HomeWorkSeminar.Lesson2;
using HomeWorkSeminar.Lesson3;

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
    hwl3.isPallindromI(16461).ToString(),
    hwl3.TwoPointDistance(new HomeWorkLesson3.Point3d(3,6,8),new HomeWorkLesson3.Point3d(2,4,-3)).ToString(),
    hwl3.CoubTable(5)
};
Console.WriteLine(string.Join("\n", allFuncL3));
#endregion
Console.ReadLine();

