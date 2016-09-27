using System;

namespace regionInfoLookupTest
{
	class Program
	{
		static void Main(string[] args)
		{

			// one liner
			Console.WriteLine(new System.Globalization.RegionInfo("NL").DisplayName);

			Console.WriteLine();
			Console.WriteLine("=========");
			Console.WriteLine();

			System.Globalization.RegionInfo region = new System.Globalization.RegionInfo("NL");
			Console.WriteLine("Name:                         {0}", region.Name);
			Console.WriteLine("DisplayName:                  {0}", region.DisplayName);
			Console.WriteLine("EnglishName:                  {0}", region.EnglishName);
			Console.WriteLine("IsMetric:                     {0}", region.IsMetric);
			Console.WriteLine("ThreeLetterISORegionName:     {0}", region.ThreeLetterISORegionName);
			Console.WriteLine("ThreeLetterWindowsRegionName: {0}", region.ThreeLetterWindowsRegionName);
			Console.WriteLine("TwoLetterISORegionName:       {0}", region.TwoLetterISORegionName);
			Console.WriteLine("CurrencySymbol:               {0}", region.CurrencySymbol);
			Console.WriteLine("ISOCurrencySymbol:            {0}", region.ISOCurrencySymbol);
			Console.ReadLine();
		}
	}
}
