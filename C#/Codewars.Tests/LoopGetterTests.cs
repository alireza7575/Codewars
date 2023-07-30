using NUnit.Framework;

namespace CodeWars.Tests;

public sealed class LoopGetterTests
{
	[TestCase(0, 2)]
	[TestCase(1, 3)]
	[TestCase(3, 30)]
	[TestCase(3904, 1087)]
	[TestCase(10000, 10000)]
	public void CreateChainAndConfirmLoopSize(int startPieces, int loopSize) =>
		Assert.That(new LoopGetter(LoopCreator(startPieces, loopSize)).GetLength(),
			Is.EqualTo(loopSize));

	private static Node LoopCreator(int startPieces, int loopSize)
	{
		var start = new Node();
		var node = start;
		for (var count = 1; count < startPieces; count++)
		{
			node.Next = new Node();
			node = node.Next;
		}
		var loopStart = node;
		for (var loopIndex = 1; loopIndex < loopSize; loopIndex++)
		{
			node.Next = new Node();
			node = node.Next;
		}
		node.Next = loopStart;
		return start;
	}
}