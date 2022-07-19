﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyPayment
{
    internal class Month
    {
        public static double Test(double p, int y, double R)
        {
            int n = 12 * y;
            double r = R / 1200;
            return (p * r / (1 - (Math.Pow((1 + r), -n))));
        }
    }
}