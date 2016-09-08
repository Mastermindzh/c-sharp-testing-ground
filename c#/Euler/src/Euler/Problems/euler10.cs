using Euler.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.Problems
{
	public class euler10 : problem
	{
		/*
			The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
			Find the sum of all the primes below two million.
		 */

		public euler10()
		{
			int boundary = 2000000;

			long sum = 0;

			for (int i = 0; i < boundary; i++)
			{
				if (MathMethods.isPrime(i))
				{
					sum += i;
				}      
			}

			Console.WriteLine(sum);
		}

	}         
}
              
