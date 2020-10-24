using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MyLib
{
    public class File
    {
        public static List<Figure> ReadFromFile(string path)
        {
            List<Figure> figures = new List<Figure>();
            Circle circle;
            Ellipse ellipse;
            Triangle triangle;
            Quadrangle quadrangle;
            Polygon polygon;
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = line.Split(" ");
                        if(str[0] == "Circle")
                        {
                            circle = CreateCircle(str);
                            figures.Add(circle);
                        }
                        if(str[0] == "Ellipse")
                        {
                            ellipse = CreateEllipse(str);
                            figures.Add(ellipse);
                        }
                        if(str[0] == "Triangle")
                        {
                            triangle = CreateTriangle(str);
                            figures.Add(triangle);
                        }
                        if(str[0] == "Quadrangle" || str[0] == "Trapeze" || str[0] == "Parallelogram")
                        {
                            quadrangle = CreateQuadrangle(str);
                            figures.Add(quadrangle);
                        }
                        if(str[0] == "Polygon")
                        {
                            polygon = CreatePolygon(str);
                            figures.Add(polygon);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return figures;
        }

        private static Circle CreateCircle(string[] str)
        {
            Circle circle = new Circle()
            {
                Name = str[0]
            };
            circle.Points[0] = double.Parse(str[1]);
            circle.Points[1] = double.Parse(str[2]);
            circle.Points[2] = double.Parse(str[3]);
            circle.Points[3] = double.Parse(str[4]);
            circle.Area();
            circle.Perimeter();

            return circle;
        }

        private static Ellipse CreateEllipse(string[] str)
        {
            Ellipse ellipse = new Ellipse()
            {
                Name = str[0]
            };

            ellipse.Points[0] = double.Parse(str[1]);
            ellipse.Points[1] = double.Parse(str[2]);
            ellipse.Points[2] = double.Parse(str[3]);
            ellipse.Points[3] = double.Parse(str[4]);
            ellipse.Points[4] = double.Parse(str[5]);
            ellipse.Points[5] = double.Parse(str[6]);
            
            ellipse.Area();
            ellipse.Perimeter();

            return ellipse;
        }

        private static Triangle CreateTriangle(string[] str)
        {
            Triangle triangle = new Triangle()
            {
                Name = str[0]
            };

            triangle.Points[0] = double.Parse(str[1]);
            triangle.Points[1] = double.Parse(str[2]);
            triangle.Points[2] = double.Parse(str[3]);
            triangle.Points[3] = double.Parse(str[4]);
            triangle.Points[4] = double.Parse(str[5]);
            triangle.Points[5] = double.Parse(str[6]);

            triangle.Area();
            triangle.Perimeter();

            return triangle;
        }

        private static Quadrangle CreateQuadrangle(string[] str)
        {
            Quadrangle quadrangle = new Quadrangle()
            {
                Name = str[0]
            };

            quadrangle.Points[0] = double.Parse(str[1]);
            quadrangle.Points[1] = double.Parse(str[2]);
            quadrangle.Points[2] = double.Parse(str[3]);
            quadrangle.Points[3] = double.Parse(str[4]);
            quadrangle.Points[4] = double.Parse(str[5]);
            quadrangle.Points[5] = double.Parse(str[6]);
            quadrangle.Points[6] = double.Parse(str[7]);
            quadrangle.Points[7] = double.Parse(str[8]);

            quadrangle.Area();
            quadrangle.Perimeter();

            return quadrangle;
        }

        private static Polygon CreatePolygon(string[] str)
        {
            Polygon polygon = new Polygon(str.Length - 1)
            {
                Name = str[0]
            };

            for(int i = 0; i + 1 <= polygon.Points.Length; i++)
            {
                polygon.Points[i] = double.Parse(str[i + 1]);
            }
            polygon.Area();
            polygon.Perimeter();

            return polygon;
        }
    }
}