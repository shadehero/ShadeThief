using System;
using HtmlAgilityPack;
using System.Collections.Generic;
namespace ShadeThief
{
	public class MainPage
	{
		public string Adress;

		private string COMPANY_XPATH = "/html/body/div/div/div/div";

		HtmlDocument Document;
		HtmlWeb _Web;

		public MainPage(string adress)
		{
			Adress = adress;
		}

		public void Download()
		{
			_Web = new HtmlWeb();
			Document = _Web.Load(Adress);
		}

		public bool IsEmpty()
		{
			var xPath = "/html/body/div/div/h1";
			var node = Document.DocumentNode.SelectSingleNode(xPath);

			Console.WriteLine(node.InnerText);
			Console.ReadKey();
			return true;
		}

		public List<Company> FindCompanies()
		{
			List<Company> cList = new List<Company>();

			try
			{
				var company_nodes = Document.DocumentNode.SelectNodes(COMPANY_XPATH);
				foreach (var company_node in company_nodes)
				{
					if (company_node.Attributes["class"].Value == "lista")
					{
						Company c = new Company();

						// Info
						c.Info = company_node.FirstChild.InnerText;


						// Name
						c.Name = company_node.FirstChild.LastChild.InnerText;

						// LocalWebsite
						c.LocalWebsite = @"http://bazafirm.e-gratka.info/" + company_node.FirstChild.LastChild.FirstChild.Attributes["href"].Value;

						// Adress
						string adress_1 = company_node.ChildNodes[1].FirstChild.InnerText;
						string adress_2 = company_node.ChildNodes[1].LastChild.InnerText;
						c.Adress = adress_1 + " / " + adress_2;

						// Repair
						company_node.ChildNodes.Remove(1);

						// Phone
						c.Phone = company_node.ChildNodes[2].FirstChild.InnerText.Split(':')[1].Trim();

						// Email
						c.Email = company_node.ChildNodes[2].LastChild.InnerText.Split(':')[1].Trim();

						// Descryption
						c.Description = company_node.LastChild.InnerText;

						cList.Add(c);
					}
				}

				return cList;
			}
			catch
			{
				return cList;
			}
		}
	}
}
