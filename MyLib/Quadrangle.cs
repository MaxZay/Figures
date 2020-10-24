using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyLib
{
    public class Quadrangle : Figure
    {
        public Quadrangle()
        {
            Points = new double[8];
        }
        public override void Area()
        {
            double xImulY = Points[0] * Points[3] + Points[2] * Points[5] + Points[4] * Points[7];
            double yImulX = Points[1] * Points[2] + Points[3] * Points[4] + Points[5] * Points[6];
            FigureArea = (yImulX - xImulY) / 2;
        }
        public override void Perimeter()
        {
            List<double> sides = new List<double>();
            sides = GetSides();
            FigurePerimeter = sides.Sum();
        }

        private List<double> GetSides()
        {
            List<double> sides = new List<double>();
            double a = Math.Pow((Math.Pow((Points[2] - Points[0]), 2) + Math.Pow((Points[3] - Points[1]), 2)), 0.5);
            double b = Math.Pow((Math.Pow((Points[4] - Points[2]), 2) + Math.Pow((Points[5] - Points[3]), 2)), 0.5);
            double c = Math.Pow((Math.Pow((Points[6] - Points[4]), 2) + Math.Pow((Points[7] - Points[5]), 2)), 0.5);
            double d = Math.Pow((Math.Pow((Points[0] - Points[6]), 2) + Math.Pow((Points[1] - Points[7]), 2)), 0.5);
            sides.Add(a);
            sides.Add(b);
            sides.Add(c);
            sides.Add(d);
            return sides;
        }
    }
}
