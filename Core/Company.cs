using System;
using Newtonsoft.Json;
using System.IO;

namespace ShadeThief
{
	public class Company
	{
		public string Info;
		public string Name;
		public string Adress;
		public string Description;
		public string LocalWebsite;
		public string Website;
		public string Phone;
		public string Email;

		public static Company FromJson(string jsonText)
		{
			return JsonConvert.DeserializeObject<Company>(jsonText);
		}

		public static Company FromFile(string file)
		{
			string jsonText = File.ReadAllText(file);
			return JsonConvert.DeserializeObject<Company>(jsonText);
		}

		public string ToJson()
		{
			return JsonConvert.SerializeObject(this.MemberwiseClone());
		}
	}
}
