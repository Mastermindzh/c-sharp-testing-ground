using System;

namespace Classes
{
	public class Calculator
	{
		public int Add(int a, int b) { return a + b; }
		public double Add(double a, double b) { return a + b; }
		public int Subtract(int a, int b) { return a - b; }
		public int Multiply(int a, int b) { return a * b; }
		public int Divide(int value, int by)
		{
			if (value > 100)
			{
				#pragma warning disable RECS0163 // Suggest the usage of the nameof operator
				throw new ArgumentOutOfRangeException("value");
				#pragma warning restore RECS0163 // Suggest the usage of the nameof operator
			}

			return value / by;
		}
	}
}
