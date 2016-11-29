namespace elasticsearchCitiesIndex
{
	class EsCity
	{
		//string json = "{\"name\": \"IMMINGHAMPOSTding\",\"location\": {\"lat\":53.6140,\"lon\":0.2159},\"foundedAt\":\"2015-05-21T15:37:11\"}";
		public string name { get; set; }
		public string foundedAt = null;

		public location location { get; set; }


	}
}
