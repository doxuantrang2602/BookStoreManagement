using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyBanSach.GUI.GUI_Login
{
	internal class PasswordHasher
	{
		public static string HashPassword(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				StringBuilder builder = new StringBuilder();

				for (int i = 0; i < hashBytes.Length; i++)
				{
					builder.Append(hashBytes[i].ToString("x2"));
				}

				return builder.ToString();
			}
		}

		public static bool VerifyPassword(string enteredPassword, string hashedPassword)
		{
			string hashedEnteredPassword = HashPassword(enteredPassword);
			return string.Equals(hashedEnteredPassword, hashedPassword);
		}
	}
}
