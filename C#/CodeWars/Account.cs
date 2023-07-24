namespace Codewars;

public sealed class Account
{
	public Account(string name, int age, int initialBalance = 0)
	{
		Name = name.NotNullOrWhiteSpace();
		Age = age.NotLessThan10();
		Balance = initialBalance.NotNegative();
	}

	public string Name { get; }
	public int Age { get; }
	public int Balance { get; }
}