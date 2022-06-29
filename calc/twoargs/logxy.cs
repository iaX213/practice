using System;

namespace calc 
{
	public class Logxycalc : ITwoArgsCalc
	{
		public double Calculate(double x, double y) { return Math.Log(y, x); }
	}
}