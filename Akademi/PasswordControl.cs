using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi
{
	public static class PasswordControl
	{
		public static void Check(string password)
		{
			if (!string.IsNullOrEmpty(password)) // Eger Bos Değilse 
			{
				int lenght = password.Length;

				char[] chars = { '@', '#', '$', '%', '!', '?' };

				bool contains = password.Any(c => chars.Contains(c));

				bool isUpper = password.Any(char.IsUpper);

				bool OK= false;

				if (!(lenght >= 8) )
				{
                    Console.WriteLine("Parolaniz 8 Karakterden Buyuk Olmali");
				}
				if ( !contains )
				{
                    Console.WriteLine("Parolaniz en az bir (! ,?,@,.....) özel karakter içermelidir");
				}
				if (!isUpper )
				{
					Console.WriteLine("Parolanız en az bir buyuk harf içermelidir ");
				}

				if (isUpper && contains && lenght>=8)
				{
					OK = true;
                    Console.WriteLine("Parola Başarıyla Oluşturuldu");
				}

				if (!OK)
				{
                    Console.WriteLine("Yeni Parola Giriniz");
					string newPW = Console.ReadLine();
					Check(newPW);
				}

			}
		}
	}
}
