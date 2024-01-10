using NUnit.Framework;

namespace CodeWars.Tests;

public sealed class FindOddNumberTests
{
	[Test]
	public void ListWithOneElementShouldReturnFirstValue() =>
		Assert.That(new FindOddNumber(7).Find(), Is.EqualTo(7));

	[TestCase(new[] { 1, 1, 2 }, 2)]
	[TestCase(new[] { 2, 1, 2 }, 1)]
	[TestCase(new[] { 0, 1, 0, 1, 0 }, 0)]
	[TestCase(new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }, 4)]
	public void ShouldReturnElementRepeatedOdd(int[] elements, int expectedResult) =>
		Assert.That(new FindOddNumber(elements).Find(), Is.EqualTo(expectedResult));
}