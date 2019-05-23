using System;
using System.Drawing;
using Console = Colorful.Console;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ShadeThief
{
	class MainClass
	{
		static int page_count = 1;

		public static void Main(string[] args)
		{
			Console.WriteAscii("SHADE THIEF", Color.Tomato);

			while (true)
			{
				MainPage page = new MainPage(LinkGenerator.FromRegion(Region.caly_kraj, page_count));
				page.Download();
			
				List<Company> companiesList = page.FindCompanies();
			
				if (companiesList.Count != 0)
				{
					foreach (Company c in companiesList)
					{
						string json = c.ToJson();

						// Directory
						if (!Directory.Exists("Companies")) { Directory.CreateDirectory("Companies"); }

						// Create Path
						Console.WriteLine(c.Name);
						string name = CreateFileName(c.Name);
						string path = "Companies/" + GetDirectoryName(name) + "/" + name + ".json";

						// Create Directory
						if (!Directory.Exists(path)) { Directory.CreateDirectory("Companies/" + GetDirectoryName(name)); }

						// Save File
						File.WriteAllText(path, c.ToJson());
					}
				}
				else
				{
					Console.WriteLine("Pusto");
				}
				page_count++;
			}
		}

		static string CreateFileName(string name)
		{
			// regex
			string clear = Regex.Replace(name, "[^a-zA-Z0-9_]+", "_", RegexOptions.Compiled);

			if (clear.Length > 64)
			{
				clear = Path.GetRandomFileName();
				return clear;
			}

			return clear;
		}

		static string GetDirectoryName(string name)
		{
			switch (name[0].ToString().ToLower())
			{
				case "a": return "A";
				case "b": return "B";
				case "c": return "C";
				case "d": return "D";
				case "e": return "E";
				case "f": return "F";
				case "g": return "G";
				case "h": return "H";
				case "i": return "I";
				case "j": return "J";
				case "k": return "K";
				case "l": return "L";
				case "m": return "M";
				case "n": return "N";
				case "o": return "O";
				case "p": return "P";
				case "r": return "R";
				case "s": return "S";
				case "t": return "T";
				case "u": return "U";
				case "w": return "W";
				case "x": return "X";
				case "y": return "Y";
				case "z": return "Z";
				default: return "OTHER";
			}
		}
	}
}
