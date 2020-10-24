using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyLib
{
    public class Triangle : Figure
    {
        public Triangle()
        {
            Points = new double[6];
        }

        public override void Area()
        {
            List<double> sides = new List<double>();
            sides = GetSides();
            double semiPerimeter = sides.Sum() / 2;
            FigureArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));

        }

        private List<double> GetSides()
        {
            List<double> sides = new List<double>();
            double ab = Math.Pow((Math.Pow((Points[2] - Points[0]), 2) + Math.Pow((Points[3] - Points[1]), 2)), 0.5);
            double bc = Math.Pow((Math.Pow((Points[4] - Points[2]), 2) + Math.Pow((Points[5] - Points[3]), 2)), 0.5);
            double ca = Math.Pow((Math.Pow((Points[0] - Points[4]), 2) + Math.Pow((Points[1] - Points[5]), 2)), 0.5);
            sides.Add(ab);
            sides.Add(bc);
            sides.Add(ca);
            return sides;            
        }

        public override void Perimeter()
        {
            List<double> sides = GetSides();
            FigurePerimeter = sides.Sum();
        }
    }
}
