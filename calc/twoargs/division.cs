using System;

namespace calc
{
	public class Divisioncalc : ITwoArgsCalc
	{
		public double Calculate(double x, double y) { return x / y; }
	}
}