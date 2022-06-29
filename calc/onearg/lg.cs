using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Lgcalc : IOneArgCalc
    {
        public double Calculate(double x) { return Math.Log10(x); }
    }
}