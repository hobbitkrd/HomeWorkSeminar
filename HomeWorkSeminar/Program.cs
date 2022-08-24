using HomeWorkSeminar.Lesson5;
using HomeWorkSeminar.Lesson6;
using System.Drawing;

var hw5 = new HomeWorkLesson5();
var hw6 = new HomeWorkLesson6();

var randEven = hw5.evenNumCount();
var even = hw5.evenNumCount(new int[] { 345, 897, 568, 234 });
var evenSum = hw5.evenPosition();
var minmax = hw5.MinMax();

Console.WriteLine("Введите любое количество чисел через пробел:");
var numArray = Console.ReadLine();
Console.WriteLine($"Кол-во чисел больше нуля: {hw6.OverZero(numArray)}");

var iPoint = hw6.IntersectionPoint(new Point(6, 5), new Point(4, 6));
Console.WriteLine(string.Join(" ",iPoint));

Console.ReadLine();
