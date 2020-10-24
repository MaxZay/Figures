using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyLib
{
    public class Processing
    {
        public static List<Figure> figures
        {
            get
            {
                return File.ReadFromFile(@"C:\Users\maxim\Documents\EPAM\Task\MyLib\Data.txt");
            }
        }

        public static double FindAveragePerimeter()
        {
            return figures.Average(o => o.FigurePerimeter);
        }

        public static double FindAverageArea()
        {
            return figures.Average(o => o.FigureArea);
        }

        public static Figure FindFigureWithMaxArea()
        {
            Figure figure;
            figure = figures.Single(o => o.FigureArea == figures.Select(i => i.FigureArea).Max());
            return figure;
        }

        public static string FindTypeOfFigureWithMaxPerimeter()
        {
            string maxType = "";
            List<string> types = figures.Select(o => o.Name).Distinct().ToList();
            double maxAveragePerimeter = figures.Where(i => i.Name == types[0]).Select(o => o.FigurePerimeter).Average(), averagePerimeter = 0;
            foreach (string type in types)
            {
                averagePerimeter = figures.Where(i => i.Name == type).Select(o => o.FigurePerimeter).Average();
                if (averagePerimeter > maxAveragePerimeter)
                {
                    maxType = type;
                    maxAveragePerimeter = averagePerimeter;
                }
            }
            return maxType;
        }
    }
}
