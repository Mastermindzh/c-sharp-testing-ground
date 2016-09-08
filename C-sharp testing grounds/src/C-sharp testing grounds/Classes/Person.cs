using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_sharp_testing_grounds.Classes
{
	public class Person
	{

		/* vars */
		public string name;
		readonly DateTime dob;

		/* Constructor */
		public Person(String name, DateTime dob)
		{
			Name = name;
			this.dob = dob;
		}

		public int Age
		{
			get; set;
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					name = value;
				}
				else { name = "NA"; }
			}
		}

		/* Methods */
		public void ChangeName()
		{
			Name = "Sam";
		}

		public void addFiveToAge()
		{
			for (int i = 0; i < 5 - 1; i++)
			{
				Age++;
			}
		}

		public void calculateAge()
		{
			Age = (DateTime.Now - dob).GetYears();
		}
	}

	public static class TimeSpanExtensions
	{
		public static int GetYears(this TimeSpan timespan)
		{
			return (int)((double)timespan.Days / 365.2425);
		}
		public static int GetMonths(this TimeSpan timespan)
		{
			return (int)((double)timespan.Days / 30.436875);
		}
	}
}
