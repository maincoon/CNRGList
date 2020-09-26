using Nethereum.Signer;
using Nethereum.Web3.Accounts;
using System;
using System.Globalization;
using System.Linq;

namespace CNRGList {
	static class Program {

		static void Main(string[] args) {
			if (args.Length == 3) {
				Random rand = new Random();
				var min = decimal.Parse(args[1], NumberStyles.Any, CultureInfo.InvariantCulture);
				var max = decimal.Parse(args[2], NumberStyles.Any, CultureInfo.InvariantCulture);
				decimal total = 0;
				Console.WriteLine("Address, Amount, Private Key");
				for (int a = 0; a < int.Parse(args[0]); a++) {
					var key = EthECKey.GenerateKey();
					var account = new Account(key);
					decimal amount = (decimal)Math.Round((double)min + (rand.NextDouble() * (double)(max - min)), 4);
					total += amount;
					Console.WriteLine($"{account.Address}, {amount.ToString(CultureInfo.InvariantCulture)}, {account.PrivateKey}");
				}
				Console.WriteLine($"# Total: {total.ToString(CultureInfo.InvariantCulture)}");
			} else {
				Console.WriteLine("Usage: CNRGList <num> <min> <max>");
			}
		}
	}
}
