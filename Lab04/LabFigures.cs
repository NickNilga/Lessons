using System;
using System.Collections.Generic;
using System.Globalization;
using Lab04.Figures;

namespace Lab04
{
    public static class LabFigures
    {
        public static void Execute()
        {

            List<Figure> scene = new List<Figure>();

            scene.Add(new Circle(10));
            scene.Add(new Square(16));
            scene.Add(new Rectangle(5, 15));

            foreach (Figure item in scene)
            {
                Console.Out.WriteLine(item);
                Console.Out.WriteLine(item.GetArea());
            }

        }

        private static double FindAvg(List<Figure> figures)
        {
            double sum = 0;
            
            foreach (Figure figure in figures)
            {
                sum += figure.GetArea();
            }

            return sum / figures.Count;
        }
    }
}