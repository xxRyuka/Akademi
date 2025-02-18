using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BuyukSayi.Bul(1, 2, 5);
			GunBelirleyici.GunBul(1);
			HesapMakinesi.Hesapla(1, 6, '*');
			SayininDurumu.KontrolEt(9);

            Console.WriteLine("\n ------");

			PasswordControl.Check("abi");
			Console.ReadLine();
		}
	}
}
