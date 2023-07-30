using System.Collections.Generic;

namespace CodeWars;

public sealed class LoopGetter
{
	public LoopGetter(Node node) => this.node = node;
	private Node node;

	public int GetLength()
	{
		while (!visitedNodes.Contains(node = node.Next!))
			visitedNodes.Add(node);
		return visitedNodes.Count - visitedNodes.IndexOf(node.Next!) + 1;
	}

	private readonly List<Node> visitedNodes = new();
}