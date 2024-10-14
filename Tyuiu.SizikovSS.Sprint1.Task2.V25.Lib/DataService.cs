using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SizikovSS.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {   
            double degree = 57.296;
            return value * degree;
        }
    }
}
