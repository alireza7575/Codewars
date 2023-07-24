namespace Codewars;

public sealed record BankBillSystem
{
	public BankBillSystem(Account customerAccount) =>
		ContractStatus = customerAccount.Balance.NotLessThan500();

	public bool ContractStatus { get; }
}