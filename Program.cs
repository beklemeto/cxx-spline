using System;
using System.Collections.Generic;

namespace SplineAlgorithmConverted
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<float> pixels = new List<float>(){ 0, 48, 246, 449, 514, 649, 683 };
            List<float> values = new List<float>(){ 149, 149, 172, 160, 172, 127, 138 };

            CubicSpline default_spline = new CubicSpline(pixels, values, BoundaryConditions.NotAKnot);
            CubicSpline natural_spline = new CubicSpline(pixels, values, BoundaryConditions.Natural);

            for (float i = 0; i < 700; i++)
            {
                Console.WriteLine(i+ " "+ natural_spline.GetValue(i));
            }

        }
    }
}
