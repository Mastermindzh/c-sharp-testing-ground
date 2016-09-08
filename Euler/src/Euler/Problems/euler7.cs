using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.Problems
{
	public class euler7 : problem
	{

		public euler7()
		{
			int primeCount = 0;
			int i = 0;

			while(primeCount <= 10001)
			{
				if (isPrime(i)) {
					primeCount++;
				}
				i++;
			}
			Console.WriteLine(i-1);
		}

		/* Function to check wether number is prime */
		private bool isPrime(long number)
		{
			if (number == 1) return false;
			if (number == 2) return true;

			var boundary = (int)Math.Floor(Math.Sqrt(number));

			for (int i = 2; i <= boundary; ++i)
			{
				if (number % i == 0) return false;
			}
			return true;
		}

	}


}
