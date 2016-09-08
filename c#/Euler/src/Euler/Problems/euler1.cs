using Euler.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler
{
	public class euler1 : problem
	{

		public euler1() {
			/*
				If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
				Find the sum of all the multiples of 3 or 5 below 1000.
			 */
			int startAt = 1000;


			for (int i = 0; i < startAt; i++)
			{
				if (isMultipleOf3And5(i))
				{
					answer += i;
				}
			}

			Console.WriteLine(answer);
		}

		private bool isMultipleOf3And5(int a)
		{
			return MathMethods.isMultipleOf(a, 3) || MathMethods.isMultipleOf(a, 5);
		}

	}
}
