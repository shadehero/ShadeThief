using System;
namespace ShadeThief
{
	public class LinkGenerator
	{
		public static string FromCategory(Category category,int page)
		{
			string c_link = "http://bazafirm.e-gratka.info/branza/";

			switch (category)
			{
				case Category.bankowosc_i_finanse: c_link += "bankowość+i+finanse"; break;
				case Category.budownictwo_i_architektura: c_link += "budownictwo+i+architektura"; break;
				case Category.internet_i_komputery: c_link += "internet+i+komputery"; break;
				case Category.kursy_i_szkolenia: c_link += "kursy+i+szkolenia";break;
				case Category.marketing_i_reklama: c_link += "marketing+i+reklama"; break;
				case Category.media: c_link += "media"; break;
				case Category.medycyna: c_link += "medycyna"; break;
				case Category.nieruchomosci: c_link += "nieruchomości"; break;
				case Category.pozostale: c_link += "pozostale"; break;
				case Category.produkcja_i_przemysl: c_link += "produkcja+i+przemysł"; break;
				case Category.rolnictwo_i_gornictwo: c_link += "rolnictwo+i+ogrodnictwo/"; break;
				case Category.rozrywka: c_link += "rozrywka";break;
				case Category.sklepy_i_hurtownie: c_link += "sklepy+i+hurtownie"; break;
				case Category.sport: c_link += "sport"; break;
				case Category.telekomunikacja: c_link += "telekomunikacja"; break;
				case Category.transport_i_spedycja: c_link += "transport+i+spedycja/"; break;
				case Category.turystyka_i_wypoczynek: c_link += "urystyka+i+wypoczynek/"; break;
				case Category.uslugi_rozne: c_link += "usługi+różne/"; break;
			}

			return c_link + "/" + page;
		}

		public static string FromRegion(Region region,int page)
		{
			string c_link = "http://bazafirm.e-gratka.info/region/";

			switch (region)
			{
				case Region.caly_kraj: c_link += "cały+kraj"; break;
				case Region.dolnoslaskie: c_link += "dolnośląskie"; break;
				case Region.kujawsko_pomorskie: c_link += "kujawsko-pomorskie"; break;
				case Region.lodzkie: c_link += "łódzkie"; break;
				case Region.lubelskie: c_link += "lubuskie"; break;
				case Region.lubuskie: c_link += "lubuskie"; break;
				case Region.malopolskie: c_link += "małopolskie"; break;
				case Region.mazowieckie: c_link += "mazowieckie"; break;
				case Region.opolskie: c_link += "opolskie"; break;
				case Region.podkarpacie: c_link += "podkarpacie"; break;
				case Region.podlaskie: c_link += "podlaskie"; break;
				case Region.pomorskie: c_link += "pomorskie"; break;
				case Region.slaskie: c_link += "slaskie"; break;
				case Region.swietokrzyskie: c_link += "świętokrzyskie"; break;
				case Region.warmijsko_mazurskie: c_link += "warmińsko-mazurskie"; break;
				case Region.wielkopolskie: c_link += "wielkopolskie"; break;
				case Region.zachodniopomorskie: c_link += "zachodniopomorskie"; break;
			}

			return c_link += "/" + page;
		}
	}
}
