using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    abstract public class Figure
    {
        public double[] Points;

        public string Name;

        public double FigureArea;

        public double FigurePerimeter;

        abstract public void Area();
        abstract public void Perimeter();
    }
}
