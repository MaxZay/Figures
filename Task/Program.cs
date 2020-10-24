using System;
using MyLib;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Средний периметр всех фигур: " + $"{Processing.FindAveragePerimeter():F2}");
            Console.WriteLine("Средняя площадь всех фигур: " + $"{Processing.FindAverageArea():F2}");
            Figure figure = Processing.FindFigureWithMaxArea();
            Console.WriteLine("Фигура с наибольшой площадью: " + figure.Name + "  " + $"{figure.FigureArea:F2}");
            Console.WriteLine("Тип фигур с ниобольшим значением среднего периметра: " + Processing.FindTypeOfFigureWithMaxPerimeter());
            Console.ReadKey();
        }
    }
}
