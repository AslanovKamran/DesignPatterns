using System;
using System.Collections.Generic;
namespace ChainOfResponsibility.Accounts
{
	internal class Account
	{
		public string FullName { get; set; } = string.Empty;
		public string CardNumber { get; set; } = string.Empty;
		
		public int Pin { get; set; } = default;
		public decimal Money { get; set; } = default;
	
		public Account() { }
		
		public Account(string fn, string cn, int p, decimal m)
		{
			this.FullName = fn;
			this.CardNumber = cn;
			this.Pin = p;
			this.Money = m;
		}
	}
}
