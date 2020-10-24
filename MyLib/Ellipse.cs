using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Ellipse : Figure
    {
        public Ellipse()
        {
            Points = new double[6];
        }
        public override void Area()
        {
            List<double> sides = GetSides();
            FigureArea = sides[0] * sides[1] * Math.PI;
        }
        public override void Perimeter()
        {
            List<double> sides = GetSides();
            FigurePerimeter = 4 * ((Math.PI * sides[1] * sides[0] + (sides[1] - sides[0])) / (sides[1] + sides[0]));
        }
        private List<double> GetSides()
        {
            List<double> sides = new List<double>();
            double a = Math.Pow((Math.Pow((Points[2] - Points[0]), 2) + Math.Pow((Points[3] - Points[1]), 2)), 0.5);
            double b = Math.Pow((Math.Pow((Points[4] - Points[0]), 2) + Math.Pow((Points[5] - Points[1]), 2)), 0.5);
            sides.Add(a);
            sides.Add(b);
            return sides;
        }
    }
}
