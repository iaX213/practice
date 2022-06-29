using System;

namespace calc
{
	public class Additionalcalc : ITwoArgsCalc
	{
		public double Calculate(double x, double y) 
		{
			return x + y; 
		}
	}
}