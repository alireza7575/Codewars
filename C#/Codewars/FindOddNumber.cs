using System.Linq;

namespace CodeWars;

public sealed record FindOddNumber(params int[] Elements)
{
	public int Find() =>
		Elements.FirstOrDefault(element => Elements.Count(value => value == element) % 2 != 0);
}