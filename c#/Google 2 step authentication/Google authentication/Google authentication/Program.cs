using Google.Authenticator;
using System;
using System.Text.RegularExpressions;

namespace Google_authentication
{
	class Program
	{
		static void Main(string[] args)
		{

			TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
			var setupInfo = tfa.GenerateSetupCode("myapp", "rvanlieshout@inforit.nl", "secretkey", 300, 300);

			Console.WriteLine("== QR Code ==");
			Console.WriteLine(setupInfo.QrCodeSetupImageUrl);
			Console.WriteLine("");
			Console.WriteLine("== Manual Code ==");
			Console.WriteLine(setupInfo.ManualEntryKey);

			Console.WriteLine("");
			Console.WriteLine("== Enter pin ==");

			while (true)
			{
				var input = Console.ReadLine();
				input = Regex.Replace(input, @"\s+", "");
				Console.WriteLine(tfa.ValidateTwoFactorPIN("secretkey", input));
			}

		}
	}
}
