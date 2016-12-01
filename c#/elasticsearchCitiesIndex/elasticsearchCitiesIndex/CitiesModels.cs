using System;

namespace elasticsearchCitiesIndex
{
	class EsCity
	{
		public string name { get; set; }
		public string foundedAt = null;
		public location location { get; set; }
	}


	class location
	{

		private string lattitude = "";
		public string lat
		{
			get
			{
				return lattitude;
			}
			set
			{
				if (!String.IsNullOrEmpty(value))
				{
					lattitude = createCoord(value);
				}
			}
		}

		private string longitude = "";
		public string lon
		{
			get
			{
				return longitude;
			}
			set
			{
				if (!String.IsNullOrEmpty(value))
				{
					longitude = createCoord(value);
				}
			}
		}

		public String createCoord(String str)
		{
			try
			{
				if (str.Length > 2)
				{
					string sub = str.Substring(0, 2);

					string last = str.Substring(2);
					return sub + "." + last;
				}
				else
				{
					return str;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("String value: " + str);
				Console.WriteLine("Error: " + e.Message);
				return "";
			}

		}

	}
}
