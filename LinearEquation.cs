using System;
using System.Collections.Generic;

namespace Labs
{
    class LinearEquation
    {
        protected List<double> x;
        protected List<double> SolveLinearEquation(double a, double b)// aX+b = 0 -> Linear quation
        {
            if (a == 0)
            {
                throw new Exception("Определено, что такое уравнение не существует");
            }

            return x = new List<double>() { -b / a };
        }
    }

}