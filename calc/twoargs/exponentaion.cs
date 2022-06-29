using System;

namespace calc 
{
	public class Exponentationcalc : ITwoArgsCalc
	{
		public double Calculate(double x, double y) { return Math.Pow(x, y); }
	}
}