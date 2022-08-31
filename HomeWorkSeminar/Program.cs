using HomeWorkSeminar.Lesson7;

var hw7 = new HomeWorkLesson7();
hw7.MXArray(3, 4);
var rndResult = hw7.mX;
var resIncludedElement = rndResult.isIncludet(0, 3) == 0 ? "Такого элемента не существует" : rndResult.isIncludet(0, 3).ToString();
var averageResult=hw7.Average(3, 4);


Console.ReadLine();
