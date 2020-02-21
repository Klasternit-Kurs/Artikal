using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikalNeeeee
{
	class Program
	{
		static void Main(string[] args)
		{
			Artikal a = new Artikal();

			Console.Write("Unesite sifru: ");
			a.sifru = Console.ReadLine();
			Console.Write("Unesite naziv: ");
			a.naziv = Console.ReadLine();
			Console.Write("Unesite ulaznu cenu: ");
			a.uCenu = decimal.Parse(Console.ReadLine());
			Console.Write("Unesite marzu: ");
			a.marza = int.Parse(Console.ReadLine());

			/*Console.Write("Unesite sifru: ");
			string sifra = Console.ReadLine();
			Console.Write("Unesite naziv: ");
			string naziv = Console.ReadLine();
			Console.Write("Unesite ulaznu cenu: ");
			decimal uc = decimal.Parse(Console.ReadLine());
			Console.Write("Unesite marzu: ");
			int m = int.Parse(Console.ReadLine());

			Artikal a = new Artikal(sifra, naziv, uc, m);*/


			Console.WriteLine( a.IzlaznaCena());
			Console.ReadKey();
		}
	}

	class Artikal
	{
		public string sifru, naziv;
		public decimal uCenu;
		public int marza;

		public Artikal(string s, string n, decimal uC, int m)
		{
			sifru = s;
			naziv = n;
			uCenu = uC;
			marza = m;
		}

		public Artikal() { }

		public decimal IzlaznaCena()
		{                       
			return uCenu * (1 + (decimal)marza / 100);
		}
	}
}
