using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;


namespace elasticsearchCitiesIndex
{

	class Program
	{

		public Program()
		{

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			SqlConnection myConnection = new SqlConnection(
				"user id=sa;" +
				"password=Welkom01!;server=.\\SQLEXPRESS;" +
				"database=localMasterData; " +
				"connection timeout=30"
			);

			try
			{
				myConnection.Open();

				SqlDataReader myReader = null;
				SqlCommand myCommand = new SqlCommand("select * from Place", myConnection);
				myReader = myCommand.ExecuteReader();

				while (myReader.Read())
				{
					if (
						!isEmpty(myReader["Lattitude"]) &&
						!isEmpty(myReader["Longitude"]) &&
						!isEmpty(myReader["DisplayName"])
					)
					{
						var myObject = new location { lat = myReader["Lattitude"].ToString(), lon = myReader["Longitude"].ToString() };
						var myCity = new EsCity { name = myReader["DisplayName"].ToString(), location = myObject };
						PostToElasticSearch(myCity);
					}
					else
					{
						//possibly log, else ignore
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("error" + e.ToString());
			}

			stopWatch.Stop();
			// Get the elapsed time as a TimeSpan value.
			TimeSpan ts = stopWatch.Elapsed;

			// Format and display the TimeSpan value.
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds,
				ts.Milliseconds / 10);
			Console.WriteLine("RunTime " + elapsedTime);

			Console.WriteLine("All done...");
			Console.WriteLine("Press a key to continue.");
			Console.ReadKey();
		}

		private void PostToElasticSearch(object serializableObject)
		{

			var serialized = JsonConvert.SerializeObject(serializableObject);

			var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://vm-infdev4:9200/cities/cities");
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				streamWriter.Write(serialized);
				streamWriter.Flush();
				streamWriter.Close();
			}

			try
			{
				var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
				{
					var result = streamReader.ReadToEnd();
				}
			}
			catch (WebException e)
			{
				using (WebResponse response = e.Response)
				{
					HttpWebResponse httpResponse = (HttpWebResponse)response;
					Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
					using (Stream data = response.GetResponseStream())
					using (var reader = new StreamReader(data))
					{
						string text = reader.ReadToEnd();
						Console.WriteLine(text);
					}
				}
			}
		}

		private Boolean isEmpty(object obj)
		{
			if (String.IsNullOrEmpty(obj.ToString()) || obj.ToString() == "0")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static void Main(string[] args)
		{
			new Program();
		}
	}
}
