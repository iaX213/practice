using System;

namespace calc 
{
	public class Subtractioncalc : ITwoArgsCalc
	{
		public double Calculate(double x, double y) { return x - y; }
	}
}