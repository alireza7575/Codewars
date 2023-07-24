using System;
using NUnit.Framework;

namespace Codewars.Tests;

public sealed class BankBillSystemTests
{
	[Test]
	public void ContractShouldAccepted()
	{
		var account = new Account("Alireza", 20, 500);
		Assert.That(new BankBillSystem(account).ContractStatus, Is.True);
		Assert.That(account.Name, Is.EqualTo("Alireza"));
		Assert.That(account.Age, Is.EqualTo(20));
		Assert.That(account.Balance, Is.EqualTo(500));
	}

	[Test]
	public void ContractShouldNotAccepted() =>
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			var _ = new BankBillSystem(new Account("Alireza", 20));
		}); //ncrunch: no coverage

	[Test]
	public void ContractShouldNotAcceptedForLessThan10YearsOld() =>
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			var _ = new BankBillSystem(new Account("Alireza", 9, 600));
		}); //ncrunch: no coverage
}