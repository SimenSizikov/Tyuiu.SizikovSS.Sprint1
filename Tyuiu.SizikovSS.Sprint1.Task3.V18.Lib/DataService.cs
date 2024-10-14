﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SizikovSS.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            double rect = a * b;
            double sqr = c * c;
            double result =  rect / sqr;
            return Math.Round(result);
        }
    }
}
