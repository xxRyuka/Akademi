using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi
{
	public static class SayininDurumu
	{
		public static void KontrolEt(int sayi)
		{
			if (sayi > 0)
				Console.WriteLine("Girilen sayı pozitiftir.");
			else if (sayi < 0)
				Console.WriteLine("Girilen sayı negatiftir.");
			else
				Console.WriteLine("Girilen sayı sıfırdır.");
		}
	}
}
