using System;

namespace Classes
{
	public class SpecialDateStore
	{
		public DateTime DateOf(string specialDate)
		{
			switch (specialDate)
			{
				case "millennium":
					return new DateTime(2000, 1, 1, 0, 0, 0, 0);
				default:
					#pragma warning disable RECS0163 // Suggest the usage of the nameof operator
					throw new ArgumentOutOfRangeException("specialDate");
					#pragma warning restore RECS0163 // Suggest the usage of the nameof operator
			}
		}
	}
}
