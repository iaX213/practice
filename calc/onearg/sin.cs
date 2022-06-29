using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Sincalc : IOneArgCalc
    {
        public double Calculate(double x) { return Math.Sin(x); }
    }
}
