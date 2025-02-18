using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi
{
	public static class HesapMakinesi
	{
		public static void Hesapla(double sayi1, double sayi2, char islem)
		{
			switch (islem)
			{
				case '+': Console.WriteLine("Sonuç: " + (sayi1 + sayi2)); break;
				case '-': Console.WriteLine("Sonuç: " + (sayi1 - sayi2)); break;
				case '*': Console.WriteLine("Sonuç: " + (sayi1 * sayi2)); break;
				case '/':
					if (sayi2 != 0)
						Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
					else
						Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
					break;
				default: Console.WriteLine("Geçersiz işlem!"); break;
			}
		}
	}

}
