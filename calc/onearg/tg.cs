using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Tgcalc : IOneArgCalc
    {
        public double Calculate(double x) { return Math.Tan(x); }
    }
}
