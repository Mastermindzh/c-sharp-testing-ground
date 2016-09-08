using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.Shared
{
    public static class MathMethods
    {
		/// <summary>
		/// Check if supplied number is a prime
		/// </summary>
		/// <param name="number"> Number to be checked. </param>
		/// <returns>True if number is a prime, flase if not.</returns>
		public static bool isPrime(long number) {
			if (number == 1) return false;
			if (number == 2) return true;

			int boundary = (int)Math.Floor(Math.Sqrt(number));

			for (int i = 2; i <= boundary; ++i)
			{
				if (number % i == 0) return false;
			}

			return true;
		}

		/// <summary>
		/// Checks wether a number is a multiple of another number
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool isMultipleOf(int a, int b)
		{
			if (a % b == 0) { return true; } else { return false; }
		}

		/// <summary>
		/// Checks wether a number is a palindrome
		/// </summary>
		/// <param name="Number">Number to be checked (as String)</param>
		/// <returns>True if number is a palindrome, false if it isn't</returns>
		public static bool isPalinDrome(String Number)
		{
			return Number == new String(Number.Reverse().ToArray());
		}


		/// <summary>
		/// returns a number of digits
		/// </summary>
		/// <param name="amount">Number of digits you want</param>
		/// <param name="digit">The digit you want, defaults to 9</param>
		/// <returns></returns>
		public static int nrOfDigits(int amount, int digit = 9)
		{
			String str = "";
			for (int i = 0; i < amount; i++)
			{
				str += digit;
			}
			return Int32.Parse(str);
		}

		/// <summary>
		/// Check wether number is divisible by a range from 1 till.....
		/// </summary>
		/// <param name="number">Number to be checked</param>
		/// <param name="boundary">Higest number in the range you want to check.</param>
		/// <returns></returns>
		public static bool isDivisibleByRange(int number, int boundary)
		{
			for (int i = 2; i < boundary; i++)
			{
				if (!(number % i == 0))
				{
					return false;
				}
			}
			return true;
		}

	}
}
