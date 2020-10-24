using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyLib
{
    public class Polygon : Figure
    {
        public Polygon(int size)
        {
            Points = new double[size];
        }

        public override void Area()
        {
            double xImulY = GetXImulY();
            double yImulX = GetYImulX();
            FigureArea = (yImulX - xImulY) / 2;
        }

        public override void Perimeter()
        {
            List<double> sides = GetSides();
            FigurePerimeter = sides.Sum();
        }

        private double GetXImulY()
        {
            double xImulY = 0;
            for(int i = 0; i + 4 <= Points.Length; i += 2)
            {
                xImulY += Points[i] * Points[i + 3];
            }

            return xImulY;
        }

        private double GetYImulX()
        {
            double yImulX = 0;
            for(int i = 1; i + 2 <= Points.Length; i += 2)
            {
                double x = Points[i];
                double y = Points[i + 1];
                yImulX += Points[i] * Points[i + 1];
            }

            return yImulX;
        }

        private List<double> GetSides()
        {
            List<double> sides = new List<double>();
            for(int i = 0; i + 4 <= Points.Length; i += 2)
            {
               sides.Add(Math.Pow((Math.Pow((Points[i + 2] - Points[i]), 2) + Math.Pow((Points[i + 3] - Points[i + 1]), 2)), 0.5));
            }           
            return sides;
        }
    }
}
