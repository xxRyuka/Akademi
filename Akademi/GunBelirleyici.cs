using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi
{
	public static class GunBelirleyici
	{
		public static void GunBul(int gun)
		{
			switch (gun)
			{
				case 1: Console.WriteLine("pazartesi"); break;
				case 2: Console.WriteLine("salı"); break;
				case 3: Console.WriteLine("carşamba"); break;
				case 4: Console.WriteLine("perşembe"); break;
				case 5: Console.WriteLine("cuma"); break;
				case 6: Console.WriteLine("cumartesi"); break;
				case 7: Console.WriteLine("pazar"); break;
				default: Console.WriteLine("eçersiz giriş!"); break;
			}
		}
	}
}
