using Euler.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler
{
    public class euler3 : problem
    {
		public euler3()
		{
			/*
				The prime factors of 13195 are 5, 7, 13 and 29.
				What is the largest prime factor of the number 600851475143 ?
			 */
			const long numm = 600851475143;

			long largestFact = 0;

			

			for (long i = 2; i * i < numm; i++)
			{
				if (numm % i == 0)
				{
					if (MathMethods.isPrime(i) && i > largestFact) {
						largestFact = i;
					}
				}
			}

			Console.WriteLine(largestFact);
		}


	}
}
