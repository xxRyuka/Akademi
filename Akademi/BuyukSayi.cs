using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi
{
	internal static class BuyukSayi
	{
		public static void Bul(int sayi1, int sayi2, int sayi3)
		{
			int enBuyuk;

			if (sayi1 >= sayi2 && sayi1 >= sayi3)
				enBuyuk = sayi1;
			else if (sayi2 >= sayi1 && sayi2 >= sayi3)
				enBuyuk = sayi2;
			else
				enBuyuk = sayi3;

			Console.WriteLine("En büyük sayı: " + enBuyuk);
		}


	}
}
