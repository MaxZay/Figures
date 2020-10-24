using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Circle : Figure
    {
        public Circle()
        {
            Points = new double[4];
        }
        public override void Area()
        {
            FigureArea = Math.Pow(GetRadious(), 2) * Math.PI;
        }

        public override void Perimeter()
        {
            FigurePerimeter = 2 * Math.PI * GetRadious();
        }

        public double GetRadious()
        {
            double radious = Math.Pow((Math.Pow((Points[2] - Points[0]), 2) + Math.Pow((Points[3] - Points[1]), 2)), 0.5);;
            return radious;
        }
    }
}
