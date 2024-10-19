﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SizikovSS.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double z = ((Math.Sin(x * x) + y) / (y + 1)) - (((x * y) - 12) / (34 + (x * x)));
            return Math.Round(z,3);
        }
    }
}
